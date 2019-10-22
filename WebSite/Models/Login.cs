using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSite.Models
{
    public partial class Login
    {
        [Key]
        [Required(ErrorMessage="Ingrese el usuario",AllowEmptyStrings=false)]
        public string ID_USUARIO { get; set; }
        [Required(ErrorMessage = "Ingrese el contraseña", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string CONTRASEÑA { get; set; }
        public string TIPO { get; set; }
    }
}