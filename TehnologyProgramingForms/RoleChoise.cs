using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TehnologyProgramingForms.MangegerForms;

namespace TehnologyProgramingForms
{
    public partial class RoleChoise : Form
    {
        public RoleChoise()
        {
            InitializeComponent();
            Utilites = new Utilites(this);
        }
        Utilites Utilites;
        private void DocButton_Click(object sender, EventArgs e)
        {
            Utilites.NextForm(new DocAutorizationSelector());
        }

        private void PatButton_Click(object sender, EventArgs e)
        {
            Utilites.NextForm(new PatAutorizationSelector());
        }

        private void ManagerButton_Click(object sender, EventArgs e)
        {
            Utilites.NextForm(new ManagerMainForm());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
