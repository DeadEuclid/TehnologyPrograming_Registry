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

namespace TehnologyProgramingForms.PatForms
{
    public partial class MainPatForm : Form
    {
        public MainPatForm()
        {
            InitializeComponent();
            Utilites = new Utilites(this);
            FIOlabel.Text = Patient.FIO;
            SNILSlabel.Text = Patient.SNILS;

        }
        Utilites Utilites;
        Patient Patient=Session.Auth as Patient;
        TalonRepository Repository = new TalonRepository();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MainPatForm_Load(object sender, EventArgs e)
        {
            talonGrid.DataSource = new BindingList<GridRowTalons>();
            var bind = new BindingList<GridRowTalons>
                (Repository.GetPatientTalons(Patient).Select(GridRowTalons.Create).ToList());
        }

        private void AddTalonButton_Click(object sender, EventArgs e)
        {
            Utilites.NextForm(new AddTalon());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    public class GridRowTalons
    {

        public GridRowTalons(int number, Talon talon)
        {
            this.number = number.ToString();
            this.fio = talon.Specialist.FIO;
            var date = talon.Time;
            this.data = date.Date.ToString();
            this.time = String.Format("{0}:{1}", talon.Time.Hour, talon.Time.Minute);
        }
        public static GridRowTalons Create(Talon talon, int index) => new GridRowTalons(index, talon);
        [DisplayName("№")]
        public string number { get; set; }
        [DisplayName("ФИО")]
        public string fio { get; set; }
        [DisplayName("Дата")]
        public string data { get; set; }
        [DisplayName("Время")]
        public string time { get; set; }


    }
}
