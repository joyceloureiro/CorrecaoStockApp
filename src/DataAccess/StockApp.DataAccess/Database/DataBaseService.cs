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
    public partial class DataBaseService : IDataBaseService
    {  
        public void CriarBanco()
        {
            var sql = @"
                        IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'StockApp')
                        BEGIN
                          CREATE DATABASE StockApp
                         END
                        ";
            try
            {
                using (var conexao = new SqlConnection(SqlServerContext.ConexaoSemBanco))
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
