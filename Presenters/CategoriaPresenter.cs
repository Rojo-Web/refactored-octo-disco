using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Presenters
{
    internal class CategoriaPresenter
    {
        private ICategoriaView view;
        private ICategoriaRepository repository;
        private BindingSource categoriaBindingSource;
        private IEnumerable<CategoriasModel> categoriaList;

        public CategoriaPresenter(ICategoriaView view, ICategoriaRepository repository)
        {
            this.categoriaBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += Search;
            this.view.AddNewEvent += AddNew;
            this.view.EditEvent += LoadSelectToEdit;
            this.view.DeleteEvent += DeleteSelected;
            this.view.SaveEvent += Saved;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoriaListBildingSource(categoriaBindingSource);

            loadAllCategoriaList();

            this.view.Show();
        }

        private void loadAllCategoriaList()
        {
            categoriaList = repository.GetAll();
            categoriaBindingSource.DataSource = categoriaList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void CleanViewFields()
        {
            view.CategoriaId = "0";
            view.CategoriaName = "";
            view.CategoriaDescripcion = "";
        }

        private void Saved(object? sender, EventArgs e)
        {
            var categoria = new CategoriasModel();
            categoria.Id = Convert.ToInt32(view.CategoriaId);
            categoria.Name = view.CategoriaName;
            categoria.Descripcion = view.CategoriaDescripcion;

            try
            {
                new Common.ModelDataValidation().Validate(categoria);
                if (view.IsEdit)
                {
                    repository.edit(categoria);
                    view.Message = "Categoria edited successfuly";
                }
                else
                {
                    repository.add(categoria);
                    view.Message = "Categoria added successfuly";
                }
                view.IsSuccessful = true;
                loadAllCategoriaList();
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
                var categoria = (CategoriasModel)categoriaBindingSource.Current;

                repository.delete(categoria.Id);
                view.IsSuccessful = true;
                view.Message = "Categoria Deleted Successfuly";
                loadAllCategoriaList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not deleted categoria";
            }
        }

        private void AddNew(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectToEdit(object? sender, EventArgs e)
        {
            // Se obtiene el objeto del datagridview que se encuentra seleccionado
            var categoria = (CategoriasModel)categoriaBindingSource.Current;

            //Se cambia el contenido de las cajas por el recuperado
            view.CategoriaId = categoria.Id.ToString();
            view.CategoriaName = categoria.Name;
            view.CategoriaDescripcion = categoria.Descripcion;

            //Se establece el modo como edicion
            view.IsEdit = true;

        }

        private void Search(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categoriaList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoriaList = repository.GetAll();
            }
            categoriaBindingSource.DataSource = categoriaList;
        }

    }
}
