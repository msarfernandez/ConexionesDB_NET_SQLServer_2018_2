﻿namespace Presentacion
{
    partial class frmAltaPropiedad
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblSuperficieCubierta = new System.Windows.Forms.Label();
            this.lblSuperficieDescubierta = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtSuperficieCubierta = new System.Windows.Forms.TextBox();
            this.txtSuperficieDescubierta = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptarDos = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(89, 33);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblSuperficieCubierta
            // 
            this.lblSuperficieCubierta.AutoSize = true;
            this.lblSuperficieCubierta.Location = new System.Drawing.Point(56, 68);
            this.lblSuperficieCubierta.Name = "lblSuperficieCubierta";
            this.lblSuperficieCubierta.Size = new System.Drawing.Size(99, 13);
            this.lblSuperficieCubierta.TabIndex = 1;
            this.lblSuperficieCubierta.Text = "Superficie Cubierta:";
            // 
            // lblSuperficieDescubierta
            // 
            this.lblSuperficieDescubierta.AutoSize = true;
            this.lblSuperficieDescubierta.Location = new System.Drawing.Point(38, 103);
            this.lblSuperficieDescubierta.Name = "lblSuperficieDescubierta";
            this.lblSuperficieDescubierta.Size = new System.Drawing.Size(117, 13);
            this.lblSuperficieDescubierta.TabIndex = 2;
            this.lblSuperficieDescubierta.Text = "Superficie Descubierta:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(168, 30);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(237, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtSuperficieCubierta
            // 
            this.txtSuperficieCubierta.Location = new System.Drawing.Point(168, 65);
            this.txtSuperficieCubierta.Name = "txtSuperficieCubierta";
            this.txtSuperficieCubierta.Size = new System.Drawing.Size(237, 20);
            this.txtSuperficieCubierta.TabIndex = 4;
            // 
            // txtSuperficieDescubierta
            // 
            this.txtSuperficieDescubierta.Location = new System.Drawing.Point(168, 100);
            this.txtSuperficieDescubierta.Name = "txtSuperficieDescubierta";
            this.txtSuperficieDescubierta.Size = new System.Drawing.Size(237, 20);
            this.txtSuperficieDescubierta.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(112, 171);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(226, 171);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptarDos
            // 
            this.btnAceptarDos.Location = new System.Drawing.Point(112, 200);
            this.btnAceptarDos.Name = "btnAceptarDos";
            this.btnAceptarDos.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarDos.TabIndex = 8;
            this.btnAceptarDos.Text = "Aceptar 2";
            this.btnAceptarDos.UseVisualStyleBackColor = true;
            this.btnAceptarDos.Click += new System.EventHandler(this.btnAceptarDos_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(168, 132);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(237, 20);
            this.txtDireccion.TabIndex = 10;
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(100, 135);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección:";
            // 
            // frmAltaPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 259);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.btnAceptarDos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtSuperficieDescubierta);
            this.Controls.Add(this.txtSuperficieCubierta);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblSuperficieDescubierta);
            this.Controls.Add(this.lblSuperficieCubierta);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "frmAltaPropiedad";
            this.Text = "frmAltaPropiedad";
            this.Load += new System.EventHandler(this.frmAltaPropiedad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblSuperficieCubierta;
        private System.Windows.Forms.Label lblSuperficieDescubierta;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtSuperficieCubierta;
        private System.Windows.Forms.TextBox txtSuperficieDescubierta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptarDos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
    }
}