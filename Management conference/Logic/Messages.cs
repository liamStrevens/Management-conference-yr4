using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_conference.Logic
{
   public class Messages
    {
        public string sender{get;set;}
        public DateTime dateAndTime{get;set;}
        public string message{get;set;}
        public Messages(String sender, DateTime dateAndTime, string message)
        {
            this.sender = sender;
            this.dateAndTime = dateAndTime;
            this.message = message;
        }
    }
}
