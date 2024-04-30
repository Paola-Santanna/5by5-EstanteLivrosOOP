/**/


//int[] pos_livro_estante = new string[10];
int posicao_livro, pos_livro_final;
int consultar, consultar_aux;

#region funcao
int ConsultarLivro()
{
    Console.WriteLine("Você deseja consultar um livro? ");
    Console.WriteLine("1 - Sim \n2 - Não");
    Console.Write("Resposta: ");
    consultar = int.Parse(Console.ReadLine());

    if (consultar != 1 && consultar != 2)
    {
        Console.WriteLine("\nOpção Inválida");
    }

    return consultar;
}
#endregion

#region iniciacaoObjetos
Estante l1 = new Estante();
Estante l2 = new Estante();
Estante l3 = new Estante();
Estante l4 = new Estante();
Estante l5 = new Estante();
Estante l6 = new Estante();
Estante l7 = new Estante();
Estante l8 = new Estante();
Estante l9 = new Estante();
Estante l10 = new Estante();
#endregion

#region cadastrarLivros
for (int indiceLivro = 0; indiceLivro < 10; indiceLivro++)
{
    switch (indiceLivro)
    {
        case 0:
            Console.WriteLine();
            Console.WriteLine($"{indiceLivro+1}º Livro:");

            l1.DefinirTituloLivro();
            l1.DefinirAutorLivro();
            l1.DefinirDataLancamento();
            l1.DefinirEditoraLivro();
            l1.DefinirEdicaoLivro();
            l1.DefinirISBNLivro();
            l1.DefinirTotalPaginasLivro();

            break;

        case 1:
            Console.WriteLine();
            Console.WriteLine($"{indiceLivro + 1}º Livro:");

            l2.DefinirTituloLivro();
            l2.DefinirAutorLivro();
            l2.DefinirDataLancamento();
            l2.DefinirEditoraLivro();
            l2.DefinirEdicaoLivro();
            l2.DefinirISBNLivro();
            l2.DefinirTotalPaginasLivro();

            break;

        case 2:
            Console.WriteLine();
            Console.WriteLine($"{indiceLivro + 1}º Livro:");

            l3.DefinirTituloLivro();
            l3.DefinirAutorLivro();
            l3.DefinirDataLancamento();
            l3.DefinirEditoraLivro();
            l3.DefinirEdicaoLivro();
            l3.DefinirISBNLivro();
            l3.DefinirTotalPaginasLivro();

            break;

        case 3:
            Console.WriteLine();
            Console.WriteLine($"{indiceLivro + 1}º Livro:");

            l4.DefinirTituloLivro();
            l4.DefinirAutorLivro();
            l4.DefinirDataLancamento();
            l4.DefinirEditoraLivro();
            l4.DefinirEdicaoLivro();
            l4.DefinirISBNLivro();
            l4.DefinirTotalPaginasLivro();

            break;

        case 4:
            Console.WriteLine();
            Console.WriteLine($"{indiceLivro + 1}º Livro:");

            l5.DefinirTituloLivro();
            l5.DefinirAutorLivro();
            l5.DefinirDataLancamento();
            l5.DefinirEditoraLivro();
            l5.DefinirEdicaoLivro();
            l5.DefinirISBNLivro();
            l5.DefinirTotalPaginasLivro();

            break;

        case 5:
            Console.WriteLine();
            Console.WriteLine($"{indiceLivro + 1}º Livro:");

            l6.DefinirTituloLivro();
            l6.DefinirAutorLivro();
            l6.DefinirDataLancamento();
            l6.DefinirEditoraLivro();
            l6.DefinirEdicaoLivro();
            l6.DefinirISBNLivro();
            l6.DefinirTotalPaginasLivro();

            break;

        case 6:
            Console.WriteLine();
            Console.WriteLine($"{indiceLivro + 1}º Livro:");

            l7.DefinirTituloLivro();
            l7.DefinirAutorLivro();
            l7.DefinirDataLancamento();
            l7.DefinirEditoraLivro();
            l7.DefinirEdicaoLivro();
            l7.DefinirISBNLivro();
            l7.DefinirTotalPaginasLivro();

            break;

        case 7:
            Console.WriteLine();
            Console.WriteLine($"{indiceLivro + 1}º Livro:");

            l8.DefinirTituloLivro();
            l8.DefinirAutorLivro();
            l8.DefinirDataLancamento();
            l8.DefinirEditoraLivro();
            l8.DefinirEdicaoLivro();
            l8.DefinirISBNLivro();
            l8.DefinirTotalPaginasLivro();

            break;

        case 8:
            Console.WriteLine();
            Console.WriteLine($"{indiceLivro + 1}º Livro:");

            l9.DefinirTituloLivro();
            l9.DefinirAutorLivro();
            l9.DefinirDataLancamento();
            l9.DefinirEditoraLivro();
            l9.DefinirEdicaoLivro();
            l9.DefinirISBNLivro();
            l9.DefinirTotalPaginasLivro();

            break;

        case 9:
            Console.WriteLine();
            Console.WriteLine($"{indiceLivro + 1}º Livro:");

            l10.DefinirTituloLivro();
            l10.DefinirAutorLivro();
            l10.DefinirDataLancamento();
            l10.DefinirEditoraLivro();
            l10.DefinirEdicaoLivro();
            l10.DefinirISBNLivro();
            l10.DefinirTotalPaginasLivro();

            break;

        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}
#endregion

Console.WriteLine();
Console.WriteLine("-------------------------------------");
Console.WriteLine("-------------------------------------");
Console.WriteLine();

consultar_aux = ConsultarLivro();

while (consultar_aux == 1)
{
    Console.WriteLine();
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("------------- Consulta --------------");
    Console.WriteLine();

    Console.Write("Digite a posição do livro, a partir de 1: ");
    posicao_livro = int.Parse(Console.ReadLine());
    pos_livro_final = posicao_livro - 1;

    switch (pos_livro_final)
    {
        case 0:
            Console.WriteLine($"{posicao_livro}º Livro");
            l1.MostrarDados();
            break;

        case 1:
            Console.WriteLine($"{posicao_livro}º Livro");
            l2.MostrarDados();
            break;

        case 2:
            Console.WriteLine($"{posicao_livro}º Livro");
            l3.MostrarDados();
            break;

        case 3:
            Console.WriteLine($"{posicao_livro}º Livro");
            l4.MostrarDados();
            break;

        case 4:
            Console.WriteLine($"{posicao_livro}º Livro");
            l5.MostrarDados();
            break;

        case 5:
            Console.WriteLine($"{posicao_livro}º Livro");
            l6.MostrarDados();
            break;

        case 6:
            Console.WriteLine($"{posicao_livro}º Livro");
            l7.MostrarDados();
            break;

        case 7:
            Console.WriteLine($"{posicao_livro}º Livro");
            l8.MostrarDados();
            break;

        case 8:
            Console.WriteLine($"{posicao_livro}º Livro");
            l9.MostrarDados();
            break;

        case 9:
            Console.WriteLine($"{posicao_livro}º Livro");
            l10.MostrarDados();
            break;

        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }
    Console.WriteLine();
    consultar_aux = ConsultarLivro();
}

Console.WriteLine("Aperte ENTER para encerrar.");
Console.ReadKey();