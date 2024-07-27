namespace Biblioteca;

class Program
{
	static void Main(string[] args)
	{
		//Criação de nova instancia da Classe Biblioteca
		Biblioteca biblioteca = new Biblioteca();

		// Adiciona um novo cliente na lista de clientes
		biblioteca.clientes.Add(new Cliente
		{
			Id = 1,
			Nome = "Jorge e Mateus",
			DataNascimento = new DateTime(1980, 01, 01),
			Telefone = "62999999"
		});

		// Adiciona um novo livro na lista de livros
		biblioteca.livros.Add(new Livro
		{
			Id = 1,
			Titulo = "Dom Casmurro",
			Autor = "Machado de Assis",
			Disponivel = true
		});

		// Emprestar um livro
		biblioteca.EmprestarLivro(1, 1);

		// Devolver um livro
		biblioteca.DevolverLivro(1, 1);

		// Emprestar outro livro
		biblioteca.EmprestarLivro(1, 2);
	}


	static void IniciarBiblioteca(Biblioteca biblioteca)
	{
		biblioteca.EmprestarLivro(2, 2);
	}
}
