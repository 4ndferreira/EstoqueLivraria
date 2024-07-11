using EstoqueLivraria.Models;
namespace EstoqueLivraria.Controllers;

public class EstoqueController
{
  public static void AdicionarLivroAoEstoque(Estoque estoque)
  {
    Console.Write("Informe o nome do livro: ");
    string nome = Console.ReadLine()!;
    Console.Write("Informe o preço: ");
    double preco = Convert.ToDouble(Console.ReadLine());
    Console.Write("Informe o autor(a): ");
    string autor = Console.ReadLine()!;
    Console.Write("Informe o gênero: ");
    string genero = Console.ReadLine()!;
    Console.Write("Informe o idioma: ");
    string idioma = Console.ReadLine()!;

    Livro novoLivro = new()
    {
      Nome = nome,
      Preco = preco,
      Autor = autor,
      Genero = genero,
      Idioma = idioma
    };

    estoque.AdicionarNovoLivro(novoLivro);
  }

  public static void RemoverLivroDoEstoque(Estoque estoque)
  {
    Console.Write("Informe o nome do livro: ");
    string nomeRemovido = Console.ReadLine()!;

    estoque.RemoverLivro(nomeRemovido);
  }

  public static void RealizarEntradaNoEstoque(Estoque estoque)
  {
    Console.Write("Informe o nome do livro: ");
    string nomeEntrada = Console.ReadLine()!;
    Console.Write("Informe a quantidade: ");
    int quantidadeEntrada = Convert.ToInt32(Console.ReadLine());

    estoque.RealizarEntrada(nomeEntrada, quantidadeEntrada);
  }

  public static void RealizarSaidaDoEstoque(Estoque estoque)
  {
    Console.Write("Informe o nome do livro: ");
    string nomeSaida = Console.ReadLine()!;
    Console.Write("Informe a quantidade: ");
    int quantidadeSaida = Convert.ToInt32(Console.ReadLine());

    estoque.RealizarSaida(nomeSaida, quantidadeSaida);
  }
}