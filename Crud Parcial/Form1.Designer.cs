namespace Crud_Parcial
{
    partial class Form1
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
            this.Numcuenta = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Crear = new System.Windows.Forms.Button();
            this.Tipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NumeroCuentas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BuscarCuenta = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.TipoUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumeroCuentaUpdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NombreUpdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BalanceTotal = new System.Windows.Forms.Label();
            this.ValidarNum = new System.Windows.Forms.Button();
            this.Retiro = new System.Windows.Forms.Button();
            this.Monto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumCuentaTransaccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Deposito = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Numcuenta
            // 
            this.Numcuenta.AutoSize = true;
            this.Numcuenta.Location = new System.Drawing.Point(632, 131);
            this.Numcuenta.Name = "Numcuenta";
            this.Numcuenta.Size = new System.Drawing.Size(35, 13);
            this.Numcuenta.TabIndex = 2;
            this.Numcuenta.Text = "label1";
            this.Numcuenta.Click += new System.EventHandler(this.Numcuenta_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 394);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.Crear);
            this.tabPage1.Controls.Add(this.Tipo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.NombreUsuario);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.NumeroCuentas);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            // 
            // Crear
            // 
            this.Crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Crear.Location = new System.Drawing.Point(128, 276);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(75, 27);
            this.Crear.TabIndex = 22;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // Tipo
            // 
            this.Tipo.Location = new System.Drawing.Point(184, 207);
            this.Tipo.Name = "Tipo";
            this.Tipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tipo.Size = new System.Drawing.Size(107, 20);
            this.Tipo.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 207);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tipo de cuenta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.Location = new System.Drawing.Point(184, 91);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NombreUsuario.Size = new System.Drawing.Size(107, 20);
            this.NombreUsuario.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 89);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nombre Usuario:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumeroCuentas
            // 
            this.NumeroCuentas.Location = new System.Drawing.Point(184, 149);
            this.NumeroCuentas.Name = "NumeroCuentas";
            this.NumeroCuentas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumeroCuentas.Size = new System.Drawing.Size(107, 20);
            this.NumeroCuentas.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 149);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "N°cuenta:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(111, 40);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(92, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Registro";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.BuscarCuenta);
            this.tabPage2.Controls.Add(this.Borrar);
            this.tabPage2.Controls.Add(this.TipoUpdate);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.NumeroCuentaUpdate);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.NombreUpdate);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            // 
            // BuscarCuenta
            // 
            this.BuscarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BuscarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.BuscarCuenta.Location = new System.Drawing.Point(126, 116);
            this.BuscarCuenta.Name = "BuscarCuenta";
            this.BuscarCuenta.Size = new System.Drawing.Size(72, 27);
            this.BuscarCuenta.TabIndex = 31;
            this.BuscarCuenta.Text = "Buscar";
            this.BuscarCuenta.UseVisualStyleBackColor = false;
            this.BuscarCuenta.Click += new System.EventHandler(this.button2_Click);
            // 
            // Borrar
            // 
            this.Borrar.BackColor = System.Drawing.Color.IndianRed;
            this.Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Borrar.Location = new System.Drawing.Point(87, 281);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(79, 27);
            this.Borrar.TabIndex = 30;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = false;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // TipoUpdate
            // 
            this.TipoUpdate.Location = new System.Drawing.Point(183, 236);
            this.TipoUpdate.Name = "TipoUpdate";
            this.TipoUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TipoUpdate.Size = new System.Drawing.Size(107, 20);
            this.TipoUpdate.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 236);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tipo de cuenta:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumeroCuentaUpdate
            // 
            this.NumeroCuentaUpdate.Location = new System.Drawing.Point(143, 90);
            this.NumeroCuentaUpdate.Name = "NumeroCuentaUpdate";
            this.NumeroCuentaUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumeroCuentaUpdate.Size = new System.Drawing.Size(111, 20);
            this.NumeroCuentaUpdate.TabIndex = 27;
            this.NumeroCuentaUpdate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 178);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Nombre Usuario:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NombreUpdate
            // 
            this.NombreUpdate.Location = new System.Drawing.Point(183, 178);
            this.NombreUpdate.Name = "NombreUpdate";
            this.NombreUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NombreUpdate.Size = new System.Drawing.Size(107, 20);
            this.NombreUpdate.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 90);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "N°cuenta:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(75, 30);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(179, 26);
            this.label11.TabIndex = 23;
            this.label11.Text = "Modificar Cuenta";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.BalanceTotal);
            this.tabPage3.Controls.Add(this.ValidarNum);
            this.tabPage3.Controls.Add(this.Retiro);
            this.tabPage3.Controls.Add(this.Monto);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.NumCuentaTransaccion);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.Deposito);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(331, 368);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transacción";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // BalanceTotal
            // 
            this.BalanceTotal.AutoSize = true;
            this.BalanceTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BalanceTotal.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceTotal.Location = new System.Drawing.Point(31, 136);
            this.BalanceTotal.Name = "BalanceTotal";
            this.BalanceTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BalanceTotal.Size = new System.Drawing.Size(64, 20);
            this.BalanceTotal.TabIndex = 11;
            this.BalanceTotal.Text = "Balance";
            this.BalanceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValidarNum
            // 
            this.ValidarNum.BackColor = System.Drawing.Color.CadetBlue;
            this.ValidarNum.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidarNum.Location = new System.Drawing.Point(230, 101);
            this.ValidarNum.Name = "ValidarNum";
            this.ValidarNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ValidarNum.Size = new System.Drawing.Size(74, 33);
            this.ValidarNum.TabIndex = 10;
            this.ValidarNum.Text = "Validar";
            this.ValidarNum.UseVisualStyleBackColor = false;
            this.ValidarNum.Click += new System.EventHandler(this.ValidarNum_Click);
            // 
            // Retiro
            // 
            this.Retiro.BackColor = System.Drawing.Color.IndianRed;
            this.Retiro.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retiro.Location = new System.Drawing.Point(77, 277);
            this.Retiro.Name = "Retiro";
            this.Retiro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Retiro.Size = new System.Drawing.Size(75, 36);
            this.Retiro.TabIndex = 9;
            this.Retiro.Text = "Retiro";
            this.Retiro.UseVisualStyleBackColor = false;
            this.Retiro.Click += new System.EventHandler(this.Retiro_Click);
            // 
            // Monto
            // 
            this.Monto.Location = new System.Drawing.Point(117, 196);
            this.Monto.Name = "Monto";
            this.Monto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Monto.Size = new System.Drawing.Size(107, 20);
            this.Monto.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 194);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Monto:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumCuentaTransaccion
            // 
            this.NumCuentaTransaccion.Location = new System.Drawing.Point(117, 108);
            this.NumCuentaTransaccion.Name = "NumCuentaTransaccion";
            this.NumCuentaTransaccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumCuentaTransaccion.Size = new System.Drawing.Size(107, 20);
            this.NumCuentaTransaccion.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 106);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "N°cuenta:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 31);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transacción";
            // 
            // Deposito
            // 
            this.Deposito.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposito.Location = new System.Drawing.Point(158, 277);
            this.Deposito.Name = "Deposito";
            this.Deposito.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Deposito.Size = new System.Drawing.Size(85, 36);
            this.Deposito.TabIndex = 1;
            this.Deposito.Text = "Depósito";
            this.Deposito.UseVisualStyleBackColor = true;
            this.Deposito.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button2.Location = new System.Drawing.Point(172, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 27);
            this.button2.TabIndex = 32;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 398);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Numcuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Numcuenta;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Deposito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumCuentaTransaccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Retiro;
        private System.Windows.Forms.Button ValidarNum;
        private System.Windows.Forms.Label BalanceTotal;
        private System.Windows.Forms.TextBox NumeroCuentas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NombreUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.TextBox TipoUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumeroCuentaUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NombreUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BuscarCuenta;
        private System.Windows.Forms.Button button2;
    }
}

