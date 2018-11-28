namespace FormReservacionHotel
{
    partial class MDIReservacionHotel
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIReservacionHotel));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileCatalogo = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.HotelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ReservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MantenimientoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RespaldoBDBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCatalogo,
            this.GestionMenu,
            this.MantenimientoMenu,
            this.AyudaMenu,
            this.SalirMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(642, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "&Catalogo";
            // 
            // fileCatalogo
            // 
            this.fileCatalogo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientesToolStripMenuItem,
            this.HabitacionesToolStripMenuItem,
            this.toolStripSeparator3,
            this.HotelesToolStripMenuItem});
            this.fileCatalogo.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileCatalogo.Name = "fileCatalogo";
            this.fileCatalogo.Size = new System.Drawing.Size(67, 20);
            this.fileCatalogo.Text = "&Catalogo";
            // 
            // ClientesToolStripMenuItem
            // 
            this.ClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ClientesToolStripMenuItem.Image")));
            this.ClientesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem";
            this.ClientesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ClientesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ClientesToolStripMenuItem.Text = "&Clientes";
            this.ClientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // HabitacionesToolStripMenuItem
            // 
            this.HabitacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("HabitacionesToolStripMenuItem.Image")));
            this.HabitacionesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.HabitacionesToolStripMenuItem.Name = "HabitacionesToolStripMenuItem";
            this.HabitacionesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.HabitacionesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.HabitacionesToolStripMenuItem.Text = "&Habitaciones";
            this.HabitacionesToolStripMenuItem.Click += new System.EventHandler(this.HabitacionesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(183, 6);
            // 
            // HotelesToolStripMenuItem
            // 
            this.HotelesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("HotelesToolStripMenuItem.Image")));
            this.HotelesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.HotelesToolStripMenuItem.Name = "HotelesToolStripMenuItem";
            this.HotelesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.HotelesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.HotelesToolStripMenuItem.Text = "&Hoteles";
            this.HotelesToolStripMenuItem.Click += new System.EventHandler(this.HotelesToolStripMenuItem_Click);
            // 
            // GestionMenu
            // 
            this.GestionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReservacionesToolStripMenuItem});
            this.GestionMenu.Name = "GestionMenu";
            this.GestionMenu.Size = new System.Drawing.Size(59, 20);
            this.GestionMenu.Text = "&Gestion";
            // 
            // ReservacionesToolStripMenuItem
            // 
            this.ReservacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ReservacionesToolStripMenuItem.Image")));
            this.ReservacionesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.ReservacionesToolStripMenuItem.Name = "ReservacionesToolStripMenuItem";
            this.ReservacionesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ReservacionesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ReservacionesToolStripMenuItem.Text = "&Reservaciones";
            this.ReservacionesToolStripMenuItem.Click += new System.EventHandler(this.ReservacionesToolStripMenuItem_Click);
            // 
            // MantenimientoMenu
            // 
            this.MantenimientoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosBarToolStripMenuItem,
            this.RespaldoBDBarToolStripMenuItem});
            this.MantenimientoMenu.Name = "MantenimientoMenu";
            this.MantenimientoMenu.Size = new System.Drawing.Size(101, 20);
            this.MantenimientoMenu.Text = "&Mantenimiento";
            // 
            // UsuariosBarToolStripMenuItem
            // 
            this.UsuariosBarToolStripMenuItem.Checked = true;
            this.UsuariosBarToolStripMenuItem.CheckOnClick = true;
            this.UsuariosBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UsuariosBarToolStripMenuItem.Name = "UsuariosBarToolStripMenuItem";
            this.UsuariosBarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.UsuariosBarToolStripMenuItem.Text = "&Usuarios";
            this.UsuariosBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // RespaldoBDBarToolStripMenuItem
            // 
            this.RespaldoBDBarToolStripMenuItem.Checked = true;
            this.RespaldoBDBarToolStripMenuItem.CheckOnClick = true;
            this.RespaldoBDBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RespaldoBDBarToolStripMenuItem.Name = "RespaldoBDBarToolStripMenuItem";
            this.RespaldoBDBarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.RespaldoBDBarToolStripMenuItem.Text = "&RespaldoBD";
            this.RespaldoBDBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // AyudaMenu
            // 
            this.AyudaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcercaToolStripMenuItem});
            this.AyudaMenu.Name = "AyudaMenu";
            this.AyudaMenu.Size = new System.Drawing.Size(53, 20);
            this.AyudaMenu.Text = "&Ayuda";
            // 
            // AcercaToolStripMenuItem
            // 
            this.AcercaToolStripMenuItem.Name = "AcercaToolStripMenuItem";
            this.AcercaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.AcercaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.AcercaToolStripMenuItem.Text = "&Acerca";
            // 
            // SalirMenu
            // 
            this.SalirMenu.Name = "SalirMenu";
            this.SalirMenu.Size = new System.Drawing.Size(41, 20);
            this.SalirMenu.Text = "&Salir";
            this.SalirMenu.Click += new System.EventHandler(this.SalirMenu_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.printPreviewToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(642, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "Nuevo";
            this.newToolStripButton.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "Abrir";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Guardar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "Imprimir";
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripButton.Image")));
            this.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printPreviewToolStripButton.Text = "Vista previa de impresión";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "Ayuda";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 286);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(642, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // MDIReservacionHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 308);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIReservacionHotel";
            this.Text = "MDIReservacionHotel";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileCatalogo;
        private System.Windows.Forms.ToolStripMenuItem ClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HotelesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionMenu;
        private System.Windows.Forms.ToolStripMenuItem ReservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MantenimientoMenu;
        private System.Windows.Forms.ToolStripMenuItem UsuariosBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RespaldoBDBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AyudaMenu;
        private System.Windows.Forms.ToolStripMenuItem AcercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem SalirMenu;
    }
}



