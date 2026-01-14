namespace UltraEnterpriseSDLC
{
    public sealed class AuditLog
    {
        public DateTime Time{get;}
        public string Action{get;}
        public AuditLog(string action)
        {
            Action = action;
            Time = DateTime.Now;
        }
    }
}