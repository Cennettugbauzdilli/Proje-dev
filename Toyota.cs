using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödevvv
{
    public class Toyota : Arabacs
    {
        public Toyota() : base("Mercedes")
        {
        }

        public void vitesTuru()
        {
            Console.WriteLine(marka + " → Otomatik viteslidir.");
        }
    }
}
