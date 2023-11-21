using System;

namespace Farmacia
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Farmacia com ArrayList

            Farmacia f = new Farmacia();

            Medicamento m1 = new Medicamento("X", TipoMedi.ANALGESICO,DateTime.Now);
            Medicamento m2 = new Medicamento("Y", TipoMedi.ANALGESICO, DateTime.Now);
            Medicamento m3 = new Medicamento("Y", TipoMedi.ANTIBIOTICO, DateTime.Now);
            f.InsereMedicamentoFarmacia(m1);
            f.InsereMedicamentoFarmacia(m2);
            f.InsereMedicamentoFarmacia(m3);

            f.ShowMedicamentos();
            f.medi.Sort();
            f.ShowMedicamentos();

            #endregion

            #region Demonstrar HashTable

            MyHash h = new MyHash();

            h.InsereNovo(m1);
            h.InsereNovo(m2);
            h.InsereNovo(m3);

            h.MostraHash();

            //Console.WriteLine(h.FuncaoHash("Luis").ToString());
            //Console.WriteLine(h.FuncaoHash("Luisa").ToString());

            #endregion

            #region Farmacia com HashTable

            FarmaciaHash fh = new FarmaciaHash();
            fh.InsereMedicamentoFarmacia(m1);
            fh.InsereMedicamentoFarmacia(m2);
            fh.InsereMedicamentoFarmacia(m3);
            fh.ShowMedicamentos();

            #region Gravar em Ficheiro

            fh.SaveAll(@"c:\temp\Farmacia.dat");

            fh.Clear();
            Console.WriteLine("Após apagar tudo!!!");
            fh.ShowMedicamentos();

            fh.LoadAll(@"c:\temp\Farmacia.dat");
            Console.WriteLine("Após carregar ficheiro!!!");
            fh.ShowMedicamentos();

            #endregion

            #endregion

            Console.WriteLine("Done!");
        }
    }
}
