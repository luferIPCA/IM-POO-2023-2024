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
    public class Mesa : Mobiliario, IComparable
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

        /// <summary>
        /// Comparador de Mobiliário
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int CompareTo( Object m)
        {
            if(object.ReferenceEquals(m,null)==true)
            if (m.GetType() != typeof(Mobiliario))
                throw new Exception("Invalid Object to compare");
            Mobiliario aux = m as Mobiliario;
            if (this.Ano > aux.Ano) return 1;
            else
                if (this.Ano < aux.Ano) return -1;
            return 0;

            //ou
            //return this.Ano.CompareTo(aux.Ano);

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
