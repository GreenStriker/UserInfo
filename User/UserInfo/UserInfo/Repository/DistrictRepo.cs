using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserInfo.Models;

namespace UserInfo.Repository
{
    public class DistrictRepo :IDistrict
    {
        private Models.userEntities userEntities;

        public DistrictRepo(Models.userEntities userEntities)
        {
            // TODO: Complete member initialization
            this.userEntities = userEntities;
        }
        public void InserDistrict(Models.District dc)
        {
            userEntities.Districts.Add(dc);
            userEntities.SaveChanges();
        }

        public IEnumerable<Models.District> getDistrict()
        {
            return userEntities.Districts.ToList();
        }

        public void UpdateDistrict(Models.District dc)
        {
            userEntities.Entry(dc).State = System.Data.Entity.EntityState.Modified;
            userEntities.SaveChanges();
        }

        public void DeleteDistrict(int dcId)
        {
            District deldv = userEntities.Districts.Find(dcId);
            userEntities.Districts.Remove(deldv);
            userEntities.SaveChanges();
        }

        public Models.District GetDistrict(int dvId)
        {
            return userEntities.Districts.Find(dvId);
        }




        public List<KeyValuePair<int, string>> GetKVP(int id)
        {
            var items = userEntities.Districts.Where(r => r.DivitionId == id).ToList();
            var typeList = new List<KeyValuePair<int, string>>();
            items.ForEach(c => typeList.Add(new KeyValuePair<int, string>(c.DistrictId, c.Name)));
            return typeList;
        }



    
    }
}