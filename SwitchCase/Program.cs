using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Gender");
            Char Gen;
            Gen =Convert.ToChar( Console.ReadLine());
            switch (Gen)
            {
                case 'm' :
                    Console.WriteLine("I'm Male");
                    break;
                case 'f':
                    Console.WriteLine("I'm Female");
                    break;
                default:
                    Console.WriteLine("I'm God Gifted");
                    break;
            }
            Console.ReadKey();
            int Bonus = 5000;
            int salary;
            switch (Gen)
            {
                case 'm':
                    Console.WriteLine("I'm Male");
                    Console.WriteLine("Enter YOur salary");
                    salary = Convert.ToInt32(Console.ReadLine());
                    if(salary>20000)
                    {
                        Console.WriteLine("sorry not eligible");
                    }
                    else
                    {
                        int finalsalry = salary + Bonus;
                        Console.WriteLine(finalsalry);
                    }
                    break;
                case 'f':
                    Console.WriteLine("I'm Female");
                     Console.WriteLine("Enter YOur salary");
                    salary = Convert.ToInt32(Console.ReadLine());
                    if(salary>20000)
                    {
                        Console.WriteLine("sorry not eligible");
                    }
                    else
                    {
                        int finalsalry = salary + Bonus;
                        Console.WriteLine(finalsalry);
                    }
                    break;
                default:
                    Console.WriteLine("I'm God Gifted");
                    int Finalsalary = salary =20000 * Bonus;
                    Console.WriteLine("Yippiie"+Finalsalary);
                    break;
            }
            Console.ReadKey();
        
        
        }
    }
}
