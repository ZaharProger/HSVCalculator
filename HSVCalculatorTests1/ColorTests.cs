using Microsoft.VisualStudio.TestTools.UnitTesting;
using HSVCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSVCalculator.Tests
{
    [TestClass()]
    public class ColorTests
    {
        [TestMethod()]
        public void ConvertToRGBTest()
        {
            Color color = new Color();
            color.setHue(60);
            color.setSaturation(100);
            color.setBrightness(50);
            color.ConvertToRGB();
            Assert.AreEqual(128, color.getRed());
            Assert.AreEqual(128, color.getGreen());
            Assert.AreEqual(0, color.getBlue());
        }

        [TestMethod()]
        public void ConvertToHSVTest()
        {
            Color color = new Color();
            color.setRed(128);
            color.setGreen(128);
            color.setBlue(0);
            color.ConvertToHSV();
            Assert.AreEqual(60, color.getHue());
            Assert.AreEqual(100, color.getSaturation());
            Assert.AreEqual(50, color.getBrightness());
        }
    }
}