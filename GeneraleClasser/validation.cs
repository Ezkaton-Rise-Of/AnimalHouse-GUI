using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneraleClasser
{
    public static class Validation
    {
        //tjekker om der kun er 0-9 i en string
        public static bool CkeckIfStringIsNummbersOnly(string s)
        {
            foreach (char c in s)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }



        //tjekker om der kun er a-å, umlaut
        public static bool CheckIfStringContainsOnlyCharacters(string s)
        {
            return s.Any(char.IsDigit);
        }
        //tjekker om det er en gylding adresse (0-9 og a-å, komma, umlaut);


        //tjekker om en string har en max længe
        public static bool CheckIfStringShorterThan(string s, int maxStørrelse)
        {
            if (s.Length > maxStørrelse)
            {
                return false;
            }
            else return true;
        }

        //tjekker om en string har en min længe
        public static bool CheckIfStringLongerThan(string s, int minStørrelse)
        {
            if (s.Length < minStørrelse)
            {
                return false;
            }
            else return true;
        }

        //tjekker om en string er tom
        public static bool CheckIfStringIsEmpty(string s)
        {
            if (s == "")
            {
                return false;
            }
            else return true;
        }
        //tjekker om en tal har et max størrelse
        public static bool CkeckIfNummberIsLessThan(int tal, int maxStørrelse)
        {
            if (tal >= maxStørrelse)
            {
                return false;
            }
            else return true;
        }
        //tjekker om en tal har en min størrelse
        public static bool CkeckIfNummberIsBiggerThan(int tal, int minStørrelse)
        {
            if (tal <= minStørrelse)
            {
                return false;
            }
            else return true;
        }
        
    }
}
