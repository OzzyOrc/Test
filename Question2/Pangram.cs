using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwo
{
    public class Pangram
    {
        public Pangram()
        {
            LetterCounter = new Dictionary<char, int>();
        }
        
        public Dictionary<char, int> LetterCounter { get; private set; }

        /// <summary>
        /// Returns 1 if a string is a pangram 
        /// Returns 0 otherwise
        /// </summary>
        public int PangramValidation { get; private set; }

        public int IsPangram(string N)
        {
            if (N.Length < 1 || N.Length > 103)
            {
                // TODO: user is able to retry with valid input
                Console.WriteLine("Invalid string input, Please enter a valid string that includes at least one character but no greater that 103 characters total");
                return 0;    
            }
            else
            {
                // Convert everything to lowercase first
                var lowercaseString = N.ToLower();
                LetterCounter = LoadDictionary();

                // No need for char array
                foreach (char c in lowercaseString)
                {
                    if (LetterCounter.ContainsKey(c))
                    {
                        LetterCounter[c]++;
                    }
                }

                // Now let's see if what the dictionary has is a pangram 
                // with the power of Linq
                bool isPangram = LetterCounter.All(i => i.Value != 0);

                return Convert.ToInt32(isPangram);
            }
        }

        /// <summary>
        /// Helper method will load all lowercase 
        /// letters in the alphabet with an associated 
        /// integer of 0 to keep count
        /// </summary>
        /// <returns></returns>
        public Dictionary<char, int> LoadDictionary()
        {
            // 97 = a & 122 = z 
            for (int i = 97; i <= 122; i++)
            {
                // Dictionary is empty so we are just setting it up 
                // with all lowercase letters in the alphabet.
                // Convert from int to its ascii value.
                LetterCounter.Add((char)i, 0);
            }

            return LetterCounter;
        }
    }
}
