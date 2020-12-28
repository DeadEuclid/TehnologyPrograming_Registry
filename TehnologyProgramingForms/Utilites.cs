using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TehnologyProgramingForms
{
    class Utilites
    {
       public Utilites(Form baseForm)
        {
            BaseForm = baseForm;
        }
        public Form BaseForm;
        public void NextForm(Form baseForm, Form nextForm)
        {
            baseForm.Hide();
            nextForm.Show();
        }

        public void NextForm(Form nextForm)
        {
            NextForm(BaseForm, nextForm);
        }

    }
}
