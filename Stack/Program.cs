// Manuel Weißböck
// Stack Übung
// 4AHWII

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack_class s1;
            Console.WriteLine(" Testprogramm für Stack von Manuel Weißböck\n");
            Console.WriteLine(" Der Stack wird nun mit Größe 5 erstellt\n");
            s1 = new Stack_class(5);
            Console.WriteLine(" maxElements = {0}\n", s1.MaxElements);
            Console.WriteLine(" Es werden nun 3 Zahlen eingelesen ( 4, 10 und 12)\n");
            s1.Push(4);
            s1.Push(10);
            s1.Push(12);
            Console.WriteLine(" Der Stack besteht nun aus {0}\n", s1.ToString());
            Console.WriteLine(" Nun wird Pop getestet.\n");
            Console.WriteLine(" Oberstes Element ist = {0}\n", s1.Pop());
            Console.WriteLine(" Der Stack besteht nun aus {0}\n", s1.ToString());
            Console.WriteLine(" Nun wird Peek ausgeführt\n");
            Console.WriteLine(" Oberstes Element ist = {0}\n", s1.Peek());
            Console.WriteLine(" Der Stack besteht aus {0}\n", s1.ToString());
            Console.WriteLine(" Nun füllen wir die letzen 3 Stack-Pläzue auf mit += (6, 54, 1)");
            s1 += 6;
            s1 += 54;
            s1 += 1;
            Console.WriteLine(" Der Stack besteht nun aus {0}\n", s1.ToString());
            Console.WriteLine(" Nun versuchen wir mit 11 eine Zahl mehr als Platz hat einzufügen");
            Console.WriteLine(" Error vor dem Einfügen = {0}", s1.Error);
            s1 += 11;
            Console.WriteLine(" Error nach dem Einfügen = {0}", s1.Error);
            Console.WriteLine(" Der Stack besteht aus {0}\n", s1.ToString());
            Console.WriteLine(" Zu guter Letzt wird der Stack geleert");
            Console.WriteLine(" Error vor dem Leeren = {0}", s1.Error);
            Console.WriteLine(" Der Stack vor dem Leeren: {0}\n", s1.ToString());
            s1.Clear();
            Console.WriteLine(" Error nach dem Leeren = {0}", s1.Error);
            Console.WriteLine(" Der Stack nach dem Leeren: {0}\n", s1.ToString());

            Console.ReadKey();
            

        }
    }
}
