
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
using ChessV.Evaluations;

namespace ChessV.Games
{
	[Game("Demi-Chess with Different Armies", typeof(Geometry.Rectangular), 8, 8, 
		  InventedBy = "Ralph Betza",
		  Invented = "1996",
		  Tags = "Chess Variant,Different Armies")]
	[Appearance(ColorScheme="Orchid")]
	public class DemiChessWithDifferentArmies: Abstract.Generic8x8
	{
		// *** PIECE TYPES *** //
		//	Outdated Originals
		public PieceType Snail;
		public PieceType Crab;
		public PieceType Lobster;
		public PieceType CrabSnail;

		//Spurned Standins
		public PieceType ForwardShortRook;
		public PieceType SteppingCrab;
		public PieceType Triangle;
		public PieceType StandinQueen;

		//	Plain Pushovers
		public PieceType Twofer;
		public PieceType Wazir;
		public PieceType Ferz;
		public PieceType KnightElephant;

		// Lame Lurchers
		public PieceType LameKnight;
		public PieceType LurchingAlfil;
		public PieceType LurchingDabbabah;
		public PieceType MasterLurcher;

		//Clunky Catastrophes




		// *** GAME VARIABLES *** //

		[GameVariable] public ChoiceVariable WhiteArmy { get; set; }
		[GameVariable] public ChoiceVariable BlackArmy { get; set; }


		// *** CONSTRUCTION *** //

		public DemiChessWithDifferentArmies(): 
			base
				( /* symmetry = */ new MirrorSymmetry() )
		{
		}


		// *** INITIALIZATION *** //

		#region SetGameVariables
		public override void SetGameVariables()
		{
			base.SetGameVariables();
			Array = "#{BlackArray}/8/8/8/8/#{WhiteArray}";
			Castling.RemoveChoice( "Flexible" );
			WhiteArmy = new ChoiceVariable( new string[] { "Outdated Originals", "Spurned Standins", "Plain Pushovers", "Lame Lurchers" } );
			BlackArmy = new ChoiceVariable( new string[] { "Outdated Originals", "Spurned Standins", "Plain Pushovers", "Lame Lurchers" } );
			PawnDoubleMove = true;
			EnPassant = true;
		//	Castling.AddChoice( "CwDA", "Standard castling with the extra exception to prevent color-bound pieces from changing square colors" );
			Castling.Value = "Standard";
			BareKing = true;
		}
		#endregion

		#region SetOtherVariables
		public override void SetOtherVariables()
		{
			base.SetOtherVariables();
			//	Set BlackArmy array
			if( BlackArmy.Value == "Outdated Originals" )
				SetCustomProperty( "BlackArray", "sclxklcs/pppppppp" );
			else if (BlackArmy.Value == "Spurned Standins")
				SetCustomProperty("BlackArray", "rndokdnr/pppppppp");
			else if( BlackArmy.Value == "Plain Pushovers" )
				SetCustomProperty( "BlackArray", "twfakfwt/pppppppp" );
			else if (BlackArmy.Value == "Lame Lurchers")
				SetCustomProperty("BlackArray", "mbezkebm/pppppppp");
			//	Set WhiteArmy array
			if ( WhiteArmy.Value == "Outdated Originals" )
				SetCustomProperty( "WhiteArray", "PPPPPPPP/SCLXKLCS" );
			else if (WhiteArmy.Value == "Spurned Standins")
				SetCustomProperty("WhiteArray", "PPPPPPPP/RNDOKDNR");
			else if( WhiteArmy.Value == "Plain Pushovers" )
				SetCustomProperty( "WhiteArray", "PPPPPPPP/TWFAKFWT" );
			else if (WhiteArmy.Value == "Lame Lurchers")
				SetCustomProperty("WhiteArray", "PPPPPPPP/MBEZKEBM");
			//	Set pawn promotion types
			PromotionTypes = "";
			if( WhiteArmy.Value == "Outdated Originals")
				PromotionTypes += "XSLC";
			if (WhiteArmy.Value == "Spurned Standins")
				PromotionTypes += "ORND";
			if ( WhiteArmy.Value == "Plain Pushovers")
				PromotionTypes += "ATFW";
			if (WhiteArmy.Value == "Lame Lurchers")
				PromotionTypes += "ZMBE";
			if ( BlackArmy.Value == "Outdated Originals" && WhiteArmy.Value != "Outdated Originals")
				PromotionTypes += "xslc";
			if (BlackArmy.Value == "Spurned Standins" && WhiteArmy.Value != "Spurned Standins")
				PromotionTypes += "ornd";
			if ( BlackArmy.Value == "Plain Pushovers" && WhiteArmy.Value != "Plain Pushovers")
				PromotionTypes += "atfw";
			if (BlackArmy.Value == "Lame Lurchers" && WhiteArmy.Value != "Lame Lurchers")
				PromotionTypes += "zmbe";
		}

