using System;
using System.Linq;

class multi
{
    List<int> numbers = new List<int>() { 1, 5, 10, 20, 35, 25, 21, 49, 50, 7, 55 };
    public void mul5()
    {
        var m5 = numbers.Where(num => num % 5 == 0);

        //Console.WriteLine(", ", m5);
        Console.WriteLine($"Multiples of 5 are: ");

        foreach(var item in m5)
        {
            Console.WriteLine(item);
        }
        
        

    }
    public void mul7()
    {
        var m7 = numbers.Where(num => num % 7 == 0);
        //Console.WriteLine(", ", m7);
        Console.WriteLine($"Multiples of 7 are: ");

        foreach(var item in m7)
        {
            Console.WriteLine(item);
        }

        

    }
    public void mul10()
    {
        var m10 = numbers.Where(num => num % 10 == 0);
        //Console.WriteLine(", ", m10);
        Console.WriteLine($"Numbers less than 100 which ends with 0 are: ");

        foreach(var item in m10)
        {
            Console.WriteLine(item);
        }

        

    }
}