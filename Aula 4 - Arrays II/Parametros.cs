/*
*	<copyright file="Aula4.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date></date>
*	<description>
*	Parametros: ref, out
*	</description>
**/
using System;

namespace Aula_4
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Parametros
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Parametros()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods


        public static int Soma(int x, int y)
        {
            x++;y++;
            return x + y;
        }


        public static int SomaII(ref int x, ref int y)
        {
            x++; y++;
            return x + y;
        }

        public static int SomaProduto(int x, int y, out int r)
        {
            r = x * y;
            return x + y;
        }

        

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Parametros()
        {
        }
        #endregion

        #endregion
    }
}
