using System;
namespace PettyCashManager.Domain
{
    public abstract class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Narration { get; set; }
    }
}