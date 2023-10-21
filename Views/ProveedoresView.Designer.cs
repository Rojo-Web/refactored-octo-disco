namespace Supermarket_mvp.Views
{
    partial class ProveedoresView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbltext1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProveedor = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            lblSearch = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtDescripcion = new TextBox();
            TxtName = new TextBox();
            TxtId = new TextBox();
            lblDescripcion = new Label();
            lblName = new Label();
            lblId = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProveedor).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbltext1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fabrica;
            pictureBox1.Location = new Point(89, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lbltext1
            // 
            lbltext1.AutoSize = true;
            lbltext1.Font = new Font("Argent CF Super", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbltext1.Location = new Point(414, 32);
            lbltext1.Name = "lbltext1";
            lbltext1.Size = new Size(318, 57);
            lbltext1.TabIndex = 0;
            lbltext1.Text = "Proveedores";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 131);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 319);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtnClose);
            tabPage1.Controls.Add(BtnDelete);
            tabPage1.Controls.Add(BtnEdit);
            tabPage1.Controls.Add(BtnNew);
            tabPage1.Controls.Add(DgProveedor);
            tabPage1.Controls.Add(BtnSearch);
            tabPage1.Controls.Add(TxtSearch);
            tabPage1.Controls.Add(lblSearch);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 286);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Proveedores List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnCancel);
            tabPage2.Controls.Add(BtnSave);
            tabPage2.Controls.Add(TxtDescripcion);
            tabPage2.Controls.Add(TxtName);
            tabPage2.Controls.Add(TxtId);
            tabPage2.Controls.Add(lblDescripcion);
            tabPage2.Controls.Add(lblName);
            tabPage2.Controls.Add(lblId);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 286);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Proveedores Detail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(544, 200);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(234, 49);
            BtnClose.TabIndex = 23;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(544, 145);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(234, 49);
            BtnDelete.TabIndex = 22;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(544, 90);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(234, 49);
            BtnEdit.TabIndex = 21;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(544, 35);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(234, 49);
            BtnNew.TabIndex = 20;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProveedor
            // 
            DgProveedor.AllowUserToAddRows = false;
            DgProveedor.AllowUserToDeleteRows = false;
            DgProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DgProveedor.DefaultCellStyle = dataGridViewCellStyle4;
            DgProveedor.Location = new Point(15, 82);
            DgProveedor.Name = "DgProveedor";
            DgProveedor.ReadOnly = true;
            DgProveedor.RowHeadersWidth = 51;
            DgProveedor.RowTemplate.Height = 29;
            DgProveedor.Size = new Size(523, 188);
            DgProveedor.TabIndex = 19;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(495, 26);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(43, 50);
            BtnSearch.TabIndex = 18;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(18, 39);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(471, 27);
            TxtSearch.TabIndex = 17;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(18, 16);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(139, 20);
            lblSearch.TabIndex = 16;
            lblSearch.Text = "Search Proveedores";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(132, 215);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 39);
            BtnCancel.TabIndex = 23;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(23, 215);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 38);
            BtnSave.TabIndex = 22;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(23, 160);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.PlaceholderText = "Proveedor Descripcion";
            TxtDescripcion.Size = new Size(235, 49);
            TxtDescripcion.TabIndex = 21;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(23, 98);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = "Proveedor Name";
            TxtName.Size = new Size(125, 27);
            TxtName.TabIndex = 20;
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(23, 36);
            TxtId.Name = "TxtId";
            TxtId.ReadOnly = true;
            TxtId.Size = new Size(125, 27);
            TxtId.TabIndex = 19;
            TxtId.Text = "0";
            TxtId.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(23, 137);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(159, 20);
            lblDescripcion.TabIndex = 18;
            lblDescripcion.Text = "Proveedor Descripcion";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(23, 75);
            lblName.Name = "lblName";
            lblName.Size = new Size(121, 20);
            lblName.TabIndex = 17;
            lblName.Text = "Proveedor Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(23, 13);
            lblId.Name = "lblId";
            lblId.Size = new Size(94, 20);
            lblId.TabIndex = 16;
            lblId.Text = "Proveedor Id";
            // 
            // ProveedoresView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProveedoresView";
            Text = "ProveedoresView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProveedor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbltext1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProveedor;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label lblSearch;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtDescripcion;
        private TextBox TxtName;
        private TextBox TxtId;
        private Label lblDescripcion;
        private Label lblName;
        private Label lblId;
    }
}