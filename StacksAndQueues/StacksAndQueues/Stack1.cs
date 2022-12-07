using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }
    }
    public class Stack1
    {
        public Node top = null;

        public void Add(int data)//Data Add Into Stack
        {
            Node node=new Node(data);
            if(this.top==null)//Check Condition
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(node.data+"Inserted Succesfully");
        }
        public void Display()//Display Data From Stack
        {
            Node temp = this.top;
            Console.WriteLine("Values in stack are");
            while(temp!=null)
            {
                Console.WriteLine(temp.data+"");
                  temp = temp.next;
            }
        }
    }
}
