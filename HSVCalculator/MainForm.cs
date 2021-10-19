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
    public partial class MainForm : Form
    {
        private Color color;
        public MainForm()
        {
            InitializeComponent();
            color = new Color();

            hueSetter.Value = 0;
            hueSetter.SetRange(0, 360);

            saturationSetter.Value = 0;
            saturationSetter.SetRange(0, 100);

            brightnessSetter.Value = 0;
            brightnessSetter.SetRange(0, 100);

            redSetter.Value = 0;
            redSetter.SetRange(0, 255);

            greenSetter.Value = 0;
            greenSetter.SetRange(0, 255);

            blueSetter.Value = 0;
            blueSetter.SetRange(0, 255);
        }

        //Закрытие формы клавишей Escape
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();       
        }

        //Нажатие на кнопку "О программе"
        private void infoButton_Click(object sender, EventArgs e)
        {
            Hide();
            ProgrammeInfo programmeInfo = new ProgrammeInfo();
            programmeInfo.Show();
            
        }

        //Копирование цвета в буффер
        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(color.get);
            MessageBox.Show("Данные о цвете скопированы в буфер обмена!");
        }
    }
}