		#endregion

		#region AddPieceTypes
		public override void AddPieceTypes()
		{
			base.AddPieceTypes();			//	White army
			if( WhiteArmy.Value == "Outdated Originals" )
			{
				AddPieceType( CrabSnail = new CrabSnail( "CrabSnail", BlackArmy.Value == "Outdated Originals" ? "X" : "X/x'", 450, 450, "KnightWazir" ) );
				AddPieceType( Snail = new Snail( "Snail", BlackArmy.Value == "Outdated Originals" ? "S" : "S/s'", 250, 250, "WazirDabbabah" ) );
				AddPieceType( Lobster = new Lobster( "Lobster", BlackArmy.Value == "Outdated Originals" ? "L" : "L/l'", 150, 150, "Bird" ) );
				AddPieceType( Crab = new Crab( "Crab", BlackArmy.Value == "Outdated Originals" ? "C" : "C/c'", 150, 150, "Zebra") );
			}

			if (WhiteArmy.Value == "Spurned Standins")
			{
				AddPieceType(StandinQueen = new StandinQueen("Omni Standin", BlackArmy.Value == "Spurned Standins" ? "O" : "O/o'", 470, 470, "Amazon"));
				AddPieceType(ForwardShortRook = new ForwardShortRook("Standin Snail", BlackArmy.Value == "Spurned Standins" ? "R" : "R/r'", 250, 250, "Charging Rook"));
				AddPieceType(Triangle = new Triangle("Standin Lobster", BlackArmy.Value == "Spurned Standins" ? "D" : "D/d'", 120, 120, "Wizard"));
				AddPieceType(SteppingCrab = new SteppingCrab("Standin Crab", BlackArmy.Value == "Spurned Standins" ? "N" : "N/n'", 170, 170, "NarrowKnight"));
			}
			if ( WhiteArmy.Value == "Plain Pushovers" )
			{
				AddPieceType( KnightElephant = new KnightElephant( "AlfilKnight", BlackArmy.Value == "Plain Pushovers" ? "A" : "A/a'", 450, 450, "ElephantKnight" ) );
				AddPieceType( Twofer = new Twofer( "Twofer", BlackArmy.Value == "Plain Pushovers" ? "T" : "T/t'", 250, 250, "VerticalMover" ) );
				AddPieceType( Ferz = new Ferz( "Ferz", BlackArmy.Value == "Plain Pushovers" ? "F" : "F/f'", 150, 150, "Ferz" ));
				AddPieceType(Wazir = new Wazir("Wazir", BlackArmy.Value == "Plain Pushovers" ? "W" : "W/w'", 150, 150, "Wazir"));
            }
			if (WhiteArmy.Value == "Lame Lurchers")
			{
				AddPieceType(MasterLurcher = new MasterLurcher("Lurching Has-been", BlackArmy.Value == "Lame Lurchers" ? "Z" : "Z/z'", 470, 470, "Minister"));
				AddPieceType(LameKnight = new LameKnight("Lurching Knight", BlackArmy.Value == "Lame Lurchers" ? "M" : "M/m'", 260, 260, "KnightFerz"));
				AddPieceType(LurchingDabbabah = new LurchingDabbabah("Lurching Dabbabah", BlackArmy.Value == "Lame Lurchers" ? "E" : "E/e'", 140, 140, "Dabbabah"));
				AddPieceType(LurchingAlfil = new LurchingAlfil("Lurching Alfil", BlackArmy.Value == "Lame Lurchers" ? "B" : "B/b'", 140, 140, "Elephant"));
			}
			//	Black army
			if ( BlackArmy.Value == "Outdated Originals" && WhiteArmy.Value != "Outdated Originals")
			{
				AddPieceType( CrabSnail = new CrabSnail("CrabSnail", "X'/x", 450, 450, "KnightWazir" ) );
				AddPieceType( Snail = new Snail( "Snail", "S'/s", 250, 250, "WazirDabbabah" ) );
				AddPieceType( Lobster = new Lobster( "Lobster", "L'/l", 150, 150, "Bird" ) );
				AddPieceType( Crab = new Crab( "Crab", "C'/c", 150, 150, "Zebra" ) );
			}
			if (BlackArmy.Value == "Spurned Standins" && WhiteArmy.Value != "Spurned Standins")
			{
				AddPieceType(StandinQueen = new StandinQueen("Omni Standin", "O'/o", 470, 470, "Amazon"));
				AddPieceType(ForwardShortRook = new ForwardShortRook("Standin Snail", "R'/r", 250, 250, "Charging Rook"));
				AddPieceType(Triangle = new Triangle("Standin Lobster", "D'/d", 120, 120, "Wizard"));
				AddPieceType(SteppingCrab = new SteppingCrab("Standin Crab", "N'/n", 170, 170, "NarrowKnight"));
			}
			if ( BlackArmy.Value == "Plain Pushovers" && WhiteArmy.Value != "Plain Pushovers")
			{
				AddPieceType(KnightElephant = new KnightElephant( "AlfilKnight", "A'/a", 450, 450, "ElephantKnight" ) );
				AddPieceType( Twofer = new Twofer( "Twofer", "T'/t", 250, 250, "VerticalMover" ) );
				AddPieceType( Ferz= new Ferz( "Ferz", "F'/f", 150, 150, "Ferz" ) );
				AddPieceType( Wazir = new Wazir( "Wazir", "W'/w", 150, 150, "Wazir" ) );
			}
			if (BlackArmy.Value == "Lame Lurchers" && WhiteArmy.Value != "Lame Lurchers")
			{
				AddPieceType(MasterLurcher = new MasterLurcher("Lurching Has-been", "Z'/z", 470, 470, "Minister"));
				AddPieceType(LameKnight = new LameKnight("Lurching Knight", "M'/m", 260, 260, "KnightFerz")) ;
				AddPieceType(LurchingDabbabah = new LurchingDabbabah("Lurching Dabbabah", "E'/e", 140, 140, "Dabbabah"));
				AddPieceType(LurchingAlfil = new LurchingAlfil("Lurching Alfil", "B'/b", 140, 140, "Elephant"));
			}
		}
		#endregion

