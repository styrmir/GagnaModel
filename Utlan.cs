using System;

namespace StarfskerfisGatt.Models.Danarbu.Fjarmalafyrirtaeki
{
    public class Utlan
    {
        public TegundUtlans Tegund { get; set; }
        public string Lansnumer { get; set; }
        public DateTime Utgafudagur { get; set; }
        public DateTime Lokadags { get; set; }
        public double StadaISK { get; set; }
        public double Vanskil { get; set; }
        public double Heimild { get; set; }
        public double Vextir { get; set; }
        public string Mynt { get; set; }
    }
    public enum TegundUtlans
    {
        Kort,
        OnnurSkuldabref,
        Yfirdrattarlan
    }
}
