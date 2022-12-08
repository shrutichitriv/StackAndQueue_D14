using System;

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack1

            //Stack1 s = new Stack1();//Create Stack Object
            //s.Add(70);
            //s.Add(30);
            //s.Add(56);
            //s.Display();//Call Display Method

            //Stack2

            //Stack2 s = new Stack2();//Create Stack Object
            //s.Add(70);
            //s.Add(30);
            //s.Add(56);
            //s.Display();//Call Display Metho
            //s.peek();//Call Peek Method
            //s.pop();//Call pop Method
            //s.Display();

            //Queue1

            Queue1 q = new Queue1();//Create object Queue
            q.Enqueue(70);//Add Datat Into The Queue
            q.Enqueue(30);
            q.Enqueue(56);
            q.Display();//Call Display Method
        }
    }
}
