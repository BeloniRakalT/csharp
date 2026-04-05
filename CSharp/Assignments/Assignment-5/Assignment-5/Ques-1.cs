using System;

namespace Assignment_5
{
    // Custom Exception Class
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }

    // Bank Account Class
    public class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        // Deposit Method
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be greater than zero.");
            }

            balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }

        // Withdraw Method
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero.");
            }

            if (amount > balance)
            {
                throw new InsufficientBalanceException("Insufficient balance for withdrawal.");
            }

            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }

        // Check Balance
        public void CheckBalance()
        {
            Console.WriteLine("Current Balance: " + balance);
        }
    }

    // Main Program
    internal class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000);
            int choice;
            double amount;

            do
            {
                Console.WriteLine("\n--- Banking System Menu ---");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter amount to deposit: ");
                            amount = Convert.ToDouble(Console.ReadLine());
                            account.Deposit(amount);
                            break;

                        case 2:
                            Console.Write("Enter amount to withdraw: ");
                            amount = Convert.ToDouble(Console.ReadLine());
                            account.Withdraw(amount);
                            break;

                        case 3:
                            account.CheckBalance();
                            break;

                        case 4:
                            Console.WriteLine("Exiting...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                }
                catch (InsufficientBalanceException ex)
                {
                    Console.WriteLine("Custom Exception: " + ex.Message);
                    choice = 0; // continue loop
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Argument Exception: " + ex.Message);
                    choice = 0;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format! Please enter numbers only.");
                    choice = 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected Error: " + ex.Message);
                    choice = 0;
                }

            } while (choice != 4);

            Console.WriteLine("Thank you for using the banking system!");
        }
    }
}