using JWTAuthentication.Models;

namespace JWTAuthentication.Services
{
    public class AdmissionService
    {
        private static List<Admission> admissions = new List<Admission>();

        public List<Admission> GetAll()
        {
            return admissions;
        }

        public void Add(Admission admission)
        {
            admission.Id = admissions.Count + 1;
            admissions.Add(admission);
        }
    }
}
