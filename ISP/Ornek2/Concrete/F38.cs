using ISP.Ornek.Validate.Abstract;
using ISP.Ornek2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IUcabilir = ISP.Ornek2.Abstract.IUcabilir;


namespace ISP.Ornek2.Concrete
{
    internal class F38 : IGozlemYapabilir,IBombalayabilir,IUcabilir
    {
        public void Bombala()
        {
            throw new NotImplementedException();
        }

        public void GozlemYap()
        {
            throw new NotImplementedException();
        }

        public void Uc()
        {
            throw new NotImplementedException();
        }
    }
}
