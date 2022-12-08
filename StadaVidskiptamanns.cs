using System;

namespace StarfskerfisGatt.Models.Danarbu.Fjarmalafyrirtaeki
{
    public class StadaVidskiptamanns
    {
        public string Kennitala { get; set; }
        public DateTime KeyrsluDags { get; set; }
        public DateTime DagsetningYfirlits { get; set; }
        public Innlansreikningur[] Innlansreikningar { get; set; }
        public Sjalfskuldarabyrgd[] Sjalfskuldarabyrgd { get; set; }
        public Skuldabrefbref[] Tryggingarbref { get; set; }
        public Skuldabrefbref[] AbyrgdVegna3jaAdila { get; set; }
        public Utlan[] Utlan { get; set; }
        public Geymsluholf[] Geymsluholf { get; set; }
        public VerdbrefaStada[] VerdbrefaStada { get; set; }
        public Skjal[] Skjol { get; set; }
    }
}
