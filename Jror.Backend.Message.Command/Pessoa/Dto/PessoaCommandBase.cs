using Jror.Backend.Libs.Messaging.Abstractions.Interfaces;
using Jror.Backend.Message.Share.Pessoa;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Jror.Backend.Message.Command.Pessoa.Dto
{
    public abstract class PessoaCommandBase : ICommand
    {
        public string Nome { get; }
        public string Sobrenome { get; }

        public IEnumerable<Endereco> Enderecos { get; }

        public string Cpf { get; }
        public string Rg { get; }
        public string TituloEleitoral { get; }

        [JsonConstructor]
        protected PessoaCommandBase(string nome, string sobrenome, IEnumerable<Endereco> enderecos, string cpf, string rg, string tituloEleitoral)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Enderecos = enderecos;
            Cpf = cpf;
            Rg = rg;
            TituloEleitoral = tituloEleitoral;
        }
    }
}