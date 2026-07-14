using System;

class BankAcc
{
    public int AccNumber { get; set; }

    private double balance;

    public double Balance
    {
        get
        {
            return balance;
        }

        set
        {
            if (value < 0)
            {
                Console.WriteLine("Balance cannot be negative.");
            }
            else
            {
                balance = value;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAcc account = new BankAcc();

        account.AccNumber = 345;
        account.Balance = 1000;

        Console.WriteLine("Account Number: " + account.AccNumber);
        Console.WriteLine("Balance: " + account.Balance);
        // Attempt to set a negative balance
        account.Balance = -500;

        Console.WriteLine("Balance after attempting to set negative value: " + account.Balance);

        Console.WriteLine("Sachin Ramesh Mehta");

    }
}