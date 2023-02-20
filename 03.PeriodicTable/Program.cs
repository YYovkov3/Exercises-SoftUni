SortedSet<string> count = new();
int times = int.Parse(Console.ReadLine());
for (int i = 0;i < times; i++)
{
    string[] input = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries);
    count.UnionWith(input);
}

    Console.WriteLine(string.Join(" ", count));
