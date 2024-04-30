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
        Console.Write("Data de Lançamento: ");
        this.DataLancamentoLivro = DateOnly.Parse(Console.ReadLine());
    }

    public void DefinirEditoraLivro()
    {
        Console.Write("Editora: ");
        this.EditoraLivro = Console.ReadLine();
    }

    public void DefinirEdicaoLivro()
    {
        Console.Write("Edição: ");
        this.EdicaoLivro = int.Parse(Console.ReadLine());
    }

    public void DefinirISBNLivro()
    {
        Console.Write("ISBN: ");
        this.ISBN = int.Parse(Console.ReadLine());
    }

    public void DefinirTotalPaginasLivro()
    {    
        Console.Write("Número de Páginas: ");
        this.TotalPaginas = int.Parse(Console.ReadLine());
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
