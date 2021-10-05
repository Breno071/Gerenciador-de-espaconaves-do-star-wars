using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_espaçonaves_do_star_wars.Models
{
    class Piloto
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public Planeta Planeta { get; set; }
    }
}
