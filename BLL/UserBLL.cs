using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace BLL
{
 public    class UserBLL
    {
        UserDB db = new UserDB();
        //添加用户
        public bool AddUser(User user) 
        {
            return db.add(user);
        }
        //查询用户
        public void SelectUser(User user)
        {

        }
        //判断用户是否存在
        public void IsExist(User user)
        {

        }
    }
}
