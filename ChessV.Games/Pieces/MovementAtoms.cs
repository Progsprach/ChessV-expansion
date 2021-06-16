
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

using System.Collections.Generic;
namespace ChessV.Games
{
	#region Wazir
	[PieceType("Wazir", "Movement Atoms")]
	public class Wazir: PieceType
	{
		public Wazir( string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null ):
			base( "Wazir", name, notation, midgameValue, endgameValue, preferredImageName )
		{
			AddMoves( this );
		}

		public static new void AddMoves( PieceType type )
		{
			type.Step( new Direction( 0, 1 ) );
			type.Step( new Direction( 0, -1 ) );
			type.Step( new Direction( 1, 0 ) );
			type.Step( new Direction( -1, 0 ) );
		}
	}
	#endregion

	#region Ferz
	[PieceType("Ferz", "Movement Atoms")]
	public class Ferz: PieceType
	{
		public Ferz( string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null ):
			base( "Ferz", name, notation, midgameValue, endgameValue, preferredImageName )
		{
			AddMoves( this );
		}

		public static new void AddMoves( PieceType type )
		{
			type.Step( new Direction( 1, 1 ) );
			type.Step( new Direction( 1, -1 ) );
			type.Step( new Direction( -1, 1 ) );
			type.Step( new Direction( -1, -1 ) );
		}
	}
	#endregion

	#region Elephant
	[PieceType("Elephant", "Movement Atoms")]
	public class Elephant: PieceType
	{
		public Elephant( string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null ):
			base( "Elephant", name, notation, midgameValue, endgameValue, preferredImageName )
		{
			AddMoves( this );
		}

		public static new void AddMoves( PieceType type )
		{
			type.Step( new Direction( 2, 2 ) );
			type.Step( new Direction( 2, -2 ) );
			type.Step( new Direction( -2, 2 ) );
			type.Step( new Direction( -2, -2 ) );
		}
	}
	#endregion

	#region Dabbabah
	[PieceType("Dabbabah", "Movement Atoms")]
	public class Dabbabah: PieceType
	{
		public Dabbabah( string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null ):
			base( "Dabbabah", name, notation, midgameValue, endgameValue, preferredImageName )
		{
			AddMoves( this );
		}

		public static new void AddMoves( PieceType type )
		{
			type.Step( new Direction( 0, 2 ) );
			type.Step( new Direction( 0, -2 ) );
			type.Step( new Direction( 2, 0 ) );
			type.Step( new Direction( -2, 0 ) );
		}
	}
	#endregion

	#region Tribbabah
	[PieceType("Tribbabah", "Movement Atoms")]
	public class Tribbabah: PieceType
	{
		public Tribbabah( string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null ):
			base( "Tribbabah", name, notation, midgameValue, endgameValue, preferredImageName )
		{
			AddMoves( this );
		}

		public static new void AddMoves( PieceType type )
		{
			type.Step( new Direction( 0, 3 ) );
			type.Step( new Direction( 0, -3 ) );
			type.Step( new Direction( 3, 0 ) );
			type.Step( new Direction( -3, 0 ) );
		}
	}
	#endregion

	#region Camel
	[PieceType("Camel", "Movement Atoms")]
	public class Camel: PieceType
	{
		public Camel( string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null ):
			base( "Camel", name, notation, midgameValue, endgameValue, preferredImageName )
		{
			AddMoves( this );
		}

		public static new void AddMoves( PieceType type )
		{
			type.Step( new Direction( 1, 3 ) );
			type.Step( new Direction( 3, 1 ) );
			type.Step( new Direction( 3, -1 ) );
			type.Step( new Direction( 1, -3 ) );
			type.Step( new Direction( -1, -3 ) );
			type.Step( new Direction( -3, -1 ) );
			type.Step( new Direction( -3, 1 ) );
			type.Step( new Direction( -1, 3 ) );
		}
	}
	#endregion

