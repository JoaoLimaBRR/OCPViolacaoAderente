using System;
using System.Collections.Generic;
using System.Text;

namespace OCPAderente
{
    class ClienteAssociado : Cliente
    {
        public override double DescontoPedido(double valor)
        {
            return valor - 10;
        }
    }
}
