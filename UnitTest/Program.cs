using System;
using System.Collections.Generic;

namespace UnitTest
{
    public class Program
    {
        public static bool CheckName(string stringToValidate)
        {
            if (stringToValidate.Length % 2 == 0 && stringToValidate.Length % 5 == 0)
            {
                Dictionary<char, int> countDictonary = new Dictionary<char, int>();

                var charARray = stringToValidate.ToCharArray();

                for (int i = 0; i < charARray.Length; i++)
                {
                    char currentChar = charARray[i];

                    if (countDictonary.ContainsKey(currentChar))
                    {
                        countDictonary[currentChar]++;

                        if (countDictonary[currentChar] > 2)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        countDictonary.Add(currentChar, 1);
                    }
                }

                return true;

            }
            return false;
        }



        static void Main(string[] args)

        {
            //Valider qu'une string a une lenght impaire et que son modulo 5 == 0
            //la string ne peut pas contenir 3 fois la meme lettre!

            var validatableString = "madam";
            var valid = CheckName(validatableString);

            int lol = 2;

        }
    }
}
