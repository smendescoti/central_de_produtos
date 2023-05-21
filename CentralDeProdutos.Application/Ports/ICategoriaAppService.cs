﻿using CentralDeProdutos.Application.Commands;
using CentralDeProdutos.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeProdutos.Application.Ports
{
    public interface ICategoriaAppService : IDisposable
    {
        CategoriasQuery Add(CreateCategoriaCommand command, string usuarioCriacao);
        CategoriasQuery Update(UpdateCategoriaCommand command, string usuarioAlteracao);
        CategoriasQuery Delete(DeleteCategoriaCommand command);

        List<CategoriasQuery> GetAll();
        CategoriasQuery GetById(Guid? id);
    }
}
