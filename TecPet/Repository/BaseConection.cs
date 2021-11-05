using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using TecPet.Model;

namespace TecPet.Repository
{
   public class BaseConection : Controle
    {
      

        public Controle GetDados (Controle dados)
        {

         string MyStringConnnection = "Server=localhost;Port=3306;database=creche;user id=root;password=Data@071194";

            using (IDbConnection connection = new MySqlConnection(MyStringConnnection))
            {
                try
                {
                    Controle con = new Controle();

                    connection.Open();
                    var sql = "SELECT * FROM alunos";

                    con = connection.Query<Controle>(sql).FirstOrDefault();

                    connection.Close();

                    return con;
                }
                catch
                {
                    throw new Exception("Erro na conexão com banco de dados");
                }

            }



        }




    }
}
