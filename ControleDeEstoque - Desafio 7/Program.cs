using ControleDeEstoque___Desafio_7;

Produto produto = new Produto("Caneta Azul", 20);
produto.Retirar(5);
produto.ExibirEstoque();
produto.Retirar(30);

Console.ReadKey();