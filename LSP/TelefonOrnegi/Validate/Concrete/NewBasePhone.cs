using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.TelefonOrnegi.Validate.Concrete
{
    internal class NewBasePhone

    {
        public string Marka { get; set; }
        public virtual void Call()
        {
            Console.WriteLine("Arama Yapildi...");
        }
    }
}
