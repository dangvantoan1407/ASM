using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.asm3
{
    public delegate void BalanceChangedEventHandler(double newBalance);

    public class BankAccount
    {

        private double balance;
        public event BalanceChangedEventHandler BalanceChanged;

        public BankAccount()
        {
            BalanceChanged += HandleBalanceChanged;

        }
        public double Balance
        {
            get => balance;
            private set
            {
                if (balance != value)
                {
                    balance = value;

                }
            }
        }
        public void Withdraw(double amout)
        {
            if (amout > 0 && amout <= balance)
            {
                balance -= amout;
                BalanceChanged(amout);
            }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                BalanceChanged(amount);
            }
        }


        public void HandleBalanceChanged(double newBalance)
        {
            Console.WriteLine($"Balance changed. New balance: {newBalance}");
        }


    }
}
