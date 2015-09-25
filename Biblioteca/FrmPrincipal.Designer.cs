namespace Biblioteca
{
    partial class FrmPrincipal
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
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.encabezado1lb = new System.Windows.Forms.Label();
            this.titulolb = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaDelClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarCuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeMorososToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeLibrosBajadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaDeContratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaDeCuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaDeDonacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoDeInsumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reciboDeSueldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDeReciboDeSueldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirReciboDeSueldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AllowUserToAddRows = false;
            this.librosDataGridView.AllowUserToDeleteRows = false;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Location = new System.Drawing.Point(100, 141);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.ReadOnly = true;
            this.librosDataGridView.Size = new System.Drawing.Size(543, 220);
            this.librosDataGridView.TabIndex = 10;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Location = new System.Drawing.Point(239, 100);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(210, 20);
            this.tituloTextBox.TabIndex = 11;
            // 
            // encabezado1lb
            // 
            this.encabezado1lb.AutoSize = true;
            this.encabezado1lb.Location = new System.Drawing.Point(48, 105);
            this.encabezado1lb.Name = "encabezado1lb";
            this.encabezado1lb.Size = new System.Drawing.Size(174, 13);
            this.encabezado1lb.TabIndex = 8;
            this.encabezado1lb.Text = "Ingrese el nombre del libro a buscar";
            // 
            // titulolb
            // 
            this.titulolb.AutoSize = true;
            this.titulolb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulolb.Location = new System.Drawing.Point(235, 57);
            this.titulolb.Name = "titulolb";
            this.titulolb.Size = new System.Drawing.Size(268, 23);
            this.titulolb.TabIndex = 7;
            this.titulolb.Text = "Biblioteca Popular Mariano Moreno";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.librosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.listadoToolStripMenuItem,
            this.fichasToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.reciboDeSueldoToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.bajasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem,
            this.importarToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarLibrosToolStripMenuItem,
            this.borrarLibrosToolStripMenuItem,
            this.modificarLibrosToolStripMenuItem,
            this.consultaDeLibrosToolStripMenuItem});
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // agregarLibrosToolStripMenuItem
            // 
            this.agregarLibrosToolStripMenuItem.Name = "agregarLibrosToolStripMenuItem";
            this.agregarLibrosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.agregarLibrosToolStripMenuItem.Text = "Agregar libros";
            this.agregarLibrosToolStripMenuItem.Click += new System.EventHandler(this.agregarLibrosToolStripMenuItem_Click);
            // 
            // borrarLibrosToolStripMenuItem
            // 
            this.borrarLibrosToolStripMenuItem.Name = "borrarLibrosToolStripMenuItem";
            this.borrarLibrosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.borrarLibrosToolStripMenuItem.Text = "Borrar libros";
            // 
            // modificarLibrosToolStripMenuItem
            // 
            this.modificarLibrosToolStripMenuItem.Name = "modificarLibrosToolStripMenuItem";
            this.modificarLibrosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modificarLibrosToolStripMenuItem.Text = "Modificar Libros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichaDelClienteToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem,
            this.agregarClienteToolStripMenuItem,
            this.modificarClienteToolStripMenuItem,
            this.pagarCuotaToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // fichaDelClienteToolStripMenuItem
            // 
            this.fichaDelClienteToolStripMenuItem.Name = "fichaDelClienteToolStripMenuItem";
            this.fichaDelClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.fichaDelClienteToolStripMenuItem.Text = "Ficha del Cliente";
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.eliminarClienteToolStripMenuItem.Text = "Eliminar Cliente";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            // 
            // pagarCuotaToolStripMenuItem
            // 
            this.pagarCuotaToolStripMenuItem.Name = "pagarCuotaToolStripMenuItem";
            this.pagarCuotaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.pagarCuotaToolStripMenuItem.Text = "Pagar cuota";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeClientesToolStripMenuItem,
            this.listadoDeLibrosToolStripMenuItem,
            this.listadoDeMorososToolStripMenuItem,
            this.listadoDeLibrosBajadosToolStripMenuItem});
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.listadoDeClientesToolStripMenuItem.Text = "Listado de Clientes";
            // 
            // listadoDeLibrosToolStripMenuItem
            // 
            this.listadoDeLibrosToolStripMenuItem.Name = "listadoDeLibrosToolStripMenuItem";
            this.listadoDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.listadoDeLibrosToolStripMenuItem.Text = "Listado de Libros";
            // 
            // listadoDeMorososToolStripMenuItem
            // 
            this.listadoDeMorososToolStripMenuItem.Name = "listadoDeMorososToolStripMenuItem";
            this.listadoDeMorososToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.listadoDeMorososToolStripMenuItem.Text = "Listado de Morosos";
            // 
            // listadoDeLibrosBajadosToolStripMenuItem
            // 
            this.listadoDeLibrosBajadosToolStripMenuItem.Name = "listadoDeLibrosBajadosToolStripMenuItem";
            this.listadoDeLibrosBajadosToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.listadoDeLibrosBajadosToolStripMenuItem.Text = "Listado de Libros bajados";
            // 
            // fichasToolStripMenuItem
            // 
            this.fichasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichaDeContratoToolStripMenuItem,
            this.fichaDeCuotaToolStripMenuItem,
            this.fichaDeLibrosToolStripMenuItem,
            this.fichaDeDonacionToolStripMenuItem});
            this.fichasToolStripMenuItem.Name = "fichasToolStripMenuItem";
            this.fichasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fichasToolStripMenuItem.Text = "Fichas";
            // 
            // fichaDeContratoToolStripMenuItem
            // 
            this.fichaDeContratoToolStripMenuItem.Name = "fichaDeContratoToolStripMenuItem";
            this.fichaDeContratoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.fichaDeContratoToolStripMenuItem.Text = "Ficha de Contrato";
            // 
            // fichaDeCuotaToolStripMenuItem
            // 
            this.fichaDeCuotaToolStripMenuItem.Name = "fichaDeCuotaToolStripMenuItem";
            this.fichaDeCuotaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.fichaDeCuotaToolStripMenuItem.Text = "Ficha de Cuota";
            // 
            // fichaDeLibrosToolStripMenuItem
            // 
            this.fichaDeLibrosToolStripMenuItem.Name = "fichaDeLibrosToolStripMenuItem";
            this.fichaDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.fichaDeLibrosToolStripMenuItem.Text = "Ficha de Libros";
            // 
            // fichaDeDonacionToolStripMenuItem
            // 
            this.fichaDeDonacionToolStripMenuItem.Name = "fichaDeDonacionToolStripMenuItem";
            this.fichaDeDonacionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.fichaDeDonacionToolStripMenuItem.Text = "Ficha de Donacion";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoDeLibrosToolStripMenuItem,
            this.pedidoDeInsumosToolStripMenuItem,
            this.consultarPedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // pedidoDeLibrosToolStripMenuItem
            // 
            this.pedidoDeLibrosToolStripMenuItem.Name = "pedidoDeLibrosToolStripMenuItem";
            this.pedidoDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.pedidoDeLibrosToolStripMenuItem.Text = "Pedido de Libros";
            // 
            // pedidoDeInsumosToolStripMenuItem
            // 
            this.pedidoDeInsumosToolStripMenuItem.Name = "pedidoDeInsumosToolStripMenuItem";
            this.pedidoDeInsumosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.pedidoDeInsumosToolStripMenuItem.Text = "Pedido de Insumos";
            // 
            // consultarPedidosToolStripMenuItem
            // 
            this.consultarPedidosToolStripMenuItem.Name = "consultarPedidosToolStripMenuItem";
            this.consultarPedidosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.consultarPedidosToolStripMenuItem.Text = "Consultar Pedidos";
            // 
            // reciboDeSueldoToolStripMenuItem
            // 
            this.reciboDeSueldoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaDeReciboDeSueldoToolStripMenuItem,
            this.imprimirReciboDeSueldoToolStripMenuItem});
            this.reciboDeSueldoToolStripMenuItem.Name = "reciboDeSueldoToolStripMenuItem";
            this.reciboDeSueldoToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.reciboDeSueldoToolStripMenuItem.Text = "Recibo de Sueldo";
            // 
            // busquedaDeReciboDeSueldoToolStripMenuItem
            // 
            this.busquedaDeReciboDeSueldoToolStripMenuItem.Name = "busquedaDeReciboDeSueldoToolStripMenuItem";
            this.busquedaDeReciboDeSueldoToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.busquedaDeReciboDeSueldoToolStripMenuItem.Text = "Busqueda de Recibo de Sueldo";
            // 
            // imprimirReciboDeSueldoToolStripMenuItem
            // 
            this.imprimirReciboDeSueldoToolStripMenuItem.Name = "imprimirReciboDeSueldoToolStripMenuItem";
            this.imprimirReciboDeSueldoToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.imprimirReciboDeSueldoToolStripMenuItem.Text = "Imprimir Recibo de Sueldo";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem1,
            this.manualesToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.acercaDeToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.acercaDeToolStripMenuItem1.Text = "Manuales             (F1)";
            // 
            // manualesToolStripMenuItem
            // 
            this.manualesToolStripMenuItem.Name = "manualesToolStripMenuItem";
            this.manualesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.manualesToolStripMenuItem.Text = "Acerca de";
            // 
            // bajasToolStripMenuItem
            // 
            this.bajasToolStripMenuItem.Name = "bajasToolStripMenuItem";
            this.bajasToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.bajasToolStripMenuItem.Text = "Salir";
            // 
            // consultaDeLibrosToolStripMenuItem
            // 
            this.consultaDeLibrosToolStripMenuItem.Name = "consultaDeLibrosToolStripMenuItem";
            this.consultaDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.consultaDeLibrosToolStripMenuItem.Text = "Consulta de Libros";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 399);
            this.Controls.Add(this.librosDataGridView);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(this.encabezado1lb);
            this.Controls.Add(this.titulolb);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.Label encabezado1lb;
        private System.Windows.Forms.Label titulolb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaDelClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarCuotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeMorososToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeLibrosBajadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaDeContratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaDeCuotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaDeDonacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoDeInsumosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reciboDeSueldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaDeReciboDeSueldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirReciboDeSueldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeLibrosToolStripMenuItem;
    }
}