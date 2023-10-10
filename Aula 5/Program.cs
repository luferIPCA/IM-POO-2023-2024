/* 
 * **/

using System;

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

        static void Main()
        {

            Farmacia f1 = new Farmacia();

            Medicamento m1 = new Medicamento("Novo",TipoMedi.ANTIBIOTICO);
            bool aux = f1.InsereMedicamentoFarmacia(m1);

            f1.ShowMedicamentos();
            Console.WriteLine("Medicamentos na Farmácia:" + f1.QuantosMedicamentos().ToString());
            Console.WriteLine("Sucesso:" + aux);

            //Farmacia f2 = new Farmacia("Outra farmacia");

            Console.ReadKey();
        }
        #endregion
    }
}
