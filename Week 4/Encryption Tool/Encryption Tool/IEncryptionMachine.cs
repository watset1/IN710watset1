using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Tool
{
    public interface IEncryptionMachine
    {
        String Encrypt(String data);
    }
}
