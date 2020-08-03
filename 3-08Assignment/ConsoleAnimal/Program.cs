using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MyArray = { "Zebra", "Ant", "Owl", "Lion" };
            Console.WriteLine("FOr Loop");
            for(int i = 0; i <MyArray.Length; i++)
            {
                Console.Write(MyArray[i]+" ");
            }
            Console.WriteLine("For Each Loop");
            foreach(string i in MyArray)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("Do while loop  ............");
            // string i;
            int j = 0;
            do
            {
                Console.WriteLine( MyArray[j]);
                j++;

            } while (j<MyArray.Length);

            Console.WriteLine("While Loop...........");


            int z = 0;
            while (z< MyArray.Length)
            {
                Console.Write(MyArray[z]+"  ");
                z++;
            }

            string[] Animal = { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };

            string[] Place = { "Africa", "New Zealand", "Jamaica", "India" };
           Array.Sort(Animal);
            
            Console.WriteLine("Displaying Animals in order");

            foreach(string i in Animal)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Displaying place in order");
            Array.Sort(Place);
            foreach (string i in Place)
            {
                Console.WriteLine(i);
            }
        }
    }
}
