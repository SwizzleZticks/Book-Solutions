using _48FountainofObjects;

FountainOfObjectsGame game = CreateSmallGame();
game.Run();

FountainOfObjectsGame CreateSmallGame()
{
    Map map = new Map(4, 4);
    Location start = new Location(0, 0);
    map.SetRoomTypeAtLocation(start, RoomType.Entrance);
    map.SetRoomTypeAtLocation(new Location(0, 2), RoomType.Fountain);

    Monster[] monsters = new Monster[] { };

    return new FountainOfObjectsGame(new Player(start), map, monsters);
}