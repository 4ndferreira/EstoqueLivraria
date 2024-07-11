using EstoqueLivraria.Controllers;

Estoque estoque = new();

bool sairDoPrograma = false;

while (!sairDoPrograma)
{
  Console.WriteLine("CONTROLE DE ESTOQUE - LIVRARIA\n");
  Console.WriteLine("[1] Novo");
  Console.WriteLine("[2] Lista Produtos");
  Console.WriteLine("[3] Remover Produtos");
  Console.WriteLine("[4] Entrada Estoque");
  Console.WriteLine("[5] Saida Estoque");
  Console.WriteLine("[0] Sair\n");

  Console.Write("Escolha uma opção: ");
  int escolha = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine();

  switch (escolha)
  {
    case 0:

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