//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Voat.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Userset
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Userset()
        {
            this.Usersetdefinitions = new HashSet<Usersetdefinition>();
            this.Usersetsubscriptions = new HashSet<Usersetsubscription>();
        }
    
        public int Set_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Created_by { get; set; }
        public System.DateTime Created_on { get; set; }
        public bool Public { get; set; }
        public int Subscribers { get; set; }
        public bool Default { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usersetdefinition> Usersetdefinitions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usersetsubscription> Usersetsubscriptions { get; set; }
    }
}
