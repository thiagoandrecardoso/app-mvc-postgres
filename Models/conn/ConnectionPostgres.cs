using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace app_mvc.Models.conn
{
    public class ConnectionPostgres : IConnection
    {
         public NpgsqlConnection getConnection()
         {
            var _connString = "Host=localhost;Username=postgres;Password=abacaxi98;Database=postgres";
            var connection = new NpgsqlConnection(_connString);
            return connection;
         }
    }
}