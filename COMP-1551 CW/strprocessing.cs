using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_1551_CW
{
    public class StringProcessing
    {
        private string _s;
        private int _n;

        public string S
        {
            get { return _s; }
            set
            {
                if (value.All(char.IsUpper) && value.Length <= 40)
                {
                    _s = value;
                }
                else
                {
                    throw new ArgumentException("String must only contain Uppercase Letters and Less than 40 characters, try again.");
                }
            }
        }

        public int N
        {
            get { return _n; }
            set
            {
                if (value >= 25 && value <= -25)
                {
                    throw new ArgumentException("N must be from -25 to 25. Try again.");
                }
                else
                {
                    _n = value;
                }
            }
        }

        public StringProcessing(string s, int n)
        {
            S = s;
            N = n;
        }

        public string Encode()
        {
                char[] result = new char[S.Length];

    for (int i = 0; i < S.Length; i++)
    {
        char c = S[i];
        char newChar = (char)(c + N);

        if (newChar > 'Z')
        {
            newChar = (char)('A' + (newChar - 'Z' - 1));
        }
        else if (newChar < 'A')
        {
            newChar = (char)('A' - ('A' - newChar - 1));
        }

        result[i] = newChar;
    }

    return new string(result);
        }

        public string Print()
        {
            return Encode();
        }

        public string InputCode(string input)
        {
            int[] codes = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                codes[i] = (int)input[i];
            }

            string result = "";
            for (int i = 0; i < codes.Length; i++)
            {
                result += codes[i].ToString();
                if (i < codes.Length - 1)
                {
                    result += " ";
                }
            }

            return result;
        }

        public string OutputCode()
        {
            string encoded = Encode();
            int[] codes = new int[encoded.Length];

            for (int i = 0; i < encoded.Length; i++)
            {
                codes[i] = (int)encoded[i];
            }

            string result = "";
            for (int i = 0; i < codes.Length; i++)
            {
                result += codes[i].ToString();
                if (i < encoded.Length - 1)
                {
                    result += " ";
                }
            }
            return result;
        }

        public string SelectionSort(string input)
        {
            char[] array = input.ToCharArray();
            int n = array.Length;

            for (int i = 0; i < n; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                char temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }

            return new string(array);
        }

    }
}


