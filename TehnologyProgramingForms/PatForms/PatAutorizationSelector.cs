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
    public partial class PatAutorizationSelector : Form
    {
        public PatAutorizationSelector()
        {
            InitializeComponent();
            Utilites = new Utilites(this);
        }
        Utilites Utilites;
        private void InputButton_Click(object sender, EventArgs e)
        {
            Utilites.NextForm(new PatAutorization());
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            Utilites.NextForm(new PatRegistration());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Utilites.NextForm(new PatDelete());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
