using System;
using System.Collections.Generic;

namespace Biblioteca;

public class Biblioteca
{
	public List<Cliente> clientes = new List<Cliente>();
	public List<Livro> livros= new List<Livro>();
	public List<Emprestimo> emprestimos= new List<Emprestimo>();
	

	/// Empresta um livro para um cliente.
	
	public void EmprestarLivro(int idCliente, int idLivro)
	{
		// Busca o livro pelo id, verificando se ele está disponível.
		Livro livro = livros.Find(l => l.Id == idLivro && l.Disponivel == true);
		
		// Se o livro não for encontrado ou estiver indisponível, exibe uma mensagem e retorna.
		if (livro == null)
		{
			Console.WriteLine("Livro não encontrado ou indisponível.");
			return;
		}
		
		// Busca o cliente pelo id.
		Cliente cliente = clientes.Find(c => c.Id == idCliente);
		
		// Se o cliente não for encontrado, exibe uma mensagem e retorna.
		if (cliente == null)
		{
			Console.WriteLine("Cliente não encontrado");
			return;
		}
		
		// Cria um novo empréstimo.
		Emprestimo emprestimo = new Emprestimo
		{
			Id = emprestimos.Count + 1,
			ClienteEmprestimo = cliente,
			LivroEmprestado = livro,
			DataDoEmprestimo = DateTime.Today,
			DataDevolucaoPrevista = DateTime.Today.AddDays(15)
		};
		
		// Marca o livro como não disponível.
		livro.Disponivel = false;
		emprestimos.Add(emprestimo);
		
		// Adiciona o empréstimo à lista de empréstimos.
		Console.WriteLine("Livro emprestado com sucesso!");
		// Exibe uma mensagem de sucesso.
	}
	

	/// Devolve um livro emprestado.

	public void DevolverLivro(int idCliente, int idLivro)
	{
		// Busca o livro pelo ID.
		Livro livro = livros.Find(l => l.Id == idLivro);
		
		// Se o livro não for encontrado, exibe uma mensagem e retorna.
		if (livro == null)
		{
			Console.WriteLine("Livro não encontrado"); 
			return;
		}
		
		// Busca o empréstimo pelo ID do cliente e do livro.
		Emprestimo emprestimo = emprestimos.Find(e => e.ClienteEmprestimo.Id == idCliente && e.LivroEmprestado.Id == idLivro);
		
		// Se o empréstimo não for encontrado, exibe uma mensagem e retorna.
		if (emprestimo == null)
		{
			Console.WriteLine("Empréstimo não encontrado.");
			return;
		}
		
		// Marca o livro como disponível e define a data de devolução.
		emprestimo.LivroEmprestado.Disponivel = true;
		emprestimo.DataDevolucao = DateTime.Today;
		
		// Exibe uma mensagem de sucesso.
		Console.WriteLine("Livro Devolvido com sucesso.");
	}	
}