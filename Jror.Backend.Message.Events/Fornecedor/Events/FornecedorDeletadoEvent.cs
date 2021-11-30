using Jr.Backend.Message.Events.Fornecedor.Dto;
using Jr.Backend.Message.Share.Fornecedor;
using System;
using System.Collections.Generic;

namespace Jr.Backend.Message.Events.Fornecedor.Events
{
    public class FornecedorDeletadoEvent : FornecedorEventBase
    {
        public FornecedorDeletadoEvent(bool aceiteTermosDeUso, decimal capitalSocial, string celular, int cnaeFiscal, string cnaeFiscalDescricao, List<CnaesSecundario> cnaesSecundarios, string cnpj, int codigoNaturezaJuridica, DateTime dataCadastro, DateTime? dataExclusaoDoSimples, DateTime dataInicioAtividade, DateTime? dataOpcaoPeloSimples, DateTime dataSituacaoCadastral, DateTime? dataSituacaoEspecial, string descricaoMatrizFilial, string descricaoPorte, string descricaoSituacaoCadastral, IEnumerable<string> emailContato, IEnumerable<string> emailFatura, List<Endereco> enderecos, int identificadorMatrizFilial, InformacoesBancarias informacoesBancarias, int motivoSituacaoCadastral, string nomeCidadeExterior, string nomeContato, string nomeFantasia, bool opcaoPeloMei, bool opcaoPeloSimples, int porte, List<Qsa> qsa, int qualificacaoDoResponsavel, string razaoSocial, int situacaoCadastral, string situacaoEspecial, IEnumerable<string> telefones, string statusCadastro) : base(aceiteTermosDeUso, capitalSocial, celular, cnaeFiscal, cnaeFiscalDescricao, cnaesSecundarios, cnpj, codigoNaturezaJuridica, dataCadastro, dataExclusaoDoSimples, dataInicioAtividade, dataOpcaoPeloSimples, dataSituacaoCadastral, dataSituacaoEspecial, descricaoMatrizFilial, descricaoPorte, descricaoSituacaoCadastral, emailContato, emailFatura, enderecos, identificadorMatrizFilial, informacoesBancarias, motivoSituacaoCadastral, nomeCidadeExterior, nomeContato, nomeFantasia, opcaoPeloMei, opcaoPeloSimples, porte, qsa, qualificacaoDoResponsavel, razaoSocial, situacaoCadastral, situacaoEspecial, telefones, statusCadastro)
        {
        }
    }
}