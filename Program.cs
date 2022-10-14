using exercicio_classe01;

Produto produto01 = new();
produto01.Codigo = 456789;
produto01.Nome = "Cafeteira Walita";
produto01.PrecoCompra = 50.342m;
produto01.PrecoVenda = 150.90m;
produto01.QuantidadeEstoque = 20;
produto01.Ativo = true;
produto01.DataCadastro = new DateTime(2021,09,11);

Console.Write($"Código do produto: {produto01.Codigo}. ");
Console.Write($"Nome do produto: {produto01.Nome}.");
Console.Write($"Preço de compra: {produto01.PrecoCompra}. ");
Console.Write($"Preço de venda: {produto01.PrecoVenda}. ");
Console.Write($"Quantidade em estoque: {produto01.QuantidadeEstoque}. ");
Console.Write($"Ativo: {produto01.Ativo}. ");
Console.Write($"Data de cadastro: {produto01.DataCadastro}. ");
Console.WriteLine();

produto01.Inserir(3);
Console.WriteLine($"Quatidade de produto em estoque: {produto01.QuantidadeEstoque}.");

produto01.Alterar(160.50m);

produto01.Excluir(10);
Console.WriteLine($"Quatidade de produto em estoque: {produto01.QuantidadeEstoque}.");

produto01.Pesquisar(456789);
produto01.Pesquisar(1234566);