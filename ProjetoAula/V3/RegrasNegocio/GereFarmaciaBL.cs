/**
 * lufer
 * BL
 * Desc
 * email
 * data
 * */
using Dados;
using ObjetosNegocio;
using System;
using Validacoes;

namespace RegrasNegocio
{
    public class GereFarmaciaBL
    {
        public static bool InsereMedicamento(Medicamento m)
        {
            if (m.Tipo != TipoMedi.ANTIBIOTICO)     // Regra de negocio
            {
                return Farmacia.InsereMedicamento(m);
            }
            return false;
        }


        public static bool VerficaExisteMedicamento(string nomeMed)
        {
            if (String.IsNullOrEmpty(nomeMed)) return false;
            return (Farmacia.ExisteMedicamento(nomeMed));
        }

        public static bool InsereUtente (Utente u)
        {
            if (!Valida.IdadeValida(u.Idade)) return false;
            return (Utentes.InsereUtente(u,2023));
        }

    }

}
