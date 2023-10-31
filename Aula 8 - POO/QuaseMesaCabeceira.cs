/*
*	<copyright file="Aula_8___POO.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/31/2023 10:22:13 AM</date>
*	<description></description>
**/
using System;

public enum CORES { BRANCO,PRETO}

namespace Aula_8___POO
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/31/2023 10:22:13 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public abstract class QuaseMesaCabeceira : Mesa
    {
        #region Attributes
        CORES cor;
        #endregion

        #region Methods

        #region Constructors


        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public CORES Cor{
            get;
            set;
            }

        public abstract string MostraCores();

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~QuaseMesaCabeceira()
        {
        }
        #endregion

        #endregion
    }

    public class MesaCabeceira : QuaseMesaCabeceira
    {
        public override string MostraCores()
        {
            return "CABECEIRA: " + Cor.ToString();
        }
    }
   
}
