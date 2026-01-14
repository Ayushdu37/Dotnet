using UltraEnterpriseSDLC;
using System;
public class Program
{
    public static void Main()
    {
        EnterpriseSDLCEngine engine = new EnterpriseSDLCEngine();

        engine.AddRequirement("Sign-On", RiskLevel.High);
        engine.AddRequirement("Fraud Detection", RiskLevel.High);

        var design = engine.CreateWorkItem("Sign-On", SDLCStage.Design);
        var development = engine.CreateWorkItem("Sign-On", SDLCStage.Development);
        var testing = engine.CreateWorkItem("Sign-On", SDLCStage.Testing);

        engine.AddDependency(development.Id, design.Id);
        engine.AddDependency(testing.Id, development.Id);

        engine.RegisterTestSuite("SSO Regression");
        engine.RegisterTestSuite("Security-Focused");

        engine.PlanStage(SDLCStage.Design);

        engine.ExecuteNext();
        engine.ExecuteNext();

        engine.DeployRelease("v3.4.1");

        engine.RecordQualityMetric("Quality metric", 91.7);
        engine.RecordQualityMetric("Security metric", 97.3);    

        engine.RollbackRelease();

        engine.PrintAuditLedger();

        engine.PrintReleaseScoreboard();
    }
}