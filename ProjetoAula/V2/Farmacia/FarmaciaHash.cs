/*
*	<copyright file="Aula_5.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/10/2023 9:54:23 AM</date>
*	<description></description>
**/
using System.Collections;
using System;

namespace Farmacia
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/10/2023 9:54:23 AM
    /// Gerir Farmácia:
    /// Inserção
    /// Consulta
    /// Remoção
    /// ...
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class FarmaciaHash
    {
        #region Attributes

        private string nome;
        MyHash medicamentos;
        private int totMedicamentos;    //indica o total de medicamentos existentes

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public FarmaciaHash()
        {
            totMedicamentos = 0;
            nome = "Farmacia Moderna";
            medicamentos = new MyHash();
        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public string NomeFarmacia
        {
            get { return nome; }
            set { nome = value; }
        }

        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Insere...
        /// </summary>
        /// <param name="m1"></param>
        /// <returns></returns>
        public bool InsereMedicamentoFarmacia(Medicamento m)
        {
            return medicamentos.InsereNovo(m);
        }

        public void ShowMedicamentos()
        {
            medicamentos.MostraHash();  
        }


        public bool SaveAll(string fileName)
        {
            return medicamentos.SaveFile(fileName);
        }

        public bool LoadAll(string fileName)
        {
            return medicamentos.LoadFile(fileName);
        }

        public void Clear()
        {
            medicamentos.Clear();
        }
      
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~FarmaciaHash()
        {
        }
        #endregion

        #endregion
    }
}
