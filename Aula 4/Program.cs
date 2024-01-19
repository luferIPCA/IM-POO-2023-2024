/*
 * lufer
 * 
 * Exercicio de Aula
 * Input/Output
 * Enumerados
 * Arrays
 * **/

using System;

namespace Aula_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ARRAYS

            //int valores[10];      //em C
            //int[] valores;
            //valores = new int[20];
            int[] valores = new int[20];
            valores[0] = 12;
            valores[12]++;
            valores[10] -= valores[7];
            //valores[20] = 14;       //Erro - rever C

            int[] valores1 = { 12, 34, 56, 78, 1, -1 };

            //Mostrar o array: for, do, while
            int tam = valores.Length; ;
            for (int i=0; i< tam; i++)
            {
                Console.WriteLine($"Valores[{i}]={valores[i].ToString()}");
            }

            Console.WriteLine("Tamanho do Array: " + valores.Length.ToString());
            
            foreach(int i in valores)
            {
                Console.WriteLine("Valor: " + i.ToString());
            }

            #region ARRAYS_OBJETOS

            Medicamento[] farmacia = new Medicamento[200];
            //Aloca memória
            for (int i = 0; i < 200; i++)
                farmacia[i] = new Medicamento();

            farmacia[0].Nome = "AAA";

            //Mostra: for; do; while
            for(int i=0; i<10; i++)
            {
                //Console.WriteLine($"Medicamento[{i}]={farmacia[i].Nome}");
                Console.WriteLine("Medicamento: Nome = {0}; Tipo {%1}", farmacia[i].Nome, farmacia[i].Tipo);
            }
            //foreach
            foreach(Medicamento m in farmacia)
            {
                Console.WriteLine("Nome: {0} - Tipo: {1}", m.Nome, m.Tipo);
            }


            //Medicamento farmacia2 = { { "ola", TipoMedi.ANT}, { }, { } }

            #endregion

            #endregion

            #region EXERC1

            Medicamento m1 = new Medicamento();
            m1.Nome = "YYY";
            m1.Tipo = TipoMedi.ANTIBIOTICO;

            Medicamento m2 = new Medicamento("XXX", TipoMedi.ANALGESICO);

            Console.WriteLine("M1: Nome: {0}", m1.Nome);
            Console.WriteLine("Tipo: " + m1.Tipo.ToString());
            Console.WriteLine($"Nome: {m1.Nome} - {m1.Tipo}");

            #endregion

            Console.ReadKey();
        }
    }
}
