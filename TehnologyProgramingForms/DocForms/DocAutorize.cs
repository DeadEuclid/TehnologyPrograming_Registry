using Validatores;
using DataUtilites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TehnologyProgramingForms.DocForms;
using TehnologyProgramingModels;
using TehnologyProgramingReposytory.ConcreteRepository;

namespace TehnologyProgramingForms
{
    public partial class DocAutorize : Form
    {
        public DocAutorize()
        {
            InitializeComponent();
            Utilites = new Utilites(this);
        }
        SpecialistRepository repository = new SpecialistRepository();
        Utilites Utilites;
        docIDValidator validator=new docIDValidator();
        private void AutorizeButton_Click(object sender, EventArgs e)
        {
            var validResalt = validator.Validate(IdBox.Text);
            if (validResalt.Valid)
            {
                var specialist = repository.Autorization(ushort.Parse(IdBox.Text));
                if (specialist != null)
                {
                    Session.Auth = specialist;
                    Utilites.NextForm(new MainDocForm());
                }
                else
                    MessageBox.Show("Специалист с данным идентификатором не найден");


            }
            else
            {
                MessageBox.Show("Ваш идентификатор содержит недопустимые символы или более 5 знаков");
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Utilites.NextForm(new DocAutorizationSelector());
        }
    }
}
