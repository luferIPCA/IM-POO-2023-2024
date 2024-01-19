using Microsoft.VisualStudio.TestTools.UnitTesting;

using Farmacia;

namespace TestFarmacia
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsereFarmacia()
        {
            //1
            bool saida = false;
            Farmacia.Medicamento f= new Medicamento("ola", TipoMedi.ANTIBIOTICO, 2);
            FarmaciaHash fh = new FarmaciaHash();

            //2
            saida=fh.InsereMedicamentoFarmacia(f);

            //3
            Assert.IsTrue(saida==true,"Cuidado");

        }

        [TestMethod]
        public void InsereDuplicados()
        {
            //1
            bool saida = false;
            Farmacia.Medicamento f = new Medicamento("ola", TipoMedi.ANTIBIOTICO, 2);
            Farmacia.Medicamento f1 = new Medicamento("ola", TipoMedi.ANTIBIOTICO, 2);
            FarmaciaHash fh = new FarmaciaHash();
            //2
            saida = fh.InsereMedicamentoFarmacia(f);
            saida = fh.InsereMedicamentoFarmacia(f1);

            //3
            Assert.IsTrue(saida == false, "Medicamento já existente");
        }

        [TestMethod]
        public void InsereCoisaFarmacia()
        {
            //
            int x;
            bool res = true;
            FarmaciaHash fh = new FarmaciaHash();
            MyHash mH = new MyHash();

            //
            res=mH.InsereNovo(fh);

            //
            Assert.IsFalse(res, "Não pode inserir Coisas na farmacia");
        }

        [TestMethod]
        public void TotalMedicamentos()
        {
            //1
            MainFarmacia mf = new MainFarmacia();
            Medicamento m = new Medicamento("ole", TipoMedi.ANALGESICO, 3);
            int totIni = mf.TotalMedicamentos();
            int totFim = totIni;
            bool res = false;

            //2
            res = mf.InsereMedicamentoFarmacia(m);
            totFim = mf.TotalMedicamentos();

            //3

            Assert.AreEqual(totIni, totFim, "Não inseriu");

        }
    }
}
