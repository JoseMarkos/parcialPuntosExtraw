using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialBlanco.Models
{
    public class ClientService
    {
        public int ID { get; set; }
        public string ClientNombre { get; set; }
        public int ClientAccount { get; set; }

        public Employe Supporter { get; set; }
    }
}
