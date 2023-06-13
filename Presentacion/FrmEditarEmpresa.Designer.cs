﻿namespace Presentacion
{
    partial class FrmEditarEmpresa
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
            this.MTxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId_Empresa = new System.Windows.Forms.TextBox();
            this.TxtExaminar = new System.Windows.Forms.TextBox();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.BtnBuscarLogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Location = new System.Drawing.Point(696, 230);
            // 
            // MTxtTelefono
            // 
            this.MTxtTelefono.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MTxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtTelefono.Location = new System.Drawing.Point(39, 178);
            this.MTxtTelefono.Mask = "000-000-0000";
            this.MTxtTelefono.Name = "MTxtTelefono";
            this.MTxtTelefono.Size = new System.Drawing.Size(223, 27);
            this.MTxtTelefono.TabIndex = 52;
            this.MTxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTxtTelefono_KeyPress);
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(345, 111);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(274, 25);
            this.TxtEmail.TabIndex = 51;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.BackColor = System.Drawing.Color.Azure;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(566, 229);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(120, 30);
            this.BtnEditar.TabIndex = 50;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Email Del Empresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Telefono:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(39, 111);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(295, 25);
            this.TxtDireccion.TabIndex = 47;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Direccion Del Empresa:";
            // 
            // TxtNit
            // 
            this.TxtNit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNit.Location = new System.Drawing.Point(345, 49);
            this.TxtNit.Multiline = true;
            this.TxtNit.Name = "TxtNit";
            this.TxtNit.Size = new System.Drawing.Size(274, 25);
            this.TxtNit.TabIndex = 45;
            this.TxtNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNit_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Nit Del Empresa:";
            // 
            // TxtNombreEmpresa
            // 
            this.TxtNombreEmpresa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreEmpresa.Location = new System.Drawing.Point(39, 49);
            this.TxtNombreEmpresa.Multiline = true;
            this.TxtNombreEmpresa.Name = "TxtNombreEmpresa";
            this.TxtNombreEmpresa.Size = new System.Drawing.Size(295, 25);
            this.TxtNombreEmpresa.TabIndex = 42;
            this.TxtNombreEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreEmpresa_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre Empresa:";
            // 
            // TxtId_Empresa
            // 
            this.TxtId_Empresa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtId_Empresa.Enabled = false;
            this.TxtId_Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId_Empresa.Location = new System.Drawing.Point(300, 18);
            this.TxtId_Empresa.Multiline = true;
            this.TxtId_Empresa.Name = "TxtId_Empresa";
            this.TxtId_Empresa.Size = new System.Drawing.Size(34, 25);
            this.TxtId_Empresa.TabIndex = 53;
            this.TxtId_Empresa.Visible = false;
            // 
            // TxtExaminar
            // 
            this.TxtExaminar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TxtExaminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExaminar.Location = new System.Drawing.Point(780, 168);
            this.TxtExaminar.Multiline = true;
            this.TxtExaminar.Name = "TxtExaminar";
            this.TxtExaminar.Size = new System.Drawing.Size(36, 25);
            this.TxtExaminar.TabIndex = 56;
            this.TxtExaminar.Visible = false;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::Presentacion.Properties.Resources.icono_bulding;
            this.ptbLogo.InitialImage = null;
            this.ptbLogo.Location = new System.Drawing.Point(649, 18);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(167, 144);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 55;
            this.ptbLogo.TabStop = false;
            // 
            // BtnBuscarLogo
            // 
            this.BtnBuscarLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarLogo.BackColor = System.Drawing.Color.Azure;
            this.BtnBuscarLogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscarLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarLogo.Location = new System.Drawing.Point(705, 168);
            this.BtnBuscarLogo.Name = "BtnBuscarLogo";
            this.BtnBuscarLogo.Size = new System.Drawing.Size(69, 30);
            this.BtnBuscarLogo.TabIndex = 54;
            this.BtnBuscarLogo.Text = "Logo";
            this.BtnBuscarLogo.UseVisualStyleBackColor = false;
            this.BtnBuscarLogo.Click += new System.EventHandler(this.BtnBuscarLogo_Click);
            // 
            // FrmEditarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 275);
            this.Controls.Add(this.TxtExaminar);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.BtnBuscarLogo);
            this.Controls.Add(this.TxtId_Empresa);
            this.Controls.Add(this.MTxtTelefono);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombreEmpresa);
            this.Controls.Add(this.label2);
            this.Name = "FrmEditarEmpresa";
            this.Text = "Editar Empresa";
            this.Load += new System.EventHandler(this.FrmEditarEmpresa_Load);
            this.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtNombreEmpresa, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtNit, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.TxtDireccion, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.BtnEditar, 0);
            this.Controls.SetChildIndex(this.TxtEmail, 0);
            this.Controls.SetChildIndex(this.MTxtTelefono, 0);
            this.Controls.SetChildIndex(this.TxtId_Empresa, 0);
            this.Controls.SetChildIndex(this.BtnBuscarLogo, 0);
            this.Controls.SetChildIndex(this.ptbLogo, 0);
            this.Controls.SetChildIndex(this.TxtExaminar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox MTxtTelefono;
        public System.Windows.Forms.TextBox TxtEmail;
        public System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtNit;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtNombreEmpresa;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtId_Empresa;
        public System.Windows.Forms.TextBox TxtExaminar;
        public System.Windows.Forms.Button BtnBuscarLogo;
        public System.Windows.Forms.PictureBox ptbLogo;
    }
}