using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    public class ACoder : ICoder
    {
        private char IncrementSymbol(char input)
        {
            if(input == 'z')
            {
                return 'a';
            }
            else if(input == 'Z')
            {
                return 'A';
            }
            else if(input == 'А')
            {
                return 'Я';
            }
            else if(input == 'а')
            {
                return 'я';
            }
            else
            {
                return (char)(input + 1);
            }
        }
        private char DecrementSymbol(char input)
        {
            if (input == 'a')
            {
                return 'z';
            }
            else if (input == 'A')
            {
                return 'Z';
            }
            else if (input == 'Я')
            {
                return 'А';
            }
            else if (input == 'я')
            {
                return 'а';
            }
            else
            {
                return (char)(input - 1);
            }
        }
        public string Decode(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                result += DecrementSymbol(input[i]);
            }
            return result;
        }
        public string Encode(string input)
        {
            string result = "";
            for(int i = 0; i < input.Length; i++)
            {
                result += IncrementSymbol(input[i]);
            }
            return result;
        }
    }
}
