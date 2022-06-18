using System;
using System.Collections.Generic;
using System.Text;

namespace OCPAderente
{
    class ClienteComum : Cliente
    {
        public override double DescontoPedido(double valor)
        {
            return valor - 5;
        }
    }
}
