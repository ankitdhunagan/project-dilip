using System;

    class Ankit

    {
        public static void Main()
        {
           /* Console.WriteLine("Enter your age");
            string age = Console.ReadLine();
            Console.WriteLine("your age is:" + age);*/

            Console.WriteLine ("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your age is: " + age + " and are a voter");
            if (age >= 18)
            {
                Console.WriteLine("Your age is: " + age + " and are a voter");
            }
            else
            {
                Console.WriteLine("Your age is: " + age + " and are not a voter");
            }



            return;  
        }
    }