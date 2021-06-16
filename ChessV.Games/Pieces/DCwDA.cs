
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
	#region Snail
	[PieceType("Snail", "DemiChess with Different Armies")]
	public class Snail: PieceType
	{
		public Snail( string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null ):
			base( "Snail", name, notation, midgameValue, endgameValue, preferredImageName )
		{
			AddMoves( this );
		}

		public static new void AddMoves( PieceType type )
		{
			Wazir.AddMoves( type );
			type.Step(new Direction(2,0));
		}
	}
	#endregion
	#region Crab
	[PieceType("Crab", "DemiChess with Different Armies")]
	public class Crab : PieceType
	{
		public Crab(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Crab", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);
		}

		public static new void AddMoves(PieceType type)
		{
			type.Step(new Direction(2, 1));
			type.Step(new Direction(2, -1));
			type.Step(new Direction(-1, -2));
			type.Step(new Direction(-1, 2));
		}
	}
	#endregion
	#region Lobster
	[PieceType("Lobster", "DemiChess with Different Armies")]
	public class Lobster : PieceType
	{
		public Lobster(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Lobster", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);
		}

		public static new void AddMoves(PieceType type)
		{
			type.Step(new Direction(-1, -1));
			type.Step(new Direction(-1, 1));
			type.Step(new Direction(2,-2));
			type.Step(new Direction(2, 2));
		}
	}
	#endregion
	#region CrabSnail
	[PieceType("CrabSnail", "DemiChess with Different Armies")]
	public class CrabSnail : PieceType
	{
		public CrabSnail(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("CrabSnail", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);
		}

		public static new void AddMoves(PieceType type)
		{
			Crab.AddMoves(type);
			Snail.AddMoves(type);
		}
	}
	#endregion
	#region Twofer
	[PieceType("Twofer", "DemiChess with Different Armies")]
	public class Twofer : PieceType
	{
		public Twofer(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Twofer", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);
		}

		public static new void AddMoves(PieceType type)
		{
			type.Slide(new Direction(1,0),2);
			type.Slide(new Direction(0, 1), 2);
			type.Slide(new Direction(-1, 0), 2);
			type.Slide(new Direction(0, -1), 2);
		}
	}
    #endregion
    #region KnightElephant
    [PieceType("Knight Elephant", "DemiChess with Different Armies")]
	public class KnightElephant : PieceType
	{
		public KnightElephant(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Knight Elephant", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);
		}

		public static new void AddMoves(PieceType type)
		{
			Knight.AddMoves(type);
			Elephant.AddMoves(type);
		}
	}
    #endregion
    #region Forward Short Rook
    [PieceType("Forward Short Rook", "DemiChess with Different Armies")]
	public class ForwardShortRook : PieceType
	{
		public ForwardShortRook(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Forward Short Rook", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);
		}

		public static new void AddMoves(PieceType type)
		{
			type.Slide(new Direction(1, 0), 3);
			type.Step(new Direction(0, 1));
			type.Step(new Direction(0, -1));
			type.Step(new Direction(-1, 0));
		}
	}

	#endregion
	#region Triangle
	[PieceType("Triangle", "DemiChess with Different Armies")]
	public class Triangle : PieceType
	{
		public Triangle(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Triangle", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);
		}

		public static new void AddMoves(PieceType type)
		{
			type.Step(new Direction(2, 0));
			type.Step(new Direction(-1, -1));
			type.Step(new Direction(-1, 1));
		}
	}
	#endregion
	#region Stepping Crab
	[PieceType("Stepping Crab", "DemiChess with Different Armies")]
	public class SteppingCrab : PieceType
	{
		public SteppingCrab(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Stepping Crab", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);
		}

		public static new void AddMoves(PieceType type)
		{
			type.Step(new Direction(2, 1));
			type.Step(new Direction(2, -1));
			type.Step(new Direction(0, 1));
			type.Step(new Direction(0, -1));
			type.Step(new Direction(-1, 0));
		}
	}

	#endregion
	#region Standin Queen
	[PieceType("Standin Queen", "DemiChess with Different Armies")]
	public class StandinQueen : PieceType
	{
		public StandinQueen(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Standin Queen", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);
		}

		public static new void AddMoves(PieceType type)
		{
			type.Step(new Direction(2, 0));
			type.Step(new Direction(1, 0));
			type.Step(new Direction(-1, -1));
			type.Step(new Direction(-1, 1));
			type.Step(new Direction(2, 1));
			type.Step(new Direction(2, -1));
			type.Step(new Direction(0, 1));
			type.Step(new Direction(0, -1));
			type.Step(new Direction(-1, 0));
			MoveCapability move3 = new MoveCapability(new Direction(1, 0), 3, 3);
			type.AddMoveCapability(move3);		
		}
	}


	#endregion
	#region Lurching Alfil
	[PieceType("Lurching Alfil", "DemiChess with Different Armies")]
	public class LurchingAlfil : PieceType
	{
		public LurchingAlfil(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Lurching Alfil", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);
		}

		public static new void AddMoves(PieceType type)
		{
			LameAlfil.AddMoves(type);
			type.Step(new Direction(-1, 0));
		}
	}
	#endregion
	#region Lurching Dabbabah
	[PieceType("Lurching Dabbabah", "DemiChess with Different Armies")]
	public class LurchingDabbabah : PieceType
	{
		public LurchingDabbabah(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Lurching Dabbabah", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);
		}

		public static new void AddMoves(PieceType type)
		{
			LameDabbabah.AddMoves(type);
			type.Step(new Direction(-1, 1));
			type.Step(new Direction(-1, -1));
		}
	}
	#endregion
	#region Master Lurcher
	[PieceType("Master Lurcher", "DemiChess with Different Armies")]
	public class MasterLurcher : PieceType
	{
		public MasterLurcher(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Master Lurcher", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);
		}

		public static new void AddMoves(PieceType type)
		{
			LameDabbabah.AddMoves(type);
			LameAlfil.AddMoves(type);
			LameKnight.AddMoves(type);
		}
	}
	#endregion


}