public class Horse{
public string Name { get; set; }
public int Height { get; set; }
public int Hunger { get; set; } = 100;
public bool IsAlive { get; set; } = true;
public void MakeNoice(){
    Console.WriteLine("hi my name is " + Name);
}
public void PerformCycleEvents(){
    Hunger = Hunger - 10;
    if (Hunger <= 0) {
        IsAlive = false;
        System.Console.WriteLine(Name + " has died");
    }

    System.Console.WriteLine(Name + " has " + Hunger + " left");
}
void Feed(){
    Hunger = Hunger + 10;
}

}
