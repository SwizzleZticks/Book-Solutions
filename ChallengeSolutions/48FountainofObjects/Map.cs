
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

        public RoomType GetRoomTypeAtLocation(Location location)
        {
            return _rooms[location.Row, location.Column];
        }

        public bool IsOnMap(Location location)
        {
            if((location.Row >= 0 && location.Row < _rooms.Length) && (location.Column >= 0 && location.Column <= _rooms.Length ))
            {
                return true;
            }
            return false;
        }
        public RoomType SetRoomType(Location location, RoomType roomType)
        {
            return _rooms[location.Row,location.Column];
        }

    }
    public enum RoomType
    {
        Normal,
        Entrance,
        Fountain,
        OffTheMap
    }
}
