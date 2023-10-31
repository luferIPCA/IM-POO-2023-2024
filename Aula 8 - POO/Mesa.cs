/*
*	<copyright file="Aula_8___POO.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/31/2023 10:00:54 AM</date>
*	<description></description>
**/
using System;

namespace Aula_8___POO
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/31/2023 10:00:54 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Mesa : Mobiliario
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Mesa()
        {
        }

        #endregion

        #region Properties
        #endregion


        #region Overrides
        #endregion

        #region OtherMethods
        public new string MostraNumSerieMobiliario()
        {
            return "NumSerie Mesa: " + base.MostraNumSerieMobiliario();
        }

        public override string MostraNumSerieMobiliarioII()
        {
            return "FILHO:" + base.MostraNumSerieMobiliario();
        }


        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Mesa()
        {
        }
        #endregion

        #endregion
    }
}
