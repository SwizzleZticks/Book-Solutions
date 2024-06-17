
namespace _48FountainofObjects
{
    public class Map
    {
        private readonly RoomType[,] _rooms;
        public int Row { get; set; }
        public int Column { get; set; }
        public Map(int row, int column)
        {
            Row = row;
            Column = column;
            _rooms = new RoomType[row, column];
        }

    }
}
