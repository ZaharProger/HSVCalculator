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
        public void ConvertationTest()
        {
            List<HSV> testHSV = new List<HSV>()
            {
                new HSV(0, 0, 0), new HSV(0, 0,100), new HSV(0, 100, 100),
                new HSV(300, 100, 100), new HSV(60, 100, 50), new HSV(0, 100, 50) 
            };
            List<RGB> testRGB = new List<RGB>()
            {
                new RGB(0, 0, 0), new RGB(255, 255, 255), new RGB(255, 0 ,0),
                new RGB(255, 0, 255), new RGB(128, 128, 0), new RGB(128, 0, 0)
            };
            short k = 0;
            for (int i = 0; i < testHSV.Count; ++i)
            {
                RGB convertedHSV = testHSV[i].Convert();
                HSV convertedRGB = testRGB[i].Convert();
                if (testRGB[i].GetRed() == convertedHSV.GetRed() && testRGB[i].GetGreen() == convertedHSV.GetGreen() && testRGB[i].GetBlue() == convertedHSV.GetBlue())
                    ++k;
                if (testHSV[i].GetHue() == convertedRGB.GetHue() && testHSV[i].GetSaturation() == convertedRGB.GetSaturation() && testHSV[i].GetBrightness() == convertedRGB.GetBrightness())
                    ++k;
            }
            
            Assert.AreEqual(12, k);
        }
    }
}