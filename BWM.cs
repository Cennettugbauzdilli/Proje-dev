using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödevvv
{
       public class BWM : Arabacs
    {
        public BWM(): base("Mercedes")
        {
        }

        public void vitesTuru()
        {
            Console.WriteLine(marka + " → Otomatik viteslidir.");
        }
    }
    
}

