public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Condition { get; set; }
    public Patient(int id, string name, int age, string condition)
    {
        Id = id;
        Name = name;
        Age = age;
        Condition = condition;
    }
}
public class HospitalManager
{
    private Dictionary<int, Patient> _patient = new Dictionary<int, Patient>();
    private Queue<Patient> _appointments = new Queue<Patient>();
    public void RegisterPatient(int id, string name, int age, string condition)
    {
        Patient patient = new Patient(id, name, age, condition);
        _patient.Add(id, patient);
    }
    public void ScheduleAppointment(int patientId)
    {
        Patient patient = _patient[patientId];
        _appointments.Enqueue(patient);
    }
    public Patient ProcessNextAppointment()
    {
        Patient nextPatient = _appointments.Dequeue();
        return nextPatient;
    }
    public List<Patient> FindPatientsByCondition(string condition)
    {
        List<Patient> result = new List<Patient>();

        foreach (Patient patient in _patient.Values)
        {
            if (patient.Condition != null && patient.Condition.Equals(condition, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(patient);
            }
        }
        return result;
    }
}
public class Program
{
    public static void Main()
    {
        HospitalManager manager = new HospitalManager();
        manager.RegisterPatient(1, "John Doe", 45, "Hypertension");
        manager.RegisterPatient(2, "Jane Smith", 32, "Diabetes");
        manager.ScheduleAppointment(1);
        manager.ScheduleAppointment(2);

        var nextPatient = manager.ProcessNextAppointment();
        Console.WriteLine(nextPatient.Name);

        var diabetesPatients = manager.FindPatientsByCondition("Diabetes");
        Console.WriteLine(diabetesPatients.Count);
    }
}