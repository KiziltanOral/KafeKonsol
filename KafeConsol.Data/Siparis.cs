﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeConsol.Data
{
    public class Siparis
    {
        public int MasaNo { get; set; }
        public SiparisDurum Durum { get; set; }
        public decimal OdenenTutar { get; set; }
        public DateTime AcilisZamani { get; set; } = DateTime.Now;
        public DateTime? KapanisZamani { get; set; }
        public List<SiparisDetay> SiparisDetaylar { get; set; } = new();
        public string ToplamTutarTL => ToplamTutar().ToString("c2"); 

        public decimal ToplamTutar() => SiparisDetaylar.Sum(x => x.Tutar()); // tek satırlık return ü olan metotları bu şekilde döndürebiliyoruz.
        
    }
}
