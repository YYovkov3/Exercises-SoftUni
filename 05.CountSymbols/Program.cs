SortedDictionary<char,int> currentChars = new();
string currentString = Console.ReadLine();
for(int i = 0;i < currentString.Length; i++)
{
    if (!currentChars.ContainsKey(currentString[i]))
    {
        currentChars.Add(currentString[i], 0);
    }
    currentChars[currentString[i]]++;
}
foreach(var ch in currentChars)
{
    Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
}