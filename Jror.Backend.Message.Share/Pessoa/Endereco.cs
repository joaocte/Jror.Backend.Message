using System.Text.Json.Serialization;

namespace Jr.Backend.Message.Share.Pessoa
{
    public class Endereco
    {
        [JsonConstructor]
        public Endereco(string logradouro, string bairro, string numero, string estado, string cidade, string pais, string cep, string complemento)
        {
            Logradouro = logradouro;
            Bairro = bairro;
            Numero = numero;
            Estado = estado;
            Cidade = cidade;
            Pais = pais;
            Cep = cep;
            Complemento = complemento;
        }

        public string Logradouro { get; }
        public string Bairro { get; }
        public string Numero { get; }
        public string Estado { get; }
        public string Cidade { get; }
        public string Pais { get; }
        public string Cep { get; }

        public string Complemento { get; }
    }
}