using System;
using System.Collections;

namespace SampleConsoleApp
{
    public class Duplicate
    {
        /// <summary>
        /// Time Complexity O(n^2) Space Complexity O(1)
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public bool DuplicateBrutForce(String[] items)
        {
            for (int i = 0; i < items.Length - 1; i++)
                for (int j = i + 1; j < items.Length; j++)
                    if (items[i] == items[j])
                        return true;
            return false;
        }

        /// <summary>
        /// Time Complexity O(n) Space Complexity O(1)
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public bool DuplicateBySort(String[] items)
        {
            Array.Sort(items);
            for (int i = 0; i < items.Length - 1; i++)
                if (items[i] == items[i + 1])
                    return true;
            return false;
        }

        /// <summary>
        /// Time Complexity O(n) Space Complexity O(n)
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public bool DuplicateByHashTable(String[] items)
        {
            Hashtable hashtable = new Hashtable();
            foreach (string s in items)
                if (!hashtable.Contains(s))
                    hashtable.Add(s, s);
                else
                    return true;
            return false;
        }
    }
}
