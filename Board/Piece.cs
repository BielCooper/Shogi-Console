using board;
using board.Enums;

namespace board
{
    internal class Piece
    {
        public Position Position { get; set; }
        public PieceColor Color { get; protected set; }
        public int MovementQty { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Position position, PieceColor color, Board board)
        {
            Position = position;
            Color = color;
            Board = board;
            MovementQty = 0;
        }
    }
}
