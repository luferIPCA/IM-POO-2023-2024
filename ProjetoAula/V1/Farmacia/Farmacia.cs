/*
*	<copyright file="Aula_5.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/10/2023 9:54:23 AM</date>
*	<description></description>
**/
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
        private Medicamento[] medicamentos;
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
            //Alocar memória para o array
            medicamentos = new Medicamento[MAX];
            //Inicializar
            for (int i=0; i<MAX; i++)
            {
                medicamentos[i] = new Medicamento();
            }
        }

        public Farmacia(string nome)
        {
            this.nome = nome;
            totMedicamentos = 0;
            //Alocar memória para o array
            medicamentos = new Medicamento[MAX];
            //Inicializar
            for (int i = 0; i < MAX; i++)
            {
                medicamentos[i] = new Medicamento();
            }
        }

        public Farmacia(string nome, int tot)
        {
            this.nome = nome;
            totMedicamentos = 0;
            //Alocar memória para o array
            medicamentos = new Medicamento[tot];
            //Inicializar
            for (int i = 0; i < MAX; i++)
            {
                medicamentos[i] = new Medicamento();
            }
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
            //Validações
            if (ExisteMedicamentoFarmacia(m1)) return false;
            medicamentos[totMedicamentos] = m1;
            totMedicamentos++;
            return true;
        }

        /// <summary>
        /// Verifica se...
        /// </summary>
        /// <param name="m1"></param>
        /// <returns></returns>
        public bool ExisteMedicamentoFarmacia(Medicamento m1)
        {
            foreach(Medicamento m in medicamentos)
            {
                //if (m.Nome == m1.Nome) return true;
                if (m == m1) return true;
                //if (m1.Nome.Equals(m.Nome)) return true;
                //if (String.Compare(m1.Nome, m.Nome)==0) return true;
            }
            return false;
        }

        public bool ExisteMedicamentoFarmacia(string nome, TipoMedi tipo)
        {
            foreach (Medicamento m in medicamentos)
            {   
                if (m.Nome.Equals(nome) && m.Tipo==tipo) return true;
            }
            return false;
        }

        public void ShowMedicamentos()
        {
            for(int i=0; i < totMedicamentos; i++)
            {
                Console.WriteLine(medicamentos[i].Nome);
            }
        }

        public int QuantosMedicamentos()
        {
            return totMedicamentos;
        }

        public int QuantosMedicamentosExistem(string nome)
        {
            int tot = 0;
            foreach(Medicamento m in medicamentos)
            {
                if (m.Nome == nome) tot++;
            }
            return tot;
        }

        public int QuantosMedicamentosExistem(string nome, TipoMedi tipo)
        {
            int tot = 0;
            foreach (Medicamento m in medicamentos)
            {
                if (m.Nome == nome && m.Tipo==tipo) tot++;
            }
            return tot;
        }

        public Medicamento[] MedicamentosExistentes
        {
            //devolve cópia do original
            get { return (Medicamento[])medicamentos.Clone(); }
            //get { return medicamentos; }        //EVITAR
            //não tem set
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
