//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proj.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class SourceOfIncome
    {
        public string Source_Name { get; set; }
        [DataType(DataType.Currency)]
        public Nullable<double> Source_Price { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Date { get; set; }
    }
}