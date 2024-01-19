using System;

namespace BODLL
{
    public class Pessoa: IComparable<Pessoa>
    {
        #region Attributes
         int idade;
         string nome;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Pessoa()
        {
        }

        #endregion

        #region Properties

        public string Nome { get { return nome; } set { nome = value; } }
        public int Idade { get { return idade; } set { idade = value; } }

        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public int CompareTo(Pessoa p){
            return 1;

        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Pessoa()
        {
        }
        #endregion

        #endregion
    }
}
