using ISP.Ornek.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Ornek.Validate.Concrete
{
    internal class YeniPenguen : IYuruyebilir, IYuzebilir
    {
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
