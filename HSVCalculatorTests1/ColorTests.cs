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
            List<RGB> convertedHSV = new List<RGB>();
            List<HSV> convertedRGB = new List<HSV>();

            for (int i = 0; i < testHSV.Count; ++i)
            {
                convertedHSV.Add(testHSV[i].Convert());
                convertedRGB.Add(testRGB[i].Convert());
            }

            for (int i = 0; i < convertedRGB.Count; ++i)
            {
                Assert.AreEqual(testHSV[i].GetHue(), convertedRGB[i].GetHue());
                Assert.AreEqual(testHSV[i].GetSaturation(), convertedRGB[i].GetSaturation());
                Assert.AreEqual(testHSV[i].GetBrightness(), convertedRGB[i].GetBrightness());
            }
            for (int i = 0; i < convertedHSV.Count; ++i)
            {
                Assert.AreEqual(testRGB[i].GetRed(), convertedHSV[i].GetRed());
                Assert.AreEqual(testRGB[i].GetGreen(), convertedHSV[i].GetGreen());
                Assert.AreEqual(testRGB[i].GetBlue(), convertedHSV[i].GetBlue());
            }
        }
    }
}