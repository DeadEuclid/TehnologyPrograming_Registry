using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TehnologyProgramingModels;

namespace TehnologyProgramingReposytory.ConcreteRepository
{
   public class TalonRepository : BaseRepository<Talon>
    {
        public TalonRepository() : base()
        {
          
        }

        public IEnumerable<Talon> GetToDayTalons(List<Talon> talons) => talons.Where(talon => talon.Time.Date == DateTime.Now.Date);
        public IEnumerable<Talon> GetToMonthTalons(List<Talon> talons) => talons.Where(talon => talon.Time.Date.Month == DateTime.Now.Date.Month);
        public IEnumerable<Talon> GetToYearTalons(List<Talon> talons) => talons.Where(talon => talon.Time.Date.Year == DateTime.Now.Date.Year);

        public List<Talon> GetPatientTalons(Patient patient)
        {
          return  Collection.Find(talon => talon.Patient == patient).ToList();
        }
        public List<Talon> GetSpecialistTalons(Specialist specialist)
        {
            return Collection.Find(talon => talon.Specialist == specialist).ToList();
        }
        public new TalonAddStatus Create(Talon item)
        {
            bool IsDocBusy = Collection.Find(talon => (talon.Time == item.Time) && (talon.Specialist == item.Specialist)).Any();
            bool IsPatBusy = Collection.Find(talon => (talon.Time == item.Time) && (talon.Patient == item.Patient)).Any();
            if (IsDocBusy)
            {
                return TalonAddStatus.SpecialistBusy;
            }
            if (IsPatBusy)
            {
                return TalonAddStatus.PatientBusy;
            }
            base.Create(item);
            return TalonAddStatus.Created;
        }
    }
}
