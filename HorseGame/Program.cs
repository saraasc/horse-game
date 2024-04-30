
using System.Globalization;
Console.BackgroundColor = ConsoleColor.Blue;

Stable stable = new Stable();

int Money = 200;


while (true)
{
  string? input = Console.ReadLine();
  switch (input)
  {
    case "buy horse":
      BuyHorse();
      break;

    case "eat":
      Eat();
      break;
    default:
      break;

    case "hi":
      SayHi();
      break;

    case "end day":
      EndDay();
      break;

    case "buy carrot":
      BuyCarrot();
      break;
  }















}

void BuyCarrot()
{
  int PriceOfCarrot = 5;

  System.Console.WriteLine("Hello welcome to the shop, would you like to buy a carrot? It costs " + PriceOfCarrot);
  string? input = Console.ReadLine();
  if (input == "yes")
  {
    if (Money < PriceOfCarrot)
    {
      System.Console.WriteLine("You only have " + Money);
      return;
    }

    Money = Money - PriceOfCarrot;
    stable.NumberOfCarrots += 1;
  }
}

void EndDay()
{
  List<Horse> horsesToRemove = new();
  foreach (Horse horse in stable.Horses)
  {
    horse.PerformCycleEvents();
    if (horse.IsAlive == false)
    {
      horsesToRemove.Add(horse);
    }
  }
  stable.Horses.RemoveAll(x => horsesToRemove.Contains(x));
}

void Eat()
{
  Console.WriteLine("eat");
}

void BuyHorse()
{
  int PriceOfHorse = 100;

  System.Console.WriteLine("Hello welcome to the shop, would you like to buy this horse? It costs " + PriceOfHorse);
  string? input = Console.ReadLine();
  if (input == "yes")
  {
    if (Money < PriceOfHorse)
    {
      System.Console.WriteLine("You only have " + Money);
      return;
    }

    Money = Money - PriceOfHorse;

    System.Console.WriteLine("Name your horse");
    string? name = Console.ReadLine();


    Horse horse = new Horse()
    {
      Name = name
    };
    horse.MakeNoice();
    stable.Horses.Add(horse);

    System.Console.WriteLine("Congrats on your new horse called " + horse.Name + ", you have " + Money + " left.");

  }
}


void SayHi()
{
  foreach (Horse horse in stable.Horses)
  {
    horse.MakeNoice();
  }
}








// //dette er en variable
// string test ="lort";
// int tal = 11;
// Console.WriteLine (test+tal);




// Horse lance = new Horse(){
//     Name = "lance",
//     Height = 138
//     };

//     lance.MakeNoice();

//     //min lektie : staldklasse navn indholde hest



//     Stable lort = new Stable(){
//         Name = "lort"
//     }; 

// prop  command kc command ku. shift + option + 8 = {}, shift + option + f = format


// lektie= køb gulerod for 5 penge - give hest 10 hunger