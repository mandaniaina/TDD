using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
    class Encoder
    {
        public int[] LetterToArrayOfInt(string value)
        {
            int[] encodedValue = new int[26];
            foreach (char c in value)
            {
                if (c >= 97 && c <= 122)
                {
                    encodedValue[c - 97]++;
                }
                if (c >= 65 && c <= 90)
                {
                    encodedValue[c - 65]++;
                }
            }
            return encodedValue;
        }
    }
}
