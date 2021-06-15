
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

namespace ChessV.Games
{
	public static class DynamicFunctionHelper
	{
		public static int mod(int a, int m)
		{
			int x = a % m;
			if (x < 0) { return x + m; }
			return x;
		}
		public static Direction? cyclicgenerator(Direction[] directions, int a, int b)
		{
			int n = directions.Length;
			if (a < 0 || a >= 2 * n || b >= n || b < 1) { return null; }
			int sign = 1;
			if (a >= n) { sign = -1; a -= n; }
			return directions[mod(a + b * sign, n)];
		}
		public static Direction? alternatinggenerator(Direction[] directions, int a, int b)
		{
			int n = directions.Length;
			if (a < 0 || a >= 2 * n || b < 1) { return null; }
			if (mod(b, 2) == 1) { return directions[mod(a, n)]; }
			if (a < n) { return directions[mod(a + 1, n)]; }
			return directions[mod(a - 1, n)];
		}
		public static Direction? leapintotwoslidesgenerator(Direction[] directions1, Direction[] directions2, int a, int b)
        {
			int n = directions1.Length;
			if (a < 0 || a >= 2 * n || b < 1) { return null; }
			if (b==1) { return directions1[mod(a, n)]; }
			if(a<n) { return directions2[a]; }
			return directions2[mod(a + 1, n)];

		}
    }
	#region Rose
	[PieceType("Rose", "Dynamic"),DynamicMoveAttribute]
	public class Rose: PieceType
	{
		public Rose( string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null ):
			base( "Rose", name, notation, midgameValue, endgameValue, preferredImageName )
		{
			Direction[] Directions = { new Direction(1, 2), new Direction(2, 1), new Direction(2, -1), new Direction(1, -2), new Direction(-1, -2), new Direction(-2, -1), new Direction(-2, 1), new Direction(-1, 2) };
            DNM = new DynamicMoveCapability(RoseDirections, Directions, 16, 8, 1);
			AddMoves( this );
		}

		public static new void AddMoves( PieceType type )
		{
			Knight.AddMoves(type);
			type.CustomMoveGenerator = CustomMoveGenerationHandler;
		}
		public static Direction? RoseDirections(int round, int step)
        {
			Direction[] Knight = { new Direction(1, 2), new Direction(2, 1), new Direction(2, -1), new Direction(1, -2), new Direction(-1, -2), new Direction(-2, -1), new Direction(-2, 1), new Direction(-1, 2) };
			return DynamicFunctionHelper.cyclicgenerator(Knight, round, step);
		}
		public static bool CustomMoveGenerationHandler(PieceType pieceType, Piece piece, MoveList moveList, bool capturesOnly)
        {
			pieceType.DNM.GenerateMoves(piece, moveList, capturesOnly);
			return false;
        }
	}
	#endregion

	#region Crooked Bishop
	[PieceType("Crooked Bishop", "Dynamic"), DynamicMoveAttribute]
	public class CrookedBishop : PieceType
	{
		public CrookedBishop(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Crooked Bishop", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			Direction[] Directions = { new Direction(1, 1), new Direction(1, -1), new Direction(-1, -1), new Direction(-1, 1) };
			DNM = new DynamicMoveCapability(zBDirections, Directions, 8);
			AddMoves(this);
		}

		public static new void AddMoves(PieceType type)
		{
			Ferz.AddMoves(type);
			type.CustomMoveGenerator = CustomMoveGenerationHandler;
		}
		public static Direction? zBDirections(int round, int step)
		{
			Direction[] Ferz = { new Direction(1, 1), new Direction(1, -1), new Direction(-1, -1), new Direction(-1, 1) };
			return DynamicFunctionHelper.alternatinggenerator(Ferz, round, step);
		}
		public static bool CustomMoveGenerationHandler(PieceType pieceType, Piece piece, MoveList moveList, bool capturesOnly)
		{
			pieceType.DNM.GenerateMoves(piece, moveList, capturesOnly);
			return false;
		}
	}
	#endregion

	#region Gryphon
	[PieceType("Gryphon", "Dynamic"), DynamicMoveAttribute]
	public class Gryphon : PieceType
	{
		public Gryphon(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Gryphon", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			Direction[] Directions = { new Direction(1, 1), new Direction(1, -1), new Direction(-1, -1), new Direction(-1, 1), new Direction(1,0), new Direction(0,1), new Direction(-1,0), new Direction(0,-1) };
			DNM = new DynamicMoveCapability(GryphonDirections, Directions, 8);
			AddMoves(this);
		}

		public static new void AddMoves(PieceType type)
		{
			Ferz.AddMoves(type);
			type.CustomMoveGenerator = CustomMoveGenerationHandler;
		}
		public static Direction? GryphonDirections(int round, int step)
		{
			Direction[] Ferz = { new Direction(1, 1), new Direction(1, -1), new Direction(-1, -1), new Direction(-1, 1) };
			Direction[] Wazir = { new Direction(0, 1), new Direction(1, 0), new Direction(0, -1), new Direction(-1, 0)};
			return DynamicFunctionHelper.leapintotwoslidesgenerator(Ferz, Wazir, round, step);
		}
		public static bool CustomMoveGenerationHandler(PieceType pieceType, Piece piece, MoveList moveList, bool capturesOnly)
		{
			pieceType.DNM.GenerateMoves(piece, moveList, capturesOnly);
			return false;
		}
	}
	#endregion
}
