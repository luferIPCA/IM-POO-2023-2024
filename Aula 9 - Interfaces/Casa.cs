/*
*	<copyright file="AUla_9___Interfaces.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/6/2023 9:50:43 AM</date>
*	<description></description>
**/
using System;

enum TipoCasa { T1, T2, T3, V1
}

namespace Aula_9_Interfaces
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/6/2023 9:50:43 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Casa: Coisas, IHistorico, IComparable
    {
        #region Attributes

        TipoCasa tipo;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Casa()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public DateTime Referencia()
        {
            return (new DateTime(2000, 1, 1));
        }

        public int CompareTo(object? obj)
        {
            if (obj is null) return 0;
            //if (object.ReferenceEquals(obj, null)) return 0;
            //if (obj.GetType() != typeof(Casa)) return 0;
            if (!(obj is Casa)) return 0;
            Casa aux = obj as Casa;
            if (this.tipo > aux.tipo) return 1;     //this maior que parametro
            else
                if (this.tipo < aux.tipo) return -1;    //this menor que parametro
            return 0;   //iguais
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Casa()
        {
        }
        #endregion

        #endregion
    }
}
