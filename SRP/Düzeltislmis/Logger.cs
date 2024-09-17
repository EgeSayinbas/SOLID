using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Düzeltislmis
{
    public class Logger
    {
        string _dosyaAdi, _message;
        public Logger(string dosya,string msg)
        {
            _dosyaAdi = dosya;
            _message = msg;
        }
        public bool Logla(string msg)
        {
            File.WriteAllText(_dosyaAdi, msg);
            return true;
        }
    }
}
