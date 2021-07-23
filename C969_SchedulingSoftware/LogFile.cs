using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_SchedulingSoftware
{
    public enum LoginType { Success, Failure};
    public static class LogFile
    {
        public static void Login(LoginType loginType, string userName)
        {
            try
            {
                Directory.CreateDirectory(@"./logs");
                using (StreamWriter w = File.AppendText(@"./Logs/logins.log"))
                {
                    var sb = new StringBuilder();
                    if (loginType == LoginType.Success)
                    {
                        sb.Append(String.Format("{0, -20} {1, -5} {2, -15} {3, -10}", $"{DateTime.Now}", " --- ", "LOGIN SUCCESS: ", userName));
                    }
                    else
                    {
                        sb.Append(String.Format("{0, -20} {1, -5} {2, -15} {3, -10}", $"{DateTime.Now}", " --- ", "LOGIN FAILURE: ", userName));
                    }
                    w.WriteLine(sb.ToString());
                }
            }
            catch (UnauthorizedAccessException)
            {
                // no action, login will still be able to proceed even if the login attempt can't be logged
            }
        }
    }
}
