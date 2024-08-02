using System;

namespace Biblioteca
{
    public interface IEmprestavel
    {
        void Emprestar(int idCliente, int idLivro);
        void Devolver(int idCliente, int idLivro);
    }
}