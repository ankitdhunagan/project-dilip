using System;
class Subtract
{
    public  void Subtraction()
    {
        Console.WriteLine ("Enter the first number:");
        Int32 num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine ("Enter second number:");
        Int32 num2 = Convert.ToInt16( Console.ReadLine());

        Int32 sum = num1 - num2;
        Console.WriteLine("The difference is:" + sum);
    }
}