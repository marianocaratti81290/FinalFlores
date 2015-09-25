namespace Biblioteca
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnacceder = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnUsuarioNuevo = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(271, 399);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 23;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnacceder
            // 
            this.btnacceder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnacceder.Location = new System.Drawing.Point(125, 399);
            this.btnacceder.Name = "btnacceder";
            this.btnacceder.Size = new System.Drawing.Size(75, 23);
            this.btnacceder.TabIndex = 22;
            this.btnacceder.Text = "Aceptar";
            this.btnacceder.UseVisualStyleBackColor = true;
            this.btnacceder.Click += new System.EventHandler(this.btnacceder_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(87, 347);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 16);
            this.Label5.TabIndex = 30;
            this.Label5.Text = "Password";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(100, 294);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(55, 16);
            this.Label4.TabIndex = 29;
            this.Label4.Text = "Usuario";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(172, 343);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(150, 20);
            this.txtpass.TabIndex = 21;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtusuario
            // 
            this.txtusuario.AcceptsTab = true;
            this.txtusuario.Location = new System.Drawing.Point(172, 294);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(150, 20);
            this.txtusuario.TabIndex = 20;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(53, 253);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(322, 13);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "Ingrese el nombre de usuario y contraseña para acceder al sistema";
            // 
            // btnUsuarioNuevo
            // 
            this.btnUsuarioNuevo.Location = new System.Drawing.Point(291, 5);
            this.btnUsuarioNuevo.Name = "btnUsuarioNuevo";
            this.btnUsuarioNuevo.Size = new System.Drawing.Size(111, 23);
            this.btnUsuarioNuevo.TabIndex = 27;
            this.btnUsuarioNuevo.Text = "Crear Usuario";
            this.btnUsuarioNuevo.UseVisualStyleBackColor = true;
            this.btnUsuarioNuevo.Click += new System.EventHandler(this.btnUsuarioNuevo_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Label2.Location = new System.Drawing.Point(132, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(148, 24);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "BIENVENIDOS";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(25, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(260, 13);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "La conexion con la base de datos es exitosa";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(151, 105);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(102, 134);
            this.PictureBox1.TabIndex = 24;
            this.PictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 468);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnacceder);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btnUsuarioNuevo);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox1);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btncancelar;
        internal System.Windows.Forms.Button btnacceder;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtpass;
        internal System.Windows.Forms.TextBox txtusuario;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnUsuarioNuevo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox1;
    }
}

