namespace UltraEnterpriseSDLC
{
    public class EnterpriseSDLCEngine
    {
        private List<Requirement> requirements;
        private Dictionary<int, WorkItem> workItemRegistry;
        private SortedDictionary<SDLCStage, List<WorkItem>> stageBoard;
        private Queue<WorkItem> executionQueue;
        private Stack<BuildSnapShot> rollBackStack;
        private HashSet<string> uniqueTestSuites;
        private LinkedList<AuditLog> auditLedger;
        private SortedList<double, QualityMetric> releaseScoreboard;
        private int requirementCounter;
        private int workItemCounter;
        public EnterpriseSDLCEngine()
        {
            requirements = new List<Requirement>();
            workItemRegistry = new Dictionary<int, WorkItem>();
            stageBoard = new SortedDictionary<SDLCStage, List<WorkItem>>();
            foreach(SDLCStage stage in Enum.GetValues(typeof(SDLCStage)))
            {
                stageBoard[stage] = new List<WorkItem>();
            }
            executionQueue = new Queue<WorkItem>();
            rollBackStack = new Stack<BuildSnapShot>();
            uniqueTestSuites = new HashSet<string>();
            auditLedger = new LinkedList<AuditLog>();
            releaseScoreboard = new SortedList<double, QualityMetric>();
        }
        public void AddRequirement(string title, RiskLevel risk)
        {
            Requirement requirement = new Requirement();
            requirementCounter++;
            requirements.Add(requirement);
            AuditLog auditLog = new AuditLog($"Requirement {title} added with risk level {risk}",DateTime.UtcNow);
            auditLedger.AddLast(auditLog);
        }
        public WorkItem CreateWorkItem(string name, SDLCStage stage)
        {
            WorkItem workItem = new WorkItem(workItemCounter, name, stage);
            workItemCounter++;
            workItemRegistry.Add(workItem.Id,workItem);
            stageBoard[WorkItem.stage].Add(workItem);
            AuditLog log = new AuditLog($"WorkItem {name} and stage {stage}", DateTime.UtcNow);
            auditLedger.AddLast(log);
            return workItem;
        }
        public void AddDependency(int workItemId, int dependsOnId)
        {
            if(workItemRegistry.ContainsKey(workItemId) && workItemRegistry.ContainsKey(dependsOnId))
            {
                workItemRegistry[workItemId].DependencyIds.Add(dependsOnId);
                AuditLog log = new AudiLog($"WorkItem {workItemId} now depends on WorkItem {dependsOnId}");
                auditLedger.AddLast(log);
            }
        }
        public void PlanStage(SDLCStage stage)
        {
            var AllWorkItems = stageBoard[stage];
        }
    }
}