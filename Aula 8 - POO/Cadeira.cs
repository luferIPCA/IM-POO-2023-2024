/*
*	<copyright file="Aula_8___POO.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/31/2023 10:09:37 AM</date>
*	<description></description>
**/
using System;

namespace Aula_8___POO
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/31/2023 10:09:37 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Cadeira : Mobiliario
    {
        #region Attributes
        public int pernas;      //ATENÇÂO
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Cadeira()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Cadeira()
        {
        }
        #endregion

        #endregion
    }
}
