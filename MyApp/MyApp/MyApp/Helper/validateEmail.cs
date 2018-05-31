using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MyApp.Helper
{
    public class validateEmail
    {
        const string emailRegex = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
        public static bool EntryValidateEmail(string email)
        {
            Regex oRegExp = new Regex(emailRegex, RegexOptions.IgnoreCase);
            return oRegExp.Match(email).Success;
        }
    }
}
