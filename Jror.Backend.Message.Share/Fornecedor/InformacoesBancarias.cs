using System.Text.Json.Serialization;

namespace Jr.Backend.Message.Share.Fornecedor
{
    public class InformacoesBancarias
    {
        [JsonConstructor]
        public InformacoesBancarias(string banco, string agencia, string conta, string tipoConta)
        {
            Banco = banco;
            Agencia = agencia;
            Conta = conta;
            TipoConta = tipoConta;
        }

        public string Agencia { get; private set; }
        public string Banco { get; private set; }
        public string Conta { get; private set; }
        public string TipoConta { get; private set; }
    }
}