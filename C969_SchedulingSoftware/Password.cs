using DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C969_SchedulingSoftware
{
    public static class Password
    {
        public static void HashPassword(string userName, string passwordText)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(passwordText, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string savedPassword = Convert.ToBase64String(hashBytes);
            
            using (U05tp4Entities dbContext = new U05tp4Entities())
            {
                var userToUpdate = dbContext.users
                    .Where(u => u.userName == userName)
                    .First();

                userToUpdate.password = savedPassword;
                dbContext.SaveChanges();
            }
        }

        public static bool VerifyPassword(string userName, string passwordText)
        {
            bool verified = false;
            using (U05tp4Entities context = new U05tp4Entities())
            {
                string savedPasswordHash = context.users
                    .Where(u => u.userName == userName)
                    .Single()
                    .password;

                byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);
                var pbkdf2 = new Rfc2898DeriveBytes(passwordText, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);

                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i+16] == hash[i])
                    {
                        verified = true;
                    }
                    else
                    {
                        verified = false;
                    }
                }
            }
            return verified;
        }
    }
}
