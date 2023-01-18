namespace PresentacionVehiculos
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
            this.btnCrearCamion = new System.Windows.Forms.Button();
            this.btnCrearRemolque = new System.Windows.Forms.Button();
            this.btnQuitarRemolque = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearCamion
            // 
            this.btnCrearCamion.Location = new System.Drawing.Point(153, 100);
            this.btnCrearCamion.Name = "btnCrearCamion";
            this.btnCrearCamion.Size = new System.Drawing.Size(126, 23);
            this.btnCrearCamion.TabIndex = 0;
            this.btnCrearCamion.Text = "Crear camión";
            this.btnCrearCamion.UseVisualStyleBackColor = true;
            this.btnCrearCamion.Click += new System.EventHandler(this.btnCrearCamion_Click);
            // 
            // btnCrearRemolque
            // 
            this.btnCrearRemolque.Location = new System.Drawing.Point(153, 154);
            this.btnCrearRemolque.Name = "btnCrearRemolque";
            this.btnCrearRemolque.Size = new System.Drawing.Size(126, 23);
            this.btnCrearRemolque.TabIndex = 1;
            this.btnCrearRemolque.Text = "Crear remolque";
            this.btnCrearRemolque.UseVisualStyleBackColor = true;
            this.btnCrearRemolque.Click += new System.EventHandler(this.btnCrearRemolque_Click);
            // 
            // btnQuitarRemolque
            // 
            this.btnQuitarRemolque.Location = new System.Drawing.Point(153, 207);
            this.btnQuitarRemolque.Name = "btnQuitarRemolque";
            this.btnQuitarRemolque.Size = new System.Drawing.Size(126, 23);
            this.btnQuitarRemolque.TabIndex = 2;
            this.btnQuitarRemolque.Text = "Quitar remolque";
            this.btnQuitarRemolque.UseVisualStyleBackColor = true;
            this.btnQuitarRemolque.Click += new System.EventHandler(this.btnQuitarRemolque_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Crear auto eléctrico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuitarRemolque);
            this.Controls.Add(this.btnCrearRemolque);
            this.Controls.Add(this.btnCrearCamion);
            this.Name = "Form1";
            this.Text = "Presentación Vehículos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCamion;
        private System.Windows.Forms.Button btnCrearRemolque;
        private System.Windows.Forms.Button btnQuitarRemolque;
        private System.Windows.Forms.Button button1;
    }
}

