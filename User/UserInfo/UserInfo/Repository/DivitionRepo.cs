using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserInfo.Models;

namespace UserInfo.Repository
{
    public class DivitionRepo : IDivition
    {
        private Models.userEntities userEntities;

        public DivitionRepo(Models.userEntities userEntities)
        {
            // TODO: Complete member initialization
            this.userEntities = userEntities;
        }
        public void InserDivition(Models.Divition dv)
        {
            userEntities.Divitions.Add(dv);
            userEntities.SaveChanges();
        }

        public IEnumerable<Models.Divition> getDivition()
        {
            return userEntities.Divitions.ToList();
        }

        public void UpdateDivition(Models.Divition dv)
        {
            userEntities.Entry(dv).State = System.Data.Entity.EntityState.Modified;
            userEntities.SaveChanges();
        }

        public void DeleteDivition(int dvId)
        {
            Divition deldv = userEntities.Divitions.Find(dvId);
            userEntities.Divitions.Remove(deldv);
            userEntities.SaveChanges();

        }

        public Models.Divition GetDivitionId(int dvId)
        {
            return userEntities.Divitions.Find(dvId);
        }
        public List<Divition> GetAll()
        {
            var items = userEntities.Divitions.ToList();

            return items;
        }

        public List<KeyValuePair<int, string>> GetKVP()
        {
            var items = userEntities.Divitions.ToList();
            var typeList = new List<KeyValuePair<int, string>>();
            items.ForEach(c => typeList.Add(new KeyValuePair<int, string>(c.DivitionId, c.Name)));
            return typeList;
        }
       
    }
}