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
    
    public partial class Stickiedsubmission
    {
        public int Submission_id { get; set; }
        public string Subversename { get; set; }
        public string Stickied_by { get; set; }
        public System.DateTime Stickied_date { get; set; }
    
        public virtual Message Message { get; set; }
        public virtual Subverse Subverse { get; set; }
    }
}
