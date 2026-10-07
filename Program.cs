Console.WriteLine("whats your name? ");
string name =Console.ReadLine();
Console.WriteLine("Wich city are you from? ? ");
string city = Console.ReadLine();
Console.WriteLine("What is your department  ? ");
string department = Console.ReadLine();
Console.WriteLine("Which year? ");
double year = double.Parse(Console.ReadLine());

Console.WriteLine($"Name: {name}\nCity:{city}\nDepartment:{department}\nYear:{year}\n ");
Console.WriteLine("C# is fun? ");
Console.WriteLine($"Hello {name} from {city},welcome to C#! \n\n\n");



Console.WriteLine("Enter the first number: ");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
double num2 = double.Parse(Console.ReadLine());

double sum = num1 + num2;
double diferent=num1 - num2;
double multiply = num1 * num2;
double division = num1 / num2;
Console.WriteLine($"{num1}+{num2}={sum}");
Console.WriteLine($"{num1}-{num2}={diferent}");
Console.WriteLine($"{num1}*{num2}={multiply}");
Console.WriteLine($"{num1}/{num2}={division}\n\n\n");


Console.Write("what is your name:");
string name2=Console.ReadLine();
Console.Write("Enter your midterm score:");
int midterm = int.Parse(Console.ReadLine());
Console.Write("Enter your final score:");
int final = int.Parse(Console.ReadLine());

double average = midterm * 0.4 + final *0.6;
Console.WriteLine($"{name2}, your average is {average}");
if (average >= 50)
    Console.WriteLine("Result:PASSED");
if (average < 50)
    Console.WriteLine("Result:FAİLED");
if (final == 100)
    Console.WriteLine("PERFECT FİNAL!\n\n\n");


Console.Write("Enter 3-digit number: ");
int digit = int.Parse(Console.ReadLine());

int hundreds = digit / 100;
int tens = (digit / 10) % 10;
int ones=digit % 10;

int sumdigit = hundreds + tens + ones;

Console.WriteLine($"Hundereds: {hundreds}\nTens: {tens}\nOnes: {ones}\nSum of digits: {sumdigit}\n");

if (digit % 2 == 0)
    Console.WriteLine($"{digit} is  even");

if (digit % 2 == 1)
    Console.WriteLine($"{digit} is  odd");
if (hundreds == ones)
    Console.WriteLine("First and last digits are same. ");

if (hundreds!=ones)
    Console.WriteLine($"First and last digits are different.\n\n\n");
