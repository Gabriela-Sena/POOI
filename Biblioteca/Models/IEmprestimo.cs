using System;

namespace Biblioteca
{
    //criacao da interface IEmprestimo que define os metodos Emprestar e Devolver
    //A Classe biblioteca vai implementar essa interface garantindo que esses métodos sejam definidos e fornecendo uma estrutura que possa ser reaproveitada ou alterada sem modificar a interface
    //A interface define um 'Contrato' que qualquer classe que vai implementar essa interface vai ter que implementar todos os metodos dela, sendo esses Emprestar e Devolver
    //Esses metodos encapsulam a logica para realizar operacoes de emprestimo e devolução, garantindo que todas as verificacoes necessarias sejam feitas (ex verificar disponiblidade de livro ou existencia de cliente)
    //encapsulamento
    public interface IEmprestimo
    {
        void Emprestar(int idCliente, int idLivro);
        void Devolver(int idCliente, int idLivro);
    }
}