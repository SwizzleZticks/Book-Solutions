
Arrow userArrow = ArrowBuild();
float arrowCost = userArrow.GetCost();

Console.WriteLine(arrowCost);


Arrow ArrowBuild()
{
    Console.Write("What arrowhead would you like?(steel,wood,obsidian) ");
    string headType = Console.ReadLine();

    Console.Write("What fletching would you like?(plastic,turkey feathers,goose feathers) ");
    string fletchingType = Console.ReadLine();

    Console.Write("How long are your arrows(.05 per cm) ");
    float arrowLength = float.Parse(Console.ReadLine());

    ArrowHead arrowHead = headType switch
    {
        "steel"    => ArrowHead.steel,
        "wood"     => ArrowHead.wood,
        "obsidian" => ArrowHead.obsidian
    };

    FletchingTypes fletching = fletchingType switch
    {
        "plastic" => FletchingTypes.plastic,
        "turkey feathers" => FletchingTypes.turkeyfeathers,
        "goose feathers" => FletchingTypes.goosefeathers
    };
    return new Arrow(arrowHead, fletching, arrowLength);
}

class Arrow
{
    public ArrowHead arrowHead;
    public FletchingTypes fletching;
    public float arrowLength;
   
    public Arrow(ArrowHead arrowHead, FletchingTypes fletching, float arrowLength)
    {
        this.arrowHead = arrowHead;
        this.fletching = fletching;
        this.arrowLength = arrowLength;
    }
    
     public float GetCost()
    {
        float arrowHeadCost = 0;
        float fletchingCost = 0;
        float arrowLengthCost = 0;
        float totalCost = 0;

        arrowHeadCost = arrowHead switch
        {
            ArrowHead.steel => 10,
            ArrowHead.wood => 3,
            ArrowHead.obsidian => 5
        };

        fletchingCost = fletching switch
        {
            FletchingTypes.plastic => 10,
            FletchingTypes.turkeyfeathers => 5,
            FletchingTypes.goosefeathers => 3,
        };

        arrowLengthCost = arrowLength * (float).05;

        totalCost = arrowHeadCost += fletchingCost += arrowLengthCost;

        return totalCost;
    }
}

enum FletchingTypes
{
    plastic,
    turkeyfeathers,
    goosefeathers
}

enum ArrowHead
{
    steel,
    wood,
    obsidian
}