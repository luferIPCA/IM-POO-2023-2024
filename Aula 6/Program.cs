/*
 * lufer
 * email
 * data
 * parametros ref e out
 * */
using System;

namespace Aula_6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            #region A

            Console.WriteLine("Hello World!");

            string nome = Console.ReadLine();
            Console.WriteLine("Hello : " + nome);

            int valor = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor = " + valor.ToString());

            Console.Write("Valor inteiro: ");
            string valorS = Console.ReadLine();
            bool aux = int.TryParse(valorS, out int v);
            if (aux == true)
            {
                Console.WriteLine("Valor = " + v.ToString());
            }
            else
            {
                Console.WriteLine("Valor Errado ");
            }

            int x;
            aux = Auxiliar.FazCoisas(12, out x);

            int novo = 2;
            int y = Auxiliar.FazOutrasCoisas(x, ref novo);
            #endregion

            #region B

            int k;
            aux = Auxiliar.Maior(2, 3, out k);
            if (aux == true)
                Console.WriteLine("O Menor valor= {0}", k);
            else
                Console.WriteLine("São iguais");

            int auxRef = 0;
            int k1 = Auxiliar.IncrementaMaior(2, 3, ref auxRef);
            #endregion

        }
    }
}
