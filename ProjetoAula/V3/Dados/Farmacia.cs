/**
 * lufer
 * DAO
 * email
 * data
 * Desc
 * */

using System.Collections.Generic;
using ObjetosNegocio;

//Pattern: singleton

namespace Dados
{
    public class Farmacia
    {
        static List<Medicamento> medicamentos;

        static Farmacia()
        {
            medicamentos = new List<Medicamento>();
        }

        public static bool InsereMedicamento(Medicamento m)
        {
            if (!medicamentos.Contains(m))
            {
                medicamentos.Add(m);
                return true;
            }
            return false;
        }

        public static bool ExisteMedicamento(string nomeMedicamento)
        {
            foreach(Medicamento m in medicamentos)
            {
                if (m.Nome == nomeMedicamento) return true;
            }
            return false;
        }
    }
}
