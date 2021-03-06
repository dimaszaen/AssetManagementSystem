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
    
    public partial class Employee
    {
        public Employee()
        {
            this.AssetAssigns = new HashSet<AssetAssign>();
            this.Stocks = new HashSet<Stock>();
        }
    
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public string MobileNumber { get; set; }
        public string Designation { get; set; }
        public string DepartmentCode { get; set; }
        public string ExtentionNumber { get; set; }
    
        public virtual ICollection<AssetAssign> AssetAssigns { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
