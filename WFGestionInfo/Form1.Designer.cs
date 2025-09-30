namespace WFGestionInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDatos = new System.Windows.Forms.TabPage();
            this.tpPreferen = new System.Windows.Forms.TabPage();
            this.tpVisual = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.labFecha = new System.Windows.Forms.Label();
            this.ttDescripcion = new System.Windows.Forms.ToolTip(this.components);
            this.timHora = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tpVisual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(713, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gestión Avanzada de Información Personal";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDatos);
            this.tabControl1.Controls.Add(this.tpPreferen);
            this.tabControl1.Controls.Add(this.tpVisual);
            this.tabControl1.Location = new System.Drawing.Point(65, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1263, 482);
            this.tabControl1.TabIndex = 2;
            // 
            // tpDatos
            // 
            this.tpDatos.Location = new System.Drawing.Point(4, 25);
            this.tpDatos.Name = "tpDatos";
            this.tpDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatos.Size = new System.Drawing.Size(1255, 453);
            this.tpDatos.TabIndex = 0;
            this.tpDatos.Text = "Datos Personales";
            this.tpDatos.UseVisualStyleBackColor = true;
            // 
            // tpPreferen
            // 
            this.tpPreferen.Location = new System.Drawing.Point(4, 25);
            this.tpPreferen.Name = "tpPreferen";
            this.tpPreferen.Padding = new System.Windows.Forms.Padding(3);
            this.tpPreferen.Size = new System.Drawing.Size(1255, 453);
            this.tpPreferen.TabIndex = 1;
            this.tpPreferen.Text = "Preferencias";
            this.tpPreferen.UseVisualStyleBackColor = true;
            // 
            // tpVisual
            // 
            this.tpVisual.Controls.Add(this.labFecha);
            this.tpVisual.Controls.Add(this.pbFoto);
            this.tpVisual.Location = new System.Drawing.Point(4, 25);
            this.tpVisual.Name = "tpVisual";
            this.tpVisual.Size = new System.Drawing.Size(1255, 453);
            this.tpVisual.TabIndex = 2;
            this.tpVisual.Text = "Visualización";
            this.tpVisual.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar";
            this.ttDescripcion.SetToolTip(this.button1, "Guardar cambios");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(680, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Limpiar";
            this.ttDescripcion.SetToolTip(this.button2, "Limpiar formulario");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(838, 527);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Salir";
            this.ttDescripcion.SetToolTip(this.button3, "Salir del formulario");
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pbFoto
            // 
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.Location = new System.Drawing.Point(491, 72);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(316, 349);
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            this.ttDescripcion.SetToolTip(this.pbFoto, "Imagen de perfil");
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Location = new System.Drawing.Point(608, 41);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(91, 16);
            this.labFecha.TabIndex = 1;
            this.labFecha.Text = "Fecha y hora: ";
            this.ttDescripcion.SetToolTip(this.labFecha, "Hora actual");
            // 
            // timHora
            // 
            this.timHora.Enabled = true;
            this.timHora.Interval = 1000;
            this.timHora.Tick += new System.EventHandler(this.timHora_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 578);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gestión Avanzada de Información Personal";
            this.tabControl1.ResumeLayout(false);
            this.tpVisual.ResumeLayout(false);
            this.tpVisual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDatos;
        private System.Windows.Forms.TabPage tpPreferen;
        private System.Windows.Forms.TabPage tpVisual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.ToolTip ttDescripcion;
        private System.Windows.Forms.Timer timHora;
    }
}