		#region AddRules
		public override void AddRules()
		{
			base.AddRules();

			#region Pawn Promotion

			// *** PAWN PROMOTION *** //
			List<PieceType> availablePromotionTypes = new List<PieceType>();
			if( WhiteArmy.Value == "Outdated Originals" || BlackArmy.Value == "Outdated Originals")
			{
				availablePromotionTypes.Add( CrabSnail );
				availablePromotionTypes.Add( Snail );
				availablePromotionTypes.Add( Lobster );
				availablePromotionTypes.Add( Crab );
			}

			if (WhiteArmy.Value == "Spurned Standins" || BlackArmy.Value == "Spurned Standins")
			{
				availablePromotionTypes.Add(StandinQueen);
				availablePromotionTypes.Add(ForwardShortRook);
				availablePromotionTypes.Add(SteppingCrab);
				availablePromotionTypes.Add(Triangle);
			}
			if ( WhiteArmy.Value == "Plain Pushovers" || BlackArmy.Value == "Plain Pushovers")
			{
				availablePromotionTypes.Add( KnightElephant );
				availablePromotionTypes.Add( Twofer );
				availablePromotionTypes.Add( Ferz );
				availablePromotionTypes.Add( Wazir );
			}
			if (WhiteArmy.Value == "Lame Lurchers" || BlackArmy.Value == "Lame Lurchers")
			{
				availablePromotionTypes.Add(MasterLurcher);
				availablePromotionTypes.Add(LameKnight);
				availablePromotionTypes.Add(LurchingAlfil);
				availablePromotionTypes.Add(LurchingDabbabah);
			}
			
			AddBasicPromotionRule( Pawn, availablePromotionTypes, loc => loc.Rank == 7 );
			#endregion

			#region Castling 

			// *** CASTLING *** //
	/*		if( Castling.Value == "CwDA" )
			{
				AddCastlingRule();
				CastlingMove( 0, "e1", "g1", "h1", "f1", 'K' );
				CastlingMove( 1, "e8", "g8", "h8", "f8", 'k' );
				if( WhiteArmy.Value == "Colorbound Clobberers" )
					CastlingMove( 0, "e1", "b1", "a1", "c1", 'Q' );
				else
					CastlingMove( 0, "e1", "c1", "a1", "d1", 'Q' );
				if( BlackArmy.Value == "Colorbound Clobberers" )
					CastlingMove( 1, "e8", "b8", "a8", "c8", 'q' );
				else
					CastlingMove( 1, "e8", "c8", "a8", "d8", 'q' );
			}
			#endregion */
		}
		#endregion

