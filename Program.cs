using exercicio_classe01;


Produto produto01 = new();
produto01.QuantidadeEstoque = 3;

produto01.Inserir(3);
Console.WriteLine($"Quatidade de produto no estoque: {produto01.QuantidadeEstoque}.");
