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
    public class Farmacia
    {
        #region Attributes
        const int MAX = 5000;

        private string nome;
        public ArrayList medi;      //CUIDADO
        private int totMedicamentos;    //indica o total de medicamentos existentes

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Farmacia()
        {
            totMedicamentos = 0;
            nome = "Nova";
            medi = new ArrayList();
            //Inicializar
 
        }

        


        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public string Nome
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
        public bool InsereMedicamentoFarmacia(Medicamento m1)
        {
            //Validações;
            if (medi.Contains(m1)) return false;
            medi.Add(m1);
            return true;
        }

        

        public void ShowMedicamentos()
        {
            foreach(object o in medi)
            {
                Medicamento aux = (Medicamento)o;
                Console.WriteLine(aux.Nome);
            }
            
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
