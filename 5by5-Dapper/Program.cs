using Controllers;
using Models;

Console.WriteLine("Inicio do processamento...");

Order order1 = new()
{
    Description = "Banana com peixe",
    Table = 12
};

Console.WriteLine(new OrderController().Insert(order1) ? "Inserido com sucesso" : "Erro ao inserir");