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
    public partial class DocDelete : Form
    {
        public DocDelete()
        {
            InitializeComponent();
            Utilites = new Utilites(this);
        }
        SpecialistRepository Repository = new SpecialistRepository();
        Utilites Utilites;
        docIDValidator validator = new docIDValidator();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            var validResalt = validator.Validate(idBox.Text);
            if (validResalt.Valid)
            {
                var specialist = Repository.FindDocByID(ushort.Parse(idBox.Text));
                if (specialist!=null)
                {
                Repository.Delete(specialist.Id);
                Utilites.NextForm(new DocAutorizationSelector());
                }
                else
                    MessageBox.Show("Специалист с данным идентификатором не найден");

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
