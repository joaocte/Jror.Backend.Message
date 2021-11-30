using Jr.Backend.Message.Command.Pessoa.Dto;
using Jr.Backend.Message.Share.Pessoa;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jr.Backend.Message.Command.Pessoa.Evemts
{
    public class CadastrarPessoaCommand : PessoaCommandBase
    {
        [JsonConstructor]
        public CadastrarPessoaCommand(NomeCompleto nomeCompleto, IList<Endereco> enderecos, Documentos documentos) : base(nomeCompleto, enderecos, documentos)
        {
        }
    }
}