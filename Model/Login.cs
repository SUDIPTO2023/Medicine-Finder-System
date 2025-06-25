using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineLocator.Model
{
    public class Login
    {
        private string user_Id;
        private string email;
        private int role;
        private string securityAnswer;
        private string password;
        
        public Login()
        {

        }

        public Login(string user_Id, string email, int role, string securityAnswer, string password)
        {
            this.User_Id = user_Id;
            this.Email = email;
            this.Role = role;
            this.SecurityAnswer = securityAnswer;
            this.Password = password;
            
        }

        public string User_Id { get => user_Id; set => user_Id = value; }
        public string Email { get => email; set => email = value; }
        public int Role { get => role; set => role = value; }
        public string SecurityAnswer { get => securityAnswer; set => securityAnswer = value; }
        public string Password { get => password; set => password = value; }
        
    }
}
