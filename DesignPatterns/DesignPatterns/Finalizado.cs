﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception ( "Orcamentos finalizados nao recebem desconto extra");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta finalizado");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta finalizado");
        }
        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta finalizado");
        }
    }
}
