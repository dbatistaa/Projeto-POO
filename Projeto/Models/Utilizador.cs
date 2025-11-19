using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Utilizador
    {
        #region Atributos User
        public int Id { get; set; }
        public string PasswordHash { get; private set; }
        public string NivelAcesso { get; set; } //Proprietario ou Inquilino
        #endregion
    }
}
