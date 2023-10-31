using System;

namespace AUla_7___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobiliario m1 = new Mobiliario();
            m1.Tipo = TipoImob.MESA;
            //m1.Codigo = 12;           //ERRO
            Console.WriteLine("Codigo: {0} - Tipo: {1}", m1.Codigo, m1.Tipo.ToString());

            Mobiliario m2 = new Mobiliario();
            m2.Tipo = TipoImob.CADEIRA;
            //m1.Codigo = 12;           //ERRO
            Console.WriteLine("Codigo: {0} - Tipo: {1}", m2.Codigo, m2.Tipo.ToString());
            
            Console.WriteLine("Tot: " + Mobiliario.TotMobiliario.ToString());


            //MobiliarioAbs a = new MobiliarioAbs();      //ERRO
            NovaMobiliario m3 = new NovaMobiliario();

            Console.WriteLine("Base: {0} - Real: {1} ", m3.ValorBaseMobiliario(), m3.ValorRealMobiliario());

            OutroMobiliario m4 = new OutroMobiliario();

            Console.WriteLine("Base: {0} - Real: {1} ", m4.ValorBaseMobiliario(), m4.ValorRealMobiliario());


            Final f1 = new Final();
            
        }
    }
}