	#region Zebra
	[PieceType("Zebra", "Movement Atoms")]
	public class Zebra: PieceType
	{
		public Zebra( string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null ):
			base( "Zebra", name, notation, midgameValue, endgameValue, preferredImageName )
		{
			AddMoves( this );
		}

		public static new void AddMoves( PieceType type )
		{
			type.Step( new Direction( 2, 3 ) );
			type.Step( new Direction( 3, 2 ) );
			type.Step( new Direction( 3, -2 ) );
			type.Step( new Direction( 2, -3 ) );
			type.Step( new Direction( -2, -3 ) );
			type.Step( new Direction( -3, -2 ) );
			type.Step( new Direction( -3, 2 ) );
			type.Step( new Direction( -2, 3 ) );
		}
	}
	#endregion

	#region Trifil
	[PieceType("Trifil", "Movement Atoms")]
	public class Trifil : PieceType
	{
		public Trifil(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Trifil", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);
		}

		public static new void AddMoves(PieceType type)
		{
			type.Step(new Direction(3, 3));
			type.Step(new Direction(3, -3));
			type.Step(new Direction(-3, 3));
			type.Step(new Direction(-3, -3));
		}
	}
	#endregion

	#region Nightrider
	[PieceType("Nightrider", "Movement Atoms")]
	public class Nightrider: PieceType
	{
		public Nightrider( string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null ):
			base( "Nightrider", name, notation, midgameValue, endgameValue, preferredImageName )
		{
			AddMoves( this );

			//	Customize piece-square-tables for the Knightrider
			PSTMidgameInSmallCenter = 12;
			PSTMidgameInLargeCenter = 9;
		}

		public static new void AddMoves( PieceType type )
		{
			type.Slide( new Direction( 1, 2 ) );
			type.Slide( new Direction( 2, 1 ) );
			type.Slide( new Direction( 2, -1 ) );
			type.Slide( new Direction( 1, -2 ) );
			type.Slide( new Direction( -1, -2 ) );
			type.Slide( new Direction( -2, -1 ) );
			type.Slide( new Direction( -2, 1 ) );
			type.Slide( new Direction( -1, 2 ) );
		}
	}
	#endregion

	#region Dabbabahrider
	[PieceType("Dabbabahrider", "Movement Atoms")]
	public class Dabbabahrider : PieceType
	{
		public Dabbabahrider(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Dabbabahrider", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);

		}

		public static new void AddMoves(PieceType type)
		{
			type.Slide(new Direction(2,0));
			type.Slide(new Direction(0,2));
			type.Slide(new Direction(-2,0));
			type.Slide(new Direction(0,-2));
		}
	}
	#endregion

	#region Lame Dabbabah
	[PieceType("Lame Dabbabah", "Movement Atoms")]
	public class LameDabbabah : PieceType
	{
		public LameDabbabah(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Lame Dabbabah", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);

		}

		public static new void AddMoves(PieceType type)
		{

			type.AddMoveCapability(MoveCapability.Step(new Direction(2, 0)).AddPath(new List<Direction>() { new Direction(1, 0), new Direction(1, 0) }));
			type.AddMoveCapability(MoveCapability.Step(new Direction(0, 2)).AddPath(new List<Direction>() { new Direction(0, 1), new Direction(0, 1) }));
			type.AddMoveCapability(MoveCapability.Step(new Direction(-2, 0)).AddPath(new List<Direction>() { new Direction(-1, 0), new Direction(-1, 0) }));
			type.AddMoveCapability(MoveCapability.Step(new Direction(0, -2)).AddPath(new List<Direction>() { new Direction(0, -1), new Direction(0, -1) }));
		}
	}
	#endregion

	#region Lame Alfil
	[PieceType("Lame Alfil", "Movement Atoms")]
	public class LameAlfil : PieceType
	{
		public LameAlfil(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Lame Alfil", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);

		}

