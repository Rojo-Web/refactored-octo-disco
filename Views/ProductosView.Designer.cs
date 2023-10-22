namespace Supermarket_mvp.Views
{
    partial class ProductosView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbltext1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProductos = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            lblSearch = new Label();
            tabPage2 = new TabPage();
            label3 = new Label();
            comboCategorias = new ComboBox();
            label2 = new Label();
            TxtPrecio = new TextBox();
            label1 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtDescripcion = new TextBox();
            TxtName = new TextBox();
            TxtId = new TextBox();
            lblDescripcion = new Label();
            lblName = new Label();
            lblId = new Label();
            nUpDownStock = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProductos).BeginInit();
            tabPage2.SuspendLayout();
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
            pictureBox1.Image = Properties.Resources.producto;
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
            lbltext1.Size = new Size(267, 57);
            lbltext1.TabIndex = 0;
            lbltext1.Text = "Productos";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 131);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 322);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtnClose);
            tabPage1.Controls.Add(BtnDelete);
            tabPage1.Controls.Add(BtnEdit);
            tabPage1.Controls.Add(BtnNew);
            tabPage1.Controls.Add(DgProductos);
            tabPage1.Controls.Add(BtnSearch);
            tabPage1.Controls.Add(TxtSearch);
            tabPage1.Controls.Add(lblSearch);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 289);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Productos List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(540, 192);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(234, 49);
            BtnClose.TabIndex = 23;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(540, 137);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(234, 49);
            BtnDelete.TabIndex = 22;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(540, 82);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(234, 49);
            BtnEdit.TabIndex = 21;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(540, 27);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(234, 49);
            BtnNew.TabIndex = 20;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProductos
            // 
            DgProductos.AllowUserToAddRows = false;
            DgProductos.AllowUserToDeleteRows = false;
            DgProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgProductos.DefaultCellStyle = dataGridViewCellStyle2;
            DgProductos.Location = new Point(11, 74);
            DgProductos.Name = "DgProductos";
            DgProductos.ReadOnly = true;
            DgProductos.RowHeadersWidth = 51;
            DgProductos.RowTemplate.Height = 29;
            DgProductos.Size = new Size(523, 188);
            DgProductos.TabIndex = 19;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(491, 18);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(43, 50);
            BtnSearch.TabIndex = 18;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(14, 31);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(471, 27);
            TxtSearch.TabIndex = 17;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(14, 8);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(123, 20);
            lblSearch.TabIndex = 16;
            lblSearch.Text = "Search Productos";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(nUpDownStock);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(comboCategorias);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(TxtPrecio);
            tabPage2.Controls.Add(label1);
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
            tabPage2.Size = new Size(792, 289);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Productos Detail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 104);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 30;
            label3.Text = "Categorias";
            // 
            // comboCategorias
            // 
            comboCategorias.FormattingEnabled = true;
            comboCategorias.Location = new Point(311, 127);
            comboCategorias.Name = "comboCategorias";
            comboCategorias.Size = new Size(151, 28);
            comboCategorias.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(624, 17);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 27;
            label2.Text = "Producto Stock";
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(420, 40);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.PlaceholderText = "$$$$$";
            TxtPrecio.Size = new Size(125, 27);
            TxtPrecio.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 17);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 24;
            label1.Text = "Producto Precio";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(420, 208);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 39);
            BtnCancel.TabIndex = 23;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(263, 208);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 38);
            BtnSave.TabIndex = 22;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(18, 106);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.PlaceholderText = "Producto Descripcion";
            TxtDescripcion.Size = new Size(235, 49);
            TxtDescripcion.TabIndex = 21;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(240, 40);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = "Producto Name";
            TxtName.Size = new Size(125, 27);
            TxtName.TabIndex = 20;
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(18, 40);
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
            lblDescripcion.Location = new Point(18, 83);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(151, 20);
            lblDescripcion.TabIndex = 18;
            lblDescripcion.Text = "Producto Descripcion";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(240, 17);
            lblName.Name = "lblName";
            lblName.Size = new Size(113, 20);
            lblName.TabIndex = 17;
            lblName.Text = "Producto Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(18, 17);
            lblId.Name = "lblId";
            lblId.Size = new Size(86, 20);
            lblId.TabIndex = 16;
            lblId.Text = "Producto Id";
            // 
            // nUpDownStock
            // 
            nUpDownStock.Location = new Point(624, 40);
            nUpDownStock.Name = "nUpDownStock";
            nUpDownStock.PlaceholderText = "Stock";
            nUpDownStock.Size = new Size(125, 27);
            nUpDownStock.TabIndex = 31;
            // 
            // ProductosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductosView";
            Text = "ProductosView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProductos).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private DataGridView DgProductos;
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
        private TextBox TxtPrecio;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox nUpDownStock;
        public static ComboBox comboCategorias;
    }
}