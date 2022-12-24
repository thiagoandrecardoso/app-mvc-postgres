using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace app_mvc.Models.conn
{
    public class AlunoConnection
    {
        
        public IConnection? _connection;

        public AlunoConnection(ConnectionPostgres connection)
        {
            _connection = connection;
        }

        public List<Aluno> getStudentyList()
        {
            List<Aluno> list = new List<Aluno>();

            if(_connection == null)
            return list;

            var _npgsqlConnection = _connection.getConnection();
            _npgsqlConnection.Open();

            string sql = "SELECT * FROM aluno";
            using var cmd = new NpgsqlCommand(sql, _npgsqlConnection);

            using NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0} {1} {2}", rdr.GetInt32(0), rdr.GetString(1),
                        rdr.GetInt32(2));

                list.Add(new Aluno(){
                    Id =  rdr.GetInt32(0),
                    Nome =  rdr.GetString(1),
                    Idade = rdr.GetInt32(2),
                    Genero = rdr.GetChar(3),
                    Curso = rdr.GetString(4)
                });
            }

           return list;
        }

    }
}