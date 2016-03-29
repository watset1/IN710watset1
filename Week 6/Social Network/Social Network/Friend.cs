using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Network
{
    public class Friend : IObserver
    {
        protected ListBox listBox;
        protected User user;
        Stack<Status> statusStack;
        
        public Friend(ListBox listBox, User user)
        {
            this.listBox = listBox;
            this.user = user;
            statusStack = new Stack<Status>();
            user.AddObserver(this);
        }

        public void Update(Status newStatus)
        {
            statusStack.Push(newStatus);
            Display();
        }

        public void Display()
        {
            String recentPost = statusStack.Peek().post;
            String recentPostDate = statusStack.Peek().date;
            listBox.Items.Add(recentPostDate);
            listBox.Items.Add(recentPost);
            listBox.Items.Add("");
        }
    }
}
