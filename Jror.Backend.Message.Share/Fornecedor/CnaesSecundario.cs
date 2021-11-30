﻿using System.Text.Json.Serialization;

namespace Jr.Backend.Message.Share.Fornecedor
{
    public class CnaesSecundario
    {
        [JsonConstructor]
        public CnaesSecundario(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        protected CnaesSecundario()
        {
        }

        public int Codigo { get; private set; }

        public string Descricao { get; private set; }
    }
}