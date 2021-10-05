using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_espaçonaves_do_star_wars.Models
{
    class Viagem
    {
        
        public int id { get; set; }
        public Piloto Piloto { get; set; }
        public Nave Nave { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime DataChegada { get; set; }
    }
}
