using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.TelefonOrnegi
{
    class Iphone : BasePhone
    {
        public override void TakePhoto()
        {
            Console.WriteLine($"{this.GetType().Name}  fotograf cekti");
        }
    }
}
