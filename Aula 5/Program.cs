/*
 * lufer
 * 
 * Arrays
 * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays#multidimensional-arrays
 * **/

using System;
using Aula_6___Armario;

namespace Aula_5
{
    
    class Program
    {
        
        #region ABORDAGEM1
        //Variavel global
        //static Medicamento[] farmacia;


        //static void Main(string[] args)
        //{

        //    //Medicamento[] farmacia = new Medicamento[10];
        //    InicializaArray(farmacia);
        //    farmacia[0].Nome = "ola";
        //}

        //static void F()
        //{
        //    farmacia[0].Nome = "ola";        }

        #endregion

        #region ABORDAGEM2

        //variavel passa por parâmetro!!!
        //static void Main()
        //{
        //    Medicamento[] farmacia;
        //    farmacia = new Medicamento[20];
        //    InicializaArray(farmacia);
        //}

        //void F()
        //{
        //    //farmacia[0].Nome = "Ola"; //ERRO, não conhece a variavel!!
        //}

        //public static bool InicializaArray(Medicamento[] a)
        //{
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        a[i] = new Medicamento();
        //    }
        //    return true;
        //}

        #endregion

        #region ABORDAGEM3
        //Variável protegida por classe
        //Classe "Farmacia" contém os dados

        //static void Main()
        //{
        //    //Cria farmácia
        //    Farmacia f1 = new Farmacia();

        //    //Cria medicamentos
        //    Medicamento m1 = new Medicamento("Novo",TipoMedi.ANTIBIOTICO, 1);
        //    Medicamento m2 = new Medicamento("Novo", TipoMedi.ANTIBIOTICO,2);
        //    Medicamento m3 = new Medicamento("Novo3", TipoMedi.ANALGESICO,3);

        //    //Mostra medicamento
        //    //Console.WriteLine("Medicamento: Nome: {0} - Tipo: {1}", m1.Nome, m1.Tipo);
        //    //ou
        //    Console.WriteLine(m1.ToString());

        //    bool aux = f1.InsereMedicamentoFarmacia(m1);
        //    aux = f1.InsereMedicamentoFarmacia(m2);

        //    //Mostra todos os medicamentos existentes na farmácia
        //    f1.ShowMedicamentos();  
        //    //Console.WriteLine("Farmacia:{0}", f1);    //QUal o resultado?

        //    //Mostra quantos medicamentos existem na farmácia
        //    Console.WriteLine("Medicamentos na Farmácia:" + f1.QuantosMedicamentos().ToString());
        //    //ou
        //    //Usa método externo para mostrar todas as prateleiras
        //    Frontend.ShowMedicamentosConsole(f1.MedicamentosExistentes, f1.QuantosMedicamentos());

        //    //Farmacia f2 = new Farmacia("Outra farmacia"); //O que acontece?

        //    Console.ReadKey();
        //}
        #endregion


        #region AORDAGEM4
        /// <summary>
        /// Dados estão num array bidimensional, na classe "Armario"
        /// </summary>
        static void Main()
        { 
            //Cria medicamentos
            Medicamento m1 = new Medicamento("Novo", TipoMedi.ANTIBIOTICO, 1);
            Medicamento m2 = new Medicamento("Novo", TipoMedi.ANTIBIOTICO, 2);
            Medicamento m3 = new Medicamento("Novo3", TipoMedi.ANALGESICO, 3);

            //Mostra medicamento
            //Console.WriteLine("Medicamento: Nome: {0} - Tipo: {1}", m1.Nome, m1.Tipo);
            //ou
            Console.WriteLine(m1.ToString());

            /*
             * Não necessita de criar Armário (Farmácia), pois 
             * o array é static
            */
            Armario.LimpaPrateleiras();
            Armario.InsereMedicamentoFarmacia(m1);
            Armario.InsereMedicamentoFarmacia(m2);
            Armario.InsereMedicamentoFarmacia(m3);

            //Mostrar todos os medicamentos existentes nas prateleiras
            Armario.ShowPrateleiras();

            Console.WriteLine("Existe Medicamento: " + Armario.ExisteMedicamentoFarmacia("Novo3", TipoMedi.ANALGESICO));
            Console.WriteLine("Total com nome {0} = {1} " , "Novo",Armario.QuantosMedicamentosNomeExistemFarmacia("Novo"));
            Console.WriteLine("Total de {0}: {1}", TipoMedi.ANTIBIOTICO, Armario.QuantosMedicamentosTipoExistemFarmacia(TipoMedi.ANTIBIOTICO));


            //Jagged Array: TPC: explorar o armário com um jagged array?
            int[][] valores = new int[3][];
            valores[0] = new int[] { 12,45,2};
            valores[1] = new int[10];

            Console.ReadKey();
        }
        #endregion

    }


}
