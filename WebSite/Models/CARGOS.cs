//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class CARGOS
    {
        public CARGOS()
        {
            this.EMPLEADOS = new HashSet<EMPLEADOS>();
        }
        [Key]
        [Display(Name = "ID Cargos")]
        public int ID_CARGOS { get; set; }
        [Required(ErrorMessage = "Ingrese nombre correcto")]
        [Display(Name = "Nombre")]
        public string NOMBRE { get; set; }
        [Display(Name = "ID Area")]
        public Nullable<int> ID_AREA { get; set; }
    
        public virtual AREAS AREAS { get; set; }
        public virtual ICollection<EMPLEADOS> EMPLEADOS { get; set; }
    }
}
