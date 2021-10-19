using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSVCalculator
{
    public partial class ProgrammeInfo : Form
    {
        public ProgrammeInfo()
        {
            InitializeComponent();
        }

        //Закрытие формы клавишей Escape
        private void ProgrammeInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        //Открытие скрытой формы
        private void ProgrammeInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form hiddenForm = Application.OpenForms[0];
            hiddenForm.Show();
        }
    }
}
