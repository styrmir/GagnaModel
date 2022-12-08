using System;

namespace StarfskerfisGatt.Models.Danarbu.Fjarmalafyrirtaeki
{
    public class Innlansreikningur
    {
        public string Banki { get; set; }
        public string Hofudbok { get; set; }
        public string Reikningur { get; set; }
        public double StadaISK { get; set; }
        public double Stada { get; set; }
        public double StadaMedAfollumVoxtum { get; set; }
        public string Mynt { get; set; }
        public string Astand { get; set; }
        public DateTime LogadDags { get; set; }
    }
}
