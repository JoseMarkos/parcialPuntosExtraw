using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialBlanco.Models
{
    public class Politic
    {

        public int ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public State state { get; set; }
        public String Description { get; set; }
    }
}
