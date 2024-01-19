/**
 * lufer
 * Conta Bancária
 * */
using System;

namespace Aula_1
{
    /// <summary>
    /// Bank account.
    /// </summary>
    public class BankAccount
    {

        public const string DebitAmountExceedsBalanceMessage = "Debito superior ao saldo existente";
        public const string DebitAmountLessThanZeroMessage = "Debito é inferior a zero";

        private readonly string customerName;
        private double balance;

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            this.customerName = customerName;
            this.balance = balance;
        }

        public string CustomerName
        {
            get { return customerName; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public void Debit(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }

            balance -= amount; 
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Montante negativo");
            }

            balance += amount;
        }
    }
}
