using PassagemDeViagem;

Passagem passagem = new Passagem("Lucas Souza", "Paris");

Console.WriteLine($"Passageiro: {passagem.NomePassageiro}\nDestino: {passagem.Destino}");

// Apenas para não fechar o console
Console.ReadKey();