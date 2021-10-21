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
        public MainForm()
        {
            InitializeComponent();

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
            Clipboard.SetText(hueSetter.Value + " " + saturationSetter.Value + " " + brightnessSetter.Value);
            MessageBox.Show("Данные о цвете успешно скопированы в буфер обмена!");
        }

        //Копирование в буфер обмена RGB
        private void copyRGBButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(redSetter.Value + " " + greenSetter.Value + " " + blueSetter.Value);
            MessageBox.Show("Данные о цвете успешно скопированы в буфер обмена!");
        }

        //Установка параметра hue
        private void hueSetter_Scroll(object sender, EventArgs e)
        {
            HSV hsv = new HSV();
            hsv.SetHue(hueSetter.Value);
            hueValue.Text = hsv.GetHue().ToString();         
            RGB rgb = hsv.Convert();
            updateTrackBarRGB(rgb);
            updateColor(rgb.GetRed(), rgb.GetGreen(), rgb.GetBlue());
        }

        //Установка параметра saturation
        private void saturationSetter_Scroll(object sender, EventArgs e)
        {
            HSV hsv = new HSV();
            hsv.SetSaturation(saturationSetter.Value);
            saturationValue.Text = hsv.GetSaturation().ToString();
            RGB rgb = hsv.Convert();
            updateTrackBarRGB(rgb);
            updateColor(rgb.GetRed(), rgb.GetGreen(), rgb.GetBlue());
        }

        //Установка параметра brightness
        private void brightnessSetter_Scroll(object sender, EventArgs e)
        {
            HSV hsv = new HSV();
            hsv.SetBrightness(brightnessSetter.Value);
            brightnessValue.Text = hsv.GetBrightness().ToString();
            RGB rgb = hsv.Convert();
            updateTrackBarRGB(rgb);
            updateColor(rgb.GetRed(), rgb.GetGreen(), rgb.GetBlue());
        }

        //Установка красного цвета
        private void redSetter_Scroll(object sender, EventArgs e)
        {
            RGB rgb = new RGB();
            rgb.SetRed(redSetter.Value);
            redValue.Text = rgb.GetRed().ToString();
            HSV hsv = rgb.Convert();
            updateTrackBarHSV(hsv);
            updateColor(hsv.GetHue(), hsv.GetSaturation(), hsv.GetBrightness());
        }

        //Установка зеленого цвета
        private void greenSetter_Scroll(object sender, EventArgs e)
        {
            RGB rgb = new RGB();
            rgb.SetGreen(greenSetter.Value);
            greenValue.Text = rgb.GetGreen().ToString();
            HSV hsv = rgb.Convert();
            updateTrackBarHSV(hsv);
            updateColor(hsv.GetHue(), hsv.GetSaturation(), hsv.GetBrightness());
        }

        //Установка синего цвета
        private void blueSetter_Scroll(object sender, EventArgs e)
        {
            RGB rgb = new RGB();
            rgb.SetBlue(blueSetter.Value);
            blueValue.Text = rgb.GetBlue().ToString();
            HSV hsv = rgb.Convert();
            updateTrackBarHSV(hsv);
            updateColor(hsv.GetHue(), hsv.GetSaturation(), hsv.GetBrightness());
        }

        //Визуализация цвета
        private void updateColor(double red, double green, double blue)
        {
            colorVisualisation.BackColor = Color.FromArgb((int)red, (int)green, (int)blue);
        }

        //Синхронизация каналов RGB
        private void updateTrackBarRGB(RGB rgb)
        {
            redSetter.Value = (int)rgb.GetRed();
            redValue.Text = ((int)rgb.GetRed()).ToString();
            greenSetter.Value = (int)rgb.GetGreen();
            greenValue.Text = ((int)rgb.GetGreen()).ToString();
            blueSetter.Value = (int)rgb.GetBlue();
            blueValue.Text = ((int)rgb.GetBlue()).ToString();
        }

        //Синхронизация каналов HSV
        private void updateTrackBarHSV(HSV hsv)
        {
            hueSetter.Value = (int)hsv.GetHue();
            hueValue.Text = ((int)hsv.GetHue()).ToString();
            saturationSetter.Value = (int)hsv.GetSaturation();
            saturationValue.Text = ((int)hsv.GetSaturation()).ToString();
            brightnessSetter.Value = (int)hsv.GetBrightness();
            brightnessValue.Text = ((int)hsv.GetBrightness()).ToString();
        }
    }
}
