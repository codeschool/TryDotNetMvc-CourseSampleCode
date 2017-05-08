using System.Collections.Generic;

namespace CharacterSheetApp.Models
{
    public class Equipment
    {
        public string Name;

        public static void Create(string EquipmentName)
        {
            var equipment = new Equipment();
            equipment.Name = EquipmentName;
            GlobalVariables.Equipment.Add(equipment);
        }

        public static List<Equipment> GetAll()
        {
            return GlobalVariables.Equipment;
        }
    }
}
