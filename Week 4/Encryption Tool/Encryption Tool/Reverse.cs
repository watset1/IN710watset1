using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Tool
{
    public class Reverse : IEncryptionMachine
    {
        public Reverse() { }

        public String Encrypt(String plainText)
        {
            char[] array = plainText.ToCharArray();
            String reverse = "";
            for (int i = array.Length - 1; i > -1; i--)
            {
                reverse += array[i];
            }
            return reverse;
        }
    }
}
