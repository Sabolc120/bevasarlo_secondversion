using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bevasarlo1
{
    internal class counter
    {
        private decimal chocoQuantity;
        private decimal gummybearQuantity;
        private decimal snacksoupQuantity;
        private decimal freezedpizzaQuantity;

        public decimal ChocoQuantity { get => chocoQuantity; set => chocoQuantity = value; }
        public decimal GummybearQuantity { get => gummybearQuantity; set => gummybearQuantity = value; }
        public decimal SnacksoupQuantity { get => snacksoupQuantity; set => snacksoupQuantity = value; }
        public decimal FreezedpizzaQuantity { get => freezedpizzaQuantity; set => freezedpizzaQuantity = value; }
    }
}
