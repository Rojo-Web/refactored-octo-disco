using Supermarket_mvp._Repositories;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class ProductosView : Form, IProductosView
    {

        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public ProductosView()
        {
            InitializeComponent();

            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPage2);

            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Add New Producto";
            };

            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit Producto";
            };

            BtnDelete.Click += delegate
            {
                //DeleteEvent?.Invoke(this, EventArgs.Empty);

                var Result = MessageBox.Show(
                        "Are you sure you want to delete the selected Producto", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                    );

                if (Result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Add(tabPage1);
                }
                MessageBox.Show(Message);
            };

            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Add(tabPage1);
            };

        }

        public string ProductoId { get { return TxtId.Text; } set { TxtId.Text = value; } }
        public string ProductoName { get { return TxtName.Text; } set { TxtName.Text = value; } }

        public string ProductoPrecio { get { return TxtPrecio.Text; } set { TxtPrecio.Text = value; } }

        //Cambio importantes
        public string ProductoStock { get { return nUpDownStock.Text; } set { nUpDownStock.Text = value; } }
        public string ProductoCategoria { get { return comboCategorias.Text; } set { comboCategorias.Text = value; } }
        //------------------

        public string SearchValue { get { return TxtSearch.Text; } set { TxtSearch.Text = value; } }
        public bool IsEdit { get { return isEdit; } set { isEdit = value; } }
        public bool IsSuccessful { get { return isSuccessful; } set { isSuccessful = value; } }
        public string Message { get { return message; } set { message = value; } }





        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProductosListBildingSource(BindingSource productosList)
        {
            DgProductos.DataSource = productosList;

        }


        private static ProductosView instance;
        public static ProductosView GetInstance(Form parentCointainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductosView();
                instance.MdiParent = parentCointainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }



    }
}
