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
    
    public partial class Usersetsubscription
    {
        public int Id { get; set; }
        public int Set_id { get; set; }
        public int Order { get; set; }
        public string Username { get; set; }
    
        public virtual Userset Userset { get; set; }
    }
}
