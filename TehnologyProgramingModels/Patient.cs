using System;

namespace TehnologyProgramingModels
{
    public class Patient:IAuthorizable
    {
        public Patient(string fio,string snils)
        {
            FIO = fio;
            SNILS = snils;
        }
        public Guid Id { get; set; }
        public string FIO { get; set; }
        public string SNILS { get; set; }
        
    }


}
