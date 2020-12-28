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
using Validatores;

namespace TehnologyProgramingForms
{
    public partial class PatRegistration : Form
    {
        public PatRegistration()
        {
            InitializeComponent();
            Utilites = new Utilites(this);
        }
        PatientRepository Repository = new PatientRepository();
        Utilites Utilites;
        PatientValidator validator = new PatientValidator();
        SNILSValidator SnilsValidator = new SNILSValidator();
        FIOValidator FIOValidator = new FIOValidator();
        private void RegistrationButton_Click(object sender, EventArgs e)
        {


            var SnilsValidResalt = SnilsValidator.Validate(SNILSBox.Text);
            var FioValidResalt = FIOValidator.Validate(FIOBox.Text);
            if (SnilsValidResalt.Valid)
            {
                if (FioValidResalt.Valid)
                {
                    if (Repository.Registration(FIOBox.Text, SNILSBox.Text))
                    {
                        MessageBox.Show("Вы успешно зарегистрированны");
                        Utilites.NextForm(new PatAutorizationSelector());
                    }
                    else
                    {
                        MessageBox.Show("Этот СНИЛС уже есть в базе");
                        Utilites.NextForm(new PatAutorizationSelector());
                    }
                }
                else
                    MessageBox.Show("ФИО содержит недопустимые символы");

            }
            else
            {
                MessageBox.Show("СНИЛС не коректен") ;
            }

            
            
         }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilites.NextForm(new RoleChoise());
        }
    }
}
