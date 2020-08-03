using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStringAssignment
{


    class Program
    {

        static void Main(string[] args)
        {
            string first;
            string last;
            Console.WriteLine("Enter the First String");
            first = Console.ReadLine();
            Console.WriteLine("Enter the last string");
            last = Console.ReadLine();
           string fullString = first + last;
            Console.WriteLine("1.Concatination");
                 Console.WriteLine("2.String Length");
            Console.WriteLine("3.Substring");
            Console.WriteLine("4.Replace");
            Console.WriteLine("5.To Upper");
            Console.WriteLine("6.To Lower");
            Console.WriteLine("7.Trim");
            Console.WriteLine("8.split");
            Console.WriteLine("Click 9 to exit");
            int i = Convert.ToInt32(Console.ReadLine());


           
       
                Console.WriteLine("Select options from 1 to 9");

                switch (i)
                {
                    case 1:
                        Console.WriteLine(string.Concat(first, last));
                        break;
                    case 2:
                        int length1 = first.Length;
                        int length2 = last.Length;
                        Console.WriteLine(length1);
                        Console.WriteLine(length2);
                        break;

                    case 3:
                        string subS = fullString.Substring(5);

                        Console.WriteLine(subS);
                        break;
                    case 4:
                        Console.WriteLine("Enter string to replace ");
                        string newS = Console.ReadLine();
                        fullString = first + last;
                        Console.WriteLine(fullString.Replace(last, newS));
                        break;

                    case 5:
                        Console.WriteLine(fullString.ToUpper());
                        break;
                    case 6:
                        Console.WriteLine(fullString.ToLower());
                        break;
                    case 7:
                        Console.WriteLine(fullString.Trim());
                        break;

                    case 8:
                        Console.WriteLine(fullString.Split(new char[] { 'e' }));
                        break;



                }


            
            
        }
    }
}
