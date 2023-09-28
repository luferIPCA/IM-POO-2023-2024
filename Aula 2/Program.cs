/*
 * */

using System;

namespace Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa.nome = "Luis";
            Pessoa.peso = 12.3;

            Console.WriteLine("Peso:{0}", Pessoa.peso);

            Console.WriteLine("Idade:{0}", Pessoa.GetIdade());

        }
    }

}
