using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace UniSieve.Homograph_Filter
{
    internal static class HomographFilter
    {
        public enum CharacterType
        {
            English,
            Persian
        }

        public static string Filter(string inputText, CharacterType characterType)
        {
            string pattern = "";
            switch (characterType)
            {
                case CharacterType.Persian:
                    pattern = "[^آابپتثجچحخدذرزژسشصضطظعغفقکگلمنوهی]";
                    break;
                case CharacterType.English:
                    pattern = "[^a-zA-Z0-9.]";
                    break;
            }
            return Regex.Replace(inputText, pattern, "");
        }
    }
}
