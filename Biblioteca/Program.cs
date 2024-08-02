using System;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            biblioteca.AdicionarCliente(new Cliente
            {
                Id = 1,
                Nome = "Jorge e Mateus",
                DataNascimento = new DateTime(1980, 01, 01),
                Telefone = "62999999"
            });

            biblioteca.AdicionarLivro(new Livro
            {
                Id = 1,
                Titulo = "Dom Casmurro",
                Autor = "Machado de Assis"
            });

            biblioteca.Emprestar(1, 1);
            biblioteca.Devolver(1, 1);

            biblioteca.Emprestar(1, 2);
        }
    }
}