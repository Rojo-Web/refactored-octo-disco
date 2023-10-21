using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IProveedoresRepository
    {

        void add(ProveedoresModel proveedorModel);
        void edit(ProveedoresModel proveedorModel);
        void delete(int id);
        IEnumerable<ProveedoresModel> GetAll();
        IEnumerable<ProveedoresModel> GetByValue(string value);
    }
}
