using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Tool
{
    public class Parser
    {
        public IEncryptionMachine encryptionMachine { get; set; }

        public Parser()
        {
            encryptionMachine = null;
        }

        public String Encrypt(String plainText)
        {
            String cypher = encryptionMachine.Encrypt(plainText);
            return cypher;
        }
    }
}
