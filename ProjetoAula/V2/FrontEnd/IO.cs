/**
 * lufer
 * email
 * desc
 * data
 * */
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd
{
    /// <summary>
    /// Métodos para Input/Output
    /// </summary>
    public class IO
    {
        /// <summary>
        /// Apresenta uma string no ecrã
        /// </summary>
        /// <param name="s"></param>
        public static void ShowString(string s)
        {
            Console.WriteLine(s);
        }

        public static void ShowArrayList(ArrayList valores)
        {
            foreach(object o in valores)
            {
                if (o.GetType() == typeof(Medicamento))
                {
                    Medicamento aux = (Medicamento)o;
                    ShowString(aux.ToString());
                }
            }
        }

    }
}
