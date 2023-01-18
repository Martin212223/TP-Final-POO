namespace WindowsEFDatos
{
    partial class frmAvion
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
            this.gridAviones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdAvion = new System.Windows.Forms.TextBox();
            this.txtDenAvion = new System.Windows.Forms.TextBox();
            this.txtCapAvion = new System.Windows.Forms.TextBox();
            this.comboLineaAerea = new System.Windows.Forms.ComboBox();
            this.btnInsertarAvion = new System.Windows.Forms.Button();
            this.btnEditarAvion = new System.Windows.Forms.Button();
            this.btnBuscarIdAvion = new System.Windows.Forms.Button();
            this.btnEliminarAvion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameLineaAerea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateLineaAerea = new System.Windows.Forms.DateTimePicker();
            this.btnInsertarLinea = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAviones)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAviones
            // 
            this.gridAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAviones.Location = new System.Drawing.Point(280, 6);
            this.gridAviones.Name = "gridAviones";
            this.gridAviones.Size = new System.Drawing.Size(240, 150);
            this.gridAviones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id del Avión:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Denominación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Capacidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Línea Aérea:";
            // 
            // txtIdAvion
            // 
            this.txtIdAvion.Location = new System.Drawing.Point(120, 6);
            this.txtIdAvion.Name = "txtIdAvion";
            this.txtIdAvion.Size = new System.Drawing.Size(121, 20);
            this.txtIdAvion.TabIndex = 5;
            // 
            // txtDenAvion
            // 
            this.txtDenAvion.Location = new System.Drawing.Point(120, 36);
            this.txtDenAvion.Name = "txtDenAvion";
            this.txtDenAvion.Size = new System.Drawing.Size(121, 20);
            this.txtDenAvion.TabIndex = 6;
            // 
            // txtCapAvion
            // 
            this.txtCapAvion.Location = new System.Drawing.Point(120, 66);
            this.txtCapAvion.Name = "txtCapAvion";
            this.txtCapAvion.Size = new System.Drawing.Size(121, 20);
            this.txtCapAvion.TabIndex = 7;
            // 
            // comboLineaAerea
            // 
            this.comboLineaAerea.FormattingEnabled = true;
            this.comboLineaAerea.Location = new System.Drawing.Point(120, 97);
            this.comboLineaAerea.Name = "comboLineaAerea";
            this.comboLineaAerea.Size = new System.Drawing.Size(121, 21);
            this.comboLineaAerea.TabIndex = 8;
            // 
            // btnInsertarAvion
            // 
            this.btnInsertarAvion.Location = new System.Drawing.Point(50, 133);
            this.btnInsertarAvion.Name = "btnInsertarAvion";
            this.btnInsertarAvion.Size = new System.Drawing.Size(86, 23);
            this.btnInsertarAvion.TabIndex = 9;
            this.btnInsertarAvion.Text = "Insertar avión";
            this.btnInsertarAvion.UseVisualStyleBackColor = true;
            this.btnInsertarAvion.Click += new System.EventHandler(this.btnInsertarAvion_Click);
            // 
            // btnEditarAvion
            // 
            this.btnEditarAvion.Location = new System.Drawing.Point(142, 133);
            this.btnEditarAvion.Name = "btnEditarAvion";
            this.btnEditarAvion.Size = new System.Drawing.Size(86, 23);
            this.btnEditarAvion.TabIndex = 10;
            this.btnEditarAvion.Text = "Editar";
            this.btnEditarAvion.UseVisualStyleBackColor = true;
            // 
            // btnBuscarIdAvion
            // 
            this.btnBuscarIdAvion.Location = new System.Drawing.Point(50, 162);
            this.btnBuscarIdAvion.Name = "btnBuscarIdAvion";
            this.btnBuscarIdAvion.Size = new System.Drawing.Size(86, 23);
            this.btnBuscarIdAvion.TabIndex = 11;
            this.btnBuscarIdAvion.Text = "Buscar por Id";
            this.btnBuscarIdAvion.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAvion
            // 
            this.btnEliminarAvion.Location = new System.Drawing.Point(142, 162);
            this.btnEliminarAvion.Name = "btnEliminarAvion";
            this.btnEliminarAvion.Size = new System.Drawing.Size(86, 23);
            this.btnEliminarAvion.TabIndex = 12;
            this.btnEliminarAvion.Text = "Eliminar";
            this.btnEliminarAvion.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre Línea Aérea:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Insertar Línea Aérea:";
            // 
            // txtNameLineaAerea
            // 
            this.txtNameLineaAerea.Location = new System.Drawing.Point(193, 235);
            this.txtNameLineaAerea.Name = "txtNameLineaAerea";
            this.txtNameLineaAerea.Size = new System.Drawing.Size(121, 20);
            this.txtNameLineaAerea.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fecha de Inicio de Actividades:";
            // 
            // dateLineaAerea
            // 
            this.dateLineaAerea.Location = new System.Drawing.Point(193, 281);
            this.dateLineaAerea.Name = "dateLineaAerea";
            this.dateLineaAerea.Size = new System.Drawing.Size(200, 20);
            this.dateLineaAerea.TabIndex = 17;
            // 
            // btnInsertarLinea
            // 
            this.btnInsertarLinea.Location = new System.Drawing.Point(392, 233);
            this.btnInsertarLinea.Name = "btnInsertarLinea";
            this.btnInsertarLinea.Size = new System.Drawing.Size(145, 23);
            this.btnInsertarLinea.TabIndex = 18;
            this.btnInsertarLinea.Text = "Insertar Línea Aérea";
            this.btnInsertarLinea.UseVisualStyleBackColor = true;
            this.btnInsertarLinea.Click += new System.EventHandler(this.btnInsertarLinea_Click);
            // 
            // frmAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 328);
            this.Controls.Add(this.btnInsertarLinea);
            this.Controls.Add(this.dateLineaAerea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNameLineaAerea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminarAvion);
            this.Controls.Add(this.btnBuscarIdAvion);
            this.Controls.Add(this.btnEditarAvion);
            this.Controls.Add(this.btnInsertarAvion);
            this.Controls.Add(this.comboLineaAerea);
            this.Controls.Add(this.txtCapAvion);
            this.Controls.Add(this.txtDenAvion);
            this.Controls.Add(this.txtIdAvion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridAviones);
            this.Name = "frmAvion";
            this.Text = "frmAvion";
            this.Load += new System.EventHandler(this.frmAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAviones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAviones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdAvion;
        private System.Windows.Forms.TextBox txtDenAvion;
        private System.Windows.Forms.TextBox txtCapAvion;
        private System.Windows.Forms.ComboBox comboLineaAerea;
        private System.Windows.Forms.Button btnInsertarAvion;
        private System.Windows.Forms.Button btnEditarAvion;
        private System.Windows.Forms.Button btnBuscarIdAvion;
        private System.Windows.Forms.Button btnEliminarAvion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameLineaAerea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateLineaAerea;
        private System.Windows.Forms.Button btnInsertarLinea;
    }
}

