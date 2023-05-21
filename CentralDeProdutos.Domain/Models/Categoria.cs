﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeProdutos.Domain.Models
{
    public class Categoria
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public string? UsuarioCriacao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
        public string? UsuarioUltimaAlteracao { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}
