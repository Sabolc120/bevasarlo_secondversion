using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bevasarlo1
{
    internal class pay
    {
        private decimal tizforint = 10;
        private decimal szazforint = 100;
        private decimal otszazforint = 500;
        private decimal ezerforint = 1000;
        private decimal ketezerforint = 2000;
        private decimal tizezerforint = 10000;

        public decimal Tizforint { get => tizforint; set => tizforint = value; }
        public decimal Szazforint { get => szazforint; set => szazforint = value; }
        public decimal Otszazforint { get => otszazforint; set => otszazforint = value; }
        public decimal Ezerforint { get => ezerforint; set => ezerforint = value; }
        public decimal Ketezerforint { get => ketezerforint; set => ketezerforint = value; }
        public decimal Tizezerforint { get => tizezerforint; set => tizezerforint = value; }
    }
}
