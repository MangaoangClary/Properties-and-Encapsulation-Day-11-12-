using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_and_Encapsulation__Day_11_12_
{
    internal class Product
    { 
        


        public string pName;
        public int qnt;
        public double price;
        private string unit;

        public Product(string PName, int Qnt, string Unit, double Price)
        {
            pName = PName;
            qnt = Qnt;
            price = Price;
            Unit1 = Unit;
        }
        public string Unit1
        {
            get { return unit; }
            set
            {
                if (value == "sachet" || value == "pc" || value == "box" || value == "pouch" || value == "bar")
                {
                    unit = value;
                }
                else
                {
                    unit = "unknown";
                }
            }
        }

    }
    class Programs
    {
        static void Main(string[] args)
        {

            Product product1 = new Product("Ariel", 2, "sachet", 7.50);

            Console.WriteLine("*************************");
            Console.WriteLine("Item: " + product1.pName);
            Console.WriteLine("Quantity: " + product1.qnt);
            Console.WriteLine("Price: " + product1.price);
            Console.WriteLine("Unit: " + product1.Unit1);
            Console.WriteLine("Amount: " + product1.qnt * product1.price);
            Console.WriteLine("*************************");
            Product product = new Product("Tide", 2, "sachet", 30);

            Console.WriteLine("Item: " + product.pName);
            Console.WriteLine("Quantity: " + product.qnt);
            Console.WriteLine("Price: " + product.price);
            Console.WriteLine("Unit: " + product.Unit1);
            Console.WriteLine("Amount: " + product.qnt * product.price);
            Console.WriteLine("*************************");


            Console.ReadLine();

        }

    }

}