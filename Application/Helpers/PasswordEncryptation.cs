using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application.Helpers
{
    public class PasswordEncryptation
    {
        public static string ComputeHash(string password) 
        {
            using (SHA256 sha = SHA256.Create()) 
            {
                byte[] bites = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bites.Length; i++) 
                {
                    builder.Append(bites[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
