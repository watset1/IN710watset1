using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Network
{
    public class UserFriendManager
    {
        public User user;
        Friend friend1;
        Friend friend2;
        Friend friend3;
        Friend friend4;

        public UserFriendManager(ListBox listBox1, ListBox listBox2, ListBox listBox3, ListBox listBox4)
        {
            user = new User();
            friend1 = new Friend(listBox1, user);
            friend2 = new Friend(listBox2, user);
            friend3 = new Friend(listBox3, user);
            friend4 = new Friend(listBox4, user);
        }

        public void createUserPost(String input, String date)
        {
            user.newStatus.post = input;
            user.newStatus.date = date;
        }

        public void updateFriends()
        {
            user.NotifyObservers();
        }
    }
}
