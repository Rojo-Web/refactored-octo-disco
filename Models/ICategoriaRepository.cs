using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface ICategoriaRepository
    {

        void add(CategoriasModel categoriaModel);
        void edit(CategoriasModel categoriaModel);
        void delete(int id);
        IEnumerable<CategoriasModel> GetAll();
        IEnumerable<CategoriasModel> GetByValue(string value);

    }
}
