using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    interface IDivition
    {
        void InserDivition(Divition dv);
        IEnumerable<Divition> getDivition();
        void UpdateDivition(Divition dv);
        void DeleteDivition(int dvId);
        Divition GetDivitionId(int dvId);








    }
}
