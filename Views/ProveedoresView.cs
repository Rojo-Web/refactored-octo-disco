﻿using System;
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
    public partial class ProveedoresView : Form, IProveedoresView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public ProveedoresView()
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
                tabPage2.Text = "Add New Proveedor";
            };

            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit Proveedor";
            };

            BtnDelete.Click += delegate
            {
                //DeleteEvent?.Invoke(this, EventArgs.Empty);

                var Result = MessageBox.Show(
                        "Are you sure you want to delete the selected Proveedor", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
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


        public string ProveedorId { get { return TxtId.Text; } set { TxtId.Text = value; } }
        public string ProveedorName { get { return TxtName.Text; } set { TxtName.Text = value; } }
        public string ProveedorDescripcion { get { return TxtDescripcion.Text; } set { TxtDescripcion.Text = value; } }
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

        public void SetProveedorListBildingSource(BindingSource proveedorList)
        {
            DgProveedor.DataSource = proveedorList;
        }

        private static ProveedoresView instance;
        public static ProveedoresView GetInstance(Form parentCointainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProveedoresView();
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
