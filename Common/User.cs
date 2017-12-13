using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class User //实体类
    {
        private String username;
        private String password;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
