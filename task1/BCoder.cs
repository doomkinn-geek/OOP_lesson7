using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    public class BCoder : ICoder
    {
        //коды символов:
        /*
        A - 65
        Z - 90
        a - 97
        z - 122

        А - 1040
        Я - 1071
        а - 1072
        я - 1103        
        */
        private char EncodeSymbol(char input)
        {            
            if (input >= 65 && input <= 90)
            {
                return (char)(90 - (input - 65));
            }
            else if (input >= 97 && input <= 122)
            {
                return (char)(122 - (input - 97));
            }
            else if (input >= 1040 && input <= 1071)
            {
                return (char)(1071 - (input - 1040));
            }
            else if (input >= 1072 && input <= 1103)
            {
                return (char)(1103 - (input - 1072));
            }
            else
            {
                return input;
            }
        }
        private char DecodeSymbol(char input)
        {
            if (input >= 65 && input <= 90)
            {
                return (char)(65 + (90 - input));
            }
            else if (input >= 97 && input <= 122)
            {
                return (char)(97 + (122 - input));
            }
            else if (input >= 1040 && input <= 1071)
            {
                return (char)(1040 + (1071 - input));
            }
            else if (input >= 1072 && input <= 1103)
            {
                return (char)(1072 + (1103 - input));
            }
            else
            {
                return input;
            }
        }
        public string Decode(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                result += DecodeSymbol(input[i]);
            }
            return result;
        }
        public string Encode(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                result += EncodeSymbol(input[i]);
            }
            return result;
        }
    }
}
