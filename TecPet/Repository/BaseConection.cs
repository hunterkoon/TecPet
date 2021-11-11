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
            string MyStringConnnection = "Server=localhost;Port=3306;database=tecpet;user id=root;password=password123@";

            #region PETS

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
                        return animals;

                    }
                    catch
                    {

                        throw new Exception("Erro na conexão com banco de dados");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
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

                        return racas;

                    }
                    catch
                    {

                        throw new Exception("Erro na conexão com banco de dados");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
            public void PostPet(AnimalModel animal)
            {
                using (IDbConnection conn = new MySqlConnection(MyStringConnnection))
                {
                    try
                    {

                        var i = new
                        {
                            NOME = animal.Nome,
                            RACA = animal.Raca,
                            IDADE = animal.Idade,
                            PESO = animal.Peso,
                            IMAGEM = animal.Imagem,
                            TIPO = animal.TipoPet
                        };

                        var sql = @"insert into animal (Nome, Idade, Raca, Peso, imagem, tipoPet)
                                    values (@NOME , @IDADE, @RACA, @PESO, @IMAGEM, @TIPO)";

                        conn.Open();

                        conn.Execute(sql, i);

                    }
                    catch
                    {
                        throw new Exception("Erro na conexão com banco de dados");
                    }
                    finally
                    {
                        conn.Close();
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

                    }
                    catch
                    {
                        throw new Exception("Erro na conexão com banco de dados");
                    }
                    finally
                    {
                        conn.Close();
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

                        var i = new
                        {

                            USUARIO = usuario,
                            SENHA = senha
                        };

                        conn.Open();

                        var sql = "SELECT * FROM usuarios WHERE usuario = @USUARIO and senha = @SENHA";

                        user = conn.Query<UsuarioModel>(sql, i).FirstOrDefault();

                        return user;


                    }
                    catch
                    {

                        throw new Exception("Erro na conexão com banco de dados");
                    }
                    finally
                    {
                        conn.Close();
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

                        var sql = @"insert into usuarios (nome,usuario,senha) values (@NOME,@USUARIO,@SENHA)";

                        conn.Open();
                        conn.Execute(sql, i);

                        return "Usuário Cadastrado";

                    }
                    catch
                    {
                        throw new Exception("Erro na conexão com banco de dados");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }

            #endregion

            #region Agendamentos

            public void AgendarData(AgendaModel agenda)
            {
                using (IDbConnection conn = new MySqlConnection(MyStringConnnection))
                {
                    try
                    {
                        var i = new

                        {
                            DATA = agenda.Data,
                            HORARIO = agenda.Horario,
                            QTD = agenda.QuantidadeRacao,
                            UMIDA = agenda.Umida
                        };

                        var sql = @"insert into agenda ( data , horario , QuantidadeRacao , umida ) values (@DATA, @HORARIO, @QTD, @UMIDA)";

                        conn.Open();
                        conn.Execute(sql, i);
                                              
                    }
                    catch
                    {
                        throw new Exception("Erro na conexão com banco de dados");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }


            public List<AgendaModel> GetAgendamentos()
            {
                using (IDbConnection conn = new MySqlConnection(MyStringConnnection))
                {
                    try
                    {
                        List<AgendaModel> agenda = new List<AgendaModel>();

                        conn.Open();
                        var sql = "SELECT * FROM agenda";
                        agenda = conn.Query<AgendaModel>(sql).ToList();
                        return agenda;

                    }
                    catch
                    {

                        throw new Exception("Erro na conexão com banco de dados");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }


            #endregion


        }

    }
}
