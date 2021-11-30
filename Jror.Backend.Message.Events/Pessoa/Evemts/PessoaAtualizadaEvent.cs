﻿using Jr.Backend.Message.Events.Pessoa.Dto;
using Jr.Backend.Message.Share.Pessoa;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Jr.Backend.Message.Events.Pessoa.Evemts
{
    public class PessoaAtualizadaEvent : PessoaEventBase
    {
        [JsonConstructor]
        public PessoaAtualizadaEvent(NomeCompleto nomeCompleto, IEnumerable<Endereco> enderecos, Documentos documentos) : base(nomeCompleto, enderecos, documentos)
        {
        }
    }
}