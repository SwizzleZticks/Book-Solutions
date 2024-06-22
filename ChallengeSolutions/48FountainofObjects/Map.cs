
namespace _48FountainofObjects
{
    public class Map
    {
        private readonly RoomType[,] _rooms;
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Map(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            _rooms = new RoomType[rows, columns];
        }
        public bool HasNeighborWithType(Location location, RoomType roomType)
        {
            if (GetRoomTypeAtLocation(new Location(location.Row - 1, location.Column - 1)) == roomType) return true;
            if (GetRoomTypeAtLocation(new Location(location.Row - 1, location.Column)) == roomType) return true;
            if (GetRoomTypeAtLocation(new Location(location.Row - 1, location.Column + 1)) == roomType) return true;
            if (GetRoomTypeAtLocation(new Location(location.Row, location.Column - 1)) == roomType) return true;
            if (GetRoomTypeAtLocation(new Location(location.Row, location.Column)) == roomType) return true;
            if (GetRoomTypeAtLocation(new Location(location.Row, location.Column + 1)) == roomType) return true;    
            if (GetRoomTypeAtLocation(new Location(location.Row + 1, location.Column - 1)) == roomType) return true;
            if (GetRoomTypeAtLocation(new Location(location.Row + 1, location.Column)) == roomType) return true;
            if (GetRoomTypeAtLocation(new Location(location.Row + 1, location.Column + 1)) == roomType) return true; 
            return false;
        }

        public RoomType GetRoomTypeAtLocation(Location location) => IsOnMap(location) ? _rooms[location.Row, location.Column] : RoomType.OffTheMap;
        public void SetRoomTypeAtLocation(Location location, RoomType type) => _rooms[location.Row, location.Column] = type;

        public bool IsOnMap(Location location) =>
            location.Row >= 0 &&
            location.Row < _rooms.GetLength(0) &&
            location.Column >= 0 &&
            location.Column < _rooms.GetLength(1);
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
        Pit,
        OffTheMap,
    }
}
