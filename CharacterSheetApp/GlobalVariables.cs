using CharacterSheetApp.Models;
using System.Collections.Generic;

namespace CharacterSheetApp
{
    public class GlobalVariables
    {
        public static List<Character> Characters { get; set; } = new List<Character>();
        public static List<Equipment> Equipment { get; set; } = new List<Equipment>();
    }
}
