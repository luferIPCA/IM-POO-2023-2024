/*
*	<copyright file="ObjetosNegocio.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/27/2023 10:13:09 AM</date>
*	<description></description>
**/
using System;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/27/2023 10:13:09 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Utente
    {
        #region Attributes
        string nome;
        int idade;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Utente()
        {
        }

        #endregion

        #region Properties

        public string Nome { get; set; }
        public int Idade { set; get; }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Utente()
        {
        }
        #endregion

        #endregion
    }
}
