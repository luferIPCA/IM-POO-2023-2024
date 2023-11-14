/*
*	<copyright file="AUla_7___POO.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/30/2023 10:12:03 AM</date>
*	<description></description>
**/
using System;

public enum TipoImob { MESA,CADEIRA, APART}

namespace Aula_9_Interfaces
{
    public class Coisas
    {
        int numSerie;

        public int NumSerie
        {
            get;set;            //ATENÇÃO
        }
    }

    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/30/2023 10:12:03 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Mobiliario : Coisas, IMobiliario, IHistorico, IComparable
    {
        #region Attributes|Estado

        //Encapsulamento: tudo TEM DE SER PRIVADO
        //Estado de classe
        private static int cod;                 //numero de serie
        private static int totImob;
        //Estado de objeto
        private TipoImob tipo;

        int ano;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor de classe: Inicializa variaveis
        /// </summary>
        static Mobiliario()
        {
            totImob = 0;
            cod = 1000;
            
        }

        /// <summary>
        /// The default Constructor Object
        /// </summary>
        public Mobiliario()
        {
            cod++;                      //cod sequencial!
            totImob++;
            tipo = TipoImob.CADEIRA;

        }

        /// <summary>
        /// Polimorfismo!!!!
        /// </summary>
        /// <param name="t"></param>
        public Mobiliario(TipoImob t)
        {
            cod++;              //cod sequencial!
            totImob++;
            tipo = t;

        }

        #endregion

        #region Properties
        /// <summary>
        /// Encapsulamento!!!
        /// </summary>
        public int Codigo
        {
            get { return cod; }
            //set;              //Encapsulado!!!
        }

        public TipoImob Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Propriedade de Classe
        /// </summary>
        public static int TotMobiliario
        {
            get { return totImob; }

        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        //public int Ano
        //{
        //    get;set;
        //}

        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public int CompareTo(object? obj)
        {
            if (obj is Mobiliario)
            {
                //if(obj.GetType() == typeof(Mobiliario)) { ..}
                Mobiliario aux = (Mobiliario)obj;
                if (aux.NumSerie > this.NumSerie)
                {
                    return -1;
                }
                if (aux.NumSerie > this.NumSerie) return 1;
                return 0;
            }
            throw new Exception();  //MAIS TARDE VEMOS!!!
        }

        public DateTime Referencia()
        {
            return DateTime.Now;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Mobiliario()
        {
            //???
        }
        #endregion

        #endregion
    }
}
