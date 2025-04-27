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
                char[] result = new char[S.Length]; // creating return char

    for (int i = 0; i < S.Length; i++)
    {
        char c = S[i]; // accessing current letter in S
        char newChar = (char)(c + N); // change character to new char

        if (newChar > 'Z')
        {
            newChar = (char)('A' + (newChar - 'Z' - 1)); // wraps back to A if exceeding Z
        }
        else if (newChar < 'A')
        {
            newChar = (char)('A' - ('A' - newChar - 1)); // wraps back to Z if going below A
        }

        result[i] = newChar; // appending the character to the result string
    }

    return new string(result); // return result string
        }

        public string Print()
        {
            return Encode(); // returning the value encoded in Encode().
        }

        public string InputCode(string input)
        {
            int[] codes = new int[input.Length]; // creating an integer array to store ASCII values.

            for (int i = 0; i < input.Length; i++)
            {
                codes[i] = (int)input[i]; //Adding values to codes array based on the letters in input.
            }

            string result = ""; // creating result string to return
            for (int i = 0; i < codes.Length; i++)
            {
                result += codes[i].ToString(); // adding ASCII value of corresponding letter to the string
                if (i < codes.Length - 1)
                {
                    result += " "; // if not at the end of string, add a space in between the values.
                }
            }

            return result;
        }

        public string OutputCode()
        {
            string encoded = Encode(); // Encode the inputted string
            int[] codes = new int[encoded.Length]; // creating integer array to store ASCII values.

            for (int i = 0; i < encoded.Length; i++)
            {
                codes[i] = (int)encoded[i]; //adding ASCII value of corresponding letter in encoded string.
            }

            string result = ""; // creating string result to return
            for (int i = 0; i < codes.Length; i++)
            {
                result += codes[i].ToString();
                if (i < encoded.Length - 1) // while not at the end of integer array, add a space between the letters.
                {
                    result += " ";
                }
            }
            return result; // return the result
        }

        public string SelectionSort(string input)
        {
            char[] array = input.ToCharArray(); // converting input string to char array
            int n = array.Length; // length of array

            for (int i = 0; i < n; i++) // loops through array
            {
                int minIndex = i; // assume minIndex as first value in array
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j; // loops through input string, if smaller value found, save the value's position in array
                    }
                }
                char temp = array[minIndex]; // find position of smallest value after loop
                array[minIndex] = array[i]; // swap current MinIndex with position of found MinIndex
                array[i] = temp; 
            }

            return new string(array);
        }

    }
}


