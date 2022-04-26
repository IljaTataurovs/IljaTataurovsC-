//3 uzdevums
public class Product {

    public double Height { get; private set; }
    public double Width { get; private set; }
    public double Weight { get; private set; }

    public void print()
    {
        Console.WriteLine($"Height is:{Height} Width is: {Width} Weight is: {Weight}");
    }

}