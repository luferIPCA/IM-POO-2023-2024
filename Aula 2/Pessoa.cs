
/*
 * Classe para descrever uma Pessoa
 * data
 * autor
 * 
 * */

namespace Aula_2
{
    /// <summary>
    /// Class Pessoa
    /// </summary>
    public class Pessoa
    {
        #region ESTADO | ATRIBUTOS | VARIAVEIS

        static int idade;           //privado
        public static string nome;  //publico
        public static double peso;

        #endregion

        #region COMPORTAMENTO | Beaviour | METHODS

        public static double GetIdade()
        {
            return 25;
        }

        #endregion
    }
}
