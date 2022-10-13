using System;
using System.Collections.Generic;
using System.Text;

namespace KalitimOdev
{
    internal class Televizyon : Urun
    {
        public bool smartTv { get; set; }
        public bool HDMI { get; set; }
        public string ekranBoyutu { get; set; }
    }
}
