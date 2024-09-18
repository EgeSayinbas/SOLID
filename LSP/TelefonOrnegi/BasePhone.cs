using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LSP.TelefonOrnegi
{
    internal abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama Yapildi...");
        }
        public abstract void TakePhoto();
    }
}
