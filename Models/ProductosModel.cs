using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProductosModel
    {

        //Validadores
        [DisplayName("Productos Id")]
        public int Id { get; set; }

        [DisplayName("Productos Name")]
        //Validadores
        [Required(ErrorMessage = "Productos name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Productos name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Precio")]
        [Required(ErrorMessage = "Productos precio is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Productos precio must be between 3 and 50 characters")]
        public double Precio { get; set; }

        [DisplayName("Stock")]
        [Required(ErrorMessage = "Productos Stock is required")]
        public int Stock { get; set; }

        //Para los combos
        [DisplayName("Categoria")]
        [Required(ErrorMessage = "Productos Categoria is required")]
        public string Categoria { get; set; }

        [DisplayName("Proveedores")]
        [Required(ErrorMessage = "Productos Proveedores is required")]
        public string Proveedores { get; set; }
    }
}
