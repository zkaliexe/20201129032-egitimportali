﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aykutproje.ViewModel
{
    public class DerslerModel
    {
        public int Dersid { get; set; }
        public string DersAd { get; set; }
        public string Dersicerik { get; set; }
        public string DersDurum { get; set; }
        public int dKatid { get; set; }
        public int dUyeid { get; set; }
        public System.DateTime dBaslamaTarih { get; set; }
        public System.DateTime dBitirmeTarih { get; set; }

    }
}