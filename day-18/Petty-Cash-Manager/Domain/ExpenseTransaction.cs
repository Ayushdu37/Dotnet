PettyCashManager.Enums;

namespace PettyCashManager.Domain
{
    public class ExpenseTransaction : Transaction
    {
        public string VoucherNumber{get; set;}
        public Category category{get; set;}
    }
}