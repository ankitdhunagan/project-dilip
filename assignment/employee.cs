using System;

namespace assignment
{

        public class employee 
        {
            public string? name;
            public string? dept;
            private int num;
            internal string? task;
            public static void Main()
            {
                employee obj1 = new employee(); // assignment of object
                obj1.name = "Ankit";
                obj1.dept = "I.T";
                obj1.num = 2;
                obj1.task = "Responsible for all the I.T activities";

                employee obj2 = new employee(); // assignment of object
                obj2.name = "Priya";
                obj2.dept = "P.M.S";
                obj2.num = 3;
                obj2.task = "Responsible for Management of portfolio of atleast 50 clients";

                System.Console.WriteLine("Employee Name :" + " " + obj1.name + "," + " " + "Department :" + " " + " " + obj1.dept);
               
                System.Console.WriteLine("Employee Name :" + " " + obj2.name + "," + " " + "Department :" + " " + " " + obj2.dept);
                           
            }
            
        }
}