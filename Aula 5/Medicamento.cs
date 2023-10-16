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
    ANALGESICO, //0
    ANTIBIOTICO //1
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
        private int numSerie;
        DateTime dataValidade;  //rever DateTime

        //Alternativa
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

        public Medicamento(string nomeMed, TipoMedi t, int numS)
        {
            nome = nomeMed;
            tipo = t;
            dataValidade = DateTime.Today;
            numSerie = numS;
        }

        public Medicamento(string nome, TipoMedi t, DateTime dv)
        {
            this.nome = nome;
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

        public override string ToString()
        {
            return String.Format("Ficha de Medicamento=> Nome: {0} - Tipo: {1} \n", nome, tipo);
            //return base.ToString();
        }

        public override bool Equals(object obj)
        {
            //Testar se obj é medicamento... 
            //Medicamento aux = obj as Medicamento;
            Medicamento aux = (Medicamento)obj;
            if (this.nome == aux.nome && this.tipo==aux.tipo) return true;
            return false;
            //return base.Equals(obj);
        }


        #endregion

        #region Operators
        //==
        public static bool operator ==(Medicamento m1, Medicamento m2)
        {
            //return m1.Equals(m2);
            if (!(m1 is null) && !(m2 is null)) 
                if (m1.nome == m2.nome && m1.tipo == m2.tipo) return true;
            return false;
        }

        public static bool operator !=(Medicamento m1, Medicamento m2)
        {
            return !(m1 == m2);
        }

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
