using System;

namespace Assignment_3
{
    class SaleDetails
    {
        int salesNo;
        int productNo;
        double price;
        int qty;
        string dateOfSale;
        double totalAmount;

        // Constructor
        public SaleDetails(int salesNo, int productNo, double price, int qty, string dateOfSale)
        {
            this.salesNo = salesNo;
            this.productNo = productNo;
            this.price = price;
            this.qty = qty;
            this.dateOfSale = dateOfSale;
        }

        // Calculate total
        public void Sales()
        {
            totalAmount = qty * price;
        }

        // Display details
        public void ShowData()
        {
            Console.WriteLine("\n--- SALES DETAILS ---");
            Console.WriteLine("Sales No     : " + salesNo);
            Console.WriteLine("Product No   : " + productNo);
            Console.WriteLine("Price        : " + price);
            Console.WriteLine("Quantity     : " + qty);
            Console.WriteLine("Date of Sale : " + dateOfSale);
            Console.WriteLine("Total Amount : " + totalAmount);
        }
    }

    internal class Ques_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- SALES PROGRAM ----");

            Console.Write("Enter Sales No: ");
            int sNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product No: ");
            int pNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Date of Sale: ");
            string date = Console.ReadLine();

            SaleDetails sale = new SaleDetails(sNo, pNo, price, qty, date);

            sale.Sales();      // Calculate total
            sale.ShowData();   // Display result

            Console.ReadLine();
        }
    }
}