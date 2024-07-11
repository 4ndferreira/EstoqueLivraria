namespace EstoqueLivraria.Models;

public class Estoque
{
  private readonly List<Livro> livros = [];

  public void AdicionarNovoLivro(Livro livro)
  {
    if (livro != null)
    {
      livros.Add(livro);
      Console.WriteLine("\nLivro Adicionado!\n");
    }
  }

  public void ListarLivros()
  {
    if (livros.Count == 0) 
    {
      Console.WriteLine("Nenhum Livro no estoque.\n");
      return;
    }
    
    foreach (var livro in livros)
    {
      Console.WriteLine($"{livro.Nome} ({livro.Preco:C}) - Idioma: {livro.Idioma} - {livro.QuantidadeEstoque} no estoque\n");
    }
  }

  public void RemoverLivro(string nome)
  {
    var livro = livros.Find(livro => livro.Nome.ToLower().Equals(nome.ToLower()));

    if (livro != null)
    {
      livros.Remove(livro);
      Console.WriteLine($"Produto '{livro.Nome}' removido do estoque.\n");
      return;
    }

    Console.WriteLine("Livro não encontrado!\n");
  }

  public void RealizarEntrada(string nome, int quantidade)
  {
    var livro = livros.Find(livro => livro.Nome.ToLower().Equals(nome.ToLower()));

    if (livro != null)
    {
      livro.QuantidadeEstoque += quantidade;
      Console.WriteLine($"{quantidade} unidades adicionadas ao estoque de '{livro.Nome}'\n");
      return;
    }

    Console.WriteLine("Livro não encontrado!\n");
  }

  public void RealizarSaida(string nome, int quantidade)
  {
    var livro = livros.Find(livro => livro.Nome.ToLower().Equals(nome.ToLower()));

    if (livro != null)
    {
      if (livro.QuantidadeEstoque >= quantidade)
      {
        livro.QuantidadeEstoque -= quantidade;
        Console.WriteLine($"{quantidade} unidades removidas do estoque de '{livro.Nome}'\n");
        return;
      }

      Console.WriteLine("Quantidade insuficiente em estoque!");
      return;
    }

    Console.WriteLine("Livro não encontrado");
  }
}