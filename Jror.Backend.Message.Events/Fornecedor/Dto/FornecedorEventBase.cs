using Jror.Backend.Libs.Messaging.Abstractions.Interfaces;
using Jror.Backend.Message.Share.Fornecedor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Jror.Backend.Message.Events.Fornecedor.Dto
{
    public abstract class FornecedorEventBase : IEvent
    {
        public bool AceiteTermosDeUso { get; private set; }
        public decimal CapitalSocial { get; private set; }
        public string Celular { get; private set; }
        public int CnaeFiscal { get; private set; }
        public string CnaeFiscalDescricao { get; private set; }
        public List<CnaesSecundario> CnaesSecundarios { get; private set; }
        public string Cnpj { get; private set; }
        public int CodigoNaturezaJuridica { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime? DataExclusaoDoSimples { get; private set; }
        public DateTime DataInicioAtividade { get; private set; }
        public DateTime? DataOpcaoPeloSimples { get; private set; }
        public DateTime DataSituacaoCadastral { get; private set; }
        public DateTime? DataSituacaoEspecial { get; private set; }
        public string DescricaoMatrizFilial { get; private set; }
        public string DescricaoPorte { get; private set; }
        public string DescricaoSituacaoCadastral { get; private set; }

        public IEnumerable<string> EmailContato { get; private set; }
        public IEnumerable<string> EmailFatura { get; private set; }
        public List<Endereco> Enderecos { get; private set; }
        public int IdentificadorMatrizFilial { get; private set; }
        public InformacoesBancarias InformacoesBancarias { get; private set; }
        public int MotivoSituacaoCadastral { get; private set; }
        public string NomeCidadeExterior { get; private set; }
        public string NomeContato { get; private set; }
        public string NomeFantasia { get; private set; }
        public bool OpcaoPeloMei { get; private set; }
        public bool OpcaoPeloSimples { get; private set; }
        public int Porte { get; private set; }
        public List<Qsa> Qsa { get; private set; }
        public int QualificacaoDoResponsavel { get; private set; }
        public string RazaoSocial { get; private set; }
        public int SituacaoCadastral { get; private set; }
        public string SituacaoEspecial { get; private set; }
        public IEnumerable<string> Telefones { get; private set; }
        public string StatusCadastro { get; private set; }

        [JsonConstructor]
        protected FornecedorEventBase(bool aceiteTermosDeUso, decimal capitalSocial, string celular, int cnaeFiscal, string cnaeFiscalDescricao, List<CnaesSecundario> cnaesSecundarios, string cnpj, int codigoNaturezaJuridica, DateTime dataCadastro, DateTime? dataExclusaoDoSimples, DateTime dataInicioAtividade, DateTime? dataOpcaoPeloSimples, DateTime dataSituacaoCadastral, DateTime? dataSituacaoEspecial, string descricaoMatrizFilial, string descricaoPorte, string descricaoSituacaoCadastral, IEnumerable<string> emailContato, IEnumerable<string> emailFatura, List<Endereco> enderecos, int identificadorMatrizFilial, InformacoesBancarias informacoesBancarias, int motivoSituacaoCadastral, string nomeCidadeExterior, string nomeContato, string nomeFantasia, bool opcaoPeloMei, bool opcaoPeloSimples, int porte, List<Qsa> qsa, int qualificacaoDoResponsavel, string razaoSocial, int situacaoCadastral, string situacaoEspecial, IEnumerable<string> telefones, string statusCadastro)
        {
            AceiteTermosDeUso = aceiteTermosDeUso;
            CapitalSocial = capitalSocial;
            Celular = celular;
            CnaeFiscal = cnaeFiscal;
            CnaeFiscalDescricao = cnaeFiscalDescricao;
            CnaesSecundarios = cnaesSecundarios;
            Cnpj = cnpj;
            CodigoNaturezaJuridica = codigoNaturezaJuridica;
            DataCadastro = dataCadastro;
            DataExclusaoDoSimples = dataExclusaoDoSimples;
            DataInicioAtividade = dataInicioAtividade;
            DataOpcaoPeloSimples = dataOpcaoPeloSimples;
            DataSituacaoCadastral = dataSituacaoCadastral;
            DataSituacaoEspecial = dataSituacaoEspecial;
            DescricaoMatrizFilial = descricaoMatrizFilial;
            DescricaoPorte = descricaoPorte;
            DescricaoSituacaoCadastral = descricaoSituacaoCadastral;
            EmailContato = emailContato;
            EmailFatura = emailFatura;
            Enderecos = enderecos;
            IdentificadorMatrizFilial = identificadorMatrizFilial;
            InformacoesBancarias = informacoesBancarias;
            MotivoSituacaoCadastral = motivoSituacaoCadastral;
            NomeCidadeExterior = nomeCidadeExterior;
            NomeContato = nomeContato;
            NomeFantasia = nomeFantasia;
            OpcaoPeloMei = opcaoPeloMei;
            OpcaoPeloSimples = opcaoPeloSimples;
            Porte = porte;
            Qsa = qsa;
            QualificacaoDoResponsavel = qualificacaoDoResponsavel;
            RazaoSocial = razaoSocial;
            SituacaoCadastral = situacaoCadastral;
            SituacaoEspecial = situacaoEspecial;
            Telefones = telefones;
            StatusCadastro = statusCadastro;
        }
    }
}