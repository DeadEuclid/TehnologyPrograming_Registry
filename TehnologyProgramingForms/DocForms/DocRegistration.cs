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
    public partial class DocRegistration : Form
    {
        public DocRegistration()
        {
            InitializeComponent();
            Utilites = new Utilites(this);
        }
        SpecialistRepository Repository = new SpecialistRepository();
        Utilites Utilites;
        SpecialistValidator validator = new SpecialistValidator();
        docIDValidator IDValidator = new docIDValidator();
        FIOValidator FIOValidator = new FIOValidator();


        private void DocRegistration_Load(object sender, EventArgs e)
        {

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {


            var validIdResalt = IDValidator.Validate(FIOBox.Text);
            var validFIOResalt = FIOValidator.Validate(specialisationBox.Text);
            if (validIdResalt.Valid)
            {
                if (validFIOResalt.Valid)
                {
                    var specialist = new Specialist(Repository.GetNewDocID(), FIOBox.Text, specialisationBox.Text);
                    Repository.Registration(specialist);
                    MessageBox.Show("Вы успешно зарегистрированны. Ваш идентификатор входа:" + specialist.Identificator);
                    Utilites.NextForm(new DocAutorizationSelector());
                }
                else
                {
                    MessageBox.Show("ФИО содержит недопустимые символы");
                }
            }
            else
                MessageBox.Show("Ваш идентификатор содержит недопустимые символы или более 5 знаков");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilites.NextForm(new DocAutorizationSelector());
        }
    }
}
