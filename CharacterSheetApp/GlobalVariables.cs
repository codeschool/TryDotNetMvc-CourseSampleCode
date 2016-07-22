using System.Collections.Generic;
using CharacterSheetApp.Models;

namespace CharacterSheetApp
{
    public static class GlobalVariables
    {
        public static List<Character> Characters { get; set; } = new List<Character>();
        public static List<Equipment> Equipment { get; set; } = new List<Equipment>();
    }
}
