using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class ProductosPresenter
    {
        private IProductosView view;
        private IProductosRepository repository;
        private BindingSource productosBindingSource;
        private IEnumerable<ProductosModel> productosList;

        public ProductosPresenter(IProductosView view, IProductosRepository repository)
        {
            this.productosBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += Search;
            this.view.AddNewEvent += AddNew;
            this.view.EditEvent += LoadSelectToEdit;
            this.view.DeleteEvent += DeleteSelected;
            this.view.SaveEvent += Saved;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductosListBildingSource(productosBindingSource);

            loadAllProductosList();

            this.view.Show();
        }

        private void loadAllProductosList()
        {
            productosList = repository.GetAll();
            productosBindingSource.DataSource = productosList;

            
            
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void CleanViewFields()
        {
            view.ProductoId = "0";
            view.ProductoName = "";
            view.ProductoPrecio = "";
            view.ProductoStock = "";
            view.ProductoCategoria = "";

        }


        private void Saved(object? sender, EventArgs e)
        {
            var productos = new ProductosModel();
            productos.Id = Convert.ToInt32(view.ProductoId);
            productos.Name = view.ProductoName;
            productos.Precio = Convert.ToInt32(view.ProductoPrecio);
            productos.Stock = Convert.ToInt32(view.ProductoStock);
            productos.Categoria = Convert.ToInt32(view.ProductoCategoria.Substring(0,6));

            try
            {
                new Common.ModelDataValidation().Validate(productos);
                if (view.IsEdit)
                {
                    repository.edit(productos);
                    view.Message = "productos edited successfuly";
                }
                else
                {
                    repository.add(productos);
                    view.Message = "productos added successfuly";
                }
                view.IsSuccessful = true;
                loadAllProductosList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteSelected(object? sender, EventArgs e)
        {
            try
            {
                var productos = (ProductosModel)productosBindingSource.Current;

                repository.delete(productos.Id);
                view.IsSuccessful = true;
                view.Message = "Productos Deleted Successfuly";
                loadAllProductosList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not deleted productos";
            }
        }


        private void AddNew(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectToEdit(object? sender, EventArgs e)
        {
            // Se obtiene el objeto del datagridview que se encuentra seleccionado
            var productos = (ProductosModel)productosBindingSource.Current;

            //Se cambia el contenido de las cajas por el recuperado
            view.ProductoId = productos.Id.ToString();
            view.ProductoName = productos.Name;
            view.ProductoPrecio = productos.Precio.ToString();
            view.ProductoStock = productos.Stock.ToString();
            view.ProductoCategoria = productos.Categoria.ToString();

            //Se establece el modo como edicion
            view.IsEdit = true;

        }

        private void Search(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productosList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productosList = repository.GetAll();
            }
            productosBindingSource.DataSource = productosList;
        }
    }
}