		#region AddEvaluations
		public override void AddEvaluations()
		{
			base.AddEvaluations();
		}
		#endregion

		#region TryCreateAdaptor
		public override EngineGameAdaptor TryCreateAdaptor( EngineConfiguration config )
		{
			//	determine XBoard name based on armies selected
			string xboardname = "";
			if( WhiteArmy.Value == "Outdated Originals" )
				xboardname = "originals~";
			else if (WhiteArmy.Value == "Spurned Standins")
				xboardname = "standins~";
			else if( WhiteArmy.Value == "Plain Pushovers" )
				xboardname = "pushovers~";
			else if (WhiteArmy.Value == "Lame Lurchers")
				xboardname = "lurchers~";
			if ( BlackArmy.Value == "Outdated Originals")
				xboardname += "originals~(cwda)";
			else if (BlackArmy.Value == "Spurned Standins")
				xboardname += "standins~(cwda)";
			else if( BlackArmy.Value == "Plain Pushovers" )
				xboardname += "pushovers~(cwda)";
			else if (BlackArmy.Value == "Lame Lurchers")
				xboardname += "lurchers~(cwda)";

			if ( config.SupportedVariants.Contains( xboardname ) )
				return new EngineGameAdaptor( xboardname );

			return null;
		}
		#endregion
	}
    #endregion
    /*	[Game("CwDA: FIDEs vs. Clobberers", typeof( Geometry.Rectangular ), 8, 8,
			  XBoardName = "fide~clobberers~(cwda)", Hidden = true,
			  Definitions = "WhiteArmy=Fabulous FIDEs;BlackArmy=Colorbound Clobberers")]
		[Game("CwDA: Clobberers vs. FIDEs", typeof( Geometry.Rectangular ), 8, 8,
			  XBoardName = "clobberers~fide~(cwda)", Hidden = true,
			  Definitions = "WhiteArmy=Colorbound Clobberers;BlackArmy=Fabulous FIDEs")]
		[Game("CwDA: FIDEs vs. Rookies", typeof( Geometry.Rectangular ), 8, 8,
			  XBoardName = "fide~rookies~(cwda)", Hidden = true,
			  Definitions = "WhiteArmy=Fabulous FIDEs;BlackArmy=Remarkable Rookies")]
		[Game("CwDA: Rookies vs. FIDEs", typeof( Geometry.Rectangular ), 8, 8,
			  XBoardName = "rookies~fide~(cwda)", Hidden = true,
			  Definitions = "WhiteArmy=Remarkable Rookies;BlackArmy=Fabulous FIDEs")]
		[Game("CwDA: FIDEs vs. Nutters", typeof( Geometry.Rectangular ), 8, 8,
			  XBoardName = "fide~nutters~(cwda)", Hidden = true,
			  Definitions = "WhiteArmy=Fabulous FIDEs;BlackArmy=Nutty Knights")]
		[Game("CwDA: Nutters vs. FIDEs", typeof( Geometry.Rectangular ), 8, 8,
			  XBoardName = "nutters~fide~(cwda)", Hidden = true,
			  Definitions = "WhiteArmy=Nutty Knights;BlackArmy=Fabulous FIDEs")]
		[Game("CwDA: Nutters vs. Clobberers", typeof( Geometry.Rectangular ), 8, 8,
			  XBoardName = "nutters~clobberers~(cwda)", Hidden = true,
			  Definitions = "WhiteArmy=Nutty Knights;BlackArmy=Colorbound Clobberers")]
		[Game("CwDA: Clobberers vs. Nutters", typeof( Geometry.Rectangular ), 8, 8,
			  XBoardName = "clobberers~nutters~(cwda)", Hidden = true,
			  Definitions = "WhiteArmy=Colorbound Clobberers;BlackArmy=Nutty Knights")]
		[Game("CwDA: Nutters vs. Rookies", typeof( Geometry.Rectangular ), 8, 8,
			  XBoardName = "nutters~rookies~(cwda)", Hidden = true,
			  Definitions = "WhiteArmy=Nutty Knights;BlackArmy=Remarkable Rookies")]
		[Game("CwDA: Rookies vs. Nutters", typeof( Geometry.Rectangular ), 8, 8,
			  XBoardName = "rookies~nutters~(cwda)", Hidden = true,
			  Definitions = "WhiteArmy=Remarkable Rookies;BlackArmy=Nutty Knights")]
		[Game("CwDA: Rookies vs. Clobberers", typeof( Geometry.Rectangular ), 8, 8,
			  XBoardName = "rookies~clobberers~(cwda)", Hidden = true,
			  Definitions = "WhiteArmy=Remarkable Rookies;BlackArmy=Colorbound Clobberers")]
		[Game("CwDA: Clobberers vs. Rookies", typeof( Geometry.Rectangular ), 8, 8,
			  XBoardName = "clobberers~rookies~(cwda)", Hidden = true,
			  Definitions = "WhiteArmy=Colorbound Clobberers;BlackArmy=Remarkable Rookies")]
		[Game("CwDA: Rookies vs. Rookies", typeof( Geometry.Rectangular ), 8, 8,
			  XBoardName = "rookies~rookies~(cwda)", Hidden = true,
			  Definitions = "WhiteArmy=Remarkable Rookies;BlackArmy=Remarkable Rookies")]
		[Game("CwDA: Clobberers vs. Clobberers", typeof( Geometry.Rectangular ), 8, 8,
			  XBoardName = "clobberers~clobberers~(cwda)", Hidden = true,
			  Definitions = "WhiteArmy=Colorbound Clobberers;BlackArmy=Colorbound Clobberers")]
		[Game("CwDA: Nutters vs. Nutters", typeof( Geometry.Rectangular ), 8, 8,
			  XBoardName = "nutters~nutters~(cwda)", Hidden = true,
			  Definitions = "WhiteArmy=Nutty Knights;BlackArmy=Nutty Knights")]
		[Appearance(ColorScheme = "Orchid")]
		public class CwDAXBoard: DemiChessWithDifferentArmies
		{
		} */
}
