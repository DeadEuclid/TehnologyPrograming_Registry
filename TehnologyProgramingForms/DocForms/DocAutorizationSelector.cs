using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TehnologyProgramingForms
{
    public partial class DocAutorizationSelector : Form
    {
        public DocAutorizationSelector()
        {
            InitializeComponent();
            Utilites = new Utilites(this);
        }
        Utilites Utilites;

        private void InputButton_Click(object sender, EventArgs e)
        {
            Utilites.NextForm(new DocAutorize());
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            Utilites.NextForm(new DocRegistration());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Utilites.NextForm(new DocDelete());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
