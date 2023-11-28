/*
*	<copyright file="Validacoes.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/27/2023 10:28:38 AM</date>
*	<description></description>
**/
using System;

namespace Validacoes
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/27/2023 10:28:38 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Valida
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Valida()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public static bool IdadeValida(int idade)
        {
            return (idade > 0 && idade < 120);
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Valida()
        {
        }
        #endregion

        #endregion
    }
}
