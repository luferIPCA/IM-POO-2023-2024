/*
*	<copyright file="Aula_5.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/15/2023 8:43:12 PM</date>
*	<description>
*	Array Bidimensional
*	</description>
**/
using System;

namespace Aula_5
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/15/2023 8:43:12 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Armario
    {
        #region Attributes

        const int HORI = 10;
        const int VERT = 10;
        static Medicamento[,] prateleiras;//new Medicamento[x,y]
        
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// Cria espaço em memória para as prateleiras
        /// </summary>
        static Armario()
        {
            prateleiras = new Medicamento[HORI, VERT];
            //Falta inicializar array
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Mostra Array Bidimensional
        /// </summary>
        public static void ShowPrateleiras()
        {
            for (int h = 0; h < prateleiras.GetLength(0); h++)
            {
                Console.WriteLine("Prateleira dos {0}", (TipoMedi)h);
                for (int v = 0; v < prateleiras.GetLength(1); v++)
                {
                    if (prateleiras[h, v] is null) continue;
                    Console.Write(prateleiras[h, v].ToString());
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Mostra array unidimensional
        /// </summary>
        /// <param name="m1">array</param>
        /// <returns></returns>
        public static bool InsereMedicamentoFarmacia(Medicamento m1)
        {
            //procura primeira posição livre na prateleira deste tipo de medicamento
            int i = 0;
            while (!(prateleiras[(int)m1.Tipo, i] is null) && i<VERT) i++;

            //Se existe espaço na prateleira
            if (i < VERT)
            {
                //prateleiras[(int)m1.Tipo, i] = new Medicamento();
                prateleiras[(int)m1.Tipo, i] = m1;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Faz "reset" ao array bidimensional (prateleiras)
        /// </summary>
        public static void LimpaPrateleiras()
        {
            for (int h = 0; h < prateleiras.GetLength(0); h++)
            {
                for (int v = 0; v < prateleiras.GetLength(1); v++)
                    prateleiras[h, v] = null;
                
            }
        }

        /// <summary>
        /// Verifica se determinado medicamento existe na farmácia
        /// </summary>
        /// <param name="nome">Nome do Medicamento</param>
        /// <param name="tipo">Tipo de Medicamento</param>
        /// <returns></returns>
        public static bool ExisteMedicamentoFarmacia(string nome, TipoMedi tipo)
        {
            for(int i=0; i<VERT; i++)
            {
                if (prateleiras[(int)tipo, i].Nome == nome) return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica quantos medicamentos com o mesmo nome existem na farmácia
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static int QuantosMedicamentosNomeExistemFarmacia(string nome)
        {
            int tot = 0;
            for (int h = 0; h < prateleiras.GetLength(0); h++)
            {
                for (int v = 0; v < prateleiras.GetLength(1); v++)
                    if (!(prateleiras[h, v] is null) && prateleiras[h, v].Nome == nome) tot++;
            }
            return tot;
        }

        /// <summary>
        /// Verifica quantos medicamentos do mesmo tipo existem na farmácia
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static int QuantosMedicamentosTipoExistemFarmacia(TipoMedi tipo)
        {
            int tot = 0;
            for (int i = 0; i < VERT; i++)
            {
                if (!(prateleiras[(int)tipo, i] is null ) && prateleiras[(int)tipo, i].Tipo == tipo) tot++;
            }
            return tot;
        }
    
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Armario()
        {
        }
        #endregion

        #endregion
    }
}
