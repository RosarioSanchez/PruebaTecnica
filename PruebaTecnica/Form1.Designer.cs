using System;

namespace PruebaTecnica
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
            this.nombre = new System.Windows.Forms.Label();
            this.AP_Paterno = new System.Windows.Forms.Label();
            this.AP_Materno = new System.Windows.Forms.Label();
            this.FechaNac = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.Label();
            this.Lugar_Nac = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFechaNac = new System.Windows.Forms.TextBox();
            this.txtAMaterno = new System.Windows.Forms.TextBox();
            this.txtAPaterno = new System.Windows.Forms.TextBox();
            this.curp = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.ciudad = new System.Windows.Forms.Label();
            this.municipio = new System.Windows.Forms.Label();
            this.colonia = new System.Windows.Forms.Label();
            this.calle = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.c_postal = new System.Windows.Forms.Label();
            this.txtC_postal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLugarNac = new System.Windows.Forms.ComboBox();
            this.cdFechaNac = new System.Windows.Forms.MonthCalendar();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(33, 34);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(57, 13);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "NOMBRE:";
            // 
            // AP_Paterno
            // 
            this.AP_Paterno.AutoSize = true;
            this.AP_Paterno.Location = new System.Drawing.Point(223, 34);
            this.AP_Paterno.Name = "AP_Paterno";
            this.AP_Paterno.Size = new System.Drawing.Size(117, 13);
            this.AP_Paterno.TabIndex = 1;
            this.AP_Paterno.Text = "APELLIDO PATERNO:";
            // 
            // AP_Materno
            // 
            this.AP_Materno.AutoSize = true;
            this.AP_Materno.Location = new System.Drawing.Point(484, 37);
            this.AP_Materno.Name = "AP_Materno";
            this.AP_Materno.Size = new System.Drawing.Size(119, 13);
            this.AP_Materno.TabIndex = 2;
            this.AP_Materno.Text = "APELLIDO MATERNO:";
            // 
            // FechaNac
            // 
            this.FechaNac.AutoSize = true;
            this.FechaNac.Location = new System.Drawing.Point(33, 73);
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.Size = new System.Drawing.Size(133, 13);
            this.FechaNac.TabIndex = 3;
            this.FechaNac.Text = "FECHA DE NACIMIENTO:";
            // 
            // Sexo
            // 
            this.Sexo.AutoSize = true;
            this.Sexo.Location = new System.Drawing.Point(284, 76);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(39, 13);
            this.Sexo.TabIndex = 4;
            this.Sexo.Text = "SEXO:";
            // 
            // Lugar_Nac
            // 
            this.Lugar_Nac.AutoSize = true;
            this.Lugar_Nac.Location = new System.Drawing.Point(468, 73);
            this.Lugar_Nac.Name = "Lugar_Nac";
            this.Lugar_Nac.Size = new System.Drawing.Size(135, 13);
            this.Lugar_Nac.TabIndex = 5;
            this.Lugar_Nac.Text = "LUGAR DE NACIMIENTO:";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(96, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarLetras);
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(172, 73);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNac.TabIndex = 7;
            this.txtFechaNac.Click += new System.EventHandler(this.txtFechaNac_TextChanged);
            // 
            // txtAMaterno
            // 
            this.txtAMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAMaterno.Location = new System.Drawing.Point(609, 37);
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.Size = new System.Drawing.Size(117, 20);
            this.txtAMaterno.TabIndex = 8;
            this.txtAMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarLetras);
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAPaterno.Location = new System.Drawing.Point(364, 31);
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.Size = new System.Drawing.Size(114, 20);
            this.txtAPaterno.TabIndex = 9;
            this.txtAPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarLetras);
            // 
            // curp
            // 
            this.curp.AutoSize = true;
            this.curp.Location = new System.Drawing.Point(126, 111);
            this.curp.Name = "curp";
            this.curp.Size = new System.Drawing.Size(40, 13);
            this.curp.TabIndex = 12;
            this.curp.Text = "CURP:";
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(190, 108);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(179, 20);
            this.txtCurp.TabIndex = 13;
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(284, 159);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(111, 13);
            this.Direccion.TabIndex = 14;
            this.Direccion.Text = "DIRECCIÓN ACTUAL";
            // 
            // ciudad
            // 
            this.ciudad.AutoSize = true;
            this.ciudad.Location = new System.Drawing.Point(499, 188);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(54, 13);
            this.ciudad.TabIndex = 15;
            this.ciudad.Text = "ESTADO:";
            // 
            // municipio
            // 
            this.municipio.AutoSize = true;
            this.municipio.Location = new System.Drawing.Point(24, 236);
            this.municipio.Name = "municipio";
            this.municipio.Size = new System.Drawing.Size(66, 13);
            this.municipio.TabIndex = 17;
            this.municipio.Text = "MUNICIPIO:";
            // 
            // colonia
            // 
            this.colonia.AutoSize = true;
            this.colonia.Location = new System.Drawing.Point(223, 236);
            this.colonia.Name = "colonia";
            this.colonia.Size = new System.Drawing.Size(57, 13);
            this.colonia.TabIndex = 19;
            this.colonia.Text = "COLONIA:";
            // 
            // calle
            // 
            this.calle.AutoSize = true;
            this.calle.Location = new System.Drawing.Point(410, 236);
            this.calle.Name = "calle";
            this.calle.Size = new System.Drawing.Size(43, 13);
            this.calle.TabIndex = 21;
            this.calle.Text = "CALLE:";
            // 
            // txtCalle
            // 
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Location = new System.Drawing.Point(459, 233);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(125, 20);
            this.txtCalle.TabIndex = 22;
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Location = new System.Drawing.Point(590, 236);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(58, 13);
            this.Numero.TabIndex = 23;
            this.Numero.Text = "NUMERO:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(320, 325);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(654, 233);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 25;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(329, 70);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 26;
            this.cmbSexo.Text = "SELECCIONAR";
            // 
            // c_postal
            // 
            this.c_postal.AutoSize = true;
            this.c_postal.Location = new System.Drawing.Point(33, 188);
            this.c_postal.Name = "c_postal";
            this.c_postal.Size = new System.Drawing.Size(30, 13);
            this.c_postal.TabIndex = 30;
            this.c_postal.Text = "C. P.";
            // 
            // txtC_postal
            // 
            this.txtC_postal.Location = new System.Drawing.Point(66, 184);
            this.txtC_postal.Name = "txtC_postal";
            this.txtC_postal.Size = new System.Drawing.Size(100, 20);
            this.txtC_postal.TabIndex = 31;
            this.txtC_postal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeros);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "PAIS:";
            // 
            // cmbLugarNac
            // 
            this.cmbLugarNac.FormattingEnabled = true;
            this.cmbLugarNac.Location = new System.Drawing.Point(609, 70);
            this.cmbLugarNac.Name = "cmbLugarNac";
            this.cmbLugarNac.Size = new System.Drawing.Size(145, 21);
            this.cmbLugarNac.TabIndex = 34;
            this.cmbLugarNac.Text = "SELECCIONAR";
            this.cmbLugarNac.SelectedIndexChanged += new System.EventHandler(this.cmbLugarNac_Selected);
            // 
            // cdFechaNac
            // 
            this.cdFechaNac.Location = new System.Drawing.Point(172, 98);
            this.cdFechaNac.MaxDate = new System.DateTime(2019, 2, 9, 22, 57, 50, 672);
            this.cdFechaNac.Name = "cdFechaNac";
            this.cdFechaNac.TabIndex = 35;
            this.cdFechaNac.Visible = false;
            this.cdFechaNac.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cdFechaNac_Selected);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Location = new System.Drawing.Point(172, 183);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 23);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(559, 186);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(152, 20);
            this.txtEstado.TabIndex = 37;
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarLetras);
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMunicipio.Location = new System.Drawing.Point(96, 233);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(121, 20);
            this.txtMunicipio.TabIndex = 38;
            this.txtMunicipio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarLetras);
            // 
            // txtColonia
            // 
            this.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColonia.Location = new System.Drawing.Point(287, 233);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(117, 20);
            this.txtColonia.TabIndex = 39;
            this.txtColonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarLetras);
            // 
            // txtPais
            // 
            this.txtPais.Enabled = false;
            this.txtPais.Location = new System.Drawing.Point(364, 184);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 40;
            this.txtPais.Text = "MEXICO";
            // 
            // telefono
            // 
            this.telefono.AutoSize = true;
            this.telefono.Location = new System.Drawing.Point(410, 111);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(67, 13);
            this.telefono.TabIndex = 41;
            this.telefono.Text = "TELEFONO:";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(483, 111);
            this.txtContacto.MaxLength = 10;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(141, 20);
            this.txtContacto.TabIndex = 42;
            this.txtContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeros);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(413, 325);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 398);
            this.Controls.Add(this.cdFechaNac);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbLugarNac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtC_postal);
            this.Controls.Add(this.c_postal);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.calle);
            this.Controls.Add(this.colonia);
            this.Controls.Add(this.municipio);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.curp);
            this.Controls.Add(this.txtAPaterno);
            this.Controls.Add(this.txtAMaterno);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Lugar_Nac);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.FechaNac);
            this.Controls.Add(this.AP_Materno);
            this.Controls.Add(this.AP_Paterno);
            this.Controls.Add(this.nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "REGISTRO DE DATOS PERSONALES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label AP_Paterno;
        private System.Windows.Forms.Label AP_Materno;
        private System.Windows.Forms.Label FechaNac;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.Label Lugar_Nac;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFechaNac;
        private System.Windows.Forms.TextBox txtAMaterno;
        private System.Windows.Forms.TextBox txtAPaterno;
        private System.Windows.Forms.Label curp;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label ciudad;
        private System.Windows.Forms.Label municipio;
        private System.Windows.Forms.Label colonia;
        private System.Windows.Forms.Label calle;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label c_postal;
        private System.Windows.Forms.TextBox txtC_postal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLugarNac;
        private System.Windows.Forms.MonthCalendar cdFechaNac;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Button btnCancelar;
    }
}

