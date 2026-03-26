namespace pryRossiLabII
{
    partial class frmVector
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
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.brnCargar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbListar = new System.Windows.Forms.GroupBox();
            this.btnWhile = new System.Windows.Forms.Button();
            this.lstPersonas = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.grbDatos.SuspendLayout();
            this.grbListar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.brnCargar);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.lblNombre);
            this.grbDatos.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatos.Location = new System.Drawing.Point(12, 25);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(302, 142);
            this.grbDatos.TabIndex = 0;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Carga de Datos";
            // 
            // brnCargar
            // 
            this.brnCargar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnCargar.Location = new System.Drawing.Point(194, 82);
            this.brnCargar.Name = "brnCargar";
            this.brnCargar.Size = new System.Drawing.Size(93, 28);
            this.brnCargar.TabIndex = 2;
            this.brnCargar.Text = "Cargar";
            this.brnCargar.UseVisualStyleBackColor = true;
            this.brnCargar.Click += new System.EventHandler(this.brnCargar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre y Apellido:";
            // 
            // grbListar
            // 
            this.grbListar.Controls.Add(this.btnFor);
            this.grbListar.Controls.Add(this.lstPersonas);
            this.grbListar.Controls.Add(this.btnWhile);
            this.grbListar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListar.Location = new System.Drawing.Point(12, 186);
            this.grbListar.Name = "grbListar";
            this.grbListar.Size = new System.Drawing.Size(302, 235);
            this.grbListar.TabIndex = 3;
            this.grbListar.TabStop = false;
            this.grbListar.Text = "Listado de Datos";
            // 
            // btnWhile
            // 
            this.btnWhile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhile.Location = new System.Drawing.Point(173, 165);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(93, 51);
            this.btnWhile.TabIndex = 2;
            this.btnWhile.Text = "Listar con While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // lstPersonas
            // 
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.ItemHeight = 16;
            this.lstPersonas.Location = new System.Drawing.Point(49, 33);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(214, 116);
            this.lstPersonas.TabIndex = 3;
            // 
            // btnFor
            // 
            this.btnFor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFor.Location = new System.Drawing.Point(49, 165);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(93, 51);
            this.btnFor.TabIndex = 4;
            this.btnFor.Text = "Listar con For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // frmVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.grbListar);
            this.Controls.Add(this.grbDatos);
            this.Name = "frmVector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vectores";
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbListar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button brnCargar;
        private System.Windows.Forms.GroupBox grbListar;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.ListBox lstPersonas;
        private System.Windows.Forms.Button btnWhile;
    }
}

