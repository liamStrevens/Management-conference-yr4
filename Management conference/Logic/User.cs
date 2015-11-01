using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_conference.Logic
{
   public class User
    {
        //getter and setters in c#
        public int id { get; set; }
        public int profileID { get; set; }
        public String name { get; set; }
        public String password { get; set; }
        public List<String> skills { get; set; }
        public Profile profile { get; set; }
        public User(int id,int profileID,String name,String password, List<String> skills,Profile profile)
        {
            this.id = id;
            this.profileID = profileID;
            this.name = name;
            this.password = password;
            this.skills = skills;
            this.profile = profile;
        }
       
    }
}
