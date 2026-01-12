using System;
using System.Collections.Generic;
using System.Collections;
using HospitalNotifierSystem;
public class MainClass{
    public delegate string ReportGenerator(string patientName);
    public delegate void HospitalAlert(string message);
    public static void Main(string[] args){
        string GenerateDischargeSummary(string patientName){
            return "Patient Name: "+patientName;
        }
        ReportGenerator report=GenerateDischargeSummary;
        string summary=report?.Invoke("Rahul");
        Console.WriteLine(summary);
        void SendSmsAlert(string msg){
            Console.WriteLine("Sms Alert: "+msg);
        }
        void SendEmailAlert(string msg){
            Console.WriteLine("Email Alert: "+msg);
        }
        void SendDashboardAlert(string msg){
            Console.WriteLine("Dashboard Alert: "+msg);
        }
        HospitalAlert alert=null;
        alert+=SendSmsAlert;
        alert+=SendEmailAlert;
        alert+=SendDashboardAlert;
        alert?.Invoke("Emergency Patient detected");
        
        HospitalNotifier notifier=new HospitalNotifier();
        AdministrationDepartment admin=new AdministrationDepartment();

        notifier.PatientAdmitted+=admin.Notify;
        notifier.AdmitPatient("Meera");

        Func<double,double,double> caculateBill=(consultation,tests)=>consultation+tests;
        double total=(double)caculateBill?.Invoke(600,1800);//return type double? not double
        Console.WriteLine(total);

        Action<string> logAction=msg=>{
            Console.WriteLine(msg);
        };
        logAction.Invoke("Billing process completed");

        Predicate<int> isSeniorCitizen=age=>age>60;
        Console.WriteLine(isSeniorCitizen.Invoke(65));

    }
}