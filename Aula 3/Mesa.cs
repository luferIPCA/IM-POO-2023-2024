/*
 * Classe Mesa
 * 
 * lufer
 * 02-10-2023
 * 
 * Regiões
 * 
 * Variaveis/metodos de instância
 * Variaveis/metodos de classe
 * 
 * Construtores de instâncias/classes
 * 
 * Polimorfismo/Overloading de métodos
 * 
 * Pripriedades objectos/classes
 * 
 * **/


using System;

namespace Aula_3
{
    class Mesa
    {
        #region ESTADO

        #region ESTADO_OBJETO
        private int numSerie;
        private string cor;
        #endregion

        #region ESTADO_CLASSE
        private static int totMesas; //Variável de Classe: total de mesas
        private static int totMesasPretas;

        #endregion

        #endregion

        #region METODOS

        #region CONST

        /// <summary>
        /// Construtor de class
        /// Inicializa variáveis de classe
        /// </summary>
        static Mesa()
        {
            totMesas = 0;   //atributo da classe
            totMesasPretas = 0;
        }

        /// <summary>
        /// Construtor por omissão de uma mesa
        /// </summary>
        public Mesa()
        {
            numSerie = 0;
            cor = "preto";
            totMesas++;     //atributo da classe
            totMesasPretas++;
        }

        public Mesa (int ns, string cor)
        {
            numSerie = ns;
            this.cor = cor;
            totMesas++;
            if (cor == "preto") //Equals
            {
                totMesasPretas++;
            }
        }

        #endregion

        #region PROPRIEDADES

        #region PROPRIEDADES_CLASSE
        /// <summary>
        /// Método de classe
        /// </summary>
        public static int TotMesas
        {
            get { return totMesas; }
            //set { }    //valor apenas controlado internamente
        }

        public static int TotMesasPretas
        {
            get { return totMesasPretas; }
        }

        #endregion

        #region PROPRIEDADES_INSTANCIA

        /// <summary>
        /// Pripriedade para manipular numSerie
        /// </summary>
        public int NumSerie
        {
            //insere valores
            set {
                //if (value < 0)
                //    numSerie = 0;
                //else
                    numSerie = value; 
            }
            get {
                //if (numSerie > 100)
                //    return numSerie - 20;
                //else
                    return numSerie; 
            }
        }

        public string Cor
        {
            get { return cor; }
            set {
                if (value != "preto") totMesasPretas--;
                cor = value; 
            }
        }

        #endregion

        #endregion

        #region OUTROS
        public bool DefineNumSerie(int ns)
        {
            numSerie = ns;
            return true;
        }

        public int QualONumeroSerie()
        {
            return numSerie;
        }

        #endregion

        #region DEST
        ~Mesa()
        {
            //qualquer coisa que deve ser feita antes de retirar a memória ocupada!!!!
        }
        #endregion

        #endregion

    }
}
