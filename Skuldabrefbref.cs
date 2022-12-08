using System;

namespace StarfskerfisGatt.Models.Danarbu.Fjarmalafyrirtaeki
{
    public class Skuldabrefbref
    {
        public TegundBrefs Tegund { get; set; }
        public string Numer { get; set; }
        public DateTime Utgafudagur { get; set; }
        public double Upphafsstada { get; set; }
        public double NustadaISK { get; set; }
        public string Stada { get; set; }
        public string Allsherjaved { get; set; }
        public string LogfraediInnheimta { get; set; }
        public string Mynt { get; set; }

    }

    public enum TegundBrefs
    {
        Tryggingarbref
    }

}
