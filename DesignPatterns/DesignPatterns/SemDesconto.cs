﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class SemDesconto : Desconto
    {
        public Desconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento0)
        {
            return 0;
        }
                             
    }
}
