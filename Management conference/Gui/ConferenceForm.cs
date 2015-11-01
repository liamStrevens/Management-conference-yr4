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
        Conference selectedConf;
        public ConferenceForm(Conference selectedConf)
        {
            this.selectedConf = selectedConf;
            InitializeComponent();

            label1.Text = this.selectedConf.name;
            for (int i = 0; i < this.selectedConf.Participant.Count(); i++)
            {
                listBox1.Items.Add(this.selectedConf.Participant[i].name);
            }
            this.selectedConf.getMessages();
            foreach (Messages message in this.selectedConf.messages)
            {
                string theMessage = "Message : " + message.message + "                      (Sender :   "+message.sender+"      Date and time : " + message.dateAndTime.ToString()+")";
                listBox2.Items.Add(theMessage);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 == null)
            {
                MessageBox.Show("please enter a message");
            }
            else
            {
                Program.MainSystem.sendMessage(textBox1.Text, selectedConf);
            }
        }
        
    }
}
