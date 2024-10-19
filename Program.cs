using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        string opre = Console.ReadLine();

        double result = 0;

        switch (opre)
        {
            case "+": result = num1 + num2; break;
            case "-": result = num1 - num2; break;
            case "*": result = num1 * num2; break;
            case "/": result = (double)num1 / num2; break;
            default: Console.WriteLine("Invalid operator"); return;
        }

        Console.WriteLine("Result: " + num1 +" "+ opre + " "+num2 + " = " + result); 
    }
}//Dima's code 