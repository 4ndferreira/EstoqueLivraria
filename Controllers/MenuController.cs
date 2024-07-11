namespace EstoqueLivraria.Controllers;

public class MenuController
{
  public static void MostrarMenu()
  {
    Console.WriteLine("CONTROLE DE ESTOQUE - LIVRARIA\n");
    Console.WriteLine("[1] Novo");
    Console.WriteLine("[2] Lista Produtos");
    Console.WriteLine("[3] Remover Produtos");
    Console.WriteLine("[4] Entrada Estoque");
    Console.WriteLine("[5] Saida Estoque");
    Console.WriteLine("[0] Sair\n");
  }
}