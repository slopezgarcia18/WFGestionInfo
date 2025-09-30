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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpDatos = new System.Windows.Forms.TabPage();
            this.tpPreferen = new System.Windows.Forms.TabPage();
            this.tpVisual = new System.Windows.Forms.TabPage();
<<<<<<< HEAD
            this.btGuardar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.mcCalendar = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.panel.SuspendLayout();
=======
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.clbListaHobbies = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpPreferen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
>>>>>>> feature/preferencias
=======
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.labFecha = new System.Windows.Forms.Label();
            this.ttDescripcion = new System.Windows.Forms.ToolTip(this.components);
            this.timHora = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tpVisual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
>>>>>>> feature/visualizacion
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gestión Avanzada de Información Personal";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpDatos);
            this.tabControl.Controls.Add(this.tpPreferen);
            this.tabControl.Controls.Add(this.tpVisual);
            this.tabControl.Location = new System.Drawing.Point(65, 38);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1263, 482);
            this.tabControl.TabIndex = 2;
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.txtCorreo);
            this.tpDatos.Controls.Add(this.txtDireccion);
            this.tpDatos.Controls.Add(this.txtNombre);
            this.tpDatos.Controls.Add(this.panel);
            this.tpDatos.Controls.Add(this.label8);
            this.tpDatos.Controls.Add(this.nudEdad);
            this.tpDatos.Controls.Add(this.label7);
            this.tpDatos.Controls.Add(this.mcCalendar);
            this.tpDatos.Controls.Add(this.label6);
            this.tpDatos.Controls.Add(this.label5);
            this.tpDatos.Controls.Add(this.label4);
            this.tpDatos.Controls.Add(this.label3);
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
            this.tpPreferen.Controls.Add(this.label5);
            this.tpPreferen.Controls.Add(this.trackBar1);
            this.tpPreferen.Controls.Add(this.label4);
            this.tpPreferen.Controls.Add(this.comboBox1);
            this.tpPreferen.Controls.Add(this.label3);
            this.tpPreferen.Controls.Add(this.clbListaHobbies);
            this.tpPreferen.Controls.Add(this.checkBox1);
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
            // btGuardar
            // 
<<<<<<< HEAD
            this.btGuardar.Location = new System.Drawing.Point(519, 527);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 3;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
=======
            this.button1.Location = new System.Drawing.Point(519, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar";
            this.ttDescripcion.SetToolTip(this.button1, "Guardar cambios");
            this.button1.UseVisualStyleBackColor = true;
>>>>>>> feature/visualizacion
            // 
            // btLimpiar
            // 
<<<<<<< HEAD
            this.btLimpiar.Location = new System.Drawing.Point(680, 527);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 4;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
=======
            this.button2.Location = new System.Drawing.Point(680, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Limpiar";
            this.ttDescripcion.SetToolTip(this.button2, "Limpiar formulario");
            this.button2.UseVisualStyleBackColor = true;
>>>>>>> feature/visualizacion
            // 
            // btSalir
            // 
<<<<<<< HEAD
            this.btSalir.Location = new System.Drawing.Point(838, 527);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dirección: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(821, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Correo electrónico: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sexo: ";
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Location = new System.Drawing.Point(22, 3);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(89, 20);
            this.rbMasc.TabIndex = 4;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(23, 29);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(88, 20);
            this.rbFem.TabIndex = 5;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Femenino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(23, 55);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(53, 20);
            this.rbOtro.TabIndex = 6;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            // 
            // mcCalendar
            // 
            this.mcCalendar.Location = new System.Drawing.Point(548, 147);
            this.mcCalendar.Name = "mcCalendar";
            this.mcCalendar.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(588, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha Nacimiento:";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(1010, 117);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 22);
            this.nudEdad.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(930, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Edad: ";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.rbMasc);
            this.panel.Controls.Add(this.rbFem);
            this.panel.Controls.Add(this.rbOtro);
            this.panel.Location = new System.Drawing.Point(305, 119);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(144, 85);
            this.panel.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(216, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 22);
            this.txtNombre.TabIndex = 12;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(532, 50);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(264, 22);
            this.txtDireccion.TabIndex = 13;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(964, 50);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(254, 22);
            this.txtCorreo.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(611, 386);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "¿Suscribirse al boletín?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // clbListaHobbies
            // 
            this.clbListaHobbies.FormattingEnabled = true;
            this.clbListaHobbies.Items.AddRange(new object[] {
            "Pintar",
            "Cantar",
            "Senderismo ",
            "Pescar",
            "Programar",
            "Ajedrez",
            "Artes marciales",
            "Gym"});
            this.clbListaHobbies.Location = new System.Drawing.Point(342, 66);
            this.clbListaHobbies.Name = "clbListaHobbies";
            this.clbListaHobbies.Size = new System.Drawing.Size(239, 123);
            this.clbListaHobbies.TabIndex = 1;
            this.clbListaHobbies.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hobbies";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Noruega",
            "España",
            "Alemania",
            "Italia",
            "Paises Bajos",
            "Francia",
            "Bélgica",
            "Suiza",
            "Letonia",
            "Brasil"});
            this.comboBox1.Location = new System.Drawing.Point(750, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(747, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pais de residencia: ";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(601, 279);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(199, 56);
            this.trackBar1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(598, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valoración del servicio";
=======
            this.button3.Location = new System.Drawing.Point(838, 527);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Salir";
            this.ttDescripcion.SetToolTip(this.button3, "Salir del formulario");
            this.button3.UseVisualStyleBackColor = true;
>>>>>>> feature/visualizacion
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
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gestión Avanzada de Información Personal";
<<<<<<< HEAD
            this.tabControl.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            this.tpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
=======
            this.tabControl1.ResumeLayout(false);
<<<<<<< HEAD
            this.tpPreferen.ResumeLayout(false);
            this.tpPreferen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
>>>>>>> feature/preferencias
=======
            this.tpVisual.ResumeLayout(false);
            this.tpVisual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
>>>>>>> feature/visualizacion
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpDatos;
        private System.Windows.Forms.TabPage tpPreferen;
        private System.Windows.Forms.TabPage tpVisual;
<<<<<<< HEAD
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar mcCalendar;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
=======
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
<<<<<<< HEAD
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckedListBox clbListaHobbies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
>>>>>>> feature/preferencias
=======
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.ToolTip ttDescripcion;
        private System.Windows.Forms.Timer timHora;
>>>>>>> feature/visualizacion
    }
}

