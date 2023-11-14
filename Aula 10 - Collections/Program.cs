/**
 * lufer
 * email
 * date
 * desc: Collections
 * */


using System;
using System.Collections;   //Necessário!!!

namespace Aula_10___Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicamento m1 = new Medicamento("Paracetamol", TipoMedi.ANALGESICO, DateTime.Today) ;

            ArrayList a1 = new ArrayList();

            a1.Add(m1);
            //a1.Add(m1);
            a1.Add(27);
            if (!a1.Contains(m1))
                a1.Add(m1);
            a1.Remove(m1);

            foreach(object o in a1)
            {
                if(o is Medicamento)
                {
                    Console.WriteLine(((Medicamento)o).Nome);
                }
                else

                Console.WriteLine(o.ToString());
            }


            Farmacia f = new Farmacia();
            f.AddMedicamento(m1);

            Stack s1 = new Stack();
            s1.Push(12);
            s1.Push(m1);


            Queue q1 = new Queue();

            ArrayList outro = new ArrayList();
            //outro.Add(12);

            Medicamento m2 = new Medicamento();
            outro.Add(m1);
            outro.Add(m2);
            outro.Sort();

            foreach (object o in outro)
            {
                Console.WriteLine(o.ToString());
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
