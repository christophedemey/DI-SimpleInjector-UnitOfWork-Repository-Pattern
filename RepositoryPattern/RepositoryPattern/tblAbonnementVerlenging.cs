//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepositoryPattern
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAbonnementVerlenging
    {
        public int Id { get; set; }
        public int GebruikersID { get; set; }
        public int GroepID { get; set; }
        public string RequestValue { get; set; }
    
        public virtual tblGebruikers tblGebruikers { get; set; }
    }
}
