using Controllers;
using Models;

Console.WriteLine("Inicio do processamento...");

Order order1 = new()
{
   Description = "Banana com canela gostosa",
   Table = 15,
   Item = new Item { Description = "Item1"}
};

Console.WriteLine(new OrderController().Insert(order1) ? "Inserido com sucesso" : "Erro ao inserir");