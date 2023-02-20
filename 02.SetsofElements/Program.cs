HashSet<int> firstSet = new();
HashSet<int> secondSet = new();
int[] numbers = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
for (int i = 0;i < numbers[0]; i++)
{
    firstSet.Add(int.Parse(Console.ReadLine()));
}
for(int i = 0;i < numbers[1]; i++)
{
    secondSet.Add(int.Parse(Console.ReadLine()));
}
firstSet.IntersectWith(secondSet);
Console.WriteLine(string.Join(" ", firstSet));