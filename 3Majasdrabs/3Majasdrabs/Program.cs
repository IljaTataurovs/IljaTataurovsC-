//1 uzdevums
Phone phone = new Phone();
phone.makeACall();
phone.sendSMS();
//2 uzdevums
Car car = new Car();
car.startTheCar();
car.showSpeed();
car.increaseSpeed();
car.showSpeed();
car.lowerSpeed();
car.showSpeed();
car.makeSound();
//3 uzdevums
Product product = new();
{
    Console.WriteLine("Please Enter Height of a product");
    double height = double.Parse(Console.ReadLine());
    Console.WriteLine("Please Enter Width of a product");
    double width = double.Parse(Console.ReadLine());
    Console.WriteLine("Please Enter Weight of a product");
    double weight = double.Parse(Console.ReadLine());

};
//Console.WriteLine("Please Enter Height of a product");
//product.Height = double.Parse(Console.ReadLine());
//Console.WriteLine("Please Enter Width of a product");
//product.Width = double.Parse(Console.ReadLine());
//Console.WriteLine("Please Enter Weight of a product");
//product.Weight = double.Parse(Console.ReadLine());
product.print();
//4 uzdevums
Person person = new Person();
Console.WriteLine("Please Enter your dob");
DateTime born = DateTime.Parse(Console.ReadLine());
DateTime now = DateTime.Now;
person.Age = (int)((int)(now - born).TotalDays / 365.242199);
Console.WriteLine("Please Enter your Name");
person.Name = Console.ReadLine();
Console.WriteLine("Please Enter your Surname");
person.Surname = Console.ReadLine();
Console.WriteLine("Please Enter your Hobbie");
person.Hobbie = Console.ReadLine();
Console.WriteLine("Please Enter your Sex");
person.Sex = Console.ReadLine();
person.sayHello();