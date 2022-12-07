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
    public class Stack2
    {
        public Node top = null;
        public void Add(int data)//Add Data Into the Stack
        {
            Node node = new Node(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(node.data + ":Inserted SuccessFully");
        }
        public void Display()//Display Data From The Stack
        {
            Node temp = this.top;
            Console.WriteLine("Values In Stack Are:");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public void peek()//Peek Data From The Stack
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack Is Empty");
            }
            else
            {
                Console.WriteLine("Top Most Value Is:" + this.top.data);
            }
        }
        public void pop()//Pop Data From The Stack
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack Is Empty");
            }
            else
            {
                Console.WriteLine("Top Most Value Popped:" + this.top.data);
                this.top = this.top.next;
            }
        }
    }
}
