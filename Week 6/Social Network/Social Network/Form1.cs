using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Network
{
    public partial class Form1 : Form
    {
        UserFriendManager manager;

        public Form1()
        {
            InitializeComponent();
            manager = new UserFriendManager(listBox1, listBox2, listBox3, listBox4);
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                String post = txtInput.Text.ToString();
                String date = DateTime.Now.ToString("ddd d MMM, yyyy h:mm tt");
                lblFeedback.ForeColor = Color.LightGray;
                manager.createUserPost(post, date);
                listBoxMainPage.Items.Clear();
                listBoxMainPage.Items.Add(post);
                lblFeedback.Text = "Message sent " + date;
                manager.updateFriends();
                txtInput.Clear();
            }
            else
            {
                lblFeedback.ForeColor = Color.Red;
                lblFeedback.Text = "You have not entered any text to post";
            }
        }
    }
}
