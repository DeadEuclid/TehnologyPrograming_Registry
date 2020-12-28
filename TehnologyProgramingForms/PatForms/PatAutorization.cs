using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TehnologyProgramingForms.PatForms;
using TehnologyProgramingModels;
using TehnologyProgramingReposytory.ConcreteRepository;
using Validatores;

namespace TehnologyProgramingForms
{
    public partial class PatAutorization : Form
    {
        public PatAutorization()
        {
            InitializeComponent();
            Utilites = new Utilites(this);
        }
        Utilites Utilites;
        PatientRepository Repository = new PatientRepository();
        SNILSValidator validator = new SNILSValidator();

        private void autorizeButton_Click(object sender, EventArgs e)
        {
            var validResalt = validator.Validate(SNILSBox.Text);
            if (validResalt.Valid)
            {
                var patient = Repository.Autrorization(SNILSBox.Text);
                if (patient != null)
                {
                    Session.Auth = patient;
                    Utilites.NextForm(new MainPatForm());
                }
                else
                    MessageBox.Show("Пациент с указанным СНИЛС не найден");

            }
            else
            {
                MessageBox.Show("СНИЛС не коректен");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilites.NextForm(new PatAutorizationSelector());
        }
    }
}
