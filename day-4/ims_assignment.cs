sealed class Security
{
    public void Authenticate(string username, string password)
    {
        if(username =="Amit" && password == "1234")
        {
            Console.WriteLine("Authetication Successful. Access Granted.");
        }
        else
        {
            Console.WriteLine("Invalid Credentials.");
        }
    }
}

abstract class InsurancePolicy
{
    public int PolicyNumber {get; init;}

    public string PolicyHolder {get; set;}

    private int premium;

    public int Premium
    {
        get{return premium;}
        set
        {
            if(value > 0)
            {
                premium = value;
            }
        }
    }

    public virtual int CalculatePremium()
    {
        return Premium * 20 / 100;
    }

    public void DisplayPolicy()
    {
        Console.WriteLine($"Policy Number : {PolicyNumber}");
        Console.WriteLine($"Policy Holder Name : {PolicyHolder}");
        Console.WriteLine($"Premium : {Premium}");
    }
}

class LifeInsurance : InsurancePolicy
{
    private int LifeInsuranceCharge = 500;

    public override int CalculatePremium()
    {
        return base.CalculatePremium() + LifeInsuranceCharge;
    }

    public new void DisplayPolicy()
    {
        Console.WriteLine($"Life Insurance Policy");
        Console.WriteLine($"Policy Number : {PolicyNumber}");
        Console.WriteLine($"Policy Holder Name : {PolicyHolder}");
        Console.WriteLine($"Premium (with Life charge)" + CalculatePremium());
    }
}

class HealthInsurance : InsurancePolicy
{
    private int HealthServiceCharge = 500;
    public sealed override int CalculatePremium()
    {
        return base.CalculatePremium() + HealthServiceCharge;
    }
}

class PolicyDirectory
{
    public Dictionary<int, InsurancePolicy> policies = new Dictionary<int, InsurancePolicy>();

    public InsurancePolicy this[int policyNumber]
    {
        get
        {
            return policies.ContainsKey(policyNumber) ? policies[policyNumber] : null;
        }

        set
        {
            policies[policyNumber] = value;
        }
    }

    public InsurancePolicy this[string PolicyHolderName]
    {
        get
        {
            return policies.FirstOrDefault(p => p.Value.PolicyHolder == PolicyHolderName).Value;
        }
    }
}