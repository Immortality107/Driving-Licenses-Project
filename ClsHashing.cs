using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject
{
    public class ClsHashing
    {
        public static string ComputeHash(string Password)
        {

            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hashbyte = sha1.ComputeHash(Encoding.UTF8.GetBytes(Password));

                return BitConverter.ToString(hashbyte).Replace("-","").ToLower();
            }
        }

        public static bool CompareHash(string Hash1, string Hash2)
        {

            return ComputeHash(Hash1) == ComputeHash(Hash2);

        }
    }
}
