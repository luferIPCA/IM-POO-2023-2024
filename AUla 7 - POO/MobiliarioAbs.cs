/*
*	<copyright file="AUla_7___POO.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/30/2023 10:33:40 AM</date>
*	<description></description>
**/
using System;

namespace AUla_7___POO
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/30/2023 10:33:40 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public abstract class MobiliarioAbs
    {
        #region Attributes

        int cod;
        TipoImob tipo;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public MobiliarioAbs()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public abstract int ValorRealMobiliario();

        public int ValorBaseMobiliario()
        {
            return (this.tipo == TipoImob.APART ? 10000 : 2000);
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~MobiliarioAbs()
        {
        }
        #endregion

        #endregion
    }


    public class NovaMobiliario : MobiliarioAbs
    {

        public override int ValorRealMobiliario()
        {
            //throw new NotImplementedException();
            int aux = base.ValorBaseMobiliario() + 2000;
            return aux;
        }

    }

    public class OutroMobiliario : MobiliarioAbs
    {

        public override int ValorRealMobiliario()
        {
            int aux = base.ValorBaseMobiliario() + 4000;
            return aux;
        }
    }

    public abstract class Outro : MobiliarioAbs
    {
        public int NovoValor()
        {
            return base.ValorBaseMobiliario() + 20;
        }

        public abstract int ValorAmigos();
    }

    public class Final : Outro
    {
        public override int ValorRealMobiliario()
        {
            int aux = base.NovoValor();
            return aux;
        }

        public override int ValorAmigos()
        {
            return NovoValor() - 1000;
        }
    }
}
