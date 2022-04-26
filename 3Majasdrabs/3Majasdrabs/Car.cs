//2 uzdevums
public class Car
{
    public string NumberPlate { get; set; }
    public string Brand { get; set; }
    public int Speed { get; set; }

    

    public void startTheCar()
    {
        Console.WriteLine("Engine makes Brrrr Brrrr");
        Speed = 10;
    }
    public void makeSound()
    {
        Console.WriteLine("Beep Beep");
    }
    public void showSpeed()
    {
        Console.WriteLine($"Car speed now is : {Speed}");
    }
    public void increaseSpeed()
    {
        Speed += 10;
    }

    public void lowerSpeed()
    {
        Speed -= 5;
    }
}