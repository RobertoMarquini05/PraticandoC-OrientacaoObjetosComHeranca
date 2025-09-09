using Funcionario___Desafio_4;

Funcionario funcionario = new Funcionario("Carlos Pereira", "Assistente Administrativo");
Console.WriteLine(funcionario.Promover("Assistente Administrativo"));
Console.WriteLine(funcionario.Promover("Analista de Projetos"));

Console.WriteLine($"--- Após promoção ---\nFuncionário: {funcionario.Nome}\nCargo Atual: {funcionario.Cargo}");

// Apenas para não fechar o console
Console.ReadKey();