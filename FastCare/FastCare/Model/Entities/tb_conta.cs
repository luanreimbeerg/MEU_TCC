//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FastCare.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_conta
    {
        public int id_conta { get; set; }
        public string nm_conta { get; set; }
        public Nullable<System.DateTime> dt_vencimento { get; set; }
        public Nullable<System.DateTime> dt_pagamento { get; set; }
        public string ds_tipo { get; set; }
        public decimal vl_conta { get; set; }
        public Nullable<bool> bl_situacao { get; set; }
    }
}
