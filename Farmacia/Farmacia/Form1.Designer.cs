namespace Farmacia
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txbcodice = new System.Windows.Forms.TextBox();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.txbtipologia = new System.Windows.Forms.TextBox();
            this.txbdescrizione = new System.Windows.Forms.TextBox();
            this.txbprezzo = new System.Windows.Forms.TextBox();
            this.txbquantita = new System.Windows.Forms.TextBox();
            this.txbanni = new System.Windows.Forms.TextBox();
            this.txbdata = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txbmesi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnconferma = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crud";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txbmesi);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txbdata);
            this.groupBox1.Controls.Add(this.txbanni);
            this.groupBox1.Controls.Add(this.txbquantita);
            this.groupBox1.Controls.Add(this.txbprezzo);
            this.groupBox1.Controls.Add(this.txbdescrizione);
            this.groupBox1.Controls.Add(this.txbtipologia);
            this.groupBox1.Controls.Add(this.txbnome);
            this.groupBox1.Controls.Add(this.txbcodice);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Location = new System.Drawing.Point(96, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 344);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(64, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 24);
            this.label24.TabIndex = 22;
            this.label24.Text = "Codice";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(64, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 24);
            this.label23.TabIndex = 23;
            this.label23.Text = "Nome";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(49, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 24);
            this.label22.TabIndex = 24;
            this.label22.Text = "Tipologia";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(195, 24);
            this.label21.TabIndex = 25;
            this.label21.Text = "Descrizione (benefici)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(59, 184);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 24);
            this.label20.TabIndex = 26;
            this.label20.Text = "Prezzo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 223);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(175, 24);
            this.label19.TabIndex = 27;
            this.label19.Text = "Quantità importata";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(27, 266);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 24);
            this.label18.TabIndex = 28;
            this.label18.Text = "Età minima";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 303);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(154, 24);
            this.label17.TabIndex = 29;
            this.label17.Text = "Data di scadenza";
            // 
            // txbcodice
            // 
            this.txbcodice.Location = new System.Drawing.Point(222, 23);
            this.txbcodice.Name = "txbcodice";
            this.txbcodice.Size = new System.Drawing.Size(144, 22);
            this.txbcodice.TabIndex = 30;
            // 
            // txbnome
            // 
            this.txbnome.Location = new System.Drawing.Point(222, 66);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(144, 22);
            this.txbnome.TabIndex = 31;
            // 
            // txbtipologia
            // 
            this.txbtipologia.Location = new System.Drawing.Point(222, 110);
            this.txbtipologia.Name = "txbtipologia";
            this.txbtipologia.Size = new System.Drawing.Size(144, 22);
            this.txbtipologia.TabIndex = 32;
            // 
            // txbdescrizione
            // 
            this.txbdescrizione.Location = new System.Drawing.Point(222, 146);
            this.txbdescrizione.Name = "txbdescrizione";
            this.txbdescrizione.Size = new System.Drawing.Size(144, 22);
            this.txbdescrizione.TabIndex = 33;
            // 
            // txbprezzo
            // 
            this.txbprezzo.Location = new System.Drawing.Point(222, 186);
            this.txbprezzo.Name = "txbprezzo";
            this.txbprezzo.Size = new System.Drawing.Size(104, 22);
            this.txbprezzo.TabIndex = 34;
            // 
            // txbquantita
            // 
            this.txbquantita.Location = new System.Drawing.Point(222, 225);
            this.txbquantita.Name = "txbquantita";
            this.txbquantita.Size = new System.Drawing.Size(85, 22);
            this.txbquantita.TabIndex = 35;
            // 
            // txbanni
            // 
            this.txbanni.Location = new System.Drawing.Point(222, 266);
            this.txbanni.Name = "txbanni";
            this.txbanni.Size = new System.Drawing.Size(52, 22);
            this.txbanni.TabIndex = 36;
            // 
            // txbdata
            // 
            this.txbdata.Location = new System.Drawing.Point(222, 305);
            this.txbdata.Name = "txbdata";
            this.txbdata.Size = new System.Drawing.Size(144, 22);
            this.txbdata.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(332, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 24);
            this.label16.TabIndex = 38;
            this.label16.Text = "€";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(280, 264);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 24);
            this.label15.TabIndex = 39;
            this.label15.Text = "Anni";
            // 
            // txbmesi
            // 
            this.txbmesi.Location = new System.Drawing.Point(336, 266);
            this.txbmesi.Name = "txbmesi";
            this.txbmesi.Size = new System.Drawing.Size(51, 22);
            this.txbmesi.TabIndex = 40;
            this.txbmesi.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(393, 264);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 24);
            this.label14.TabIndex = 41;
            this.label14.Text = "Mesi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(313, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 24);
            this.label13.TabIndex = 42;
            this.label13.Text = "Pezzi";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnconferma);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inserisci";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnconferma
            // 
            this.btnconferma.BackColor = System.Drawing.Color.White;
            this.btnconferma.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconferma.Location = new System.Drawing.Point(580, 293);
            this.btnconferma.Name = "btnconferma";
            this.btnconferma.Size = new System.Drawing.Size(165, 78);
            this.btnconferma.TabIndex = 23;
            this.btnconferma.Text = "CONFERMA";
            this.btnconferma.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbmesi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbdata;
        private System.Windows.Forms.TextBox txbanni;
        private System.Windows.Forms.TextBox txbquantita;
        private System.Windows.Forms.TextBox txbprezzo;
        private System.Windows.Forms.TextBox txbdescrizione;
        private System.Windows.Forms.TextBox txbtipologia;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.TextBox txbcodice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnconferma;
    }
}

