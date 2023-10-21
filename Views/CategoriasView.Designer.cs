namespace Supermarket_mvp.Views
{
    partial class CategoriasView
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
            DgCategoria = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)DgCategoria).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbltext1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 125);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.categorias;
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
            lbltext1.Size = new Size(279, 57);
            lbltext1.TabIndex = 0;
            lbltext1.Text = "Categorias";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 128);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(828, 282);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtnClose);
            tabPage1.Controls.Add(BtnDelete);
            tabPage1.Controls.Add(BtnEdit);
            tabPage1.Controls.Add(BtnNew);
            tabPage1.Controls.Add(DgCategoria);
            tabPage1.Controls.Add(BtnSearch);
            tabPage1.Controls.Add(TxtSearch);
            tabPage1.Controls.Add(lblSearch);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(820, 249);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Categoria List";
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
            tabPage2.Size = new Size(820, 249);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Categoria Detail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(547, 183);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(234, 49);
            BtnClose.TabIndex = 15;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(547, 128);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(234, 49);
            BtnDelete.TabIndex = 14;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(547, 73);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(234, 49);
            BtnEdit.TabIndex = 13;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(547, 18);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(234, 49);
            BtnNew.TabIndex = 12;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCategoria
            // 
            DgCategoria.AllowUserToAddRows = false;
            DgCategoria.AllowUserToDeleteRows = false;
            DgCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DgCategoria.DefaultCellStyle = dataGridViewCellStyle4;
            DgCategoria.Location = new Point(18, 65);
            DgCategoria.Name = "DgCategoria";
            DgCategoria.ReadOnly = true;
            DgCategoria.RowHeadersWidth = 51;
            DgCategoria.RowTemplate.Height = 29;
            DgCategoria.Size = new Size(523, 188);
            DgCategoria.TabIndex = 11;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(498, 9);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(43, 50);
            BtnSearch.TabIndex = 10;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(21, 22);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(471, 27);
            TxtSearch.TabIndex = 9;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(21, -1);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(122, 20);
            lblSearch.TabIndex = 8;
            lblSearch.Text = "Search Categoria";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(128, 205);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 39);
            BtnCancel.TabIndex = 15;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(19, 205);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 38);
            BtnSave.TabIndex = 14;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(19, 150);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.PlaceholderText = "Categoria Descripcion";
            TxtDescripcion.Size = new Size(235, 49);
            TxtDescripcion.TabIndex = 13;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(19, 88);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = "Categoria Name";
            TxtName.Size = new Size(125, 27);
            TxtName.TabIndex = 12;
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(19, 26);
            TxtId.Name = "TxtId";
            TxtId.ReadOnly = true;
            TxtId.Size = new Size(125, 27);
            TxtId.TabIndex = 11;
            TxtId.Text = "0";
            TxtId.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(19, 127);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(156, 20);
            lblDescripcion.TabIndex = 10;
            lblDescripcion.Text = "Categoria Descripcion";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(19, 65);
            lblName.Name = "lblName";
            lblName.Size = new Size(118, 20);
            lblName.TabIndex = 9;
            lblName.Text = "Categoria Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(19, 3);
            lblId.Name = "lblId";
            lblId.Size = new Size(91, 20);
            lblId.TabIndex = 8;
            lblId.Text = "Categoria Id";
            // 
            // CategoriasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 422);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriasView";
            Text = "CategoriasView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategoria).EndInit();
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
        private DataGridView DgCategoria;
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