namespace circustrein
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxGrootte = new System.Windows.Forms.ComboBox();
            this.lblGrootte = new System.Windows.Forms.Label();
            this.lblSoortEter = new System.Windows.Forms.Label();
            this.comboBoxSoortEter = new System.Windows.Forms.ComboBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.listBoxLijstDieren = new System.Windows.Forms.ListBox();
            this.lblLijstVanDieren = new System.Windows.Forms.Label();
            this.dataGridViewWagon = new System.Windows.Forms.DataGridView();
            this.grpBoxTrein = new System.Windows.Forms.GroupBox();
            this.WagonNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grootte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerdelen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWagon)).BeginInit();
            this.grpBoxTrein.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnToevoegen);
            this.groupBox1.Controls.Add(this.lblSoortEter);
            this.groupBox1.Controls.Add(this.comboBoxSoortEter);
            this.groupBox1.Controls.Add(this.lblGrootte);
            this.groupBox1.Controls.Add(this.comboBoxGrootte);
            this.groupBox1.Location = new System.Drawing.Point(23, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dier";
            // 
            // comboBoxGrootte
            // 
            this.comboBoxGrootte.FormattingEnabled = true;
            this.comboBoxGrootte.Location = new System.Drawing.Point(83, 69);
            this.comboBoxGrootte.Name = "comboBoxGrootte";
            this.comboBoxGrootte.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGrootte.TabIndex = 1;
            // 
            // lblGrootte
            // 
            this.lblGrootte.AutoSize = true;
            this.lblGrootte.Location = new System.Drawing.Point(6, 72);
            this.lblGrootte.Name = "lblGrootte";
            this.lblGrootte.Size = new System.Drawing.Size(56, 17);
            this.lblGrootte.TabIndex = 2;
            this.lblGrootte.Text = "Grootte";
            // 
            // lblSoortEter
            // 
            this.lblSoortEter.AutoSize = true;
            this.lblSoortEter.Location = new System.Drawing.Point(6, 31);
            this.lblSoortEter.Name = "lblSoortEter";
            this.lblSoortEter.Size = new System.Drawing.Size(71, 17);
            this.lblSoortEter.TabIndex = 4;
            this.lblSoortEter.Text = "Soort eter";
            // 
            // comboBoxSoortEter
            // 
            this.comboBoxSoortEter.FormattingEnabled = true;
            this.comboBoxSoortEter.Location = new System.Drawing.Point(83, 28);
            this.comboBoxSoortEter.Name = "comboBoxSoortEter";
            this.comboBoxSoortEter.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSoortEter.TabIndex = 3;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(51, 110);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(121, 34);
            this.btnToevoegen.TabIndex = 1;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // listBoxLijstDieren
            // 
            this.listBoxLijstDieren.FormattingEnabled = true;
            this.listBoxLijstDieren.ItemHeight = 16;
            this.listBoxLijstDieren.Location = new System.Drawing.Point(23, 238);
            this.listBoxLijstDieren.Name = "listBoxLijstDieren";
            this.listBoxLijstDieren.Size = new System.Drawing.Size(282, 244);
            this.listBoxLijstDieren.TabIndex = 1;
            // 
            // lblLijstVanDieren
            // 
            this.lblLijstVanDieren.AutoSize = true;
            this.lblLijstVanDieren.Location = new System.Drawing.Point(20, 218);
            this.lblLijstVanDieren.Name = "lblLijstVanDieren";
            this.lblLijstVanDieren.Size = new System.Drawing.Size(104, 17);
            this.lblLijstVanDieren.TabIndex = 3;
            this.lblLijstVanDieren.Text = "Lijst van dieren";
            // 
            // dataGridViewWagon
            // 
            this.dataGridViewWagon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWagon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WagonNummer,
            this.Soort,
            this.Grootte});
            this.dataGridViewWagon.Location = new System.Drawing.Point(27, 42);
            this.dataGridViewWagon.Name = "dataGridViewWagon";
            this.dataGridViewWagon.RowTemplate.Height = 24;
            this.dataGridViewWagon.Size = new System.Drawing.Size(485, 411);
            this.dataGridViewWagon.TabIndex = 4;
            // 
            // grpBoxTrein
            // 
            this.grpBoxTrein.Controls.Add(this.dataGridViewWagon);
            this.grpBoxTrein.Location = new System.Drawing.Point(349, 29);
            this.grpBoxTrein.Name = "grpBoxTrein";
            this.grpBoxTrein.Size = new System.Drawing.Size(539, 471);
            this.grpBoxTrein.TabIndex = 5;
            this.grpBoxTrein.TabStop = false;
            this.grpBoxTrein.Text = "Trein";
            // 
            // WagonNummer
            // 
            this.WagonNummer.HeaderText = "WagonNr";
            this.WagonNummer.Name = "WagonNummer";
            // 
            // Soort
            // 
            this.Soort.HeaderText = "Soort";
            this.Soort.Name = "Soort";
            // 
            // Grootte
            // 
            this.Grootte.HeaderText = "Grootte";
            this.Grootte.Name = "Grootte";
            // 
            // btnVerdelen
            // 
            this.btnVerdelen.Location = new System.Drawing.Point(74, 488);
            this.btnVerdelen.Name = "btnVerdelen";
            this.btnVerdelen.Size = new System.Drawing.Size(121, 34);
            this.btnVerdelen.TabIndex = 6;
            this.btnVerdelen.Text = "Verdelen";
            this.btnVerdelen.UseVisualStyleBackColor = true;
            this.btnVerdelen.Click += new System.EventHandler(this.btnVerdelen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 538);
            this.Controls.Add(this.btnVerdelen);
            this.Controls.Add(this.grpBoxTrein);
            this.Controls.Add(this.lblLijstVanDieren);
            this.Controls.Add(this.listBoxLijstDieren);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWagon)).EndInit();
            this.grpBoxTrein.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Label lblSoortEter;
        private System.Windows.Forms.ComboBox comboBoxSoortEter;
        private System.Windows.Forms.Label lblGrootte;
        private System.Windows.Forms.ComboBox comboBoxGrootte;
        private System.Windows.Forms.ListBox listBoxLijstDieren;
        private System.Windows.Forms.Label lblLijstVanDieren;
        private System.Windows.Forms.DataGridView dataGridViewWagon;
        private System.Windows.Forms.DataGridViewTextBoxColumn WagonNummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grootte;
        private System.Windows.Forms.GroupBox grpBoxTrein;
        private System.Windows.Forms.Button btnVerdelen;
    }
}

