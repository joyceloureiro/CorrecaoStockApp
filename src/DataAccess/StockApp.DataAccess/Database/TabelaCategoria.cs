using Dapper;
using Microsoft.Data.SqlClient;
using StockApp.Busines.Interface.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.DataAccess.Database
{
   public partial class DataBaseService
    {
        public void CriarTabelaCategoria()
        {
            var sql = @"
                        CREATE TABLE Categorias
                        (
                            Id int,
                            Nome varchar(100)
                        )";
            try
            {
                using (var conexao = new SqlConnection(SqlServerContext.ConexaoComBanco))
                {
                    var resultado = conexao.Execute(sql);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
