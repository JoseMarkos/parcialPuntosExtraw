using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialBlanco.Models
{
    public class Bank
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string NIT { get; set; }
        public BankType Type { get; set; }
    }
}
