using System;

namespace Biblioteca{
    
    //cruacao da classe Pessoa para que cliente e funcionario herdem seus atributos e metodos - heranca
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}