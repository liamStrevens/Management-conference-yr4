using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management_conference.Logic;
using Management_conference.Gui;
using Management_conference;
namespace Management_conference.Gui
{
    public partial class ConferenceForm : Form
    {
        Conference thisConference;
        public ConferenceForm(Conference selectedConf)
        {
            thisConference = selectedConf;
            InitializeComponent();
            
            label1.Text = thisConference.name;
            for (int i = 0; i < thisConference.Participant.Count();i++ )
            {
                listBox1.Items.Add(thisConference.Participant[i].name);
            }
            thisConference.getMessages();
            foreach (Messages message in thisConference.messages)
            {
                string theMessage = "Message : " + message.message + "                      (Sender :   "+message.sender+"      Date and time : " + message.dateAndTime.ToString()+")";
                listBox2.Items.Add(theMessage);
            }
        }
        
    }
}
