using System;

namespace CoffeShopNS
{

    public class Coffeshop
    {
        private string m_customerName;
        private double m_balance;
        private const string priceExceedsBalanceMessage = "Price exceeds balance";
        private const string debitAmountLessThanZeroMessage = "Price less than zero";
        private bool m_frozen = false;
        private Coffeshop()
        {
        }
        public Coffeshop(string customerName, double balance)
        {
            CustomerName1 = customerName;
            Balance1 = balance;
        }

        public string CustomerName
        {
            get { return CustomerName1; }
        }
        public double Balance
        {
            get { return Balance1; }
        }

        public string CustomerName1 { get => CustomerName2; set => CustomerName2 = value; }
        public double Balance1 { get => Balance2; set => Balance2 = value; }

        public static string PriceExceedsBalanceMessage => PriceExceedsBalanceMessage1;

        public static string DebitAmountLessThanZeroMessage => DebitAmountLessThanZeroMessage1;

        public bool Frozen { get => Frozen1; set => Frozen1 = value; }
        public string CustomerName2 { get => m_customerName; set => m_customerName = value; }
        public double Balance2 { get => m_balance; set => m_balance = value; }

        public static string PriceExceedsBalanceMessage1 => priceExceedsBalanceMessage;

        public static string DebitAmountLessThanZeroMessage1 => debitAmountLessThanZeroMessage;

        public bool Frozen1 { get => m_frozen; set => m_frozen = value; }
        public string CustomerName3 { get => m_customerName; set => m_customerName = value; }
        public double Balance3 { get => m_balance; set => m_balance = value; }

        public static string PriceExceedsBalanceMessage2 => priceExceedsBalanceMessage;

        public static string DebitAmountLessThanZeroMessage2 => debitAmountLessThanZeroMessage;

        public bool Frozen2 { get => m_frozen; set => m_frozen = value; }

        public void pay(double amount)
        {
            if (Frozen)
            {
                throw new Exception("Account frozen");
            }

           
            if (amount > Balance1)
            {
                throw new ArgumentOutOfRangeException("amount", amount, PriceExceedsBalanceMessage);
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }
            Balance1 -= amount; 
        }
       public void Amountavailable(double amount)
        {
            if (Frozen)
            {
                throw new Exception("Account frozen");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
          Balance1 -= amount;
        }

        private void FreezeAccount()
        {
            Frozen = true;
        }
        private void UnfreezeAccount()
        {
            Frozen = false;
        }
        public static void Main()
        {
            Coffeshop cShop = new Coffeshop("Mr. Ammar", 11.99);
            cShop.Amountavailable(5.77);
            cShop.pay(11.22);
            Console.WriteLine("Current balance is ${0}", cShop.Balance);
        }



    }
}