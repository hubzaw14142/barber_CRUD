//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace newbarbershop
{
    using System;
    using System.Collections.Generic;
    
    public partial class klienci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public klienci()
        {
            this.rezerwacje = new HashSet<rezerwacje>();
        }
    
        public int id_klienta { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string adres { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rezerwacje> rezerwacje { get; set; }
    }
}