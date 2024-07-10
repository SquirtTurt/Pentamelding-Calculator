using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace Pentamelding_Calculator.Calculator
{
    public class MeldableItem
    {
        public MeldSlot Meld1 {  get; set; }
        public MeldSlot Meld2 { get; set; }
        public MeldSlot Meld3 { get; set; }
        public MeldSlot Meld4 { get; set; }
        public MeldSlot Meld5 { get; set; }

        public GearType GearType { get; set; }

        public string Name { get; set; }

        public MeldableItem(
            string name,
            GearType type,
            MateriaType meld1Type,
            int meld1Rank,
            MateriaType meld2Type,
            int meld2Rank,
            MateriaType meld3Type,
            int meld3Rank,
            MateriaType meld4Type
            , int meld4Rank,
            MateriaType meld5Type,
            int meld5Rank)
        {
            Name = name;
            GearType = type;

            Meld1 = new MeldSlot(meld1Type, meld1Rank, GetMeldRate(1));

            Meld2 = new MeldSlot(meld2Type, meld2Rank, GetMeldRate(2));

            Meld3 = new MeldSlot(meld3Type, meld3Rank, GetMeldRate(3));

            Meld4 = new MeldSlot(meld4Type, meld4Rank, GetMeldRate(4));

            Meld5 = new MeldSlot(meld5Type, meld5Rank, GetMeldRate(5));
        }

        private int GetMeldRate(int meld)
        {
            switch (GearType) 
            {
                case GearType.Earring:
                case GearType.Bracelet:
                case GearType.Necklace:
                case GearType.Ring:
                case GearType.Tool:
                    meld+= 1;
                    break;
            }
            return meld switch
            {
                1 => 100,
                2 => 100,
                3 => 17,
                4 => 10,
                5 => 7,
                6 => 5,
                _ => throw new Exception(),
            };
        }
    }
}