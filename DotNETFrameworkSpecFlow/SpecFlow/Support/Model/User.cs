using DotNETFrameworkSpecFlow.SpecFlow.Support.POM_Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETFrameworkSpecFlow.SpecFlow.Support.Model
{
    public class User
    {
        internal string Username { get; set; }
        internal string Password { get; set; }

        public User(string _username, string _password)
        {
            Username = _username;
            Password = _password;
        }

        public static User UserCredentials()
        {
            var random = new Random();
            var users = new List<User>
            {
                new User("testUserOne", "Password1")
            };
            int index = random.Next(users.Count);
            return users[index];
        }

        public static void UserLogin(string UserName, string Password)
        {

            //Page_Login.email("mai").Value = "xxxxx";
            Page_Login.password.Value = "Password";
            //Page_Login.loginButton.Click();
        }

        public static void UserLogin(User user)
        {
            UserLogin(user.Username, user.Password);
        }
    }
}
