namespace banka_otomasyonu
{
    partial class GelirGiderRaporu
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
            this.grdRapor = new System.Windows.Forms.DataGridView();
            this.txtBitisSaat = new System.Windows.Forms.DateTimePicker();
            this.txtBaslangicSaat = new System.Windows.Forms.DateTimePicker();
            this.btnListele = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBitisTarih = new System.Windows.Forms.DateTimePicker();
            this.txtBaslangicTarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grdRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRapor
            // 
            this.grdRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRapor.Location = new System.Drawing.Point(11, 51);
            this.grdRapor.Margin = new System.Windows.Forms.Padding(2);
            this.grdRapor.Name = "grdRapor";
            this.grdRapor.ReadOnly = true;
            this.grdRapor.RowHeadersWidth = 51;
            this.grdRapor.RowTemplate.Height = 24;
            this.grdRapor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRapor.Size = new System.Drawing.Size(715, 351);
            this.grdRapor.TabIndex = 26;
            // 
            // txtBitisSaat
            // 
            this.txtBitisSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtBitisSaat.Location = new System.Drawing.Point(415, 18);
            this.txtBitisSaat.Name = "txtBitisSaat";
            this.txtBitisSaat.Size = new System.Drawing.Size(79, 20);
            this.txtBitisSaat.TabIndex = 5;
            // 
            // txtBaslangicSaat
            // 
            this.txtBaslangicSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtBaslangicSaat.Location = new System.Drawing.Point(187, 18);
            this.txtBaslangicSaat.Name = "txtBaslangicSaat";
            this.txtBaslangicSaat.Size = new System.Drawing.Size(79, 20);
            this.txtBaslangicSaat.TabIndex = 3;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Thistle;
            this.btnListele.Location = new System.Drawing.Point(508, 14);
            this.btnListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(119, 28);
            this.btnListele.TabIndex = 6;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(271, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Bitiş:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Başlangıç:";
            // 
            // txtBitisTarih
            // 
            this.txtBitisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBitisTarih.Location = new System.Drawing.Point(314, 18);
            this.txtBitisTarih.Name = "txtBitisTarih";
            this.txtBitisTarih.Size = new System.Drawing.Size(95, 20);
            this.txtBitisTarih.TabIndex = 4;
            // 
            // txtBaslangicTarih
            // 
            this.txtBaslangicTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBaslangicTarih.Location = new System.Drawing.Point(86, 18);
            this.txtBaslangicTarih.Name = "txtBaslangicTarih";
            this.txtBaslangicTarih.Size = new System.Drawing.Size(95, 20);
            this.txtBaslangicTarih.TabIndex = 2;
            // 
            // GelirGiderRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(737, 413);
            this.Controls.Add(this.txtBitisSaat);
            this.Controls.Add(this.txtBaslangicSaat);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBitisTarih);
            this.Controls.Add(this.txtBaslangicTarih);
            this.Controls.Add(this.grdRapor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GelirGiderRaporu";
            this.Text = "Gelir-Gider Raporu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GelirGiderRaporu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdRapor;
        private System.Windows.Forms.DateTimePicker txtBitisSaat;
        private System.Windows.Forms.DateTimePicker txtBaslangicSaat;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtBitisTarih;
        private System.Windows.Forms.DateTimePicker txtBaslangicTarih;
    }
}