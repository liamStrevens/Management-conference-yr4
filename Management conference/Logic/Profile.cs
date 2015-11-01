using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_conference.Logic
{
   public class Profile
    {
        public int profileID{get;set;}
        public string name{get;set;}
        public string email{get;set;}
        public string jobTitle{get;set;}
        public string department{ get; set; }
        public Profile(int profileID,string name,string email,string jobTitle,string department)
        {
            this.profileID = profileID;
            this.name = name;
            this.email = email;
            this.jobTitle = jobTitle;
            this.department = department;
        }
    }
}
