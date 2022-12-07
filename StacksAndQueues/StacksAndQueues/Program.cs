using System;

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack1

            Stack1 s = new Stack1();//Create Stack Object
            s.Add(70);
            s.Add(30);
            s.Add(56);
            s.Display();//Call Display Method
        }
    }
}
