//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITAssetManagementSystem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.Assets = new HashSet<Asset>();
        }
    
        public int CategoryId { get; set; }
        public string CategoryTitle { get; set; }
    
        public virtual ICollection<Asset> Assets { get; set; }
    }
}