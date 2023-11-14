using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_9_Interfaces
{
    /// <summary>
    /// <code></code>
    /// </summary>
    public interface IMobiliario
    {
        /// <summary>
        /// 
        /// </summary>
        int Ano { get; set; }
    }


    public interface IHistorico
    {
        DateTime Referencia();

    }
}
