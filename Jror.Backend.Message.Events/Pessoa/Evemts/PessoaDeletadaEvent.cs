using Jr.Backend.Message.Events.Pessoa.Dto;
using Jr.Backend.Message.Share.Pessoa;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jr.Backend.Message.Events.Pessoa.Evemts
{
    public class PessoaDeletadaEvent : PessoaEventBase
    {
        [JsonConstructor]
        public PessoaDeletadaEvent(NomeCompleto nomeCompleto, IEnumerable<Endereco> enderecos, Documentos documentos) : base(nomeCompleto, enderecos, documentos)
        {
        }
    }
}