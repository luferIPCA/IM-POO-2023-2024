/*
*	<copyright file="Aula_5.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/15/2023 8:29:27 PM</date>
*	<description></description>
**/
using System;

namespace Aula_5
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/15/2023 8:29:27 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Frontend
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Frontend()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        public static void ShowMedicamentosConsole(Medicamento[] farm, int totMedicamentos)
        {
            for (int i = 0; i < totMedicamentos; i++)
            {
                Console.WriteLine(farm[i].Nome);
            }
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Frontend()
        {
        }
        #endregion

        #endregion
    }
}
