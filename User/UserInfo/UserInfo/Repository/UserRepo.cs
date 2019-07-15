using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserInfo.Repository
{
    public class UserRepo :IUser
    {
        private Models.userEntities userEntities;

        public UserRepo(Models.userEntities userEntities)
        {
            // TODO: Complete member initialization
            this.userEntities = userEntities;
        }
        public void InserUser(Models.UserInfo user)
        {
            userEntities.UserInfoes.Add(user);
            userEntities.SaveChanges();
        }

        public IEnumerable<Models.UserInfo> getUser()
        {
            return userEntities.UserInfoes.ToList();
        }

        public void UpdateUser(Models.UserInfo user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int uId)
        {
            throw new NotImplementedException();
        }

        public Models.UserInfo GetUser(int uId)
        {
            throw new NotImplementedException();
        }
    }
}