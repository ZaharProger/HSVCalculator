using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSVCalculator
{
    public class RGB : Convertable<HSV>
    {
        private double red;
        private double green;
        private double blue;

        public RGB()
        {
            red = 0;
            green = 0;
            blue = 0;
        }

        public RGB(double red, double green, double blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public void SetRed(double value)
        {
            red = value;
        }

        public void SetGreen(double value)
        {
            green = value;
        }

        public void SetBlue(double value)
        {
            blue = value;
        }

        public double GetRed()
        {
            return red;
        }

        public double GetGreen()
        {
            return green;
        }

        public double GetBlue()
        {
            return blue;
        }

        public void AddRed(double value)
        {
            red += value;
        }

        public void AddGreen(double value)
        {
            green += value;
        }

        public void AddBlue(double value)
        {
            blue += value;
        }

        public HSV Convert()
        {
            HSV hsv = new HSV();
            double max = Math.Max(Math.Max(red / 255, green / 255), blue / 255);
            double min = Math.Min(Math.Min(red / 255, green / 255), blue / 255);
            double delta = max - min;

            if (delta != 0)
            {
                if (max == red / 255)
                    hsv.SetHue(60 * ((green / 255 - blue / 255) / delta % 6));
                else if (max == green / 255)
                    hsv.SetHue(60 * (((blue / 255 - red / 255) / delta) + 2));
                else if (max == blue / 255)
                    hsv.SetHue(60 * (((red / 255 - green / 255) / delta) + 4));

                if (max != 0)
                    hsv.SetSaturation(delta / max * 100);
                else
                    hsv.SetSaturation(0);
            }
            else
            {
                hsv.SetHue(0);
                hsv.SetSaturation(0);
            }
            hsv.SetBrightness(max * 100);

            if (hsv.GetHue() < 0)
                hsv.AddHue(360);

            hsv.SetHue(Math.Round(hsv.GetHue()));
            hsv.SetSaturation(Math.Round(hsv.GetSaturation()));
            hsv.SetBrightness(Math.Round(hsv.GetBrightness()));

            return hsv;
        }
    }
}
