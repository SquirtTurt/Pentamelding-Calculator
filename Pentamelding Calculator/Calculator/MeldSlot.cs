namespace Pentamelding_Calculator.Calculator
{
    public class MeldSlot
    {
        public MateriaType MateriaType { get; set; }

        public int Rank { get; set; }

        public bool Melded { get; set; }

        public int MeldRate { get; set; }

        public MeldSlot(MateriaType type, int rank, int Meldrate)
        {
            MateriaType = type;
            Rank = rank;
            MeldRate = Meldrate;
            Melded = false;
        }
    }
}