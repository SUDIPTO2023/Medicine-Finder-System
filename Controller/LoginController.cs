using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicineLocator.Model;

namespace MedicineLocator.Controller
{
    class LoginController
    {
        Logins logins = new Logins();
        public void AddLogin(Login login)
        {
            logins.AddLogin(login);
        }
        public Login SearchLogin(string userId,string password)
        {
            Login login = logins.SearchLogin( userId, password);
            return login;
        }
         
        public Login UserValidate(string userId, string answer)
        {
            Login l = logins.UserValidate(userId,answer);
            return l;
        }
        public void UpdatePassword(Login login)
        {
            logins.UpdatePassword(login);
        }
    }
}
