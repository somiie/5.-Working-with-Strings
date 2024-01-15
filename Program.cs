using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write same line");
            Console.WriteLine("This will \n wrap to next line");
            Console.WriteLine("This will \" print out the quotation mark.");

            string firstName = "Someleze";
            string lastName = "Sipayile";
            //concatination (combining 2 words)
            Console.WriteLine(firstName + " " + lastName);

            //functions with strings
            Console.WriteLine(lastName.Length);
            //methods on strings
            Console.WriteLine(firstName.ToUpper());
            //method with a parameter eg the contains(), its case sensitive
            Console.WriteLine(lastName.Contains("Si"));
            //acces characters using index
            Console.WriteLine(firstName[0]);
            //indexOf will tell you if the value is there and at what position
            Console.Write("index of a is ");
            Console.WriteLine(lastName.IndexOf('a'));//can use double quotes too
            //substring, to grab from an index onwards
            Console.WriteLine(firstName.Substring(1));
            //you can also give index and length ie how many chars you want to grab
            Console.WriteLine(firstName.Substring(1, 2));
            Console.Read();
        }
    }
}
