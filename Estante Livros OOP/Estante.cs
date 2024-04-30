using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class Estante
{
    public string TituloLivro;
    public string AutorLivro;
    public DateOnly DataLancamentoLivro;
    public string EditoraLivro;
    public int EdicaoLivro;
    public int ISBN;
    public int TotalPaginas;

    public Estante()
    {

    }

    public void DefinirTituloLivro()
    {
        Console.Write("Título: ");
        this.TituloLivro = Console.ReadLine();
    }

    public void DefinirAutorLivro()
    {
        Console.Write("Autor: ");
        this.AutorLivro = Console.ReadLine();
    }

    public void DefinirDataLancamento()
    {
        DateOnly data_lancamento;
        Console.Write("Data de Lançamento: ");
        data_lancamento = DateOnly.Parse(Console.ReadLine());
        this.DataLancamentoLivro = data_lancamento;
    }

    public void DefinirEditoraLivro()
    {
        string editora_livro;
        Console.Write("Editora: ");
        editora_livro = Console.ReadLine();
        this.EditoraLivro = editora_livro;
    }

    public void DefinirEdicaoLivro()
    {
        int edicao_livro;
        Console.Write("Edição: ");
        edicao_livro = int.Parse(Console.ReadLine());
        this.EdicaoLivro = edicao_livro;
    }

    public void DefinirISBNLivro()
    {
        int isbn_livro;
        Console.Write("ISBN: ");
        isbn_livro = int.Parse(Console.ReadLine());
        this.ISBN = isbn_livro;
    }

    public void DefinirTotalPaginasLivro()
    {
        int paginas_livro;
        Console.Write("Número de Páginas: ");
        paginas_livro = int.Parse(Console.ReadLine());
        this.TotalPaginas = paginas_livro;
    }
    public void MostrarDados()
    {
        Console.WriteLine($"\n\nTítulo: {TituloLivro}", this.TituloLivro);
        Console.WriteLine($"Autor(s): {AutorLivro}", this.AutorLivro);
        Console.WriteLine($"Data de Lançamento: {DataLancamentoLivro}", this.DataLancamentoLivro);
        Console.WriteLine($"Editora: {EditoraLivro}", this.EditoraLivro);
        Console.WriteLine($"Edição: {EdicaoLivro}", this.EdicaoLivro);
        Console.WriteLine($"ISBN: {ISBN}", this.ISBN);
        Console.WriteLine($"Quantidade de Páginas: {TotalPaginas}", this.TotalPaginas);
    }
}
