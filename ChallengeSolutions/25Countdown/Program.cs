

using System.Threading.Channels;

CountDownRecursion(10);

int CountDownRecursion (int Count)
{
    if (Count == 1)
    {
        Console.WriteLine("Base Case Reached.");
        return 1;
    }

    Console.WriteLine(Count);
    return Count * CountDownRecursion(Count - 1);
    
}
