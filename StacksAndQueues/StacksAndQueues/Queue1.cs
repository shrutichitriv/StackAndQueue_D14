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
    public class Queue1
    {
        Node head = null;

        public void Enqueue(int data)//Add Data into Queue
        {
            Node node=new Node(data);
            if(this.head== null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next=node;
            }
            Console.WriteLine(node.data+"Inserted Succesfully");
        }
        public void Display()//Display Data From Queue
        {
            Node temp = this.head;
            Console.WriteLine("Values In Queue Are");
            if(temp==null)
            {
                Console.WriteLine("Queue Is Empty");
                return;
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data+"");
                temp = temp.next;
            }
        }
    }

}
