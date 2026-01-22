using System;
PettyCashManager.Enums;

namespace PettyCashManager.Domain
{
    public class AuditLogEntry
    {
        public int Id { get; set; }
        public string EntityName { get; set; }
        public int EntityId { get; set; }
        public AuditAction Action { get; set; }
        public DateTime Timestamp { get; set; }
        public string PerformedBy { get; set; }
        public string? Details { get; set; }
    }
}