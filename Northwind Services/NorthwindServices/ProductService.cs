using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace NorthwindServices
{
    public class ProductService : IProducts 
    {
        public string GetProductName(int productID)
        {
            XDocument doc = XDocument.Load("C:\\Laxmikant\\products.xml");

            string productName =
                (from result in doc.Descendants("DocumentElement")
                .Descendants("Products")
                 where result.Element("productID").Value == productID.ToString()
                 select result.Element("productname").Value)
                .FirstOrDefault<string>();

            return productName;
        }

        public int GetProductQty(int productID)
        {
            XDocument doc = XDocument.Load("C:\\Laxmikant\\products.xml");
            int ProductQty = 0;

            string strProductQty =
                (from result in doc.Descendants("DocumentElement")
                .Descendants("Products")
                 where result.Element("productID").Value == productID.ToString()
                 select result.Element("UnitsInStock").Value)
                .FirstOrDefault<string>();

            int.TryParse(strProductQty, out ProductQty);

            return ProductQty;
        }

        public string GetCategoryName(int productID)
        {
            XDocument doc = XDocument.Load("C:\\Laxmikant\\products.xml");

            string categoryName =
                (from result in doc.Descendants("DocumentElement")
                    .Descendants("Products")
                 where result.Element("productID").Value == productID.ToString()
                 select result.Element("CategoryName").Value)
                 .FirstOrDefault<string>();

            return categoryName;
        }
    }
}
