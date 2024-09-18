
using ISP.Ornek2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Ornek2.Concrete
{
    internal class Boing780 : IUcabilir, IYolcuTasiyabilir, IKargoTasiyabilir
    {
        public void KargoTasi()
        {
            throw new NotImplementedException();
        }

        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void YolcuTasi()
        {
            throw new NotImplementedException();
        }
    }
}
