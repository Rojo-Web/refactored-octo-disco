using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class ProveedoresPresenter
    {

        private IProveedoresView view;
        private IProveedoresRepository repository;
        private BindingSource proveedorBindingSource;
        private IEnumerable<ProveedoresModel> proveedorList;

        public ProveedoresPresenter(IProveedoresView view, IProveedoresRepository repository)
        {
            this.proveedorBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += Search;
            this.view.AddNewEvent += AddNew;
            this.view.EditEvent += LoadSelectToEdit;
            this.view.DeleteEvent += DeleteSelected;
            this.view.SaveEvent += Saved;
            this.view.CancelEvent += CancelAction;

            this.view.SetProveedorListBildingSource(proveedorBindingSource);

            loadAllProveedorList();

            this.view.Show();
        }


        private void loadAllProveedorList()
        {
            proveedorList = repository.GetAll();
            proveedorBindingSource.DataSource = proveedorList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void CleanViewFields()
        {
            view.ProveedorId = "0";
            view.ProveedorName = "";
            view.ProveedorDescripcion = "";
        }

        private void Saved(object? sender, EventArgs e)
        {
            var proveedor = new ProveedoresModel();
            proveedor.Id = Convert.ToInt32(view.ProveedorId);
            proveedor.Name = view.ProveedorName;
            proveedor.Descripcion = view.ProveedorDescripcion;

            try
            {
                new Common.ModelDataValidation().Validate(proveedor);
                if (view.IsEdit)
                {
                    repository.edit(proveedor);
                    view.Message = "proveedor edited successfuly";
                }
                else
                {
                    repository.add(proveedor);
                    view.Message = "proveedor added successfuly";
                }
                view.IsSuccessful = true;
                loadAllProveedorList();
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
                var proveedor = (ProveedoresModel)proveedorBindingSource.Current;

                repository.delete(proveedor.Id);
                view.IsSuccessful = true;
                view.Message = "proveedor Deleted Successfuly";
                loadAllProveedorList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not deleted proveedor";
            }
        }

        private void AddNew(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectToEdit(object? sender, EventArgs e)
        {
            // Se obtiene el objeto del datagridview que se encuentra seleccionado
            var proveedor = (ProveedoresModel)proveedorBindingSource.Current;

            //Se cambia el contenido de las cajas por el recuperado
            view.ProveedorId = proveedor.Id.ToString();
            view.ProveedorName = proveedor.Name;
            view.ProveedorDescripcion = proveedor.Descripcion;

            //Se establece el modo como edicion
            view.IsEdit = true;

        }

        private void Search(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                proveedorList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                proveedorList = repository.GetAll();
            }
            proveedorBindingSource.DataSource = proveedorList;
        }


    }
}
