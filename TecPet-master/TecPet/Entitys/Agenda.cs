using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecPet.Entitys
{
    class Agenda
    {
        public DateTime DataeHora {get; set;}
        public float QntRacao {get; set;}

        public Agenda (DateTime dataehora, float qntracao)
        {
            DataeHora = dataehora;
            QntRacao = qntracao;
           

        }

    }
}
