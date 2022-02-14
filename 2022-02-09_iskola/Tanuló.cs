using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022_02_09_iskola
{
    class Tanuló
    {
        public int év { get; set; }
        public string osztály { get; set; }

        public string név { get; set; }

        public Tanuló()
        {
            string[] t = sor.split(';');
            év = int.Parse(t[0]);
            osztály = t[1];
            név = t[2];
         }
    }
}
