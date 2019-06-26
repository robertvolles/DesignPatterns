using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns2.Cap7
{
    class Pedido
    {
        public string Cliente { get; private set; }

        public double Valor { get; private set; }

        public DateTime DataFinalizacao { get; private set; }

        public Status status { get; private set; }

        public Pedido(string cliente , double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.status = Status.Novo;

        }

        public void Paga()
        {
            this.status = Status.Pago;
        }

        public void Finaliza()
        {
            this.status = Status.Entregue;
            this.DataFinalizacao = DateTime.Now;
        }
    }
}
