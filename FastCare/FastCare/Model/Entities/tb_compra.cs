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
    
    public partial class tb_compra
    {
        public int id_compra { get; set; }
        public Nullable<int> id_prestador { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public Nullable<decimal> vl_compra { get; set; }
        public Nullable<System.DateTime> dt_compra { get; set; }
        public string ds_setor { get; set; }
        public string ds_avaliacao { get; set; }
        public Nullable<int> qt_estrela { get; set; }
    
        public virtual tb_cliente tb_cliente { get; set; }
        public virtual tb_prestador tb_prestador { get; set; }
    }
}
