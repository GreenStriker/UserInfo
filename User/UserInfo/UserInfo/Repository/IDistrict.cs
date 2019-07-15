using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfo.Models;

namespace UserInfo.Repository
{
    interface IDistrict
    {

        void InserDistrict(District dc);
        IEnumerable<District> getDistrict();
        void UpdateDistrict(District dc);
        void DeleteDistrict(int dcId);
        District GetDistrict(int dcId);

        List<KeyValuePair<int, string>> GetKVP(int id);



    }
}
