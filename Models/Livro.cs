namespace EstoqueLivraria.Models;

public class Livro
{
  public required string Nome { get; set; } 
  public required double Preco { get; set;}
  public required string Autor { get; set; }
  public required string Genero { get; set; }
  public required string Idioma { get; set; }
  public int QuantidadeEstoque { get; set; }
}