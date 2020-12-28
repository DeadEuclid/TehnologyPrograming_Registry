using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TehnologyProgramingModels;
using TehnologyProgramingReposytory.ConcreteRepository;

namespace TehnologyProgramingForms.MangegerForms
{
    public partial class ManagerMainForm : Form
    {
        public ManagerMainForm()
        {
            InitializeComponent();
        }
        SpecialistRepository Repository = new SpecialistRepository();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManagerMainForm_Load(object sender, EventArgs e)
        {
            specialistsGrid.DataSource = new BindingList<GridRowSpecialistWork>
                (Repository.ReadAll().Select(GridRowSpecialistWork.Create).ToList());
        }
    }
    public class GridRowSpecialistWork
    {
        TalonRepository talonRepository = new TalonRepository();
        public GridRowSpecialistWork(int number, Specialist doc)
        {
            this.Number = number.ToString();
            this.fio = doc.FIO;
            this.specialisation = doc.Specialisation;
            var docTalons = talonRepository.GetSpecialistTalons(doc);
            this.countTalonOfMounth = talonRepository.GetToMonthTalons(docTalons).Count().ToString();
            this.countTalonOfYear = talonRepository.GetToMonthTalons(docTalons).Count().ToString();
        }
        public static GridRowSpecialistWork Create(Specialist spec, int index) => new GridRowSpecialistWork(index, spec);

        [DisplayName("№")]
        public string Number { get; set; }

        [DisplayName("ФИО")]
        public string fio { get; set; }

        [DisplayName("Специализация")]
        public string specialisation { get; set; }
        [DisplayName("Приёмов за месяц")]
        public string countTalonOfMounth { get; set; }
        [DisplayName("Приёмов за год")]

        public string countTalonOfYear { get; set; }
    }
  
}
