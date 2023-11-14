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

namespace Aula_8___POO
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/30/2023 10:12:03 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Mobiliario
    {
        #region Attributes|Edtado

        int numSerie;
        //protected int ano;
        int ano;
        static int numGlobalSerie;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor de classe: Inicializa variaveis
        /// </summary>
        static Mobiliario()
        {
            numGlobalSerie = 0;
        }

        /// <summary>
        /// The default Constructor Object
        /// </summary>
        public Mobiliario()
        {
            numSerie = numGlobalSerie;
            numGlobalSerie++;
        }


        #endregion

        #region Properties
        /// <summary>
        /// Encapsulamento!!!
        /// </summary>
        public int NumSerie
        {
            get { return numSerie; }
            set { numSerie = value; }
        }

        public int Ano
        {
            get;set;
        }
        public static string MostraDetalhesMobiliario()
        {
            return "Total Objetos: " + numGlobalSerie;
        }

        public string MostraNumSerieMobiliario()
        {
            return "NumSerie: " + numSerie;
        }

        public virtual string MostraNumSerieMobiliarioII()
        {
            return "PAI: NumSerie: " + numSerie;
        }

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Mobiliario()
        {
        }
        #endregion

        #endregion

        #endregion
    }
}
