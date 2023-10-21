﻿using Supermarket_mvp._Repositories;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            //Aqui hayq que agregar cuando hayan mas clases
            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowCategoriaView += ShowCategoriaView;
            this.mainView.ShowProveedorView += ShowProveedorView;
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView) mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository); 
        }

        private void ShowCategoriaView(object? sender, EventArgs e)
        {
            ICategoriaView view = CategoriasView.GetInstance((MainView)mainView);
            ICategoriaRepository repository = new CategoriaRepository(sqlConnectionString);
            new CategoriaPresenter(view, repository);
        }

        private void ShowProveedorView(object? sender, EventArgs e)
        {
            IProveedoresView view = ProveedoresView.GetInstance((MainView)mainView);
            IProveedoresRepository repository = new ProveedoresRepository(sqlConnectionString);
            new ProveedoresPresenter(view, repository);
        }

        //Añadir los metedos conforme a las clases 
    }
}
