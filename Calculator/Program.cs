// See https://aka.ms/new-console-template for more information

Console.Write("Enter your first number: ");
double number1 = double.Parse(Console.ReadLine());

Console.Write("Enter your arithmetic operator (+, -, *, /): ");
string operatorInput = Console.ReadLine();

Console.Write("Enter your second number: ");
double number2 = double.Parse(Console.ReadLine());

if(operatorInput == "+")
{
    Console.WriteLine($"Result: {number1} + {number2} = {number1 + number2}");
}else if(operatorInput == "-")
{
    Console.WriteLine($"Result: {number1} - {number2} = {number1 - number2}");
}
else if (operatorInput == "*")
{
    Console.WriteLine($"Result: {number1} * {number2} = {number1 * number2}");
}
else if (operatorInput == "/")
{
    if(number2 == 0)
    {
        Console.WriteLine("Error: Cannot Divide by zero!");
    }
    else
    {
        Console.WriteLine($"Result: {number1} / {number2} = {number1 / number2}");
    }

}
else
{
    Console.WriteLine("Invalid operator! Use +, -, *, /");
}