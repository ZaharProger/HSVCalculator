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

        //Копирование в буфер обмена HSV
        private void copyHSVButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(color.getHue() + " " + color.getSaturation() + " " + color.getBrightness());
            MessageBox.Show("Данные о цвете успешно скопированы в буфер обмена!");
        }

        //Копирование в буфер обмена RGB
        private void copyRGBButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(color.getRed() + " " + color.getGreen() + " " + color.getBlue());
            MessageBox.Show("Данные о цвете успешно скопированы в буфер обмена!");
        }

        //Установка параметра hue
        private void hueSetter_Scroll(object sender, EventArgs e)
        {
            color.setHue(hueSetter.Value);
            hueValue.Text = color.getHue().ToString();
        }

        //Установка параметра saturation
        private void saturationSetter_Scroll(object sender, EventArgs e)
        {
            color.setSaturation(saturationSetter.Value);
            saturationValue.Text = color.getSaturation().ToString();
        }

        //Установка параметра brightness
        private void brightnessSetter_Scroll(object sender, EventArgs e)
        {
            color.setBrightness(brightnessSetter.Value);
            brightnessValue.Text = color.getBrightness().ToString();
        }

        //Установка красного цвета
        private void redSetter_Scroll(object sender, EventArgs e)
        {
            color.setRed(redSetter.Value);
            redValue.Text = color.getRed().ToString();
        }

        //Установка зеленого цвета
        private void greenSetter_Scroll(object sender, EventArgs e)
        {
            color.setGreen(greenSetter.Value);
            greenValue.Text = color.getGreen().ToString();
        }

        //Установка синего цвета
        private void blueSetter_Scroll(object sender, EventArgs e)
        {
            color.setBlue(blueSetter.Value);
            blueValue.Text = color.getBlue().ToString();
        }

        //Визуализация цвета
        private void colorVisualisation_Paint(object sender, PaintEventArgs e)
        {
            Graphics drawer = e.Graphics;
            drawer.FillRectangle(Brushes., colorVisualisation.Left, colorVisualisation.Top, colorVisualisation.Right, colorVisualisation.Bottom);
        }
    }
}
