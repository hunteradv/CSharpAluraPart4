using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAluraPart4
{
    public class InsufficientFundsException : FinancialOperationException
    {
        public double Balance { get; }
        public double WithdrawValue { get; }

        public InsufficientFundsException()
        {

        }

        public InsufficientFundsException(double balance, double withdrawValue) 
            : this("Tentativa de saque no valor de " + withdrawValue + " em uma conta com saldo de " + balance)
        {
            Balance = balance;
            WithdrawValue = withdrawValue;
        }

        public InsufficientFundsException(string message) : base(message)
        {

        }

        public InsufficientFundsException(string message, Exception internalException) : base(message, internalException)
        {

        }
    }
}
