using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecPet.Model;

namespace TecPet.Entitys
{
    public class HandleFunctions
    {
        UsuarioModel usuario = new UsuarioModel();

        public string redrawWelcome()
        {
            string text;
            if (usuario.Nome != null)
            {
                text =  $"Olá, {usuario.Nome}";
                return text;

            }
            else return "";

        }
    }
}
