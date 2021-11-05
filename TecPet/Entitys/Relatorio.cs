using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecPet.Model;

namespace TecPet.Entitys
{
    class Relatorio : Controle
    {
    
    
        public string ConsultarReservatorio()
        {
            double consulta = QtdDepositada - QtdConsumida;
            return DadosRelatorio = $"A quantidade restante é {consulta} gramas";
        }  
        
        public double AdicionarReservatorio (double adicao )
        {
            return QtdDepositada += adicao;

        }


    }
}
