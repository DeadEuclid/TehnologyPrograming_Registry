using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TehnologyProgramingModels
{
    public class Talon
    {
        public Guid Id{ get; set; }
        public DateTime Time;

        public Talon(DateTime time, Patient patient, Specialist specialist)
        {
            Time = time;
            Patient = patient;
            Specialist = specialist;
        }

        public virtual Patient Patient { get; set; }
        public virtual Specialist Specialist { get; set; }
    }


}
