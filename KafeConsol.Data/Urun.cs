﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeConsol.Data
{
    public class Urun
    {
        public string UrunAd { get; set; } = null!;
        public decimal BirimFiyat { get; set; }

        public override string ToString()
        {
            return $"{UrunAd} ({BirimFiyat:c2})";
        }
    }
}
