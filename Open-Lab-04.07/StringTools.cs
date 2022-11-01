using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            original.ToCharArray();
            string reverse = string.Empty;
            for (int i = original.Length - 1; i > -1; i--)
            {
                reverse += original[i];
            }
            return reverse;
                
        }
    }
}
