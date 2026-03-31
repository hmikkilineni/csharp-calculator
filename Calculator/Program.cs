
double number1 = 0;
double number2 = 0;
string operatorInput = "";

try
{
    Console.Write("Enter your first number: ");
   number1 = double.Parse(Console.ReadLine());

    Console.Write("Enter your arithmetic operator (+, -, *, /): ");
    operatorInput = Console.ReadLine();

    Console.Write("Enter your second number: ");
     number2 = double.Parse(Console.ReadLine());

   if (operatorInput == "+")
   {
    Console.WriteLine($"Result: {number1} + {number2} = {number1 + number2}");
   }
   else if (operatorInput == "-")
   {
    Console.WriteLine($"Result: {number1} - {number2} = {number1 - number2}");
   }
   else if (operatorInput == "*")
   {
    Console.WriteLine($"Result: {number1} * {number2} = {number1 * number2}");
   }

   else if (operatorInput == "/")
   {
        if (number2 == 0)
            throw new DivideByZeroException();
        Console.WriteLine($"Result: {number1} / {number2} = {number1 / number2}");
   }
    else
        Console.WriteLine("Invalid operator!");
}
catch (FormatException ex)
{
    Console.WriteLine("Please enter a valid number!");
}
 catch (DivideByZeroException ex){
        Console.WriteLine("Cannot divide by zero!");
    }
finally
{
    Console.WriteLine("Thank you for using the calculator!");
}
Console.ReadKey();