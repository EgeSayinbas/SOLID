using LSP.TelefonOrnegi.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.TelefonOrnegi.Validate.Concrete
{
    internal class NewIphone : NewBasePhone, ITakePhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Fotograf Cekildi");
        }
        public void TakeVideo()
        {

        }
    }
}
