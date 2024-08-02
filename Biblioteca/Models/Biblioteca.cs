using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Biblioteca : IEmprestavel
    {
        private List<Cliente> clientes = new List<Cliente>();
        private List<Livro> livros = new List<Livro>();
        private List<Emprestimo> emprestimos = new List<Emprestimo>();

        public void AdicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public void Emprestar(int idCliente, int idLivro)
        {
            Livro livro = livros.Find(l => l.Id == idLivro && l.Disponivel);

            if (livro == null)
            {
                Console.WriteLine("Livro não encontrado ou indisponível.");
                return;
            }

            Cliente cliente = clientes.Find(c => c.Id == idCliente);

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado.");
                return;
            }

            Emprestimo emprestimo = new Emprestimo
            {
                Id = emprestimos.Count + 1,
                ClienteEmprestimo = cliente,
                LivroEmprestado = livro,
                DataDoEmprestimo = DateTime.Today,
                DataDevolucaoPrevista = DateTime.Today.AddDays(15)
            };

            livro.Disponivel = false;
            emprestimos.Add(emprestimo);
            Console.WriteLine("Livro emprestado com sucesso!");
        }

        public void Devolver(int idCliente, int idLivro)
        {
            Livro livro = livros.Find(l => l.Id == idLivro);

            if (livro == null)
            {
                Console.WriteLine("Livro não encontrado.");
                return;
            }

            Emprestimo emprestimo = emprestimos.Find(e => e.ClienteEmprestimo.Id == idCliente && e.LivroEmprestado.Id == idLivro);

            if (emprestimo == null)
            {
                Console.WriteLine("Empréstimo não encontrado.");
                return;
            }

            emprestimo.LivroEmprestado.Disponivel = true;
            emprestimo.DataDevolucao = DateTime.Today;
            Console.WriteLine("Livro devolvido com sucesso.");
        }
    }
}