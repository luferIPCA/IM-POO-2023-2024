/*
*	<copyright file="Farmacia.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/20/2023 10:03:27 AM</date>
*	<description>Gestão de uma Tabela de Hash</description>
**/
using System.Collections;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using FrontEnd;

namespace Farmacia
{
    /// <summary>
    /// Purpose: Gerir uma Hash de Medicamentos
    /// Created by: lufer
    /// Created on: 11/20/2023 10:03:27 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class MyHash
    {
        #region Attributes
        
        const int N = 55;   //deve ser número primo
        Hashtable hash;
 
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public MyHash()
        {
            hash = new Hashtable();
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Calcula a Hash de um valor
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        private int FuncaoHash (string nome)
        {
            int tot = 0;

            for(int i=0; i < nome.Length; i++)
            {
                tot = tot + (int)nome[i];
            }
            return (tot % N);
        }
        
        /// <summary>
        /// Insere Medicamento na Hash e gere colisões
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool InsereNovo(object x) {

            if (x.GetType() != typeof(Medicamento)) return false;

            Medicamento aux = (Medicamento)x;
            int valorHash = FuncaoHash(aux.Nome);      
            if (!hash.ContainsKey(valorHash))  //se ainda não existe esta chave
            {
                hash.Add(valorHash, new ArrayList());
            }
            //insere novo medicamento...se não existir!!
            ((ArrayList)(hash[valorHash])).Add(x);
            return true;
            //return false  - verficar se já existe e não admitir repetidos x
        }

        public bool RemoveMedicamento(Medicamento m)
        {
            int k = FuncaoHash(m.Nome);
            if (!hash.ContainsKey(k)) return false;
            ((ArrayList)hash[k]).Remove(m);
            return true;
        }
        
        /// <summary>
        /// Apresenta conteúdo da HashTable
        /// </summary>
        /// <returns></returns>
        public bool MostraHash()
        {
            foreach(object k in hash.Keys)
            {
                int aux = (int)k;
                ArrayList valores = ((ArrayList)hash[aux]);
                
                IO.ShowArrayList(valores);

                //Console.WriteLine("Key: " + aux.ToString());
                //foreach (object v in valores)
                //{
                //    Medicamento m = (Medicamento)(v);
                //    Console.WriteLine(m.Nome);
                //}
            }
            return true;
        }

        public bool ExisteMedicamento (string nome, ArrayList medis)
        {
            foreach (Medicamento m in medis)
            {
                if (String.Compare(m.Nome, nome) == 0) return true;
            }
            return false;
        }

        #region Preservar em Ficheiro

        public bool SaveFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Create);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, hash);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
            }
            return false;
        }

        public bool LoadFile(string fileName)
        {
            if (!File.Exists(fileName)) return false;  
            try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    hash = (Hashtable) bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
        }

        public void Clear()
        {
            hash.Clear();
        }
        #endregion


        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~MyHash()
        {
        }
        #endregion

        #endregion
    }
}
