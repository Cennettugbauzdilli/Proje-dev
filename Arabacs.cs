using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödevvv
{
    public class Arabacs
    {
        //properties değişkenler
        public string marka;
        public string model;
        public byte kapiSayisi;
        public int pencereSayisi;

        //METODLAR 
        public void git(string markasi, string modeli)
        {
            Console.WriteLine(markasi + " " + modeli + " gidiyor...");
        }


        public void markaModelYaz(string markasi, string modeli)
        {
            Console.WriteLine("arabanın markası : " + markasi + " modeli : " + modeli);
        }
    }
}
