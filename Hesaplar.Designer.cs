
namespace banka_otomasyonu
{
    partial class Hesaplar
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grdHesaplar = new System.Windows.Forms.DataGridView();
            this.lblBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHesaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHesaplar
            // 
            this.grdHesaplar.AllowUserToAddRows = false;
            this.grdHesaplar.AllowUserToDeleteRows = false;
            this.grdHesaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHesaplar.Location = new System.Drawing.Point(12, 28);
            this.grdHesaplar.Name = "grdHesaplar";
            this.grdHesaplar.ReadOnly = true;
            this.grdHesaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHesaplar.Size = new System.Drawing.Size(576, 326);
            this.grdHesaplar.TabIndex = 0;
            this.grdHesaplar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdHesaplar_CellDoubleClick);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(12, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(45, 13);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "lblBaslik";
            // 
            // Hesaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.grdHesaplar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hesaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesaplar";
            this.Load += new System.EventHandler(this.Hesaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHesaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView grdHesaplar;
        public System.Windows.Forms.Label lblBaslik;
    }
}