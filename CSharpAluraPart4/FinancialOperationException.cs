﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAluraPart4
{
    public class FinancialOperationException : Exception
    {
        public FinancialOperationException()
        {

        }

        public FinancialOperationException(string message) : base(message)
        {

        }

        public FinancialOperationException(string message, Exception internalException) : base(message, internalException)
        {

        }
    }
}
