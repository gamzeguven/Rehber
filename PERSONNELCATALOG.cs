//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rehber
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERSONNELCATALOG
    {
        public int RegisterID { get; set; }
        public int DepartmentID { get; set; }
        public int TitleID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
    
        public virtual DEPARTMENT DEPARTMENT { get; set; }
        public virtual TITLE TITLE { get; set; }
    }
}