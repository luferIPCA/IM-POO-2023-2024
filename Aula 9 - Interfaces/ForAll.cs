/*
*	<copyright file="AUla_9___Interfaces.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/6/2023 9:54:51 AM</date>
*	<description></description>
**/
using System;

namespace Aula_9_Interfaces
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/6/2023 9:54:51 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class ForAll
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public ForAll()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public static DateTime ShowReference (IHistorico h)
        {

            return (h.Referencia());
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~ForAll()
        {
        }
        #endregion

        #endregion
    }
}
