
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

		public PieceType Chancellor;
		public PieceType Archbishop;
		public PieceType Rose;
		public PieceType FerzDabbabah;
		public PieceType ElephantGeneral;
		public PieceType CamelZebraKnight;
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
			Array = "rndwboaqkcjbwdnr/pppppppppppppppp/16/16/16/16/16/16/16/16/16/16/16/16/PPPPPPPPPPPPPPPP/RNDWBOAQKCJBWDNR";
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
			AddPieceType( Chancellor = new Chancellor( "Chancellor", "C", 1050, 1100, "Chancellor" ) );
			AddPieceType( Archbishop = new Archbishop( "Archbishop", "A", 850, 900, "Archbishop" ) );
			AddPieceType( Rose = new Rose("Rose", "O", 850, 850,"General"));
			AddPieceType(FerzDabbabah = new FerzDabbabah("Squire", "D", 250, 250,"Dabbabah"));
			AddPieceType(ElephantGeneral = new ElephantGeneral("Guardian", "W", 450, 450,"Jumping General"));
			AddPieceType(CamelZebraKnight = new CamelZebraKnight("Chevalier", "J", 800, 800,"Unicorn"));

		}
		#endregion

		#region AddRules
		public override void AddRules()
		{
			base.AddRules();
			AddRule(new ChessV.Games.Rules.DynamicIsSquareAttacked(Rose));
		}
		#endregion

		#region AddEvaluations
		public override void AddEvaluations()
		{
			base.AddEvaluations();

			//	Customize the development evaluation function
			Evaluations.DevelopmentEvaluation eval = (Evaluations.DevelopmentEvaluation) 
				FindEvaluation( typeof(Evaluations.DevelopmentEvaluation) );
			eval.HeavyPieceThreshold = 600;
		}
		#endregion
	}
}
