using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace services.Services
{
    public class Ecryption : IEncryption
    {
        public string generateHash(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] tmpSource;
            byte[] tmpHash;
            tmpSource = ASCIIEncoding.ASCII.GetBytes(password); 
            tmpHash = md5.ComputeHash(tmpSource);

            StringBuilder sOutput = new StringBuilder(tmpHash.Length);
            for (int i = 0; i < tmpHash.Length; i++)
            {
                sOutput.Append(tmpHash[i].ToString("X2"));  
            }
            return sOutput.ToString();
        }

        public bool verifiyHash(string password, string hash)
        {
            Boolean IsValid = false;
            string tmpHash = generateHash(password); 
            if (tmpHash == hash) IsValid = true;  
            return IsValid;
        }
    }
}
