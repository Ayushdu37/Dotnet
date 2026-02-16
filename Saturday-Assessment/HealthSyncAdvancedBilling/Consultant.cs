using System;

public abstract class Consultant
{
    public string ConsultantId{get;set;}
    public Consultant(string consultantId)
    {
        if(!ValidateConsultantId(consultantId)) throw new Exception("Invalid doctor id");
        ConsultantId = consultantId;
    }
    public abstract double CalculateGrossPayout();
    public virtual double CalculateTDS(double gross)
    {
        if(gross <= 5000)
        {
            return gross * 0.05;
        }
        else
        {
            return gross * 0.15;
        }
    }
}