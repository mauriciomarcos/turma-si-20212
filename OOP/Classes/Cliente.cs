using System;

namespace OOP.Classes
{
    public class Cliente
    {
        public Cliente(string nome, string documento, string endereco)
        {
            Nome = nome;
            Documento = documento;
            Endereco = endereco;
        }

        public string Nome { get; private set; }

        public string Documento { get; private set; }

        public string Endereco { get; private set; }
    }
}