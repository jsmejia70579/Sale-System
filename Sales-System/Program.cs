using System;

namespace Sales_System
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sellers.
            Seller s1 = new Seller();
            s1.name = "Juan Salvador M";
            s1.age = 30;

            Seller s2 = new Seller();
            s2.name = "German Mejia";
            s2.age = 56;

            Seller s3 = new Seller();
            s3.name = "Ana Maria Diaz";
            s3.age = 53;

            // Products.

            Product p1 = new Product();
            p1.productname = "Rice";
            p1.productprice = 1500;

            Product p2 = new Product();
            p2.productname = "Potatoes";
            p2.productprice = 4000;

            Product p3 = new Product();
            p3.productname = "Oranges";
            p3.productprice = 2000;

            // Sale.
            Sale sa1 = new Sale();
            sa1.seller = s1.name;
            sa1.product = p1.productname;
            sa1.comments = "Succesfully sale.";
            sa1.price = p1.productprice;

            Sale sa2 = new Sale();
            sa2.seller = s3.name;
            sa2.product = p2.productname;
            sa2.comments = "Succesfully sale.";
            sa2.price = p2.productprice;


            Sale sa3 = new Sale();
            sa3.seller = s1.name;
            sa3.product = p2.productname;
            sa3.comments = "error";
            sa3.price = p2.productprice;

            int totalprice(Sale price1, Sale price2, Sale price3)
            {
                int pricecalculation = price1.price + price2.price + price3.price;
                return pricecalculation;

            }
            Console.WriteLine("Sales total amount: " + totalprice(sa1, sa2, sa3));  






        }
    }
}
