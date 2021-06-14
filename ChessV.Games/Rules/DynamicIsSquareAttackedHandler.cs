
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

namespace ChessV.Games.Rules
{
	public class DynamicIsSquareAttacked: Rule
	{
		// *** PROPERTIES *** //

		public PieceType PieceType { get; private set; }


		// *** CONSTRUCTION *** //

		public DynamicIsSquareAttacked( PieceType pieceType )
		{
			PieceType = pieceType;
		}
		//TODO: Write this rule to fix Checkmate

		// *** EVENT HANDLERS *** //


		public override bool IsSquareAttacked( int square, int side )
		{
			BitBoard attackers = Board.GetPieceTypeBitboard( side, PieceType.TypeNumber );
			while( attackers )
			{
				int pieceSquare = attackers.ExtractLSB();
				Piece piece = Board.GetSquare(pieceSquare);
			    if( PieceType.DNM.AttacksSquare(piece,square)) { return true; }
			}
			return false;
		}

	}
}
