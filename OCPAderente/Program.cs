using System;

namespace OCPAderente
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteComum clienteComum = new ClienteComum();
            ClienteAssociado clienteAssociado = new ClienteAssociado();
            ClienteVip clienteVip = new ClienteVip();

            var valorPedidoClienteComun =
               clienteComum.DescontoPedido(1000);

            var valorPedidoClienteAssociado =
                clienteAssociado.DescontoPedido(1000);

            var valorPedidoClienteVip =
                clienteVip.DescontoPedido(1000);

            Console.WriteLine("Principio OCP - Aderente");

            Console.WriteLine($"Cliente Comum = " +
                $"{valorPedidoClienteComun}");

            Console.WriteLine($"Cliente Associado = " +
                $"{valorPedidoClienteAssociado}");

            Console.WriteLine($"Cliente Vip = " +
                $" {clienteVip}");

            Console.ReadLine();
        }
    }
}
