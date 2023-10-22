using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IProductosView
    {

        string ProductoId { get; set; }
        string ProductoName { get; set; }
        string ProductoPrecio { get; set; }
        string ProductoStock { get; set; }

        string ProductoCategoria { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;


        void SetProductosListBildingSource(BindingSource productosList);
        void Show();

    }
}
