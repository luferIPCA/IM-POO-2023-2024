/*
 * Manipulação de classes em C#
 * 
 * lufer
 * 02-10-2023
 * **/

using System;

namespace Aula_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;  //objeto
            x = 3;

            //Mesa m; //declarei objeto
            //m = new Mesa();

            Mesa m1 = new Mesa(); //declara e cria objeto do tipo Mesa
            Console.WriteLine("ANTES Num Serie: {0}", m1.QualONumeroSerie());
            Console.WriteLine("Total de Mesas: {0}", Mesa.TotMesas);
            //m1.Cor = "Branca";
            m1.DefineNumSerie(27);
            Console.WriteLine("DEPOIS Num Serie: {0}", m1.QualONumeroSerie());
            Console.WriteLine("Total de Mesas: {0}", Mesa.TotMesas);

            Mesa m2 = new Mesa(23, "Rosa");
            Console.WriteLine("DEPOIS Num Serie: {0} - Cor: {1}", m2.QualONumeroSerie(), m2.Cor);
            Console.WriteLine("Total de Mesas: {0}", Mesa.TotMesas);

            Mesa m3 = new Mesa();
            m3.NumSerie = 28;
            Console.WriteLine("DEPOIS Num Serie: {0} - Cor: {1}", m3.NumSerie, m3.Cor);
            Console.WriteLine("Total de Mesas: {0}", Mesa.TotMesas);

            Console.WriteLine("Total de Mesas Pretas: {0}", Mesa.TotMesasPretas);

            m3.Cor = "Azul";

            Console.WriteLine("Total de Mesas Pretas depois da Azul: {0}", Mesa.TotMesasPretas);
            Console.ReadKey();
        }
    }
}
