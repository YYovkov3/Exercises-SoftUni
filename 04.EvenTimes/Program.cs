Dictionary<int,int> keyValuePairs = new();
int n = int.Parse(Console.ReadLine());
for(int i = 0;i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    if(!keyValuePairs.ContainsKey(currentNumber))
    {
        keyValuePairs.Add(currentNumber, 0);
    }
    keyValuePairs[currentNumber]++;
}
Console.WriteLine(keyValuePairs.Single(x=>x.Value%2==0).Key);

  

