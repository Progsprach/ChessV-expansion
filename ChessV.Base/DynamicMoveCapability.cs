
/***************************************************************************

                                 ChessV

                  COPYRIGHT (C) 2012-2019 BY GREG STRONG

This file is part of ChessV.  ChessV is free software; you can redistribute
it and/or modify it under the terms of the GNU General Public License as 
published by the Free Software Foundation, either version 3 of the License, 
or (at your option) any later version.

ChessV is distributed in the hope that it will be useful, but WITHOUT ANY 
WARRANTY; without even the implied warranty of MERCHANTABILITY or 
FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for 
more details; the file 'COPYING' contains the License text, but if for
some reason you need a copy, please visit <http://www.gnu.org/licenses/>.

****************************************************************************/
using System;
using System.Collections.Generic;

namespace ChessV
{
	public class DynamicMoveCapability : ExObject
	{
		// *** PROPERTIES *** //

		#region Properties
		//	The direction sequences of movement
		public Func<int,int, Direction?> Directions { get; set; }

		//	The minimum number of steps that can be made
		public int MinSteps { get; set; }

		//	The maximum number of steps that can be made
		public int MaxSteps { get; set; }

		// Number of rounds for generation
		public int Rounds { get; set; }

		//	Can an enemy piece be captured with this move?
		public bool CanCapture { get; set; }

		//	Can the move only be made if an enemy piece is captured?
		public bool MustCapture { get; set; }
		public Direction[] DirectionsUsed { get; set; }
		//	Lookuptable for direction numbers
		//	(all directions used in a given game are given unique 
		//	numbers for efficiency reasons.)
		public Dictionary<Direction, int> DirectionLookup { get; set; }

		//	If not null, the move can only be performed if the moving 
		//	piece is on a square with a true value in the array 
		//	ConditionalBySquare[playerNumber,squareNumber]
		//public bool[,] ConditionalBySquare { get; set; }
		public BitBoard[] ConditionalBySquare { get; set; }

		//	The ConditionalBySquare is automatically initialized when 
		//	a Condition is set to a ConditionDelegate, which is a 
		//	lambda function determining if a move is allowed for the 
		//	given location (translated appropriately for each player 
		//	based on the Symmetry of the Game.)
		public ConditionalLocationDelegate Condition { get; set; }
		#endregion
		// *** CONSTRUCTION *** //

		#region Construction
		public DynamicMoveCapability()
		{
			MinSteps = 1;
			MaxSteps = 9999;
			CanCapture = true;
			MustCapture = false;
			Directions = null;
			Rounds = 0;
		}

		public DynamicMoveCapability(Func<int,int, Direction?> dir, Direction[] dirsused, int rnd = 0, int maxSteps = 9999, int minSteps = 1, bool canCapture = true, bool mustCapture = false)
		{
			Directions = dir;
			MaxSteps = maxSteps;
			MinSteps = minSteps;
			CanCapture = canCapture;
			MustCapture = mustCapture;
			DirectionsUsed = dirsused;
			Rounds = rnd;
			DirectionLookup = new Dictionary<Direction, int>();
		}
		#endregion


		// *** INITIALIZATION *** //

		#region Initialization
		public void Initialize(Game game)
		{
			if (Condition != null && ConditionalBySquare == null)
			{
				ConditionalBySquare = new BitBoard[game.NumPlayers];
				for (int player = 0; player < game.NumPlayers; player++)
				{
					ConditionalBySquare[player].SetAll();
					for (int sq = 0; sq < game.Board.NumSquares; sq++)
					{
						Location location = game.Board.SquareToLocation(sq);
						location = game.Symmetry.Translate(player, location);
						if (!Condition(location))
							ConditionalBySquare[player].ClearBit(sq);
					}
				}
			}
			foreach(Direction d in DirectionsUsed)
            {
				this.DirectionLookup.Add(d, game.GetDirectionNumber(d));
            }
		}
		#endregion
		public void GenerateMoves(Piece piece, MoveList list, bool capturesonly = false)
		{
			for (int i = 0; i < Rounds; i++)
			{
				int step = 1;
				Direction? dirx = Directions(i, step);
				if (dirx == null) { continue; }
				Direction dir = (Direction)dirx;
				int dirn = DirectionLookup[dir];
				int nextSquare = piece.Board.NextSquare(piece.Player, dirn, piece.Square);
				while (nextSquare >= 0 && step <= this.MaxSteps)
				{
					Piece pieceOnSquare = piece.Board[nextSquare];
					if (pieceOnSquare != null)
					{
						if (step >= this.MinSteps && this.CanCapture && pieceOnSquare.Player != piece.Player)
							list.AddCapture(piece.Square, nextSquare);
						break;
					}
					else
					{
						if (step >= this.MinSteps && !this.MustCapture && !capturesonly)
							list.AddMove(piece.Square, nextSquare);
						step++;
					}

					dirx = Directions(i, step);
					if (dirx == null) { break; }
					dir = (Direction)dirx;
					dirn = DirectionLookup[dir];
					nextSquare = piece.Board.NextSquare(piece.Player, dirn, nextSquare);
				}
			}
		}
		public bool AttacksSquare(Piece piece, int square)
        {
			if (!CanCapture) { return false; }
			for (int i = 0; i < Rounds; i++)
			{
				int step = 1;
				Direction? dirx = Directions(i, step);
				if (dirx == null) { continue; }
				Direction dir = (Direction)dirx;
				int dirn = DirectionLookup[dir];
				int nextSquare = piece.Board.NextSquare(piece.Player, dirn, piece.Square);
				while (nextSquare >= 0 && step <= this.MaxSteps)
				{
					Piece pieceOnSquare = piece.Board[nextSquare];
					if (nextSquare == square) { return true; }
					if (pieceOnSquare != null)
					{
						break;
					}
					step++;

					dirx = Directions(i, step);
					if (dirx == null) { break; }
					dir = (Direction)dirx;
					dirn = DirectionLookup[dir];
					nextSquare = piece.Board.NextSquare(piece.Player, dirn, nextSquare);
				}
			}
			return false;
		}
	}
}