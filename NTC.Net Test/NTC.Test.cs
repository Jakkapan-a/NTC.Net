using NTC.Net;
using System.Diagnostics;
using System.Drawing;

namespace NTC.Net_Test
{
    public class NTC_Test
    {
        private readonly NTCNet ntc;
        public NTC_Test()
        {
            ntc = new NTCNet();
        }
        [Fact]
        public void RGB_to_hex()
        {
            // RGB 
            string hex = ntc.RgbToHex(135,67,99);
            Assert.NotNull(hex);
            Assert.Equal("#874363", hex);
        }
        [Fact]
        public void HEX_to_ntc()
        {
            // RGB 
            string hex = "#874363";
            string[] _name = ntc.Name(hex);
            Assert.NotNull(_name);
            Assert.Equal("Red", _name[3]);
        }

        [Fact]
        public void RGB_to_ntc()
        {
            // RGB
            string[] _name = ntc.Name(ntc.RgbToHex(135, 67, 99));
            Assert.NotNull(_name);
            Assert.Equal("Red", _name[3]);
        }
    }
}