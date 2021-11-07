using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bevasarlo1
{
    internal class prices
    {
        private decimal chocoprice = 300;
        private decimal gummybearPrice = 450;
        private decimal snackSoup = 200;
        private decimal freezedPizza = 700;

        public decimal Chocoprice { get => chocoprice; set => chocoprice = value; }
        public decimal GummybearPrice { get => gummybearPrice; set => gummybearPrice = value; }
        public decimal SnackSoup { get => snackSoup; set => snackSoup = value; }
        public decimal FreezedPizza { get => freezedPizza; set => freezedPizza = value; }
    }
}
