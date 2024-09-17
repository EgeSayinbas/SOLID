using SRP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Düzeltislmis
{

    //Burada loglama islemi ayri bir sinifa verilmistir
    //buradaki sinifin isi sadece urun create etmektir
    public class UrunCreate
    {
        public Logger Logger { get; set; }
        public UrunCreate()
        {
            Logger = new Logger("UrunTanimlari.csv", "Urun Kayit Islemi : " + DateTime.Now);
        }
        public void UrunEkle(Urun urun)
        {
            string kayit = "";
            if (!string.IsNullOrEmpty(urun.urunAdi))
            {
                kayit = $"{DateTime.Now} ; {urun.UrunAdi}; Created";
            }
            else
            {
                kayit = $"{DateTime.Now} ; {urun.UrunAdi}; Created";
            }
            
            Logger.Logla(kayit);
        }
    }
}
