using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += SavedPayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModelListBildingSource(payModeBindingSource);

            loadAllPayModeList();

            this.view.Show();
        }

        private void loadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavedPayMode(object? sender, EventArgs e)
        {
            var payMode = new PayModeModel();
            payMode.Id = Convert.ToInt32(view.PayModelId);
            payMode.Name = view.PayModeName;
            payMode.Observation = view.PayModeObservation;

            try {
                new Common.ModelDataValidation().Validate(payMode);
                if (view.IsEdit)
                {
                    repository.edit(payMode);
                    view.Message = "PayMode edited successfuly";
                }
                else
                {
                    repository.add(payMode);
                    view.Message = "PayMode added successfuly";
                }
                view.IsSuccessful = true;
                loadAllPayModeList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.PayModelId = "0";
            view.PayModeName = "";
            view.PayModeObservation = "";
        }

        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            try
            {
                var payMode = (PayModeModel)payModeBindingSource.Current;

                repository.delete(payMode.Id);
                view.IsSuccessful = true;
                view.Message = "Pay Mode Deleted Successfuly";
                loadAllPayModeList();
            } catch (Exception ex) { 
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not deleted pay mode";
            }
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            // Se obtiene el objeto del datagridview que se encuentra seleccionado
            var payMode = (PayModeModel)payModeBindingSource.Current;

            //Se cambia el contenido de las cajas por el recuperado
            view.PayModelId = payMode.Id.ToString();
            view.PayModeName = payMode.Name;
            view.PayModeObservation= payMode.Observation;

            //Se establece el modo como edicion
            view.IsEdit = true;

        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if(emptyValue == false)
            {
                payModeList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                payModeList = repository.GetAll();
            }
            payModeBindingSource.DataSource = payModeList;
        }
    }
}
