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
using TehnologyProgramingReposytory;
using TehnologyProgramingReposytory.ConcreteRepository;

namespace TehnologyProgramingForms.PatForms
{
    public partial class AddTalon : Form
    {
        SpecialistRepository DocRepository = new SpecialistRepository();
        TalonRepository TalonRepository = new TalonRepository();
        Utilites Utilites;
        public AddTalon()
        {
            InitializeComponent();
            Utilites = new Utilites(this);
            specialistBox.DataSource = DocRepository.ReadAll();
            specialistBox.DisplayMember = "Title";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetTalonButton_Click(object sender, EventArgs e)
        {
            var date = dateTime.Value;
            var hours = (int)HousUpDown.Value;
            var minutes = (int)minuteUpDown.Value;
            var time = new DateTime(date.Date.Year, date.Date.Month, date.Date.Day, hours, minutes, 0);
            var talon = new Talon(time, Session.Auth as Patient, (specialistBox.SelectedItem as Specialist));
            if (TalonRepository.Create(talon) == TalonAddStatus.Created)
            {
                MessageBox.Show("Вы зписаны на приём");
                Utilites.NextForm(new MainPatForm());
            }
            else if (TalonRepository.Create(talon) == TalonAddStatus.PatientBusy)
                MessageBox.Show("Вы уже записаны на приём на это время");
            else if (TalonRepository.Create(talon) == TalonAddStatus.SpecialistBusy)
            {
                MessageBox.Show("Данный специалист не сможет принять вас в это время");
            }

        }

        private void AddTalon_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilites.NextForm(new MainPatForm());
        }
    }

}
