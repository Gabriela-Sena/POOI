using System;

namespace Biblioteca
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public Cliente ClienteEmprestimo { get; set; }
        public Livro LivroEmprestado { get; set; }
        public DateTime DataDoEmprestimo { get; set; }
        public DateTime DataDevolucaoPrevista { get; set; }
        public DateTime? DataDevolucao { get; set; }

        public bool Devolvido => DataDevolucao.HasValue;
    }
}