namespace board
{
    class Board
    {
        public int Line { get; set; }
        public int Column { get; set; }
        private Piece[,] pieces;

        public Board(int line, int column)
        {
            Line = line;
            Column = column;
            pieces = new Piece[line, column];
        }
    }
}
