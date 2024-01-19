/*
*	<copyright file="Dados.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/27/2023 10:12:43 AM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Collections;
using ObjetosNegocio;

namespace Dados
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/27/2023 10:12:43 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Utentes
    {
        #region Attributes
        static Dictionary<int, List<Utente>> utentes;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Utentes()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public static bool InsereUtente(Utente u, int ano)
        {
            if (!utentes.ContainsKey(ano))
                utentes.Add(ano, new List<Utente>());
            if (!utentes[ano].Contains(u))
            {
                utentes[ano].Add(u);
                return true;
            }
            return false;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Utentes()
        {
        }
        #endregion

        #endregion
    }

}
