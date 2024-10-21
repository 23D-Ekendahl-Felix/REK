List<string> rekname = ["Felix", "Matija", "Kevin"];
List<string> inne = [];
string name;
Console.WriteLine("Skriv ditt namn:");
name = Console.ReadLine();

rekname.Add(name);


System.Console.WriteLine("\nLista med namn");


for (int i = 0; i < rekname.Count; i++)
{
    System.Console.WriteLine($"[{i}] {rekname[i]}");
}

Console.WriteLine("\nChoose a recruit:");
{
  int rNum = 0;
  bool couldConvert = false;
  while (couldConvert == false || rNum < 0 || rNum >= rekname.Count)
  {
    string nText = Console.ReadLine();
    couldConvert = int.TryParse(nText, out rNum);

    if (couldConvert == false)
    {
      Console.WriteLine("That's not a number!");
    }
    else if (rNum < 0 || rNum <= rekname.Count)
    {
      Console.WriteLine("That's not a valid index!");
    }
  }

  string recruit = rekname[rNum];
  inne.Add(recruit);
  rekname.RemoveAt(rNum);
}

Console.WriteLine($"You recruited a total of {inne.Count} soldiers.");

Console.WriteLine("Press ENTER to quit");


Console.ReadLine();