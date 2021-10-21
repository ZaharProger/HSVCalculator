using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSVCalculator
{
    class HSV : Convertable<RGB>
    {
        private double hue;
        private double saturation;
        private double brightness;

        public HSV()
        {
            hue = 0;
            saturation = 0;
            brightness = 0;
        }

        public void SetHue(double value)
        {
            hue = value;
        }

        public void SetSaturation(double value)
        {
            saturation = value;
        }

        public void SetBrightness(double value)
        {
            brightness = value;
        }

        public double GetHue()
        {
            return hue;
        }

        public double GetSaturation()
        {
            return saturation;
        }

        public double GetBrightness()
        {
            return brightness;
        }

        public void AddHue(double value)
        {
            hue += value;
        }

        public void AddSaturation(double value)
        {
            saturation += value;
        }

        public void AddBrightness(double value)
        {
            brightness += value;
        }

        public RGB Convert()
        {
            RGB rgb = new RGB();
            double chroma = brightness / 100 * saturation / 100;
            double x = chroma * (1 - Math.Abs(hue / 60 % 2 - 1));
            double delta = brightness / 100 - chroma;

            if (hue >= 0 && hue < 60)
            {
                rgb.SetRed(chroma);
                rgb.SetGreen(x);
                rgb.SetBlue(0);
            }
            else if (hue >= 60 && hue < 120)
            {
                rgb.SetRed(x);
                rgb.SetGreen(chroma);
                rgb.SetBlue(0);
            }
            else if (hue >= 120 && hue < 180)
            {
                rgb.SetRed(0);
                rgb.SetGreen(chroma);
                rgb.SetBlue(x);
            }
            else if (hue >= 180 && hue < 240)
            {
                rgb.SetRed(0);
                rgb.SetGreen(x);
                rgb.SetBlue(chroma);
            }
            else if (hue >= 240 && hue < 300)
            {
                rgb.SetRed(x);
                rgb.SetGreen(0);
                rgb.SetBlue(chroma);
            }
            else if (hue >= 300 && hue < 360)
            {
                rgb.SetRed(chroma);
                rgb.SetGreen(0);
                rgb.SetBlue(x);
            }

            rgb.AddRed(delta);
            rgb.AddGreen(delta);
            rgb.AddBlue(delta);

            rgb.SetRed(rgb.GetRed() * 255);
            rgb.SetGreen(rgb.GetGreen() * 255);
            rgb.SetBlue(rgb.GetBlue() * 255);

            rgb.SetRed(Math.Round(rgb.GetRed()));
            rgb.SetGreen(Math.Round(rgb.GetGreen()));
            rgb.SetBlue(Math.Round(rgb.GetBlue()));

            return rgb;
        }
    }
}
