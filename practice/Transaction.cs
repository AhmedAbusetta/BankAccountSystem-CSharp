using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    
    public class Transaction
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public TransactionType Type { get; set; }

        public override string ToString()
        {
            return $"Date: {Date} | Amount: {Amount} | Type: {Type}"; 
        }


    }
}
