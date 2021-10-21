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
        private RGB rgb;
        private HSV hsv;
        public MainForm()
        {
            InitializeComponent();

            rgb = new RGB(Properties.Settings.Default.red, Properties.Settings.Default.green, Properties.Settings.Default.blue);
            hsv = new HSV(Properties.Settings.Default.hue, Properties.Settings.Default.saturation, Properties.Settings.Default.brightness);

            hueSetter.SetRange(0, 360);
            hueSetter.Value = (int)Properties.Settings.Default.hue;
            hueValue.Text = Properties.Settings.Default.hue.ToString();

            saturationSetter.SetRange(0, 100);
            saturationSetter.Value = (int)Properties.Settings.Default.saturation;
            saturationValue.Text = Properties.Settings.Default.saturation.ToString();

            brightnessSetter.SetRange(0, 100);
            brightnessSetter.Value = (int)Properties.Settings.Default.brightness;
            brightnessValue.Text = Properties.Settings.Default.brightness.ToString();

            redSetter.SetRange(0, 255);
            redSetter.Value = (int)Properties.Settings.Default.red;
            redValue.Text = Properties.Settings.Default.red.ToString();

            greenSetter.SetRange(0, 255);
            greenSetter.Value = (int)Properties.Settings.Default.green;
            greenValue.Text = Properties.Settings.Default.green.ToString();

            blueSetter.SetRange(0, 255);
            blueSetter.Value = (int)Properties.Settings.Default.blue;
            blueValue.Text = Properties.Settings.Default.blue.ToString();

            updateColor(Properties.Settings.Default.red, Properties.Settings.Default.green, Properties.Settings.Default.blue);
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
            hsv.SetHue(hueSetter.Value);
            hueValue.Text = hsv.GetHue().ToString();         
            rgb = hsv.Convert();
            updateTrackBarRGB(rgb.GetRed(), rgb.GetGreen(), rgb.GetBlue());
            updateColor(rgb.GetRed(), rgb.GetGreen(), rgb.GetBlue());
        }

        //Установка параметра saturation
        private void saturationSetter_Scroll(object sender, EventArgs e)
        {
            hsv.SetSaturation(saturationSetter.Value);
            saturationValue.Text = hsv.GetSaturation().ToString();
            rgb = hsv.Convert();
            updateTrackBarRGB(rgb.GetRed(), rgb.GetGreen(), rgb.GetBlue());
            updateColor(rgb.GetRed(), rgb.GetGreen(), rgb.GetBlue());
        }

        //Установка параметра brightness
        private void brightnessSetter_Scroll(object sender, EventArgs e)
        {
            hsv.SetBrightness(brightnessSetter.Value);
            brightnessValue.Text = hsv.GetBrightness().ToString();
            rgb = hsv.Convert();
            updateTrackBarRGB(rgb.GetRed(), rgb.GetGreen(), rgb.GetBlue());
            updateColor(rgb.GetRed(), rgb.GetGreen(), rgb.GetBlue());
        }

        //Установка красного цвета
        private void redSetter_Scroll(object sender, EventArgs e)
        {
            rgb.SetRed(redSetter.Value);
            redValue.Text = rgb.GetRed().ToString();
            hsv = rgb.Convert();
            updateTrackBarHSV(hsv.GetHue(), hsv.GetSaturation(), hsv.GetBrightness());
            updateColor(rgb.GetRed(), rgb.GetGreen(), rgb.GetBlue());
        }

        //Установка зеленого цвета
        private void greenSetter_Scroll(object sender, EventArgs e)
        {
            rgb.SetGreen(greenSetter.Value);
            greenValue.Text = rgb.GetGreen().ToString();
            hsv = rgb.Convert();
            updateTrackBarHSV(hsv.GetHue(), hsv.GetSaturation(), hsv.GetBrightness());
            updateColor(rgb.GetRed(), rgb.GetGreen(), rgb.GetBlue());
        }

        //Установка синего цвета
        private void blueSetter_Scroll(object sender, EventArgs e)
        {
            rgb.SetBlue(blueSetter.Value);
            blueValue.Text = rgb.GetBlue().ToString();
            hsv = rgb.Convert();
            updateTrackBarHSV(hsv.GetHue(), hsv.GetSaturation(), hsv.GetBrightness());
            updateColor(rgb.GetRed(), rgb.GetGreen(), rgb.GetBlue());
        }

        //Визуализация цвета
        private void updateColor(double red, double green, double blue)
        {
            colorVisualisation.BackColor = Color.FromArgb((int)red, (int)green, (int)blue);
        }

        //Синхронизация каналов RGB
        private void updateTrackBarRGB(double red, double green, double blue)
        {
            redSetter.Value = (int)red;
            redValue.Text = ((int)red).ToString();
            greenSetter.Value = (int)green;
            greenValue.Text = ((int)green).ToString();
            blueSetter.Value = (int)blue;
            blueValue.Text = ((int)blue).ToString();
        }

        //Синхронизация каналов HSV
        private void updateTrackBarHSV(double hue, double saturation, double brightness)
        {
            hueSetter.Value = (int)hue;
            hueValue.Text = ((int)hue).ToString();
            saturationSetter.Value = (int)saturation;
            saturationValue.Text = ((int)saturation).ToString();
            brightnessSetter.Value = (int)brightness;
            brightnessValue.Text = ((int)brightness).ToString();
        }

        //Сохранение данных на форме
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.hue = hsv.GetHue();
            Properties.Settings.Default.saturation = hsv.GetSaturation();
            Properties.Settings.Default.brightness = hsv.GetBrightness();
            Properties.Settings.Default.red = rgb.GetRed();
            Properties.Settings.Default.green = rgb.GetGreen();
            Properties.Settings.Default.blue = rgb.GetBlue();
            Properties.Settings.Default.Save();
        }
    }
}
