using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrairCelular.Models
{
    internal class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero,modelo,imei,memoria) {}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O Aplicativo {nomeApp} será instalado através da apple store");
        }
    }
}
