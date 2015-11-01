using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_conference.Logic
{
   
    class System

    { 
       //Hard coded values
        public User LoggedIn { get; set; }
        User U1;
        User U2;
        User U3;
        User U4;
        User U5;
        User U6;
        Profile tempProfile = new Profile(1, "Liam Strevens", "liamstrevens131@hotmail.com", "software engineering", "Programming");
        Conference C1;
        Conference C2;
        Conference C3;
        Conference C4;
        Conference C5;
        List<Conference> ConArray = new List<Conference>();
        List<User> ConUserList1 = new List<User>();
        List<User> ConUserList2 = new List<User>();
        List<User> ConUserList3 = new List<User>();
        List<User> ConUserList4 = new List<User>();
        List<User> ConUserList5 = new List<User>();
        List<String> U1SkillsList = new List<String>(){"sql","java"};
        List<String> U2SkillsList = new List<String>();
        List<String> U3SkillsList = new List<String>();
        List<String> U4SkillsList = new List<String>();
        List<String> U5SkillsList = new List<String>();
        List<String> U6SkillsList = new List<String>();
        List<String> ConSkillList1 = new List<String>(){"sql","mysql","sqllite"};
        List<String> ConSkillList2 = new List<String>(){ "test", "testing" ,"etest", "ctesting" };
        List<String> ConSkillList3 = new List<String>(){"Java", "testing" ,"etest", "ctesting"};
        List<String> ConSkillList4 = new List<String>(){ "management", "business", "finance", "leadership" };
        List<String> ConSkillList5 = new List<String>(){"management", "business", "finance", "leadership"};
        
       
        public System()
        {
            U1 = new User(1,23,"Liam","password",U1SkillsList,tempProfile);
            U2 = new User(2, 23, "Sam", "password", U2SkillsList, tempProfile);
            U3 = new User(3, 23, "Joe", "password", U3SkillsList, tempProfile);
            U4 = new User(4, 23, "Aaron", "password", U4SkillsList, tempProfile);
            U5 = new User(5, 23, "Ignas", "password", U5SkillsList, tempProfile);
            U6 = new User(6, 23, "Dovydas", "password", U6SkillsList, tempProfile);
            LoggedIn = U1;
            ConUserList1.Add(U2);
            C1 = new Conference(1, "Sql Conference", U1, Convert.ToDateTime("10/10/2014"), ConUserList1, ConSkillList1);
            C2 = new Conference(2, "test conference", U2, Convert.ToDateTime("10/10/2015"), ConUserList2, ConSkillList2);
            C3 = new Conference(3, "Java conference", U3, Convert.ToDateTime("10/10/2014"), ConUserList1, ConSkillList3);
            C4 = new Conference(4, "Business management",U4, Convert.ToDateTime("10/10/2014"), ConUserList1, ConSkillList4);
            C5 = new Conference(5,"Business management", U5, Convert.ToDateTime("10/10/2014"), ConUserList1, ConSkillList5);
            ConArray.Add(C1);
            ConArray.Add(C2);
            ConArray.Add(C3);
            ConArray.Add(C4);
            ConArray.Add(C5);
        }
        public List<Conference> searchConference(String searchTerm)
        {
            
            Boolean isMatch;
            string[] words;
            words = searchTerm.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);//split string into an array of search terms
            List<Conference> SearchResults = new List<Conference>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < ConArray.Count; j++)
                {
                    //searches every term against every conference skills
                    isMatch = ConArray[j].SearchTerms(words[i]);
                    if (isMatch)
                    {
                        SearchResults.Add(ConArray[j]);
                    }
                }
            }
            return SearchResults;
        }
        public Boolean validateConference(Conference selectedConf)
        {
            Boolean isValid= false;
            //Checks the skills of the logged on user against the choosen conference 
            for (int i = 0; i < LoggedIn.skills.Count(); i++)
            {
                if (selectedConf.skills.Contains(LoggedIn.skills[i]))
                {
                    isValid = true;
                    break;
                }
            }
                return isValid;
        }
        public void sendMessage(string messageText, Conference selectedConf)
        {
            string userName = LoggedIn.name;
            DateTime CurrentDateTime = DateTime.Now;
            selectedConf.sendMessage(messageText, userName, CurrentDateTime);
            
        }
        public List<Messages> refreshMessages(Conference selectedConf)
        {
            List<Messages> MsgFees = new List<Messages>();
            MsgFees = selectedConf.getConferenceMessages();
            return MsgFees;
        }
    }
}
