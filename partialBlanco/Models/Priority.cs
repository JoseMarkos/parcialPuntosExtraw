﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialBlanco.Models
{
    public class Priority
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public State State { get; set; }
    }
}
