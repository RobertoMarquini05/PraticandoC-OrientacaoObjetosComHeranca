using PraticandoOrientacaoAObjetosComClasses;
using System.Text;

Livro livro = new Livro("Dom Casmurro", "Machado de Assis");

Console.WriteLine($"Livro: {livro.Nome}\nAutor: {livro.Autor}");

// Apenas para não fechar o console
Console.ReadKey();