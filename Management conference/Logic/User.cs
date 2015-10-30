using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_conference.Logic
{
    class User
    {
        int id;
        int profileID;
        String name;
        String password;
        List<String> skills;
        public User(int id,int profileID,String name,String password, List<String> skills)
        {
            this.id = id;
            this.profileID = profileID;
            this.name = name;
            this.password = password;
            this.skills = skills;
        }
        public string getName()
        {
            return this.name;
        }
    }
}
