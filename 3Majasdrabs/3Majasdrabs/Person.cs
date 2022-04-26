//4 uzdevums
public class Person {    
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }
    public string Hobbie { get; set; }

    public void sayHello()
    {
        Console.WriteLine($"Hello my name is {Name} {Surname} and I am {Age} y.o. Also my hooby is {Hobbie}and I am {Sex}");
    }

}

