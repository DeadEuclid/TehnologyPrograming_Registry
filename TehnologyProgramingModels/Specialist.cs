using LiteDB;
using System;

namespace TehnologyProgramingModels
{
    public class Specialist : IAuthorizable
    {
        public Specialist(ushort id, string fio, string specialisation)
        {
            Identificator = id;
            FIO = fio;
            Specialisation = specialisation;
        }
        public Specialist() { }
        public string Title => $"{FIO} ({Specialisation})";
        public Guid Id { get; set; }
        public ushort Identificator { get; set; }
        public string FIO { get; set; }
        public string Specialisation { get; set; }
    }


}
