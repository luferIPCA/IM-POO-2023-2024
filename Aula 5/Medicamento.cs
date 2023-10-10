/*
*	<copyright file="Aula_4.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/9/2023 9:47:43 AM</date>
*	<description> Descreve um medicamento </description>
**/
using System;

public enum TipoMedi
{
    ANALGESICO,
    ANTIBIOTICO
}

namespace Aula_5
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/9/2023 9:47:43 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Medicamento
    {
        #region Attributes

        private string nome;
        private TipoMedi tipo;
        DateTime dataValidade;  //rever DateTime

        //static Medicamento[] farmacia;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Medicamento()
        {
            nome = "";
            tipo = TipoMedi.ANALGESICO;
            dataValidade = DateTime.Today;
        }

        public Medicamento(string nomeMed, TipoMedi t)
        {
            nome = nomeMed;
            tipo = t;
            dataValidade = DateTime.Today;
        }

        public Medicamento(string nomeMed, TipoMedi t, DateTime dv)
        {
            nome = nomeMed;
            tipo = t;
            dataValidade = dv;
        }

        #endregion

        #region Properties

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public TipoMedi Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Medicamento()
        {
        }
        #endregion

        #endregion

    }
}