		public static new void AddMoves(PieceType type)
		{
			type.AddMoveCapability(MoveCapability.Step(new Direction(2, 2)).AddPath(new List<Direction>() { new Direction(1, 1), new Direction(1, 1) }));
			type.AddMoveCapability(MoveCapability.Step(new Direction(-2, 2)).AddPath(new List<Direction>() { new Direction(-1, 1), new Direction(-1, 1) }));
			type.AddMoveCapability(MoveCapability.Step(new Direction(-2, -2)).AddPath(new List<Direction>() { new Direction(-1, -1), new Direction(-1, -1) }));
			type.AddMoveCapability(MoveCapability.Step(new Direction(2, -2)).AddPath(new List<Direction>() { new Direction(1, -1), new Direction(1, -1) }));
		}
	}
	#endregion

	#region Lame Knight
	[PieceType("Lame Knight", "Movement Atoms")]
	public class LameKnight : PieceType
	{
		public LameKnight(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("Lame Knight", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);

		}

		public static new void AddMoves(PieceType type)
		{
			MoveCapability move = MoveCapability.Step(new Direction(2, 1));
			MovePathInfo movePath = new MovePathInfo();
			movePath.AddPath(new List<Direction>() { new Direction(1, 1), new Direction(1, 0)});
			movePath.AddPath(new List<Direction>() { new Direction(1, 0), new Direction(1, 1) });
			move.PathInfo = movePath;
			type.AddMoveCapability(move);

			move = MoveCapability.Step(new Direction(2, -1));
			movePath = new MovePathInfo();
			movePath.AddPath(new List<Direction>() { new Direction(1, -1), new Direction(1, 0) });
			movePath.AddPath(new List<Direction>() { new Direction(1, 0), new Direction(1, -1) });
			move.PathInfo = movePath;
			type.AddMoveCapability(move);

			move = MoveCapability.Step(new Direction(1, -2));
			movePath = new MovePathInfo();
			movePath.AddPath(new List<Direction>() { new Direction(1, -1), new Direction(0, -1) });
			movePath.AddPath(new List<Direction>() { new Direction(0, -1), new Direction(1, -1) });
			move.PathInfo = movePath;
			type.AddMoveCapability(move);

			move = MoveCapability.Step(new Direction(-1, -2));
			movePath = new MovePathInfo();
			movePath.AddPath(new List<Direction>() { new Direction(-1, -1), new Direction(0, -1) });
			movePath.AddPath(new List<Direction>() { new Direction(0, -1), new Direction(-1, -1) });
			move.PathInfo = movePath;
			type.AddMoveCapability(move);

			move = MoveCapability.Step(new Direction(-2, -1));
			movePath = new MovePathInfo();
			movePath.AddPath(new List<Direction>() { new Direction(-1, -1), new Direction(-1, 0) });
			movePath.AddPath(new List<Direction>() { new Direction(-1, 0), new Direction(-1, -1) });
			move.PathInfo = movePath;
			type.AddMoveCapability(move);

			move = MoveCapability.Step(new Direction(-2, 1));
			movePath = new MovePathInfo();
			movePath.AddPath(new List<Direction>() { new Direction(-1, 1), new Direction(-1, 0) });
			movePath.AddPath(new List<Direction>() { new Direction(-1, 0), new Direction(-1, 1) });
			move.PathInfo = movePath;
			type.AddMoveCapability(move);

			move = MoveCapability.Step(new Direction(-1, 2));
			movePath = new MovePathInfo();
			movePath.AddPath(new List<Direction>() { new Direction(-1, 1), new Direction(0, 1) });
			movePath.AddPath(new List<Direction>() { new Direction(0, 1), new Direction(-1, 1) });
			move.PathInfo = movePath;
			type.AddMoveCapability(move);

			move = MoveCapability.Step(new Direction(1, 2));
			movePath = new MovePathInfo();
			movePath.AddPath(new List<Direction>() { new Direction(1, 1), new Direction(0, 1) });
			movePath.AddPath(new List<Direction>() { new Direction(0, 1), new Direction(1, 1) });
			move.PathInfo = movePath;
			type.AddMoveCapability(move);
		}
	}
    #endregion
}
