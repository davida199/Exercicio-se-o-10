using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_10.Entities
{
    sealed class OutSoucerdEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSoucerdEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        public sealed override double payment()
        {
            
            return base.payment()+1.1*AdditionalCharge;
        }
    }
}
/*Fazer um programa para ler os dados de N funcionários (N
fornecido pelo usuário) e armazená-los em uma lista. Depois
de ler todos os dados, mostrar nome e pagamento de cada
funcionário na mesma ordem em que foram digitados.
Construa o programa conforme projeto ao lado. Veja
exemplo na próxima página.*/