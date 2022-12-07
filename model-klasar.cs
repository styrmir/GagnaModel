namespace DistrictCommissionerAPI.Models.FinancialCompanies
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
        public Skjol[] Files { get; set; }
    }

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

    public class Sjalfskuldarabyrgd
    {
        public string NumerTryggingarbrefs { get; set; }
        public string KennitalaGreidanda { get; set; }
        public string TegundAbyrgdar { get; set; }
        public string Mynt { get; set; }
        public DateTime Utgafudagur { get; set; }
        public double NustadaISK { get; set; }
    }

    public class Geymsluholf
    {
        public string Audkenni { get; set; }
        public string NafnKrofuhafa { get; set; }
        public string Utibu { get; set; }
        public string StadaIDag { get; set; }
    }

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
    public class VerdbrefaStada 
    {
        public dobule VerdbrefaeignIsk { get; set; }
    }

    public class Skjol
    {
        public string Nafn { get; set; }
        public string Lysing { get; set; }
        public string Tegund { get; set; }
        public string FileDataBase64 { get; set; }
    }

    public enum TegundUtlans
    {
        Kort,
        OnnurSkuldabref,
        Yfirdrattarlan
    }
    public enum TegundBrefs
    {
        Tryggingarbref
    }
}

