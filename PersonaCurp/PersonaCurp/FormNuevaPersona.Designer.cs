namespace PersonaCurp
{
    partial class FormNuevaPersona
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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_ApellidoP = new System.Windows.Forms.Label();
            this.lbl_ApellidoMaterno = new System.Windows.Forms.Label();
            this.lbl_FechaNacimiento = new System.Windows.Forms.Label();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.lbl_EstadoNacimiento = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Municipio = new System.Windows.Forms.Label();
            this.lbl_Colonia = new System.Windows.Forms.Label();
            this.lbl_Calle = new System.Windows.Forms.Label();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.tbox_Numero = new System.Windows.Forms.TextBox();
            this.tbox_Calle = new System.Windows.Forms.TextBox();
            this.tbox_ApellidpM = new System.Windows.Forms.TextBox();
            this.tbox_ApellidP = new System.Windows.Forms.TextBox();
            this.tbox_Nombres = new System.Windows.Forms.TextBox();
            this.tbox_Municipio = new System.Windows.Forms.TextBox();
            this.tbox_Colonia = new System.Windows.Forms.TextBox();
            this.tbox_Telefono = new System.Windows.Forms.TextBox();
            this.dtime_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.cbox_EstadoNacimiento = new System.Windows.Forms.ComboBox();
            this.cbox_Estado = new System.Windows.Forms.ComboBox();
            this.cbox_Sexo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_Nombre.Location = new System.Drawing.Point(45, 31);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(75, 17);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre(s)";
            // 
            // lbl_ApellidoP
            // 
            this.lbl_ApellidoP.AutoSize = true;
            this.lbl_ApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_ApellidoP.Location = new System.Drawing.Point(45, 72);
            this.lbl_ApellidoP.Name = "lbl_ApellidoP";
            this.lbl_ApellidoP.Size = new System.Drawing.Size(112, 17);
            this.lbl_ApellidoP.TabIndex = 1;
            this.lbl_ApellidoP.Text = "Apellido Paterno";
            // 
            // lbl_ApellidoMaterno
            // 
            this.lbl_ApellidoMaterno.AutoSize = true;
            this.lbl_ApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_ApellidoMaterno.Location = new System.Drawing.Point(48, 118);
            this.lbl_ApellidoMaterno.Name = "lbl_ApellidoMaterno";
            this.lbl_ApellidoMaterno.Size = new System.Drawing.Size(114, 17);
            this.lbl_ApellidoMaterno.TabIndex = 2;
            this.lbl_ApellidoMaterno.Text = "Apellido Materno";
            // 
            // lbl_FechaNacimiento
            // 
            this.lbl_FechaNacimiento.AutoSize = true;
            this.lbl_FechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_FechaNacimiento.Location = new System.Drawing.Point(48, 170);
            this.lbl_FechaNacimiento.Name = "lbl_FechaNacimiento";
            this.lbl_FechaNacimiento.Size = new System.Drawing.Size(121, 17);
            this.lbl_FechaNacimiento.TabIndex = 3;
            this.lbl_FechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_Sexo.Location = new System.Drawing.Point(48, 222);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(39, 17);
            this.lbl_Sexo.TabIndex = 4;
            this.lbl_Sexo.Text = "Sexo";
            // 
            // lbl_EstadoNacimiento
            // 
            this.lbl_EstadoNacimiento.AutoSize = true;
            this.lbl_EstadoNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_EstadoNacimiento.Location = new System.Drawing.Point(48, 271);
            this.lbl_EstadoNacimiento.Name = "lbl_EstadoNacimiento";
            this.lbl_EstadoNacimiento.Size = new System.Drawing.Size(146, 17);
            this.lbl_EstadoNacimiento.TabIndex = 5;
            this.lbl_EstadoNacimiento.Text = "Estado de Nacimiento";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_Telefono.Location = new System.Drawing.Point(45, 320);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(64, 17);
            this.lbl_Telefono.TabIndex = 6;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_Estado.Location = new System.Drawing.Point(45, 416);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(52, 17);
            this.lbl_Estado.TabIndex = 7;
            this.lbl_Estado.Text = "Estado";
            // 
            // lbl_Municipio
            // 
            this.lbl_Municipio.AutoSize = true;
            this.lbl_Municipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_Municipio.Location = new System.Drawing.Point(42, 451);
            this.lbl_Municipio.Name = "lbl_Municipio";
            this.lbl_Municipio.Size = new System.Drawing.Size(67, 17);
            this.lbl_Municipio.TabIndex = 8;
            this.lbl_Municipio.Text = "Municipio";
            // 
            // lbl_Colonia
            // 
            this.lbl_Colonia.AutoSize = true;
            this.lbl_Colonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_Colonia.Location = new System.Drawing.Point(48, 487);
            this.lbl_Colonia.Name = "lbl_Colonia";
            this.lbl_Colonia.Size = new System.Drawing.Size(55, 17);
            this.lbl_Colonia.TabIndex = 9;
            this.lbl_Colonia.Text = "Colonia";
            // 
            // lbl_Calle
            // 
            this.lbl_Calle.AutoSize = true;
            this.lbl_Calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_Calle.Location = new System.Drawing.Point(48, 524);
            this.lbl_Calle.Name = "lbl_Calle";
            this.lbl_Calle.Size = new System.Drawing.Size(39, 17);
            this.lbl_Calle.TabIndex = 10;
            this.lbl_Calle.Text = "Calle";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_Numero.Location = new System.Drawing.Point(48, 561);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(58, 17);
            this.lbl_Numero.TabIndex = 11;
            this.lbl_Numero.Text = "Numero";
            // 
            // tbox_Numero
            // 
            this.tbox_Numero.Location = new System.Drawing.Point(200, 561);
            this.tbox_Numero.Name = "tbox_Numero";
            this.tbox_Numero.Size = new System.Drawing.Size(242, 20);
            this.tbox_Numero.TabIndex = 12;
            // 
            // tbox_Calle
            // 
            this.tbox_Calle.Location = new System.Drawing.Point(200, 524);
            this.tbox_Calle.Name = "tbox_Calle";
            this.tbox_Calle.Size = new System.Drawing.Size(242, 20);
            this.tbox_Calle.TabIndex = 13;
            // 
            // tbox_ApellidpM
            // 
            this.tbox_ApellidpM.Location = new System.Drawing.Point(200, 118);
            this.tbox_ApellidpM.Name = "tbox_ApellidpM";
            this.tbox_ApellidpM.Size = new System.Drawing.Size(242, 20);
            this.tbox_ApellidpM.TabIndex = 14;
            // 
            // tbox_ApellidP
            // 
            this.tbox_ApellidP.Location = new System.Drawing.Point(200, 72);
            this.tbox_ApellidP.Name = "tbox_ApellidP";
            this.tbox_ApellidP.Size = new System.Drawing.Size(242, 20);
            this.tbox_ApellidP.TabIndex = 15;
            // 
            // tbox_Nombres
            // 
            this.tbox_Nombres.Location = new System.Drawing.Point(200, 31);
            this.tbox_Nombres.Name = "tbox_Nombres";
            this.tbox_Nombres.Size = new System.Drawing.Size(242, 20);
            this.tbox_Nombres.TabIndex = 16;
            // 
            // tbox_Municipio
            // 
            this.tbox_Municipio.Location = new System.Drawing.Point(200, 451);
            this.tbox_Municipio.Name = "tbox_Municipio";
            this.tbox_Municipio.Size = new System.Drawing.Size(242, 20);
            this.tbox_Municipio.TabIndex = 20;
            // 
            // tbox_Colonia
            // 
            this.tbox_Colonia.Location = new System.Drawing.Point(200, 487);
            this.tbox_Colonia.Name = "tbox_Colonia";
            this.tbox_Colonia.Size = new System.Drawing.Size(242, 20);
            this.tbox_Colonia.TabIndex = 21;
            // 
            // tbox_Telefono
            // 
            this.tbox_Telefono.Location = new System.Drawing.Point(200, 320);
            this.tbox_Telefono.Name = "tbox_Telefono";
            this.tbox_Telefono.Size = new System.Drawing.Size(242, 20);
            this.tbox_Telefono.TabIndex = 22;
            // 
            // dtime_FechaNacimiento
            // 
            this.dtime_FechaNacimiento.Location = new System.Drawing.Point(200, 170);
            this.dtime_FechaNacimiento.Name = "dtime_FechaNacimiento";
            this.dtime_FechaNacimiento.Size = new System.Drawing.Size(242, 20);
            this.dtime_FechaNacimiento.TabIndex = 23;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(385, 604);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 24;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // cbox_EstadoNacimiento
            // 
            this.cbox_EstadoNacimiento.FormattingEnabled = true;
            this.cbox_EstadoNacimiento.Location = new System.Drawing.Point(200, 271);
            this.cbox_EstadoNacimiento.Name = "cbox_EstadoNacimiento";
            this.cbox_EstadoNacimiento.Size = new System.Drawing.Size(242, 21);
            this.cbox_EstadoNacimiento.TabIndex = 25;
            // 
            // cbox_Estado
            // 
            this.cbox_Estado.FormattingEnabled = true;
            this.cbox_Estado.Location = new System.Drawing.Point(200, 413);
            this.cbox_Estado.Name = "cbox_Estado";
            this.cbox_Estado.Size = new System.Drawing.Size(242, 21);
            this.cbox_Estado.TabIndex = 26;
            // 
            // cbox_Sexo
            // 
            this.cbox_Sexo.FormattingEnabled = true;
            this.cbox_Sexo.Location = new System.Drawing.Point(200, 222);
            this.cbox_Sexo.Name = "cbox_Sexo";
            this.cbox_Sexo.Size = new System.Drawing.Size(242, 21);
            this.cbox_Sexo.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(12, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "DATOS DOMICILIO ACTUAL";
            // 
            // FormNuevaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 639);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_Sexo);
            this.Controls.Add(this.cbox_Estado);
            this.Controls.Add(this.cbox_EstadoNacimiento);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.dtime_FechaNacimiento);
            this.Controls.Add(this.tbox_Telefono);
            this.Controls.Add(this.tbox_Colonia);
            this.Controls.Add(this.tbox_Municipio);
            this.Controls.Add(this.tbox_Nombres);
            this.Controls.Add(this.tbox_ApellidP);
            this.Controls.Add(this.tbox_ApellidpM);
            this.Controls.Add(this.tbox_Calle);
            this.Controls.Add(this.tbox_Numero);
            this.Controls.Add(this.lbl_Numero);
            this.Controls.Add(this.lbl_Calle);
            this.Controls.Add(this.lbl_Colonia);
            this.Controls.Add(this.lbl_Municipio);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_EstadoNacimiento);
            this.Controls.Add(this.lbl_Sexo);
            this.Controls.Add(this.lbl_FechaNacimiento);
            this.Controls.Add(this.lbl_ApellidoMaterno);
            this.Controls.Add(this.lbl_ApellidoP);
            this.Controls.Add(this.lbl_Nombre);
            this.Name = "FormNuevaPersona";
            this.Text = "Datos Persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_ApellidoP;
        private System.Windows.Forms.Label lbl_ApellidoMaterno;
        private System.Windows.Forms.Label lbl_FechaNacimiento;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.Label lbl_EstadoNacimiento;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Municipio;
        private System.Windows.Forms.Label lbl_Colonia;
        private System.Windows.Forms.Label lbl_Calle;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.TextBox tbox_Numero;
        private System.Windows.Forms.TextBox tbox_Calle;
        private System.Windows.Forms.TextBox tbox_ApellidpM;
        private System.Windows.Forms.TextBox tbox_ApellidP;
        private System.Windows.Forms.TextBox tbox_Nombres;
        private System.Windows.Forms.TextBox tbox_Municipio;
        private System.Windows.Forms.TextBox tbox_Colonia;
        private System.Windows.Forms.TextBox tbox_Telefono;
        private System.Windows.Forms.DateTimePicker dtime_FechaNacimiento;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.ComboBox cbox_EstadoNacimiento;
        private System.Windows.Forms.ComboBox cbox_Estado;
        private System.Windows.Forms.ComboBox cbox_Sexo;
        private System.Windows.Forms.Label label1;
    }
}