namespace UltraEnterpriseSDLC
{
    public class EnterpriseSDLCEngine
    {
        private List<Requirement> requirements;
        private Dictionary<int, WorkItem> workItemRegistry;
        private SortedDictionary<SDLCStage, List<WorkItem>> stageBoard;
        private Queue<WorkItem> executionQueue;
        private Stack<BuildSnapshot> rollBackStack;
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
            rollBackStack = new Stack<BuildSnapshot>();
            uniqueTestSuites = new HashSet<string>();
            auditLedger = new LinkedList<AuditLog>();
            releaseScoreboard = new SortedList<double, QualityMetric>();
        }
        public void AddRequirement(string title, RiskLevel risk)
        {
            Requirement requirement = new Requirement(requirementCounter, title, risk);
            requirementCounter++;
            requirements.Add(requirement);
            AuditLog auditLog = new AuditLog($"Requirement {title} added with risk level {risk}");
            auditLedger.AddLast(auditLog);
        }
        public WorkItem CreateWorkItem(string name, SDLCStage stage)
        {
            WorkItem workItem = new WorkItem(workItemCounter, name, stage);
            workItemCounter++;
            workItemRegistry.Add(workItem.Id,workItem);
            stageBoard[workItem.Stage].Add(workItem);
            AuditLog log = new AuditLog($"WorkItem {name} and stage {stage}");
            auditLedger.AddLast(log);
            return workItem;
        }
        public void AddDependency(int workItemId, int dependsOnId)
        {
            if(workItemRegistry.ContainsKey(workItemId) && workItemRegistry.ContainsKey(dependsOnId))
            {
                workItemRegistry[workItemId].DependencyIds.Add(dependsOnId);
                AuditLog log = new AuditLog($"WorkItem {workItemId} now depends on WorkItem {dependsOnId}");
                auditLedger.AddLast(log);
            }
        }
        public void PlanStage(SDLCStage stage)
        {
            var AllWorkItems = stageBoard[stage].Where(workItem => workItem.DependencyIds.All(depId => workItemRegistry.TryGetValue(depId, out var dependency) && dependency.Stage > stage));
            foreach(var workItem in AllWorkItems)
            {
                executionQueue.Enqueue(workItem);
            }
            auditLedger.AddLast(new AuditLog($"Planned Stage {stage}"));
        }
        public void ExecuteNext()
        {
            if(executionQueue.Count == 0)
            {
                return;
            }
            var workItem = executionQueue.Dequeue();
            var previousStage = workItem.Stage;
            workItem.Stage = workItem.Stage + 1;

            stageBoard[previousStage].Remove(workItem);
            stageBoard[workItem.Stage].Add(workItem);

            auditLedger.AddLast(new AuditLog($"Executed WorkItem {workItem} from {previousStage} to {workItem.Stage}"));
        }
        public void RegisterTestSuite(string suiteId)
        {
            uniqueTestSuites.Add(suiteId);
            auditLedger.AddLast(new AuditLog($"Registered test suite: {suiteId}"));
        }
        public void DeployRelease(string version)
        {
            var snapshot = new BuildSnapshot(version);
            rollBackStack.Push(snapshot);
            auditLedger.AddLast(new AuditLog($"Deployed version {snapshot}"));
        }
        public void RollbackRelease()
        {
            if(rollBackStack.Count == 0)
            {
                return;
            }
            var snapshot = rollBackStack.Pop();
            var version = snapshot.Version;
            auditLedger.AddLast(new AuditLog($"Rollback executed for version {version}"));
        }
        public void RecordQualityMetric(string metricName, double score)
        {
            if (!releaseScoreboard.ContainsKey(score))
            {
                QualityMetric qualityMetric = new QualityMetric(metricName, score);
                releaseScoreboard.Add(score, qualityMetric);
            }
        }
        public void PrintAuditLedger()
        {
            foreach(var log in auditLedger)
            {
                Console.WriteLine($"{log.Time} : {log.Action}");
            }
        }
        public void PrintReleaseScoreboard()
        {
            foreach(var entry in releaseScoreboard.Reverse())
            {
                var metric = entry.Value;
                var score = entry.Key;

                Console.WriteLine($"{metric.Name} : {score:F2}");
            }
        }
    }
}