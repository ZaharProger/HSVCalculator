using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSVCalculator
{
    public class Color
    {
        struct HSV
        {
            public double hue;
            public double saturation;
            public double brightness;
        }
        struct RGB
        {
            public double red;
            public double green;
            public double blue;
        }
        private HSV hsv;
        private RGB rgb;

        public Color()
        {
            hsv.hue = 0;
            hsv.saturation = 0;
            hsv.brightness = 0;
            rgb.red = 0;
            rgb.green = 0;
            rgb.blue = 0;
        }

        #region[сеттеры]

        public void setHue(double value)
        {
            hsv.hue = value;
        }

        public void setSaturation(double value)
        {
            hsv.saturation = value;
        }

        public void setBrightness(double value)
        {
            hsv.brightness = value;
        }


        public void setRed(double value)
        {
            rgb.red = value;
        }

        public void setGreen(double value)
        {
            rgb.green = value;
        }

        public void setBlue(double value)
        {
            rgb.blue = value;
        }
        #endregion[сеттеры]

        #region[геттеры]

        public double getHue()
        {
            return hsv.hue;
        }

        public double getSaturation()
        {
            return hsv.saturation;
        }

        public double getBrightness()
        {
            return hsv.brightness;
        }

        public double getRed()
        {
            return rgb.red;
        }

        public double getGreen()
        {
            return rgb.green;
        }

        public double getBlue()
        {
            return rgb.blue;
        }
        #endregion[геттеры]

        public void ConvertToRGB()
        {
            double chroma = hsv.brightness / 100 * hsv.saturation / 100;
            double x = chroma * (1 - Math.Abs(hsv.hue / 60 % 2 - 1));
            double delta = hsv.brightness / 100 - chroma;

            if (hsv.hue >= 0 && hsv.hue < 60)
            {
                rgb.red = chroma;
                rgb.green = x;
                rgb.blue = 0;
            }
            else if (hsv.hue >= 60 && hsv.hue < 120)
            {
                rgb.red = x;
                rgb.green = chroma;
                rgb.blue = 0;
            }
            else if (hsv.hue >= 120 && hsv.hue < 180)
            {
                rgb.red = 0;
                rgb.green = chroma;
                rgb.blue = x;
            }
            else if (hsv.hue >= 180 && hsv.hue < 240)
            {
                rgb.red = 0;
                rgb.green = x;
                rgb.blue = chroma;
            }
            else if (hsv.hue >= 240 && hsv.hue < 300)
            {
                rgb.red = x;
                rgb.green = 0;
                rgb.blue = chroma;
            }
            else if (hsv.hue >= 300 && hsv.hue < 360)
            {
                rgb.red = chroma;
                rgb.green = 0;
                rgb.blue = x;
            }

            rgb.red += delta;
            rgb.green += delta;
            rgb.blue += delta;

            rgb.red *= 255;
            rgb.green *= 255;
            rgb.blue *= 255;

            rgb.red = Math.Round(rgb.red);
            rgb.green = Math.Round(rgb.green);
            rgb.blue = Math.Round(rgb.blue);
        }

        public void ConvertToHSV()
        {
            double max = Math.Max(Math.Max(rgb.red / 255, rgb.green / 255), rgb.blue / 255);
            double min = Math.Min(Math.Min(rgb.red / 255, rgb.green / 255), rgb.blue / 255);
            double delta = max - min;

            if (delta != 0)
            {
                if (max == rgb.red / 255)
                    hsv.hue = 60 * ((rgb.green / 255 - rgb.blue / 255) / delta % 6);
                else if (max == rgb.green / 255)
                    hsv.hue = 60 * (((rgb.blue / 255 - rgb.red / 255) / delta) + 2);
                else if (max == rgb.blue / 255)
                    hsv.hue = 60 * (((rgb.red / 255 - rgb.green / 255) / delta) + 4);

                if (max != 0)
                    hsv.saturation = delta / max * 100;
                else
                    hsv.saturation = 0;               
            }
            else
            {
                hsv.hue = 0;
                hsv.saturation = 0;
            }
            hsv.brightness = max * 100;

            if (hsv.hue < 0)
                hsv.hue += 360;

            hsv.hue = Math.Round(hsv.hue);
            hsv.saturation = Math.Round(hsv.saturation);
            hsv.brightness = Math.Round(hsv.brightness);
        }      
    }
}
