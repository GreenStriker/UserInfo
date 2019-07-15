using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfo.Models;
namespace UserInfo.Repository
{
    interface IDivition
    {
        void InserDivition(Divition dv);
        IEnumerable<Divition> getDivition();
        void UpdateDivition(Divition dv);
        void DeleteDivition(int dvId);
        Divition GetDivitionId(int dvId);
         List<KeyValuePair<int, string>> GetKVP();

         List<Divition> GetAll();

    }
}
