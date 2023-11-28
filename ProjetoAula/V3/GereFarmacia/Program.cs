/**
 * */
using System;
using ObjetosNegocio;
using RegrasNegocio;

namespace GereFarmacia
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicamento m = new Medicamento("Aspegic", TipoMedi.ANALGESICO, DateTime.Now);
            if (GereFarmaciaBL.InsereMedicamento(m))
            {
                Console.WriteLine("Sucesso!");
            }
            else
                Console.WriteLine("Nao!");

            Console.WriteLine(GereFarmaciaBL.InsereMedicamento(m)==true ? "Sim ": "Não");


            Console.WriteLine("Existe:" + GereFarmaciaBL.VerficaExisteMedicamento(m.Nome).ToString());
        }
    }
}
