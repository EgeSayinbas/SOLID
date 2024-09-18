using ISP.Ornek.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Ornek.Validate.Concrete
{
    internal class Kartal : IYuruyebilir, IKosabilir, IYuzebilir, IUcabilir
    {
        public void Kos()
        {
            throw new NotImplementedException();
        }

        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Yuru()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
}
