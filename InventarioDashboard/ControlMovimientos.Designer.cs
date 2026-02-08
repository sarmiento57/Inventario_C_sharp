namespace InventarioDashboard
{
    partial class ControlMovimientos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAgregarMovimiento = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarMovimiento = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBuscarMovimiento = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvMovimiento = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.idMovimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMovimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadMovimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaMovimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(3, 119);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(950, 27);
            this.guna2HtmlLabel2.TabIndex = 30;
            this.guna2HtmlLabel2.Text = "Listado de Movimientos";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarMovimiento
            // 
            this.btnAgregarMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarMovimiento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarMovimiento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarMovimiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarMovimiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarMovimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarMovimiento.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMovimiento.Location = new System.Drawing.Point(773, 77);
            this.btnAgregarMovimiento.Name = "btnAgregarMovimiento";
            this.btnAgregarMovimiento.Size = new System.Drawing.Size(180, 36);
            this.btnAgregarMovimiento.TabIndex = 29;
            this.btnAgregarMovimiento.Text = "Agregar";
            this.btnAgregarMovimiento.Click += new System.EventHandler(this.btnAgregarMovimiento_Click);
            // 
            // txtBuscarMovimiento
            // 
            this.txtBuscarMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarMovimiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarMovimiento.DefaultText = "";
            this.txtBuscarMovimiento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarMovimiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarMovimiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarMovimiento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarMovimiento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarMovimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarMovimiento.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarMovimiento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarMovimiento.Location = new System.Drawing.Point(3, 77);
            this.txtBuscarMovimiento.Name = "txtBuscarMovimiento";
            this.txtBuscarMovimiento.PlaceholderText = "";
            this.txtBuscarMovimiento.SelectedText = "";
            this.txtBuscarMovimiento.Size = new System.Drawing.Size(578, 36);
            this.txtBuscarMovimiento.TabIndex = 28;
            // 
            // btnBuscarMovimiento
            // 
            this.btnBuscarMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarMovimiento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarMovimiento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarMovimiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarMovimiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarMovimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarMovimiento.ForeColor = System.Drawing.Color.White;
            this.btnBuscarMovimiento.Location = new System.Drawing.Point(587, 77);
            this.btnBuscarMovimiento.Name = "btnBuscarMovimiento";
            this.btnBuscarMovimiento.Size = new System.Drawing.Size(180, 36);
            this.btnBuscarMovimiento.TabIndex = 27;
            this.btnBuscarMovimiento.Text = "Buscar";
            this.btnBuscarMovimiento.Click += new System.EventHandler(this.btnBuscarMovimiento_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(3, 52);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(109, 19);
            this.guna2HtmlLabel3.TabIndex = 26;
            this.guna2HtmlLabel3.Text = "Filtrar Movimiento";
            // 
            // dgvMovimiento
            // 
            this.dgvMovimiento.AllowUserToAddRows = false;
            this.dgvMovimiento.AllowUserToDeleteRows = false;
            this.dgvMovimiento.AllowUserToResizeColumns = false;
            this.dgvMovimiento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvMovimiento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovimiento.AutoGenerateColumns = false;
            this.dgvMovimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMovimiento.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvMovimiento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMovimiento.ColumnHeadersHeight = 40;
            this.dgvMovimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMovimientoDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.tipoMovimientoDataGridViewTextBoxColumn,
            this.cantidadMovimientoDataGridViewTextBoxColumn,
            this.fechaMovimientoDataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.dgvMovimiento.DataSource = this.movimientoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovimiento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMovimiento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMovimiento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvMovimiento.Location = new System.Drawing.Point(3, 152);
            this.dgvMovimiento.MultiSelect = false;
            this.dgvMovimiento.Name = "dgvMovimiento";
            this.dgvMovimiento.RowHeadersVisible = false;
            this.dgvMovimiento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMovimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMovimiento.Size = new System.Drawing.Size(950, 263);
            this.dgvMovimiento.TabIndex = 25;
            this.dgvMovimiento.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvMovimiento.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvMovimiento.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMovimiento.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMovimiento.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMovimiento.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMovimiento.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMovimiento.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvMovimiento.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvMovimiento.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMovimiento.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMovimiento.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMovimiento.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMovimiento.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvMovimiento.ThemeStyle.ReadOnly = false;
            this.dgvMovimiento.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMovimiento.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMovimiento.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMovimiento.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMovimiento.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMovimiento.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvMovimiento.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMovimiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimiento_CellContentClick);
            this.dgvMovimiento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMovimiento_CellFormatting);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(219, 27);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = "Gestión de Movimientos";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForLinkValue = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForLinkValue = true;
            // 
            // idMovimientoDataGridViewTextBoxColumn
            // 
            this.idMovimientoDataGridViewTextBoxColumn.DataPropertyName = "IdMovimiento";
            this.idMovimientoDataGridViewTextBoxColumn.HeaderText = "IdMovimiento";
            this.idMovimientoDataGridViewTextBoxColumn.Name = "idMovimientoDataGridViewTextBoxColumn";
            this.idMovimientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            // 
            // tipoMovimientoDataGridViewTextBoxColumn
            // 
            this.tipoMovimientoDataGridViewTextBoxColumn.DataPropertyName = "TipoMovimiento";
            this.tipoMovimientoDataGridViewTextBoxColumn.HeaderText = "TipoMovimiento";
            this.tipoMovimientoDataGridViewTextBoxColumn.Name = "tipoMovimientoDataGridViewTextBoxColumn";
            // 
            // cantidadMovimientoDataGridViewTextBoxColumn
            // 
            this.cantidadMovimientoDataGridViewTextBoxColumn.DataPropertyName = "CantidadMovimiento";
            this.cantidadMovimientoDataGridViewTextBoxColumn.HeaderText = "CantidadMovimiento";
            this.cantidadMovimientoDataGridViewTextBoxColumn.Name = "cantidadMovimientoDataGridViewTextBoxColumn";
            // 
            // fechaMovimientoDataGridViewTextBoxColumn
            // 
            this.fechaMovimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaMovimiento";
            this.fechaMovimientoDataGridViewTextBoxColumn.HeaderText = "FechaMovimiento";
            this.fechaMovimientoDataGridViewTextBoxColumn.Name = "fechaMovimientoDataGridViewTextBoxColumn";
            // 
            // observacionDataGridViewTextBoxColumn
            // 
            this.observacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion";
            this.observacionDataGridViewTextBoxColumn.HeaderText = "Observacion";
            this.observacionDataGridViewTextBoxColumn.Name = "observacionDataGridViewTextBoxColumn";
            // 
            // movimientoBindingSource
            // 
            this.movimientoBindingSource.DataSource = typeof(InventarioDashboard.Movimiento);
            // 
            // ControlMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btnAgregarMovimiento);
            this.Controls.Add(this.txtBuscarMovimiento);
            this.Controls.Add(this.btnBuscarMovimiento);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.dgvMovimiento);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "ControlMovimientos";
            this.Size = new System.Drawing.Size(956, 418);
            this.Load += new System.EventHandler(this.ControlMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnAgregarMovimiento;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarMovimiento;
        private Guna.UI2.WinForms.Guna2Button btnBuscarMovimiento;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMovimiento;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMovimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMovimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadMovimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaMovimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
        private System.Windows.Forms.BindingSource movimientoBindingSource;
    }
}
