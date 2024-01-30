namespace SozlarJadvali.Models.Words
{
    public class Word
    {
        public Guid Id { get; set; }
        public string YordamchiSoz { get; set; } = string.Empty;
        public string Turkumi { get; set; } = string.Empty;
        public string XalqaroTegi { get; set; } = string.Empty;
        public string OzbekchaTegi { get; set; } = string.Empty;
        public string SofvazifaDosh { get; set; } = string.Empty;
        public string Shakli { get; set; } = string.Empty;
        public string ManoTuri { get; set; } = string.Empty;
        public string UslubiyXoslanishi { get; set; } = string.Empty;
        public string SofTurkumi { get; set; } = string.Empty;
        public string YordamchiSozVaOlinganManba { get; set; } = string.Empty;
    }
}
