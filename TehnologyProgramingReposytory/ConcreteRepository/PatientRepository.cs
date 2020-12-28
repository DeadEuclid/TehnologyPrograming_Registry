using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TehnologyProgramingModels;

namespace TehnologyProgramingReposytory.ConcreteRepository
{
    public class PatientRepository : BaseRepository<Patient>
    {
        public PatientRepository() : base()
        {
        }
        public Patient FindBySNILS(string SNILS)
        {
            return Collection.FindOne((pat) => pat.SNILS == SNILS);
        }
        public bool Registration(string SNILS, string FIO)
        {
            Patient patient = FindBySNILS(SNILS);
            if (patient == null)
            {

                patient = new Patient(SNILS, FIO);
                Create(patient);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Patient Autrorization(string SNILS)
        {
            return FindBySNILS(SNILS);
        }

    }
}
