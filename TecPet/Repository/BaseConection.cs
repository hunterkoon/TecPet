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
            string MyStringConnnection = "Server=localhost;Port=3306;database=tecpet;user id=root;password=***";

            #region PETS

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

                        throw new Exception("Erro na conexão com banco de dados");
                    }
                }

            }

            public void PostPet(string nome, string raca, int idade, int peso)
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

            public void DeletePet(int id)
            {
                using (IDbConnection conn = new MySqlConnection(MyStringConnnection))
                {
                    try
                    {
                        var i = new
                        {
                            ID = id
                        };

                        var sql = @"delete from animal where id = @ID";

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

            public List<AnimalModel> GetPets()
            {
                using (IDbConnection conn = new MySqlConnection(MyStringConnnection))
                {
                    try
                    {
                        List<AnimalModel> animals = new List<AnimalModel>();

                        conn.Open();
                        var sql = "SELECT * FROM animal";
                        animals = conn.Query<AnimalModel>(sql).ToList();
                        conn.Close();
                        return animals;

                    }
                    catch
                    {

                        throw new Exception("Erro na conexão com banco de dados");
                    }
                }

            }

            #endregion

            #region USUÁRIOS

            public UsuarioModel Login(string usuario, string senha)
            {
                using (IDbConnection conn = new MySqlConnection(MyStringConnnection))
                {
                    try
                    {
                        UsuarioModel user = new UsuarioModel();

                        var i = new {

                            USUARIO = usuario,
                            SENHA = senha
                        };

                        conn.Open();

                        var sql = "SELECT * FROM usuarios WHERE usuario = @USUARIO and senha = @SENHA";

                        user = conn.Query<UsuarioModel>(sql, i).FirstOrDefault();
                        conn.Close();


                        return user;


                    }
                    catch
                    {

                        throw new Exception("Erro na conexão com banco de dados");
                    }
                }

            }

            public string CadastrarLogin(string nome, string usuario, string senha)
            {
                using (IDbConnection conn = new MySqlConnection(MyStringConnnection))
                {
                    try
                    {
                        var i = new

                        {
                            NOME = nome, 
                            USUARIO = usuario,
                            SENHA = senha
                        };

                        var sql = @"insert into usuarios (nome,usuario,senha)values(@NOME,@USUARIO,@SENHA)";

                        conn.Open();
                        conn.Execute(sql, i);
                        conn.Close();

                        return "Usuário Cadastrado";

                    }
                    catch
                    {
                        throw new Exception("Erro na conexão com banco de dados");
                    }
                }

            }

            #endregion


        }

    }
}
