namespace Presentacion
{
    partial class frmAmbientes
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
            this.dgvAmbientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmbientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAmbientes
            // 
            this.dgvAmbientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmbientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAmbientes.Location = new System.Drawing.Point(12, 57);
            this.dgvAmbientes.MultiSelect = false;
            this.dgvAmbientes.Name = "dgvAmbientes";
            this.dgvAmbientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAmbientes.Size = new System.Drawing.Size(343, 150);
            this.dgvAmbientes.TabIndex = 0;
            // 
            // frmAmbientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 243);
            this.Controls.Add(this.dgvAmbientes);
            this.Name = "frmAmbientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ambientes";
            this.Load += new System.EventHandler(this.frmAmbientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmbientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAmbientes;
    }
}