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
    
    public partial class ASISTENCIAS
    {
        [Key]
        [Display(Name = "ID")]
        public int ID_sis { get; set; }
        [Required(ErrorMessage = "Ingrese fecha correcta")]
        [Display(Name = "Fecha")]
        public string FECHA { get; set; }
        [Required(ErrorMessage = "Ingrese id empleado")]
        [Display(Name = "ID Empleado")]
        public Nullable<int> ID_EMPLEADO { get; set; }
        [Display(Name = "Hora Ingreso")]
        public string HORA_INGRESO { get; set; }
        [Display(Name = "Hora Salida")]
        public string HORA_SALIDA { get; set; }
        [Display(Name = "Observaciones")]
        public string OBSERVACIONES { get; set; }
    }
}
