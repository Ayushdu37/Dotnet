using System;
namespace HospitalNotifierSystem{
    public delegate void HospitalNotificationHandler(string msg,DateTime time);
    public class HospitalNotifier{
        public event HospitalNotificationHandler PatientAdmitted;
        public void AdmitPatient(string name){
            PatientAdmitted?.Invoke(name+" Admitted Successful",DateTime.Now);
        }
    }
    public class AdministrationDepartment{
        public void Notify(string msg,DateTime time){
            Console.WriteLine("Administration Notification:");
            Console.WriteLine($"Message : {msg}");
            Console.WriteLine($"Time    : {time}");
        }
    }
}