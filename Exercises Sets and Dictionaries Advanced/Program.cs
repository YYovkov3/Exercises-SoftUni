HashSet<string> userNames = new();
int times = int.Parse(Console.ReadLine());
for(int i = 0;i < times; i++)
{
    userNames.Add(Console.ReadLine());
}
foreach(string currentUser in userNames)
{ Console.WriteLine(currentUser); }

