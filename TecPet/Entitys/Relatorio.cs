using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecPet.Entitys
{
    class Relatorio
    {
        public string Dados { get; set; }
        public double QtdDepositada { get; set; }
        public double QtdConsumida { get; set; }


        public Relatorio(string dados, double deposita , double consumida)
        {
            Dados = dados;
            QtdDepositada = deposita;
            QtdConsumida = consumida;

        }

        public string ConsultarReservatorio()
        {
            double consulta = QtdDepositada - QtdConsumida;
            return Dados = $"A quantidade restante é {consulta} gramas";
        }  
        
        public double AdicionarReservatorio (double adicao )
        {
            return QtdDepositada += adicao;

        }


    }
}
