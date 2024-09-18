using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class Loglayici
    {
        public bool Logla(SmsLogger logger)
        {
            return logger.SmsGonder("qweqwe");
        }
        public bool LoglaDb(DbLogger logger)
        {
            return logger.DbYaz("1dfsfd");
        }
        public bool DosyayaYaz(FileLogger logger)
        {
            return logger.DosyayaYaz("sdfsdf");

        }
    }
}
