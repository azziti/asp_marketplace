//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectAspNETv2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vue
    {
        public int id { get; set; }
        public Nullable<int> product_id { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<int> value { get; set; }
    
        public virtual Produit Produit { get; set; }
    }
}