//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aykutproje.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uyeler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uyeler()
        {
            this.Dersler = new HashSet<Dersler>();
        }
    
        public int Uyeid { get; set; }
        public string UyeAdSoyad { get; set; }
        public string UyeMail { get; set; }
        public int UyeYas { get; set; }
        public string UyeParola { get; set; }
        public System.DateTime UyeTarih { get; set; }
        public int UyeYetki { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dersler> Dersler { get; set; }
    }
}
