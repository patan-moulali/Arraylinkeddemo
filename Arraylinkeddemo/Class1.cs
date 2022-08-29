using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylinkeddemo
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            // Creating a list of strings
            List<string> Product = new List<string>();

            Product.Add("pen");
            Product.Add("pencil");
            Product.Add("ink");


            System.Console.WriteLine("Original List:");

            Product.ForEach(System.Console.WriteLine);



            Product.Remove("pencil");

            System.Console.WriteLine();

            System.Console.WriteLine("After removing pencil:");

            Product.ForEach(System.Console.WriteLine);
        }
    }
}
