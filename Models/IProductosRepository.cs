using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IProductosRepository
    {

        void add(ProductosModel productosModel);
        void edit(ProductosModel productosModel);
        void delete(int id);
        IEnumerable<ProductosModel> GetAll();
        IEnumerable<ProductosModel> GetByValue(string value);

    }
}
