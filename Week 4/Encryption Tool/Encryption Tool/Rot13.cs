﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Tool
{
    public class Rot13 : IEncryptionMachine
    {
        public Rot13() { }

        public String Encrypt(String plainText)
        {
            char[] array = plainText.ToCharArray();
	        for (int i = 0; i < array.Length; i++)
	        {
		        int number = (int)array[i];

		        if (number >= 'a' && number <= 'z')
		        {
		            if (number > 'm')
		            {
			        number -= 13;
		            }
		            else
		            {
			        number += 13;
		            }
		        }
		        else if (number >= 'A' && number <= 'Z')
		        {
		            if (number > 'M')
		            {
			        number -= 13;
		            }
		            else
		            {
			        number += 13;
		            }
		        }
		        array[i] = (char)number;
	        }
	        return new string(array);
	    }
    }
}
