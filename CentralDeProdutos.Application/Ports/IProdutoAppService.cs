﻿using CentralDeProdutos.Application.Commands;
using CentralDeProdutos.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeProdutos.Application.Ports
{
    public interface IProdutoAppService : IDisposable
    {
        ProdutosQuery Add(CreateProdutoCommand command, string usuarioCriacao);
        ProdutosQuery Update(UpdateProdutoCommand command, string usuarioAlteracao);
        ProdutosQuery Delete(DeleteProdutoCommand command);

        List<ProdutosQuery> GetByCategoria(Guid? idCategoria);
        ProdutosQuery GetById(Guid? id);
    }
}
