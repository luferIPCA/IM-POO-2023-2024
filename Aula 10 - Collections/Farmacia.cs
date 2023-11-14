/*
*	<copyright file="Aula_10___Collections.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/13/2023 10:24:56 AM</date>
*	<description></description>
**/
using System;
using System.Collections;

namespace Aula_10___Collections
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/13/2023 10:24:56 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Farmacia
    {
        #region Attributes

        //Medicamento[] medica;
        ArrayList medicamentos;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Farmacia()
        {
            medicamentos = new ArrayList();
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public bool AddMedicamento(Medicamento m)
        {
            if (medicamentos.Contains(m)) return false;
            medicamentos.Add(m);
            return true;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Farmacia()
        {
        }
        #endregion

        #endregion
    }
}
