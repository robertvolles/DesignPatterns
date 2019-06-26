using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ICPP : Imposto
    {
        public ICPP(Imposto outroImposto) : base(outroImposto) { }
        public ICPP() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07 + CalculoDoOutroImposto(orcamento);
        }
        
    }
}
