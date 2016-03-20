using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClass
{
    public class LinkedList
    {
        public StringNode head;
        public StringNode tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddString(StringNode newString)
        {
            if (head == null)
            {
                head = newString;
                tail = newString;
            }
            else
            {
                tail.Next = newString;
                tail = newString;
            }
        }

        public int ListCount()
        {
            int count = 0;
            StringNode nodeWalker = head;

            while (nodeWalker != null)
            {
                count++;
                nodeWalker = nodeWalker.Next;
            }

            return count;
        }

        public void DeleteString(StringNode StringToDelete)
        {
            StringNode nodeWalker = head;

            //If deleting the only pellet in the list
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                //If deleting first pellet in list when there are more than one in list
                if (StringToDelete == head && StringToDelete.Next != null)
                {
                    head = StringToDelete.Next;
                }

                else
                {
                    while (nodeWalker.Next != StringToDelete)
                    {
                        nodeWalker = nodeWalker.Next;
                    }

                    nodeWalker.Next = StringToDelete.Next;
                    //If deleting last pellet in list
                    if (StringToDelete.Next == null)
                    {
                        tail = nodeWalker;
                    }
                }
            }
        }
    }
}
