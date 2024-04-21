//Print something other than Hello World(with a twist)

string forEachString = "This is my new string";

char[] chars = new char[forEachString.Length];

foreach(char c in forEachString)
{
    chars = forEachString.ToCharArray();
    Console.WriteLine(c);
}

