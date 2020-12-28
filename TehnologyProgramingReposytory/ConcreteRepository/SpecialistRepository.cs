using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TehnologyProgramingModels;

namespace TehnologyProgramingReposytory.ConcreteRepository
{
    public class SpecialistRepository : BaseRepository<Specialist>
    {
        public SpecialistRepository() : base()
        {

        }
       
        public Specialist FindDocByID(ushort id)
        {
            return Collection.FindOne((doc) => doc.Identificator == id);
        }
        public ushort Registration(Specialist specialist)
        {
            Create(specialist);
            return specialist.Identificator;
        }
        public Specialist Autorization(ushort id)
        {
            return FindDocByID(id);
        }
        public ushort GetNewDocID()
        {
            var rnd = new Random();
            ushort id;
            do
                id = (ushort)rnd.Next(65535);
             while (Collection.FindOne(doc => doc.Identificator == id) != null);
            
            return id;
        }
    }
}
