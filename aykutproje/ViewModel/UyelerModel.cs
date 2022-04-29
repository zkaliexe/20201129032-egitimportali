using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aykutproje.ViewModel
{
    public class UyelerModel
    {
        public int Uyeid { get; set; }
        public string UyeAdSoyad { get; set; }
        public string UyeMail { get; set; }
        public int UyeYas { get; set; }
        public string UyeParola { get; set; }
        public System.DateTime UyeTarih { get; set; }
        public int UyeYetki { get; set; }
    }
}