using EstoqueLivraria.Controllers;
using EstoqueLivraria.Models;

Estoque estoque = new();

bool sairDoPrograma = false;


while (!sairDoPrograma)
{
  MenuController.MostrarMenu();
  
  Console.Write("Escolha uma opção: ");
  int escolha = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine();

  switch (escolha)
  {
    case 0:
      sairDoPrograma = true;
      Console.Write("Saindo do programa...");
      break;
    case 1:
      EstoqueController.AdicionarLivroAoEstoque(estoque);
      break;
    case 2:
      estoque.ListarLivros();
      break;
    case 3:
      EstoqueController.RemoverLivroDoEstoque(estoque);
      break;
    case 4:
      EstoqueController.RealizarEntradaNoEstoque(estoque);
      break;
    case 5:
      EstoqueController.RealizarSaidaDoEstoque(estoque);
      break;
    default:
      Console.Write("Opção inválida! Escolha novamente.");
      break;
  }
}