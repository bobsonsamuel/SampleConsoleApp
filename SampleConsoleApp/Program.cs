using SampleConsoleApp.ExtensionMethods;
using SampleConsoleApp.HelperMethods;
using System;
using System.Collections.Generic;

namespace SampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////DISPLAY DISTINCT LETTERS FROM A STRING
            //var inputString = "Hello World! hello world!";
            //getDistinctChar(inputString);

            Program program = new Program();
            ///////EXTENSION METHODS
            //program.getExtension();

            ///////FIND DUPLICATES
            //string[] input;
            //input = program.ReadData();
            //program.FindDuplicate(input);

            //SIP PASSWORD DECRYPT
            program.DecryptPassword();

            Console.ReadLine();
        }
        
        private static void getDistinctChar(string inputString)
        {
            ///List<String>
            List<String> charList = StringHelper.getDistinctCharArray(inputString);
            foreach (var c in charList)
            {
                Console.WriteLine(c);
            }

            ///KeyValuePair
            List<KeyValuePair<string, string>> kvpList = StringHelper.getDistinctKeyValue(inputString);
            foreach (var kvp in kvpList)
            {
                Console.WriteLine(kvp.Value);
            }

            ///HashSet
            HashSet<string> hashS = StringHelper.getDistinctHashSet(inputString);
            foreach (var hs in hashS)
            {
                Console.WriteLine(hs);
            }
        }

        private void getExtension()
        {
            ///EXTENSION METHODS FOR INT
            int i = 101;
            bool iresult = i.IsGreaterThan(100);
            float f = 9;
            bool fresult = f.IsGreaterThan(10);

            Console.WriteLine(iresult ? "Greater" : "Lesser");
            Console.WriteLine(fresult ? "Greater" : "Lesser");


            ///EXTENSION METHODS FOR EMPLOYEE CLASS
            Employee empe = new Employee();
            bool emepeActive = empe.IsActive();
            Console.WriteLine(emepeActive ? "Active" : "Inactive");

            bool hasCard = empe.HasCard(empe);
            Console.WriteLine(hasCard ? "Yes" : "No");
        }

        public string[] ReadData()
        {
            string[] items;
            Console.WriteLine("Please enter the array elements separated by a space.");
            string input = Console.ReadLine();
            items = input.Split(" ");
            return items;
        }

        private void FindDuplicate(string[] items)
        {
            bool hasDuplicate;
            Duplicate duplicate = new Duplicate();

            //hasDuplicate = duplicate.DuplicateBrutForce(items);
            //hasDuplicate = duplicate.DuplicateBySort(items);
            hasDuplicate = duplicate.DuplicateByHashTable(items);

            Console.WriteLine("Entered Input is :");
            foreach (string s in items)
                Console.WriteLine(s);

            Console.WriteLine(hasDuplicate ? "Duplicate Found." : "Duplicate Not Found.");
        }

        /// <summary>
        /// Used to decrypt passwords of BOSS - SIP application
        /// </summary>
        private void DecryptPassword()
        {
            Console.WriteLine("Please enter the password to decrypt.");
            string ePassword = Console.ReadLine();
            try
            {
                string dPassword = ePassword.Decrypt();
                Console.WriteLine("The decrypted password is : {0}", dPassword);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error in decrypting password. \n{0}", ex.Message);
            }
        }
    }
}
