﻿
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
	[Game("Chess on a Really Big Board", typeof(Geometry.Rectangular), 16, 16,
		  Invented = "2100",
		  InventedBy = "Ralph Betza",
		  Tags = "Chess Variant")]
	[Appearance(ColorScheme = "Surrealistic Summer", PieceSet="Abstract", Player2Color="255,0,0")]
	public class CoarbB: Abstract.Generic16x16
	{
		// *** PIECE TYPES *** //

		public PieceType Chancellor;
		public PieceType Archbishop;
		// *** CONSTRUCTION *** //

		public CoarbB():
			base
				( /* symmetry = */ new MirrorSymmetry() )
		{
		}


		// *** INITIALIZATION *** //

		#region SetGameVariables
		public override void SetGameVariables()
		{
			base.SetGameVariables();
			Array = "r7k6r/pppppppppppppppp/16/16/16/16/16/16/16/16/16/16/16/16/PPPPPPPPPPPPPPPP/R7K6R";
			Castling.Value = "6-6";
			PromotionRule.Value = "Standard";
			PawnMultipleMove.Value = "@2(2,3,4,5,6)";
			EnPassant = true;
		}
		#endregion

		#region AddPieceTypes
		public override void AddPieceTypes()
		{
			base.AddPieceTypes();
			AddChessPieceTypes();
			AddPieceType( Chancellor = new Chancellor( "Marshall", "M", 1000, 1050 ) );
			AddPieceType( Archbishop = new Archbishop( "Archbishop", "A", 850, 900 ) );
		}
		#endregion

		#region AddRules
		public override void AddRules()
		{
			base.AddRules();
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
