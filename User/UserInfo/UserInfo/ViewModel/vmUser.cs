using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserInfo.ViewModel
{
    public class vmUser
    {
        public int UserId { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Mobile { get; set; }
        public int GenderId { get; set; }
        public int DivitionId { get; set; }
        public int DistrictId { get; set; }
        public string PresentAddress { get; set; }
        public string LastEducationalQulification { get; set; }
        public string Occupation { get; set; }
        public System.DateTime DateOFBirth { get; set; }

        public List<KeyValuePair<int, string>> Divitions { get; set; }

        public List<KeyValuePair<int, string>> Districts { get; set; }


    }
}