using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsoleApp.HelperMethods
{
    class StringHelper
    {

        public static List<String> getDistinctCharArray(string origStr)
        {
            char[] charArray;
            List<String> charList = new List<String>();

            charArray = origStr.ToCharArray();
            for (int i = 0; i <= origStr.Length - 1; i++)
            {
                if (!charList.Contains(charArray[i].ToString().ToLower()) && charArray[i] != ' ')
                {
                    charList.Add(charArray[i].ToString().ToLower());
                }
            }
            charList.Sort();
            return charList;
        }

        public static List<KeyValuePair<string, string>> getDistinctKeyValue(string origStr)
        {
            char[] charArray;
            List<KeyValuePair<string, string>> kvpList = new List<KeyValuePair<string, string>>();

            charArray = origStr.ToCharArray();
            for (int i = 0; i <= origStr.Length - 1; i++)
            {
                var c = charArray[i].ToString().ToLower();
                KeyValuePair<string, string> kvp = new KeyValuePair<string, string>(c, c);
                if (!kvpList.Contains(kvp) && charArray[i] != ' ')
                {
                    kvpList.Add(kvp);
                }
            }
            //kvpList.Sort();
            return kvpList;
        }

        public static HashSet<string> getDistinctHashSet(string origStr)
        {
            char[] charArray;
            HashSet<string> hashS = new HashSet<string>();

            charArray = origStr.ToCharArray();
            for (int i = 0; i <= origStr.Length - 1; i++)
            {
                var c = charArray[i].ToString().ToLower();
                if (!hashS.Contains(c) && charArray[i] != ' ')
                {
                    hashS.Add(c);
                }
            }
            //hashS.Sort();
            return hashS;
        }
    }
}
