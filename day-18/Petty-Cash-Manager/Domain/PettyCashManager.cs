using System;
using System.Collections.Generic;

namespace PettyCashManager.Domain
{
    public class PettyCashManager
    {
        public int Id{get; set;}
        public string Name{get; set;}
        public decimal OpeningBalance{get; set;}
        public decimal CurrentBalance{get; set;}
        public List<Transaction> Transactions{get; set;}
        public PettyCashManager()
        {
            Transactions = new List<Transaction>();
        }
    }
}