using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NorthwindApp.ProductServiceRef;  

namespace NorthwindApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsClient client = new ProductsClient();
            string productName = client.GetProductName(2);
            Console.WriteLine(productName);
            Console.Read();  
        }
    }
}
