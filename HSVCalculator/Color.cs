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
            public float hue;
            public float saturation;
            public float brightness;
        }
        struct RGB
        {
            public float red;
            public float green;
            public float blue;
        }
        private HSV hsv;
        private RGB rgb;
        private byte type;

        public Color()
        {
            hsv.hue = 0;
            hsv.saturation = 0;
            hsv.brightness = 0;
            rgb.red = 0;
            rgb.green = 0;
            rgb.blue = 0;
            type = 0;
        }

        #region[сеттеры]
        public void setType(byte type)
        {
            this.type = type;
        }

        public void setHue(float value)
        {
            hsv.hue = value;
        }

        public void setSaturation(float value)
        {
            hsv.saturation = value;
        }

        public void setBrightness(float value)
        {
            hsv.brightness = value;
        }


        public void setRed(float value)
        {
            rgb.red = value;
        }

        public void setGreen(float value)
        {
            rgb.green = value;
        }

        public void setBlue(float value)
        {
            rgb.blue = value;
        }
        #endregion[сеттеры]

        #region[геттеры]
        public byte getType()
        {
            return type;
        }

        public float getHue()
        {
            return hsv.hue;
        }

        public float getSaturation()
        {
            return hsv.saturation;
        }

        public float getBrightness()
        {
            return hsv.brightness;
        }

        public float getRed()
        {
            return rgb.red;
        }

        public float getGreen()
        {
            return rgb.green;
        }

        public float getBlue()
        {
            return rgb.blue;
        }
        #endregion[геттеры]
    }
}
