
namespace Covid_19_Vaccine_System
{
    partial class Form1
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
            this.button_kayit = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonAsiKaydi = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.tCDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiTuruDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiTarihiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dozSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaccineDataSet5 = new Covid_19_Vaccine_System.VaccineDataSet5();
            this.buttonListele = new System.Windows.Forms.Button();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineTableAdapter = new Covid_19_Vaccine_System.VaccineDataSet5TableAdapters.VaccineTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // button_kayit
            // 
            this.button_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kayit.Location = new System.Drawing.Point(269, 741);
            this.button_kayit.Name = "button_kayit";
            this.button_kayit.Size = new System.Drawing.Size(234, 68);
            this.button_kayit.TabIndex = 0;
            this.button_kayit.Text = "Yeni Kişi Ekle";
            this.button_kayit.UseVisualStyleBackColor = true;
            this.button_kayit.Click += new System.EventHandler(this.button_kayit_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Location = new System.Drawing.Point(549, 741);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(234, 68);
            this.buttonGuncelle.TabIndex = 1;
            this.buttonGuncelle.Text = "Kayıt Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonAsiKaydi
            // 
            this.buttonAsiKaydi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAsiKaydi.Location = new System.Drawing.Point(812, 741);
            this.buttonAsiKaydi.Name = "buttonAsiKaydi";
            this.buttonAsiKaydi.Size = new System.Drawing.Size(234, 68);
            this.buttonAsiKaydi.TabIndex = 2;
            this.buttonAsiKaydi.Text = "Aşı Kaydı";
            this.buttonAsiKaydi.UseVisualStyleBackColor = true;
            this.buttonAsiKaydi.Click += new System.EventHandler(this.buttonAsiKaydi_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tCDataGridViewTextBoxColumn2,
            this.adDataGridViewTextBoxColumn1,
            this.soyadDataGridViewTextBoxColumn1,
            this.yasDataGridViewTextBoxColumn1,
            this.sehirDataGridViewTextBoxColumn1,
            this.asiTuruDataGridViewTextBoxColumn1,
            this.asiTarihiDataGridViewTextBoxColumn1,
            this.dozSayisiDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.vaccineBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(0, 6);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(1327, 682);
            this.dataGrid.TabIndex = 4;
            // 
            // tCDataGridViewTextBoxColumn2
            // 
            this.tCDataGridViewTextBoxColumn2.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn2.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.tCDataGridViewTextBoxColumn2.Name = "tCDataGridViewTextBoxColumn2";
            this.tCDataGridViewTextBoxColumn2.Width = 125;
            // 
            // adDataGridViewTextBoxColumn1
            // 
            this.adDataGridViewTextBoxColumn1.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn1.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn1.Name = "adDataGridViewTextBoxColumn1";
            this.adDataGridViewTextBoxColumn1.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn1
            // 
            this.soyadDataGridViewTextBoxColumn1.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn1.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn1.Name = "soyadDataGridViewTextBoxColumn1";
            this.soyadDataGridViewTextBoxColumn1.Width = 125;
            // 
            // yasDataGridViewTextBoxColumn1
            // 
            this.yasDataGridViewTextBoxColumn1.DataPropertyName = "Yas";
            this.yasDataGridViewTextBoxColumn1.HeaderText = "Yas";
            this.yasDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.yasDataGridViewTextBoxColumn1.Name = "yasDataGridViewTextBoxColumn1";
            this.yasDataGridViewTextBoxColumn1.Width = 125;
            // 
            // sehirDataGridViewTextBoxColumn1
            // 
            this.sehirDataGridViewTextBoxColumn1.DataPropertyName = "Sehir";
            this.sehirDataGridViewTextBoxColumn1.HeaderText = "Sehir";
            this.sehirDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sehirDataGridViewTextBoxColumn1.Name = "sehirDataGridViewTextBoxColumn1";
            this.sehirDataGridViewTextBoxColumn1.Width = 125;
            // 
            // asiTuruDataGridViewTextBoxColumn1
            // 
            this.asiTuruDataGridViewTextBoxColumn1.DataPropertyName = "Asi Turu";
            this.asiTuruDataGridViewTextBoxColumn1.HeaderText = "Asi Turu";
            this.asiTuruDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.asiTuruDataGridViewTextBoxColumn1.Name = "asiTuruDataGridViewTextBoxColumn1";
            this.asiTuruDataGridViewTextBoxColumn1.Width = 125;
            // 
            // asiTarihiDataGridViewTextBoxColumn1
            // 
            this.asiTarihiDataGridViewTextBoxColumn1.DataPropertyName = "Asi Tarihi";
            this.asiTarihiDataGridViewTextBoxColumn1.HeaderText = "Asi Tarihi";
            this.asiTarihiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.asiTarihiDataGridViewTextBoxColumn1.Name = "asiTarihiDataGridViewTextBoxColumn1";
            this.asiTarihiDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dozSayisiDataGridViewTextBoxColumn
            // 
            this.dozSayisiDataGridViewTextBoxColumn.DataPropertyName = "Doz sayisi";
            this.dozSayisiDataGridViewTextBoxColumn.HeaderText = "Doz sayisi";
            this.dozSayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dozSayisiDataGridViewTextBoxColumn.Name = "dozSayisiDataGridViewTextBoxColumn";
            this.dozSayisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // vaccineBindingSource
            // 
            this.vaccineBindingSource.DataMember = "Vaccine";
            this.vaccineBindingSource.DataSource = this.vaccineDataSet5;
            // 
            // vaccineDataSet5
            // 
            this.vaccineDataSet5.DataSetName = "VaccineDataSet5";
            this.vaccineDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonListele
            // 
            this.buttonListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(12, 741);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(234, 68);
            this.buttonListele.TabIndex = 5;
            this.buttonListele.Text = "Listele";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            this.tCDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // yasDataGridViewTextBoxColumn
            // 
            this.yasDataGridViewTextBoxColumn.DataPropertyName = "Yas";
            this.yasDataGridViewTextBoxColumn.HeaderText = "Yas";
            this.yasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yasDataGridViewTextBoxColumn.Name = "yasDataGridViewTextBoxColumn";
            this.yasDataGridViewTextBoxColumn.Width = 125;
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "Sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "Sehir";
            this.sehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            this.sehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // asiTuruDataGridViewTextBoxColumn
            // 
            this.asiTuruDataGridViewTextBoxColumn.DataPropertyName = "Asi Turu";
            this.asiTuruDataGridViewTextBoxColumn.HeaderText = "Asi Turu";
            this.asiTuruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asiTuruDataGridViewTextBoxColumn.Name = "asiTuruDataGridViewTextBoxColumn";
            this.asiTuruDataGridViewTextBoxColumn.Width = 125;
            // 
            // asiTarihiDataGridViewTextBoxColumn
            // 
            this.asiTarihiDataGridViewTextBoxColumn.DataPropertyName = "Asi Tarihi";
            this.asiTarihiDataGridViewTextBoxColumn.HeaderText = "Asi Tarihi";
            this.asiTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asiTarihiDataGridViewTextBoxColumn.Name = "asiTarihiDataGridViewTextBoxColumn";
            this.asiTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tCDataGridViewTextBoxColumn1
            // 
            this.tCDataGridViewTextBoxColumn1.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn1.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tCDataGridViewTextBoxColumn1.Name = "tCDataGridViewTextBoxColumn1";
            this.tCDataGridViewTextBoxColumn1.Width = 125;
            // 
            // vaccineTableAdapter
            // 
            this.vaccineTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(503, 840);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 864);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Silinicek kisi TC:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(232, 859);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 30);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 969);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.buttonAsiKaydi);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.button_kayit);
            this.Name = "Form1";
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_kayit;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonAsiKaydi;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn1;
        private VaccineDataSet5 vaccineDataSet5;
        private System.Windows.Forms.BindingSource vaccineBindingSource;
        private VaccineDataSet5TableAdapters.VaccineTableAdapter vaccineTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiTuruDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiTarihiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dozSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

