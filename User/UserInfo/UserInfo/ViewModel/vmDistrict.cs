using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace UserInfo.ViewModel
{
    public class vmDistrict
    {
        public int DistrictId { get; set; }
        public string Name { get; set; }
        public int DivitionId { get; set; }

        public List<KeyValuePair<int, string>> Divitions { get; set; }
      
    
    }
}