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

namespace TehnologyProgramingForms.DocForms
{
    public partial class MainDocForm : Form
    {
        public MainDocForm()
        {
            InitializeComponent();
        }
        TalonRepository Repository = new TalonRepository();
        Specialist Specialist = (Session.Auth as Specialist);
        private void MainDocForm_Load(object sender, EventArgs e)
        {
            FIOlabel.Text = Specialist.FIO;
            IdLabel.Text = Specialist.Id.ToString();

            talonGrid.DataSource=new BindingList<GridRowPatientToday>();
            var bind = new BindingList<GridRowPatientToday>
                (Repository.GetToDayTalons(Repository.GetSpecialistTalons(Specialist)).Select(GridRowPatientToday.Create).ToList());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


    public class GridRowPatientToday
    {
        public GridRowPatientToday(int number, Talon talon)
        {
            this.number = number.ToString();
            this.fio = talon.Patient.FIO;
            var date = talon.Time;
            this.data = date.Date.ToString();
            this.time = String.Format("{0}:{1}", talon.Time.Hour, talon.Time.Minute);
        }
        public static GridRowPatientToday Create(Talon talon, int index) => new GridRowPatientToday(index, talon);
        [DisplayName("№ ")]
        public string number { get; set; }
        [DisplayName("ФИО")]
        public string fio { get; set; }
        [DisplayName("Дата")]
        public string data { get; set; }
        [DisplayName("Время")]
        public string time { get; set; }


    }

}
