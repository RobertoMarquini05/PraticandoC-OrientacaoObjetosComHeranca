using Conta_Bancaria___Desafio_3;

ContaBancaria conta = new ContaBancaria("78901-2", 1000.00);

Console.WriteLine($"Conta: {conta.NumeroConta}\nSaldo Atual: {conta.Saldo}");
conta.Depositar(500.00);
Console.WriteLine($"Depósito realizado com sucesso! Novo saldo: {conta.Saldo}");

// Apenas para não fechar o console
Console.ReadKey();