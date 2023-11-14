using System;

namespace Aula_9_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Mobiliario m1 = new Mobiliario();
            
            Console.WriteLine("Data Mobi:" + m1.Referencia().ToString());


            int x, y;

            //if (x==y)
            //if (x.CompareTo(y))..
            //if (String.Compare("ola","ole"))...

            Casa c1 = new Casa();
            Console.WriteLine("Data Casa:" + c1.Referencia().ToString());

            Console.WriteLine("DATA: " + ForAll.ShowReference(m1));

            Console.WriteLine("DATA: " + ForAll.ShowReference(c1));

            Casa c2 = new Casa();
            

            if (c1 == c2)
            {

            }
            if (c1.CompareTo(c2) == 0) Console.WriteLine("Iguais");

        }
    }
}
