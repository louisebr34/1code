
  using System;
  using System.Collections.Generic;

namespace ExemploPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um objeto Pedido
            Pedido pedido = new Pedido
            {
                Cliente = "João da Silva",
                Data = DateTime.Now,
                Itens = new List<ItemDePedido>
                {
                    new ItemDePedido { Nome = "Produto A", Quantidade = 2, PrecoUnitario = 10.0m },
                    new ItemDePedido { Nome = "Produto B", Quantidade = 1, PrecoUnitario = 15.0m }
                }
            };

            // Calculando o total do pedido
            pedido.CalcularTotal();

            // Exibindo informações no console
            Console.WriteLine($"Cliente: {pedido.Cliente}");
            Console.WriteLine($"Data do pedido: {pedido.Data}");
            Console.WriteLine("Itens do pedido:");
            foreach (var item in pedido.Itens)
            {
                Console.WriteLine($"- {item.Nome}: {item.Quantidade} x {item.PrecoUnitario:C}");
            }
            Console.WriteLine($"Total do pedido: {pedido.Total:C}");
        }
    }

    class Pedido
    {
        public string Cliente { get; set; }
        public DateTime Data { get; set; }
        public List<ItemDePedido> Itens { get; set; }
        public decimal Total { get; private set; }

        public void CalcularTotal()
        {
            Total = 0;
            foreach (var item in Itens)
            {
                Total += item.Quantidade * item.PrecoUnitario;
            }
        }
    }

    class ItemDePedido
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
    }
}
