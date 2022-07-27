using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAluraPart4
{
    public class CheckingAccount
    {
        public static double OperationTax { get; private set; }
        public static int TotalAccountsCreated { get; private set; }
        private Client Holder { get; set; }
        public int CounterDisallowedWithdraws { get; private set; }
        public int CounterDisallowedTransfers { get; private set; }
        public int Agency { get; }
        public int Number { get; }

        private double _balance = 100;
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _balance = value;
            }
        }

        public CheckingAccount(int agency, int number)
        {
            if( agency <= 0)
            {
                throw new ArgumentException("O argumento agência deve ser maior que 0.", nameof(agency));
            }

            if (number <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(number));
            }

            Agency = agency;
            Number = number;

            TotalAccountsCreated++;

            OperationTax = 30 / TotalAccountsCreated;
        }

        public void Withdraw(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(value));
            }

            if (Balance < value)
            {
                CounterDisallowedWithdraws++;
                throw new InsufficientFundsException(Balance, value);
            }
            
            Balance -= value;                
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public void Transfer(double value, CheckingAccount account)
        {
            if (value < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(value));
            }

            try
            {
                Withdraw(value);
                account.Deposit(value);
            }
            catch (InsufficientFundsException e)
            {
                CounterDisallowedTransfers++;
                throw new FinancialOperationException("Operação não realizada", e);
            }
        }
    }
}
