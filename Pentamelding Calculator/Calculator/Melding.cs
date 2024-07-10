using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Pentamelding_Calculator.Calculator
{
    public class Melding
    {
        public ObservableCollection<MeldableItem> Gear { get; set; }
        public Melding()
        {
            Gear = new ObservableCollection<MeldableItem>()
            {
                new MeldableItem("test Head", GearType.Head, MateriaType.Control, 12, MateriaType.Control, 12, MateriaType.Control, 11, MateriaType.Control, 11, MateriaType.Control, 11),
                new MeldableItem("test Chest",GearType.Chest, MateriaType.Control, 12, MateriaType.Control, 12, MateriaType.Control, 11, MateriaType.Control, 11, MateriaType.Control, 11),
                new MeldableItem("test Gloves",GearType.Gloves, MateriaType.Control, 12, MateriaType.Control, 12, MateriaType.Control, 11, MateriaType.Control, 11, MateriaType.Control, 11),
            };
        }
    }
}