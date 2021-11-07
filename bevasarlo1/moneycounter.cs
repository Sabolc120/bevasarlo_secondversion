using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bevasarlo1
{
    internal class moneycounter
    {
        private decimal tizforintszam;
        private decimal ezerforintszam;
        private decimal ketezerforintszam;
        private decimal tizezerforintszam;
        private decimal otszazforintszam;
        private decimal szazforintszam;

        public decimal Tizforintszam { get => tizforintszam; set => tizforintszam = value; }
        public decimal Ezerforintszam { get => ezerforintszam; set => ezerforintszam = value; }
        public decimal Ketezerforintszam { get => ketezerforintszam; set => ketezerforintszam = value; }
        public decimal Tizezerforintszam { get => tizezerforintszam; set => tizezerforintszam = value; }
        public decimal Otszazforintszam { get => otszazforintszam; set => otszazforintszam = value; }
        public decimal Szazforintszam { get => szazforintszam; set => szazforintszam = value; }
    }
}
