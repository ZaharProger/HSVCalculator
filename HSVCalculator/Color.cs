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
            double hueRemainder = hsv.hue / 60 % 6;
            double brightnessMin = ((100 - hsv.saturation) * hsv.brightness) / 100;
            double delta = (hsv.brightness - brightnessMin) * (hsv.hue % 60 / 60);
            double brightnessInc = brightnessMin + delta;
            double brightnessDec = hsv.brightness - delta;
            switch (hueRemainder)
            {
                case 0:
                    rgb.red = hsv.brightness;
                    rgb.green = brightnessInc;
                    rgb.blue = brightnessMin;
                    break;
                case 1:
                    rgb.red = brightnessDec;
                    rgb.green = hsv.brightness;
                    rgb.blue = brightnessMin;
                    break;
                case 2:
                    rgb.red = brightnessMin;
                    rgb.green = hsv.brightness;
                    rgb.blue = brightnessInc;
                    break;
                case 3:
                    rgb.red = brightnessMin;
                    rgb.green = brightnessDec;
                    rgb.blue = hsv.brightness;
                    break;
                case 4:
                    rgb.red = brightnessInc;
                    rgb.green = brightnessMin;
                    rgb.blue = hsv.brightness;
                    break;
                case 5:
                    rgb.red = hsv.brightness;
                    rgb.green = brightnessMin;
                    rgb.blue = brightnessDec;
                    break;
            }

            rgb.red *= 2.55;
            rgb.green *= 2.55;
            rgb.blue *= 2.55;
        }

        public void ConvertToHSV()
        {
            double max = 0;
            double min = 0;
            if (rgb.red % 1 > rgb.green % 1 && rgb.red % 1 > rgb.blue % 1)
                max = rgb.red;
            else if (rgb.green % 1 > rgb.red % 1 && rgb.green % 1 > rgb.blue % 1)
                max = rgb.green;
            else if (rgb.blue % 1 > rgb.green % 1 && rgb.blue % 1 > rgb.red % 1)
                max = rgb.blue;
            if (rgb.red % 1 < rgb.green % 1 && rgb.red % 1 < rgb.blue % 1)
                min = rgb.red;
            else if (rgb.green % 1 < rgb.red % 1 && rgb.green % 1 < rgb.blue % 1)
                min = rgb.green;
            else if (rgb.blue % 1 < rgb.green % 1 && rgb.blue % 1 < rgb.red % 1)
                min = rgb.blue;

            if (max != min)
            {
                if (max == rgb.red && rgb.green >= rgb.blue)
                    hsv.hue = 60 * ((rgb.green - rgb.blue) / (max - min));
                else if (max == rgb.red && rgb.green < rgb.blue)
                    hsv.hue = 60 * ((rgb.green - rgb.blue) / (max - min)) + 360;
                else if (max == rgb.green)
                    hsv.hue = 60 * ((rgb.blue - rgb.red) / (max - min)) + 120;
                else if (max == rgb.blue)
                    hsv.hue = 60 * ((rgb.red - rgb.green) / (max - min)) + 240;

                if (max == 0)
                    hsv.saturation = 0;
                else
                    hsv.saturation = 1 - (min / max);

                hsv.brightness = max;
            }
        }
    }
}
