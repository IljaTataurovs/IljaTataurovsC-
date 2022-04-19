//1 uzdevums
Console.WriteLine("Please enter your name! ");
string name = Console.ReadLine();
Console.WriteLine($"Hi {name}");
//2 uzdevums
Console.WriteLine("Please enter your age! ");
string userAgeString = Console.ReadLine();
int age = int.Parse(userAgeString);
age += 1;
Console.WriteLine($"You will be {age} y.o next year");
//3 uzdevums
Console.WriteLine("Please enter first number! ");
int firtsNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter second number! ");
int secondNumber = int.Parse(Console.ReadLine());
int maxNumber = Math.Max(firtsNumber, secondNumber);
Console.WriteLine($"The biggest number is: {maxNumber} ");
//4 uzdevums
int minNumber = Math.Min(firtsNumber, secondNumber);
Console.WriteLine($"The smallest number is: {minNumber} ");
//5 uzdevums
int leftOver = firtsNumber % secondNumber;
Console.WriteLine($"The division leftover is equal to: {leftOver} ");
//6 uzdevums

if (firtsNumber % 2 == 0)
{
    Console.WriteLine($"The {firtsNumber} number is even ");
}
else
{
    Console.WriteLine($"The {firtsNumber} number is odd ");
}

if (secondNumber % 2 == 0)
{
    Console.WriteLine($"The {secondNumber} number is even ");
}
else
{
    Console.WriteLine($"The {secondNumber} number is odd ");
}
//7 uzdevums
Console.WriteLine("Please enter the width of a rectangle! ");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the lenght of a rectangle! ");
double length = double.Parse(Console.ReadLine());
double area = width * length;
Console.WriteLine($"The area of a rectangle is equal to:{area} ");
double areaRounded = Math.Round(area);
Console.WriteLine("area rounded " + areaRounded);
//8 uzdevums
Console.WriteLine("Please enter the side length of a triangle! ");
int side = int.Parse(Console.ReadLine());
int areaTriangle = side * side / 2;
Console.WriteLine($"The area of a triangle is equal to:{areaTriangle} ");
//9 uzdevums
age -= 1;
Console.WriteLine($"Hi {name}, your age is {age}.");

