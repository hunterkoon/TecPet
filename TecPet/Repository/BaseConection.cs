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
    public class BaseConection
    {   
        public class Repository : Modelo 
        {
            string MyStringConnnection = "Server=localhost;Port=3306;database=creche;user id=root;password=Data@071194";
            public List<Animal> GetDadosAnimal()
            {
                using (IDbConnection conn = new MySqlConnection(MyStringConnnection))
                {
                    try
                    {
                        List<Animal> control = new List<Animal>();

                        conn.Open();
                        var sql = "SELECT * FROM alunos";
                        control = conn.Query<Animal>(sql).ToList();
                        conn.Close();
                        return control;

                    }
                    catch
                    {
                        throw new Exception("Erro na conexão com banco de dados");
                    }
                }

            }

        }
    }
}
