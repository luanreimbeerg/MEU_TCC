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
    
    public partial class tb_cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_cliente()
        {
            this.tb_compra = new HashSet<tb_compra>();
            this.tb_servico = new HashSet<tb_servico>();
        }
    
        public int id_cliente { get; set; }
        public Nullable<int> id_login { get; set; }
        public string nm_cliente { get; set; }
        public System.DateTime dt_nasc { get; set; }
        public string ds_rg { get; set; }
        public string ds_cpf { get; set; }
        public string end_cliente { get; set; }
        public string nu_cliente { get; set; }
        public string ds_cep { get; set; }
        public string ds_tel { get; set; }
        public string ds_cel { get; set; }
        public string ds_email { get; set; }
        public string uf_estado { get; set; }
        public string ds_genero { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_compra> tb_compra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_servico> tb_servico { get; set; }
    }
}
