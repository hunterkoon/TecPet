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
            string MyStringConnnection = "Server=localhost;Port=3306;database=tecpet;user id=root;password=Data@071194";
            public List<AnimalModel> GetRacas()
            {
                using (IDbConnection conn = new MySqlConnection(MyStringConnnection))
                {
                    try
                    {
                        List<AnimalModel> racas = new List<AnimalModel>();

                        conn.Open();
                        var sql = "SELECT * FROM racas";
                        racas = conn.Query<AnimalModel>(sql).ToList();
                        conn.Close();
                        return racas;

                    }
                    catch
                    {
                       
                        throw  new Exception ( "Erro na conexão com banco de dados");
                    }
                }

            }

            public void PostPet(string nome,  string raca , int idade, int peso)
            {
                using (IDbConnection conn = new MySqlConnection(MyStringConnnection))
                {
                    try
                    {
                        var i = new
                        {
                            NOME = nome,
                            RACA = raca,
                            IDADE = idade,
                            PESO = peso
                        };

                        var sql = @"insert into animal (Nome, Idade, Raca, Peso)
                                    values (@NOME , @IDADE, @RACA, @PESO)";

                        conn.Open();


                        conn.Execute(sql, i);
                        conn.Close();
                       
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
