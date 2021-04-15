using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld32.Entities
{
    class OutsourcedEmployee : Employee // Herdando caracteristicas da super classe ('Employee').
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHours, double additionalCharge) : base(name, hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }


        public override double Payment() // Método sobreescrito.
        {
            return base.Payment() + (1.10 * AdditionalCharge) ;
        }
    }
}
