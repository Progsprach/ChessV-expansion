
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

//using ChessV.Games.Rules.Gross;

namespace ChessV.Games
{
	[Game("Golden Age Chess on a Really Big Board", typeof(Geometry.Rectangular), 16, 16,
		  Invented = "1996",
		  InventedBy = "Ralph Betza",
		  Tags = "Chess Variant")]
	[Appearance(ColorScheme = "Orchid",PieceSet ="Standard")]
	public class GACoarbB: Abstract.Generic16x16
	{
		// *** PIECE TYPES *** //

		public PieceType Archbishop;
		public PieceType Rose;
		public PieceType CamelZebraKnight;
		public PieceType CrookedBishop;
		public PieceType Nightrider;
		public PieceType WazirDabbabahrider;
		public PieceType Duck;
		public PieceType Gryphon;

		// *** CONSTRUCTION *** //

		public GACoarbB():
			base
				( /* symmetry = */ new MirrorSymmetry() )
		{
		}


		// *** INITIALIZATION *** //

		#region SetGameVariables
		public override void SetGameVariables()
		{
			base.SetGameVariables();
			Array = "wosjiahgkhaijsow/pppppppppppppppp/16/16/16/16/16/16/16/16/16/16/16/16/PPPPPPPPPPPPPPPP/WOSJIAHGKHAIJSOW";
			Castling.Value = "6-6";
			PromotionRule.Value = "Standard";
			PawnMultipleMove.Value = "@2(2,3,4,5,6)";
			EnPassant = true;
			DeduplicateMoves = true;
		}
		#endregion

		#region AddPieceTypes
		public override void AddPieceTypes()
		{
			base.AddPieceTypes();
			AddChessPieceTypes();
			AddPieceType( Archbishop = new Archbishop( "Archbishop", "A", 800, 850, "Archbishop" ) );
			AddPieceType( Rose = new Rose("Rose", "O", 600, 600,"General"));
			AddPieceType(CamelZebraKnight = new CamelZebraKnight("Chevalier", "J", 800, 800,"Unicorn"));
			AddPieceType(CrookedBishop = new CrookedBishop("Scout", "S", 400, 400,"BishopDebbabah"));
			AddPieceType(Nightrider = new Nightrider("Nightrider", "I", 600, 600,"Nightrider"));
			AddPieceType(WazirDabbabahrider = new WazirDabbabahrider("Tower","W", 400, 400,"VerticalMover"));
			AddPieceType(Duck = new Duck("Duck", "H", 600, 600,"Bird"));
			AddPieceType(Gryphon = new Gryphon("Gryphon", "G", 800, 850,"Lion"));



		}
		#endregion

		#region AddRules
		public override void AddRules()
		{
			base.AddRules();
			AddRule(new ChessV.Games.Rules.DynamicIsSquareAttacked(Rose));
			AddRule(new ChessV.Games.Rules.DynamicIsSquareAttacked(CrookedBishop));
			AddRule(new ChessV.Games.Rules.DynamicIsSquareAttacked(Gryphon));
		}
		#endregion

		#region AddEvaluations
		public override void AddEvaluations()
		{
			base.AddEvaluations();

			//	Customize the development evaluation function
			Evaluations.DevelopmentEvaluation eval = (Evaluations.DevelopmentEvaluation) 
				FindEvaluation( typeof(Evaluations.DevelopmentEvaluation) );
			eval.HeavyPieceThreshold = 700;
		}
		#endregion
	}
}
