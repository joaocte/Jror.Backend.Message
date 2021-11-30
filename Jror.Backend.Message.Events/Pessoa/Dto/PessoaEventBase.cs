using Jr.Backend.Message.Share.Pessoa;
using Jror.Backend.Libs.Messaging.Abstractions.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jr.Backend.Message.Events.Pessoa.Dto
{
    public abstract class PessoaEventBase : IEvent
    {
        public NomeCompleto NomeCompleto { get; }

        public IEnumerable<Endereco> Enderecos { get; }

        public Documentos Documentos { get; }

        [JsonConstructor]
        protected PessoaEventBase(NomeCompleto nomeCompleto, IEnumerable<Endereco> enderecos, Documentos documentos)
        {
            NomeCompleto = nomeCompleto;
            Enderecos = enderecos;
            Documentos = documentos;
        }
    }
}