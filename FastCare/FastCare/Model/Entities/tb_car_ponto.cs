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
    
    public partial class tb_car_ponto
    {
        public int id_car_ponto { get; set; }
        public Nullable<int> id_funcionario { get; set; }
        public Nullable<System.DateTime> dt_dia { get; set; }
        public Nullable<System.TimeSpan> hr_entrada { get; set; }
        public Nullable<System.TimeSpan> hr_almoco { get; set; }
        public Nullable<System.TimeSpan> hr_volta { get; set; }
        public Nullable<System.TimeSpan> hr_saida { get; set; }
        public Nullable<System.TimeSpan> hr_extra { get; set; }
        public Nullable<System.TimeSpan> hr_saidaextra { get; set; }
        public Nullable<int> qt_extra { get; set; }
    
        public virtual tb_funcionario tb_funcionario { get; set; }
    }
}
