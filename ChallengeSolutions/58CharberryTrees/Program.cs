namespace _58CharberryTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharberryTree theTree = new CharberryTree();
            RipeningHandler handler = new RipeningHandler(theTree);
            Harvester harvester = new Harvester(theTree);

            while (true)
            {
                theTree.MaybeGrow();
            }
        }
    }
}
