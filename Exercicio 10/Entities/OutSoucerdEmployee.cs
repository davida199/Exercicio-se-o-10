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
