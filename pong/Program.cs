using System;

namespace pong
{
    class MainClass
    {
        public static void Main()
        {
            Pong clas = new Pong();
            Console.WriteLine("Enter a number dude");
            string finishedList = clas.AddPong(int.Parse(Console.ReadLine()));
            Console.WriteLine(finishedList);
        }
    }
}
