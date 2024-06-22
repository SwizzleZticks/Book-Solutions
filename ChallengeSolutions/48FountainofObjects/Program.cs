using _48FountainofObjects;

FountainOfObjectsGame game = GetGameSize();
game.Run();
 
FountainOfObjectsGame GetGameSize()
{
    bool isValid;
    int result;

    while (true)
    {
        Console.Clear();
        ConsoleHelper.WriteLine("Please choose a game size(1=small,2=medium,3=large): ", ConsoleColor.Green);
        isValid = int.TryParse(Console.ReadLine(), out result);

        if (result == 1 || result == 2 || result == 3) break;
    }

    FountainOfObjectsGame game = result switch
    {
        1 => CreateSmallGame(),
        2 => CreateMediumGame(),
        3 => CreateLargeGame()
    };

    switch (result)
    {
        case 1:
            Console.WriteLine("Small game started with 4x4 grid.");
            break;
        case 2:
            Console.WriteLine("Medium game started with 6x6 grid.");
            break;
        case 3:
            Console.WriteLine("Large game started with 8x8 grid.");
            break;
    }

    return game;
}

FountainOfObjectsGame CreateSmallGame()
{
    Map map = new Map(4, 4);
    Location start = new Location(0, 0);
    map.SetRoomTypeAtLocation(start, RoomType.Entrance);
    map.SetRoomTypeAtLocation(new Location(0, 2), RoomType.Fountain);
    map.SetRoomTypeAtLocation(new Location(2, 3), RoomType.Pit);
    
    Monster[] monsters = new Monster[] 
    {
        new Maelstrom(new Location(2, 0)),
        new Amarok(new Location(0, 3))
    };

    return new FountainOfObjectsGame(new Player(start), map, monsters);
}
FountainOfObjectsGame CreateMediumGame()
{
    Map map = new Map(6, 6);
    Location start = new Location(0, 0);
    map.SetRoomTypeAtLocation(start, RoomType.Entrance);
    map.SetRoomTypeAtLocation(new Location(0, 2), RoomType.Fountain);
    map.SetRoomTypeAtLocation(new Location(2, 3), RoomType.Pit);
    map.SetRoomTypeAtLocation(new Location(1, 1), RoomType.Pit);

    Monster[] monsters = new Monster[]
    {
        new Maelstrom(new Location(2, 0)),
        new Amarok(new Location(3, 3)),
        new Amarok(new Location(1, 3))
    };

    return new FountainOfObjectsGame(new Player(start), map, monsters);
}
FountainOfObjectsGame CreateLargeGame()
{
    Map map = new Map(8, 8);
    Location start = new Location(0, 0);

    map.SetRoomTypeAtLocation(start, RoomType.Entrance);
    map.SetRoomTypeAtLocation(new Location(0, 2), RoomType.Fountain);
    map.SetRoomTypeAtLocation(new Location(2, 3), RoomType.Pit);
    map.SetRoomTypeAtLocation(new Location(1, 1), RoomType.Pit);
    map.SetRoomTypeAtLocation(new Location(1, 2), RoomType.Pit);
    map.SetRoomTypeAtLocation(new Location(2, 2), RoomType.Pit);

    Monster[] monsters = new Monster[]
    {
        new Maelstrom(new Location(2, 0)),
        new Maelstrom(new Location(3,3)),
        new Amarok(new Location(3, 3)),
        new Amarok(new Location(1, 3)),
        new Amarok(new Location(3, 1)),
    };

    return new FountainOfObjectsGame(new Player(start), map, monsters);
}