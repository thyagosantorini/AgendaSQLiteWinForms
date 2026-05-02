using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWinFormsSQLite.Models
{
    /// <summary>
    /// Classe de Modelo (Entidade) que representa a estrutura de um Contato na aplicação.
    /// </summary>
    public class Contato
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
