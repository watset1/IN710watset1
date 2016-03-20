using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClass
{
    public class Stack
    {
        LinkedList stackList;       

        public Stack()
        {
            stackList = new LinkedList();
        }

        public void Push(StringNode newString)
        {
            stackList.AddString(newString);
        }

        public String Pop()
        {
            String PopString;
            try
            {
                PopString = stackList.tail.Value;
                stackList.DeleteString(stackList.tail);           
            }
            catch(NullReferenceException)
            {
                throw new Exception("Attempted to pop from an empty stack");
            }
            return PopString;
            
        }

        public String Peek()
        {
            
            String peekString;
            try
            {
                peekString = stackList.tail.Value;
            }
            catch(NullReferenceException)
            {
                throw new Exception ("Attempted to peek at an empty stack");
            }
            return peekString;
        }

        public int Count()
        {
           return stackList.ListCount();
        }

        public bool IsEmpty()
        {
            if (stackList.ListCount() == 0)
                return true;
            else
                return false;
        }
    }
}
