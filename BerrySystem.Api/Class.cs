using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BerrySystem.Api
{
    public class MailValidator
    {
        public bool IsValidEmail(String email)
        {
            String expresion;
            if (string.IsNullOrEmpty(email))
            {
                throw new Exception();
            }
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string IsSpam(string emailAddress)
        {
            if (string.IsNullOrEmpty(emailAddress))
                throw new Exception();

            List<string> spammyDomain = new List<string>() { "spam.com", "dodgy.com", "donttrust.com" };
            return spammyDomain.Any(d => emailAddress.Contains(d)) ? "SPAM" : "INBOX";
        }




    }
}
