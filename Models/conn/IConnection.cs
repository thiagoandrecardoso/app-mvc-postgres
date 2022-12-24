using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace app_mvc.Models.conn
{
    public interface IConnection
    {
        public NpgsqlConnection getConnection();
    }
}