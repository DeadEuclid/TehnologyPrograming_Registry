using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TehnologyProgramingReposytory.ConcreteRepository;
using Validatores;

namespace TehnologyProgramingForms
{
    public partial class PatDelete : Form
    {
        public PatDelete()
        {
            Utilites = new Utilites(this);
            InitializeComponent();
        }
        PatientRepository Repository = new PatientRepository();
        Utilites Utilites;
        SNILSValidator validator = new SNILSValidator();
        private void button1_Click(object sender, EventArgs e)
        {
            Utilites.NextForm(new PatAutorizationSelector());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var validResalt = validator.Validate(SNILSBox.Text);
            if (validResalt.Valid)
            {
                var patient = Repository.FindBySNILS(SNILSBox.Text);
                if (patient!=null)
                {
                Repository.Delete(patient.Id);
                Utilites.NextForm(new PatAutorizationSelector());
                }
                else
                    MessageBox.Show("Пациент с указанным СНИЛС не найден");

            }
            else
            {
                MessageBox.Show("СНИЛС не коректен");
            }
        }
    }
}
