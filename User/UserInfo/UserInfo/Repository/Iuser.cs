using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfo.Models;
namespace UserInfo.Repository
{
    interface IUser
    {
        void InserUser(Models.UserInfo user);
        IEnumerable<Models.UserInfo> getUser();
        void UpdateUser(Models.UserInfo user);
        void DeleteUser(int uId);
        Models.UserInfo GetUser(int uId);
    }
}
