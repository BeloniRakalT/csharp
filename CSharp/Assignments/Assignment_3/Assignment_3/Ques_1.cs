using System;

namespace Assignment_3
{
    // Account Class
    class Account
    {
        int acc_no;
        string cust_name;
        string acc_type;
        double bal;

        public Account(int acc_no, string cust_name, string acc_type, double bal)
        {
            this.acc_no = acc_no;
            this.cust_name = cust_name;
            this.acc_type = acc_type;
            this.bal = bal;
        }

        public void Credit(double amount)
        {
            bal += amount;
            Console.WriteLine("Amount Deposited");
        }

        public void Debit(double amount)
        {
            if (amount <= bal)
            {
                bal -= amount;
                Console.WriteLine("Amount Withdrawn");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public void Transaction(char type, double amount)
        {
            if (type == 'D' || type == 'd')
                Credit(amount);
            else if (type == 'W' || type == 'w')
                Debit(amount);
            else
                Console.WriteLine("Invalid Transaction");
        }

        public void ShowData()
        {
            Console.WriteLine("\n--- ACCOUNT DETAILS ---");
            Console.WriteLine("Account Number : " + acc_no);
            Console.WriteLine("Customer Name  : " + cust_name);
            Console.WriteLine("Account Type   : " + acc_type);
            Console.WriteLine("Balance        : " + bal);
        }
    }

    // Main Class for Question 1
    internal class Ques_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- ACCOUNT PROGRAM ----");

            Console.Write("Enter Account Number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Account Type: ");
            string type = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Account acc = new Account(accNo, name, type, balance);

            Console.Write("\nEnter Transaction Type (D/W): ");
            char transType = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());

            acc.Transaction(transType, amt);

            acc.ShowData();

            Console.ReadLine();
        }
    }
}