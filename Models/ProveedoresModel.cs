using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProveedoresModel
    {
        //Validadores
        [DisplayName("Proveedor Id")]
        public int Id { get; set; }

        [DisplayName("Proveedor Name")]
        //Validadores
        [Required(ErrorMessage = "Proveedor name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Proveedor name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Descripcion")]
        [Required(ErrorMessage = "Proveedor descripcion is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Proveedor descripcion must be between 3 and 200 characters")]
        public string Descripcion { get; set; }
    }
}
