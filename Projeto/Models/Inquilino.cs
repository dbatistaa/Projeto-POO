using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Inquilino:Pessoa
    {
        #region   Atributos
        public DateTime DataInicioContrato { get; set; }
        public DateTime DataFimContrato { get; set; }
        #endregion
    }
}
