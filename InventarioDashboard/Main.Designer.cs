namespace InventarioDashboard
{
    partial class Main
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMovimiento = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategoria = new Guna.UI2.WinForms.Guna2Button();
            this.btnProducto = new Guna.UI2.WinForms.Guna2Button();
            this.panelTitulo = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMenuUser = new Guna.UI2.WinForms.Guna2Button();
            this.cmsMenuUser = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.verPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelContenido = new Guna.UI2.WinForms.Guna2Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.cmsMenuUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderColor = System.Drawing.Color.DarkGray;
            this.panelMenu.BorderThickness = 1;
            this.panelMenu.Controls.Add(this.btnMovimiento);
            this.panelMenu.Controls.Add(this.btnCategoria);
            this.panelMenu.Controls.Add(this.btnProducto);
            this.panelMenu.CustomBorderColor = System.Drawing.Color.Transparent;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(60, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // btnMovimiento
            // 
            this.btnMovimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMovimiento.BackColor = System.Drawing.Color.Transparent;
            this.btnMovimiento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMovimiento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMovimiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMovimiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMovimiento.FillColor = System.Drawing.Color.Transparent;
            this.btnMovimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMovimiento.ForeColor = System.Drawing.Color.White;
            this.btnMovimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnMovimiento.Image")));
            this.btnMovimiento.ImageSize = new System.Drawing.Size(35, 35);
            this.btnMovimiento.Location = new System.Drawing.Point(3, 202);
            this.btnMovimiento.Name = "btnMovimiento";
            this.btnMovimiento.Size = new System.Drawing.Size(54, 47);
            this.btnMovimiento.TabIndex = 2;
            this.btnMovimiento.Click += new System.EventHandler(this.btnMovimiento_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnCategoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategoria.FillColor = System.Drawing.Color.Transparent;
            this.btnCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoria.Image")));
            this.btnCategoria.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCategoria.Location = new System.Drawing.Point(3, 255);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(54, 47);
            this.btnCategoria.TabIndex = 1;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProducto.FillColor = System.Drawing.Color.Transparent;
            this.btnProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.Image")));
            this.btnProducto.ImageSize = new System.Drawing.Size(35, 35);
            this.btnProducto.Location = new System.Drawing.Point(3, 149);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(54, 47);
            this.btnProducto.TabIndex = 0;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BorderColor = System.Drawing.Color.DarkGray;
            this.panelTitulo.BorderThickness = 1;
            this.panelTitulo.Controls.Add(this.btnMenuUser);
            this.panelTitulo.Controls.Add(this.guna2PictureBox1);
            this.panelTitulo.Controls.Add(this.guna2HtmlLabel1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelTitulo.Location = new System.Drawing.Point(60, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(740, 60);
            this.panelTitulo.TabIndex = 1;
            // 
            // btnMenuUser
            // 
            this.btnMenuUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMenuUser.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuUser.ContextMenuStrip = this.cmsMenuUser;
            this.btnMenuUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenuUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenuUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenuUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenuUser.FillColor = System.Drawing.Color.Transparent;
            this.btnMenuUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMenuUser.ForeColor = System.Drawing.Color.White;
            this.btnMenuUser.Image = global::InventarioDashboard.Properties.Resources.NET_core;
            this.btnMenuUser.ImageSize = new System.Drawing.Size(35, 35);
            this.btnMenuUser.Location = new System.Drawing.Point(608, 3);
            this.btnMenuUser.Name = "btnMenuUser";
            this.btnMenuUser.Size = new System.Drawing.Size(60, 54);
            this.btnMenuUser.TabIndex = 4;
            this.btnMenuUser.Click += new System.EventHandler(this.btnMenuUser_Click);
            // 
            // cmsMenuUser
            // 
            this.cmsMenuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPerfilToolStripMenuItem,
            this.cerrarSesiToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.cmsMenuUser.Name = "cmsMenuUser";
            this.cmsMenuUser.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsMenuUser.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsMenuUser.RenderStyle.ColorTable = null;
            this.cmsMenuUser.RenderStyle.RoundedEdges = true;
            this.cmsMenuUser.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsMenuUser.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsMenuUser.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsMenuUser.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsMenuUser.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsMenuUser.Size = new System.Drawing.Size(181, 92);
            this.cmsMenuUser.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsMenuUser_ItemClicked);
            // 
            // verPerfilToolStripMenuItem
            // 
            this.verPerfilToolStripMenuItem.Name = "verPerfilToolStripMenuItem";
            this.verPerfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verPerfilToolStripMenuItem.Text = "Ver perfil";
            // 
            // cerrarSesiToolStripMenuItem
            // 
            this.cerrarSesiToolStripMenuItem.Name = "cerrarSesiToolStripMenuItem";
            this.cerrarSesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesiToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::InventarioDashboard.Properties.Resources.store_business_and_finance_svgrepo_com;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(44, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(95, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(239, 34);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Inventario Dashboard";
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.FillColor = System.Drawing.Color.White;
            this.panelContenido.Location = new System.Drawing.Point(60, 60);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(740, 390);
            this.panelContenido.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.cmsMenuUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Panel panelTitulo;
        private Guna.UI2.WinForms.Guna2Button btnProducto;
        private Guna.UI2.WinForms.Guna2Button btnMovimiento;
        private Guna.UI2.WinForms.Guna2Button btnCategoria;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsMenuUser;
        private System.Windows.Forms.ToolStripMenuItem verPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnMenuUser;
        private Guna.UI2.WinForms.Guna2Panel panelContenido;
    }
}

