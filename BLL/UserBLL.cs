using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace BLL
{
 public    class UserBLL
    {  //测试
        UserDB db = new UserDB();
        //添加用户
        public bool AddUser(User user)
        {
            return db.add(user);
        }
        //查询用户
        public bool SelectUser(User user)
        {
            return db.seek(user);
        }
        //判断用户是否存在
        public void IsExist(User user)
        {

        }
        //判断用户
    }
}
