using System;

namespace elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant e1 = new Elephant("Zazou", 2);
            Elephant e2 = new Elephant("Tati", 45);
            int cli;
            cli = int.Parse(Console.ReadLine());
            switch(cli)
            {
                case 1:
                    Console.WriteLine(e1.attr());
                    break;
                case 2:
                    Console.WriteLine(e2.attr());
                    break;
                case 3:
                    Elephant temp = e1;
                    e1 = e2;
                    e2 = temp;
                    Console.WriteLine(e1.attr());
                    Console.WriteLine(e2.attr());
                    break;
            }
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            e2.ecouteMessage("haaaaa", e1);
            e1.envoieMessage("Haha lol.2", e2);
            Elephant.quiALesPlusGrosse(e1, e2);

        }
    }
}
