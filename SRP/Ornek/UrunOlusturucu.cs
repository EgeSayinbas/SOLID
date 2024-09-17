using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRP.Entities;

namespace SRP.Ornek
{
    public class UrunOlusturucu
    {
        public void UrunEkle(Urun urun)
        {
            try
            {
                #region Urun Kayit Islemi
                string mesaj = $"{DateTime.Now} ;{urun.UrunAdi} Created";
                File.WriteAllText("Urunler.csv", mesaj);
                #endregion
                #region MyRegion
                string log = $"{DateTime.Now} ;{urun.UrunAdi} Kaydedildi";
                File.WriteAllText("UrunLog.csv", log);
                #endregion
            }
            catch (Exception ex)
            {

                #region Hatalari Loglayalim
                File.WriteAllText("Hata.log", $"{DateTime.Now} {ex.Message}");
                #endregion
            }
        }
    }
}
