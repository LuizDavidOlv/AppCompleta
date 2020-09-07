﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; } // Foreign key: Esse produto pertence a um fornecedor 
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        //EF Relation. Relação com o fornecedor. Propriedades de navegação para o EF
        public Fornecedor Fornecedor { get; set; }

    }
}
