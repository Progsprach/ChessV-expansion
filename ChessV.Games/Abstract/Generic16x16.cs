
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

namespace ChessV.Games.Abstract
{
	//**********************************************************************
	//
	//                           Generic12x12
	//
	//    The Generic game classes make it easier to specify games by 
	//    providing functionality common to chess variants.  This class 
	//    extends the Generic__x12 class by adding support for a 
	//    variety of different castling rules commonly used on 12x12 board

	[Game("Generic 16x16", typeof(Geometry.Rectangular), 16, 16,
		  Template=true)]
	public class Generic16x16: Generic__x16
	{
		// *** GAME VARIABLES *** //

		[GameVariable] public ChoiceVariable Castling { get; set; }


		// *** CONSTRUCTION *** //

		public Generic16x16
			( Symmetry symmetry ):
				base
					( /* num files = */ 16,
					  /* symmetry = */ symmetry )
		{
		}


		// *** INITIALIZATION *** //

		#region SetGameVariables
		public override void SetGameVariables()
		{
			base.SetGameVariables();
			Castling = new ChoiceVariable();
			Castling.AddChoice( "3-3", "King starting on f or g file slides three squares either direction, " +
				"subject to the usual restrictions, to castle with the piece in the corner" );
			Castling.AddChoice( "3-4", "King starting on f or g file slides three squares when castling short " +
				"or four when castling long, subject to the usual restrictions, to castle with the piece in the corner" );
			Castling.AddChoice( "4-4", "King starting on f or g file slides four squares either direction, " +
				"subject to the usual restrictions, to castle with the piece in the corner" );
			Castling.AddChoice( "4-5", "King starting on f or g file slides four squares when castling short " +
				"or five when castling long, subject to the usual restrictions, to castle with the piece in the corner" );
			Castling.AddChoice( "6-6", "King starting on f or g file slides six squares either direction, " +
				"subject to the usual restrictions, to castle with the piece in the corner" );
			Castling.AddChoice( "Close-Rook 2-2", "King starting on f or g file slides two squares either direction, " +
				"subject to the usual restrictions, to castle with the piece on the b or k file" );
			Castling.AddChoice( "Close-Rook 2-3", "King starting on f or g file slides two squares when castling short " +
				"or three when castling long, subject to the usual restrictions, to castle with the piece on the b or k file" );
			Castling.AddChoice( "Close-Rook 3-3", "King starting on f or g file slides three squares either direction, " +
				"subject to the usual restrictions, to castle with the piece on the b or k file" );
			Castling.AddChoice( "Close-Rook 3-4", "King starting on f or g file slides three squares when castling short " +
				"or four when castling long, subject to the usual restrictions, to castle with the piece on the b or k file" );
			Castling.AddChoice( "None", "No castling" );
			Castling.Value = "None";
		}
		#endregion

		#region AddRules
		public override void AddRules()
		{
			base.AddRules();

			// *** CASTLING *** //

			#region Castling
			//	Only handle here if this is a castling type we defined
			if( Castling.Choices.IndexOf( Castling.Value ) < Castling.Choices.IndexOf( "None" ) )
			{
				//	find the king's start square (must be f1, f2, g1, or g2)
				GenericPiece WhiteKing = new GenericPiece( 0, CastlingType );
				GenericPiece BlackKing = new GenericPiece( 1, CastlingType );
				string whiteKingSquare = null;
				string blackKingSquare = null;
					if( StartingPieces["h1"] == WhiteKing )
						whiteKingSquare = "h1";
					else if( StartingPieces["i1"] == WhiteKing )
						whiteKingSquare = "i1";
					if( StartingPieces["h16"] == BlackKing )
						blackKingSquare = "h16";
					else if( StartingPieces["i16"] == BlackKing )
						blackKingSquare = "i16";
				if( whiteKingSquare == null || blackKingSquare == null )
					throw new Exception( "Can't enable castling rule because King does not start on a supported square" );

			
				//	ALL OTHER CASTLING TYPES
					//	handle implementation of all other castling options by algorithm
					string rankPlayer0 = "1";
					string rankPlayer1 = "16";
					char file0Player0 = Castling.Value.IndexOf( "Close-Rook" ) >= 0 ? 'B' : 'A';
					char file1Player0 = Castling.Value.IndexOf( "Close-Rook" ) >= 0 ? 'O' : 'P';
					char file0Player1 = Castling.Value.IndexOf( "Close-Rook" ) >= 0 ? 'b' : 'a';
					char file1Player1 = Castling.Value.IndexOf( "Close-Rook" ) >= 0 ? 'o' : 'p';
					int shortDistance = Convert.ToInt32( Castling.Value.Substring( Castling.Value.Length - 3, 1 ) );
					int longDistance = Convert.ToInt32( Castling.Value.Substring( Castling.Value.Length - 1, 1 ) );
					AddCastlingRule();
					if( whiteKingSquare[0] == 'i' )
					{
						CastlingMove( 0, "i" + rankPlayer0, (char) ('i' + shortDistance) + rankPlayer0, file1Player1.ToString() + rankPlayer0, (char) ('i' + shortDistance - 1) + rankPlayer0, file1Player0 );
						CastlingMove( 0, "i" + rankPlayer0, (char) ('i' - longDistance) + rankPlayer0, file0Player1.ToString() + rankPlayer0, (char) ('i' - longDistance + 1) + rankPlayer0, file0Player0 );
					}
					else
					{
						CastlingMove( 0, "h" + rankPlayer0, (char) ('h' + longDistance) + rankPlayer0, file1Player1.ToString() + rankPlayer0, (char) ('h' + longDistance - 1) + rankPlayer0, file1Player0 );
						CastlingMove( 0, "h" + rankPlayer0, (char) ('h' - shortDistance) + rankPlayer0, file0Player1.ToString() + rankPlayer0, (char) ('h' - shortDistance + 1) + rankPlayer0, file0Player0 );
					}
					if( blackKingSquare[0] == 'i' )
					{
						CastlingMove( 1, "i" + rankPlayer1, (char) ('i' + shortDistance) + rankPlayer1, file1Player1.ToString() + rankPlayer1, (char) ('i' + shortDistance - 1) + rankPlayer1, file1Player1 );
						CastlingMove( 1, "i" + rankPlayer1, (char) ('i' - longDistance) + rankPlayer1, file0Player1.ToString() + rankPlayer1, (char) ('i' - longDistance + 1) + rankPlayer1, file0Player1 );
					}
					else
					{
						CastlingMove( 1, "h" + rankPlayer1, (char) ('h' + longDistance) + rankPlayer1, file1Player1.ToString() + rankPlayer1, (char) ('h' + longDistance - 1) + rankPlayer1, file1Player1 );
						CastlingMove( 1, "h" + rankPlayer1, (char) ('h' - shortDistance) + rankPlayer1, file0Player1.ToString() + rankPlayer1, (char) ('h' - shortDistance + 1) + rankPlayer1, file0Player1 );
					}
			}
			#endregion
		}
		#endregion


		// *** OPERATIONS *** //

		public void AddChessPieceTypes()
		{
			AddPieceType( Queen = new Queen( "Queen", "Q", 1250, 1350 ) );
			AddPieceType( Rook = new Rook( "Rook", "R", 700, 750 ) );
			AddPieceType( Bishop = new Bishop( "Bishop", "B", 500, 500 ) );
			AddPieceType( Knight = new Knight( "Knight", "N", 225, 225 ) );
		}
	}
}
