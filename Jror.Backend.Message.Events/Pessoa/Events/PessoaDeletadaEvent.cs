using Jror.Backend.Message.Events.Pessoa.Dto;
using Jror.Backend.Message.Share.Pessoa;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Jror.Backend.Message.Events.Pessoa.Events
{
    public class PessoaDeletadaEvent : PessoaEventBase
    {
        [JsonConstructor]
        public PessoaDeletadaEvent(string nome, string sobrenome, IEnumerable<Endereco> enderecos, string cpf, string rg, string tituloEleitoral) : base(nome, sobrenome, enderecos, cpf, rg, tituloEleitoral)
        {
        }
    }
}