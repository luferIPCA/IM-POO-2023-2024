/*
*	<copyright file="Aula_6.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/24/2023 9:39:40 AM</date>
*	<description></description>
**/
using System;

namespace Aula_6
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/24/2023 9:39:40 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Auxiliar
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Auxiliar()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Verifica....
        /// </summary>
        /// <param name="x"></param>
        /// <param name="v"></param>
        /// <param name="menor">Menor valor dos parametros</param>
        /// <returns></returns>
        public static bool Maior(int x, int v, out int menor)
        {
            if (x != v)
            {
                //menor = (x > v) ? v : x;

                //(x>v)? printf("ol") : printf("ole");  //ERRO
                //printf("%s",(x>y) ? "ola" : "ole");
                //Console.WriteLine("Maior: {0}", (x > v) ? v : x);
                //(x > v) ? Console.WriteLine(x.ToString() : v.ToString()); ; //ERRO
                if (x > v) menor = v;
                else
                    menor = x;
                return true;
            }
            else
            {
                menor = x;
                return false;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int IncrementaMaior(int x, int y, ref int b)
        {
            if (x != y)
            {
                b++;
                return ((x > y) ? x : y);
            }
            else
            {
                b--;
                return -1;
            }
        }

        public static bool FazCoisas(int x, out int v)
        {
            v = 2 * x;
            return true;
        }

        public static int FazOutrasCoisas(int x, ref int v)
        {
            x++;
            v = 2 * x;
            return x;
        }

        public static int FazOutrasCoisas2(int x, ref int v, out int z)
        {
            x++;
            v = 2 * x;
            z = 2 * v;
            return x;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Auxiliar()
        {
        }
        #endregion

        #endregion
    }
}
