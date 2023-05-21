using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeProdutos.Infra.Data.Contexts
{
    public class SqlServerContextMigration : IDesignTimeDbContextFactory<DataContext>
    {
        /// <summary>
        /// Injetor de dependência para a classe SqlServerContext sempre que executarmos
        /// o recurso do Migrations do EntityFramework
        /// </summary>
        public DataContext CreateDbContext(string[] args)
        {
            #region Localizar o arquivo appsettings.json

            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            #endregion

            #region Capturar a connectionstring do arquivo appsettings.json

            var root = configurationBuilder.Build();
            var connectionString = root.GetSection("ConnectionStrings").GetSection("BD_CentralDeProdutos").Value;

            #endregion

            #region Fazer a injeção de dependência na classe SqlServerContext

            var builder = new DbContextOptionsBuilder<DataContext>();
            builder.UseSqlServer(connectionString);

            return new DataContext(builder.Options);

            #endregion
        }
    }
}
