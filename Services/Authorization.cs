using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Authorization
    {
        public static AuthVariants Login(string login, string password)
        {
            if (login == "admin")
            {
                if (password == "admin") return AuthVariants.LoginAndPassworcorrect;
                return AuthVariants.PasswordIncorrect;
            }
            return AuthVariants.LoginIncorrect;
        }
    }
}
