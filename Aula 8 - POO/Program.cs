using System;

namespace Aula_8___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobiliario m1 = new Mobiliario();
            Mesa me1 = new Mesa();
            Console.WriteLine("Mesa n: " + me1.NumSerie.ToString());
            Console.WriteLine("Mesa: " + me1.MostraNumSerieMobiliario());
            Console.WriteLine("Mesa: " + me1.MostraNumSerieMobiliarioII());

            MesaCabeceira mc = new MesaCabeceira();
            mc.MostraCores();
        }
    }
}
