using Jr.Backend.Message.Events.Pessoa.Dto;
using Jr.Backend.Message.Share.Pessoa;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jr.Backend.Message.Events.Pessoa.Evemts
{
    public class PessoaCadastradaEvent : PessoaEventBase
    {
        [JsonConstructor]
        public PessoaCadastradaEvent(NomeCompleto nomeCompleto, IList<Endereco> enderecos, Documentos documentos) : base(nomeCompleto, enderecos, documentos)
        {
        }
    }
}