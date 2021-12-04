using Jror.Backend.Message.Command.Pessoa.Dto;
using Jror.Backend.Message.Share.Pessoa;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Jror.Backend.Message.Command.Pessoa.Commands
{
    public class CadastrarPessoaCommand : PessoaCommandBase
    {
        [JsonConstructor]
        public CadastrarPessoaCommand(string nome, string sobrenome, IEnumerable<Endereco> enderecos, string cpf, string rg, string tituloEleitoral) : base(nome, sobrenome, enderecos, cpf, rg, tituloEleitoral)
        {
        }
    }
}