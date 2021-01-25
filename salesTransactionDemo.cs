using System;
using static System.Console;

namespace SalesTransactionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate some salesTransactions. Console will display the values upon instatiation.
            SalesTransaction saleOne = new SalesTransaction("Matt"); //declare with just name
            SalesTransaction saleTwo = new SalesTransaction("Akira", 330); // declare with name and sales amount
            SalesTransaction saleThree = new SalesTransaction("Frank", 230, 0.3); // declare with name, sales amount and commission rate
            SalesTransaction saleFour = new SalesTransaction("Charlie", 230, 0.5); // declare with name, sales amount and commission rate
            SalesTransaction saleFive = new SalesTransaction("Mac", 200, 0.5); // declare with name, sales amount and commission rate
            SalesTransaction saleSix = new SalesTransaction("Mac", 230, 0.5); // declare with name, sales amount and commission rate

            // Add two Sales with the same name, same rate
            SalesTransaction saleSeven = saleSix + saleFive;
            // Add two Sales with different names, same rate
            SalesTransaction saleEight = saleFour + saleFive;
            // Add two sales with different CommissionRates thows and exception
            SalesTransaction saleNine = saleThree + saleFour;
        }
    }

    class SalesTransaction
    {
        string name;
        double salesAmount;
        double commission;
        double commissionRate;
        
        static public SalesTransaction operator+(SalesTransaction left, SalesTransaction right)
        {
            if (left.CommissionRate != right.CommissionRate)
            {
                throw new Exception("Commission Rates should be equal to one another to add Sales Amounts");
            }
            else
            {
                string name = (left.Name == right.Name) ? left.Name : left.Name + "~" + right.Name;
                double totalSales = left.SalesAmount + right.SalesAmount;
                double rate = left.CommissionRate;
                SalesTransaction rv = new SalesTransaction(name, totalSales, rate);
                return rv;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double SalesAmount
        {
            get
            {
                return salesAmount;
            }
            set
            {
                salesAmount = value;
            }
        }

        public double Commission
        {
            get
            {
                return commission;
            }
            set
            {
                commission = value;
            }
        }

        public double CommissionRate
        {
            get
            {
                return commissionRate;
            }
        }

        public SalesTransaction(string name)
        {
            this.name = name;
            salesAmount = 0;
            commission = 0;
            commissionRate = 0;
            WriteLine($"new SalesTransaction Created\nName: {name}\nSalesAmount: {salesAmount}\nCommission: {commission}\nCommission Rate: {commissionRate}\n");
        }

        public SalesTransaction(string name, double salesAmount, double commissionRate)
        {
            this.name = name;
            this.salesAmount = salesAmount;
            this.commissionRate = commissionRate;
            this.commission = salesAmount * commissionRate;
            WriteLine($"new SalesTransaction Created\nName: {name}\nSalesAmount: {salesAmount}\nCommission: {commission}\nCommission Rate: {commissionRate}\n");
        }

        public SalesTransaction(string name, double salesAmount)
        {
            this.name = name;
            this.salesAmount = salesAmount;
            this.commissionRate = 0;
            WriteLine($"new SalesTransaction Created\nName: {name}\nSalesAmount: {salesAmount}\nCommission Rate: {commissionRate}\n");
        }
    }
}
