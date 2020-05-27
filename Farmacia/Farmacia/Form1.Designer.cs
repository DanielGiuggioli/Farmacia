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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnconferma = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txbmesi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txbdata = new System.Windows.Forms.TextBox();
            this.txbanni = new System.Windows.Forms.TextBox();
            this.txbquantita = new System.Windows.Forms.TextBox();
            this.txbprezzo = new System.Windows.Forms.TextBox();
            this.txbdescrizione = new System.Windows.Forms.TextBox();
            this.txbtipologia = new System.Windows.Forms.TextBox();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.txbcodice = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btncarica = new System.Windows.Forms.Button();
            this.btnsalva = new System.Windows.Forms.Button();
            this.txbsalva = new System.Windows.Forms.TextBox();
            this.btncancella = new System.Windows.Forms.Button();
            this.txbcerca = new System.Windows.Forms.TextBox();
            this.btncerca = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnconferma);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnconferma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnconferma.Name = "btnconferma";
            this.btnconferma.Size = new System.Drawing.Size(165, 78);
            this.btnconferma.TabIndex = 23;
            this.btnconferma.Text = "CONFERMA";
            this.btnconferma.UseVisualStyleBackColor = false;
            this.btnconferma.Click += new System.EventHandler(this.btnconferma_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(96, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(467, 345);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(393, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 24);
            this.label14.TabIndex = 41;
            this.label14.Text = "Mesi";
            // 
            // txbmesi
            // 
            this.txbmesi.Location = new System.Drawing.Point(336, 266);
            this.txbmesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbmesi.Name = "txbmesi";
            this.txbmesi.Size = new System.Drawing.Size(51, 22);
            this.txbmesi.TabIndex = 40;
            this.txbmesi.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(280, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 24);
            this.label15.TabIndex = 39;
            this.label15.Text = "Anni";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(332, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 24);
            this.label16.TabIndex = 38;
            this.label16.Text = "€";
            // 
            // txbdata
            // 
            this.txbdata.Location = new System.Drawing.Point(221, 305);
            this.txbdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbdata.Name = "txbdata";
            this.txbdata.Size = new System.Drawing.Size(144, 22);
            this.txbdata.TabIndex = 37;
            // 
            // txbanni
            // 
            this.txbanni.Location = new System.Drawing.Point(221, 266);
            this.txbanni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbanni.Name = "txbanni";
            this.txbanni.Size = new System.Drawing.Size(52, 22);
            this.txbanni.TabIndex = 36;
            // 
            // txbquantita
            // 
            this.txbquantita.Location = new System.Drawing.Point(221, 225);
            this.txbquantita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbquantita.Name = "txbquantita";
            this.txbquantita.Size = new System.Drawing.Size(85, 22);
            this.txbquantita.TabIndex = 35;
            // 
            // txbprezzo
            // 
            this.txbprezzo.Location = new System.Drawing.Point(221, 186);
            this.txbprezzo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbprezzo.Name = "txbprezzo";
            this.txbprezzo.Size = new System.Drawing.Size(104, 22);
            this.txbprezzo.TabIndex = 34;
            // 
            // txbdescrizione
            // 
            this.txbdescrizione.Location = new System.Drawing.Point(221, 146);
            this.txbdescrizione.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbdescrizione.Name = "txbdescrizione";
            this.txbdescrizione.Size = new System.Drawing.Size(144, 22);
            this.txbdescrizione.TabIndex = 33;
            // 
            // txbtipologia
            // 
            this.txbtipologia.Location = new System.Drawing.Point(221, 110);
            this.txbtipologia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbtipologia.Name = "txbtipologia";
            this.txbtipologia.Size = new System.Drawing.Size(144, 22);
            this.txbtipologia.TabIndex = 32;
            // 
            // txbnome
            // 
            this.txbnome.Location = new System.Drawing.Point(221, 66);
            this.txbnome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(144, 22);
            this.txbnome.TabIndex = 31;
            // 
            // txbcodice
            // 
            this.txbcodice.Location = new System.Drawing.Point(221, 23);
            this.txbcodice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbcodice.Name = "txbcodice";
            this.txbcodice.Size = new System.Drawing.Size(144, 22);
            this.txbcodice.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 303);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(154, 24);
            this.label17.TabIndex = 29;
            this.label17.Text = "Data di scadenza";
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(5, 223);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(175, 24);
            this.label19.TabIndex = 27;
            this.label19.Text = "Quantità importata";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(59, 185);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 24);
            this.label20.TabIndex = 26;
            this.label20.Text = "Prezzo";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(5, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(195, 24);
            this.label21.TabIndex = 25;
            this.label21.Text = "Descrizione (benefici)";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btncarica);
            this.tabPage2.Controls.Add(this.btnsalva);
            this.tabPage2.Controls.Add(this.txbsalva);
            this.tabPage2.Controls.Add(this.btncancella);
            this.tabPage2.Controls.Add(this.txbcerca);
            this.tabPage2.Controls.Add(this.btncerca);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(767, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crud";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btncarica
            // 
            this.btncarica.BackColor = System.Drawing.Color.Red;
            this.btncarica.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncarica.Location = new System.Drawing.Point(563, 319);
            this.btncarica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncarica.Name = "btncarica";
            this.btncarica.Size = new System.Drawing.Size(197, 55);
            this.btncarica.TabIndex = 7;
            this.btncarica.Text = "Carica file";
            this.btncarica.UseVisualStyleBackColor = false;
            this.btncarica.Click += new System.EventHandler(this.btncarica_Click);
            // 
            // btnsalva
            // 
            this.btnsalva.BackColor = System.Drawing.Color.White;
            this.btnsalva.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalva.Location = new System.Drawing.Point(563, 249);
            this.btnsalva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsalva.Name = "btnsalva";
            this.btnsalva.Size = new System.Drawing.Size(197, 55);
            this.btnsalva.TabIndex = 6;
            this.btnsalva.Text = "Salva";
            this.btnsalva.UseVisualStyleBackColor = false;
            this.btnsalva.Click += new System.EventHandler(this.btnsalva_Click);
            // 
            // txbsalva
            // 
            this.txbsalva.Location = new System.Drawing.Point(563, 207);
            this.txbsalva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbsalva.Name = "txbsalva";
            this.txbsalva.Size = new System.Drawing.Size(199, 22);
            this.txbsalva.TabIndex = 5;
            // 
            // btncancella
            // 
            this.btncancella.BackColor = System.Drawing.Color.Red;
            this.btncancella.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancella.Location = new System.Drawing.Point(7, 319);
            this.btncancella.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancella.Name = "btncancella";
            this.btncancella.Size = new System.Drawing.Size(197, 55);
            this.btncancella.TabIndex = 4;
            this.btncancella.Text = "Cancella";
            this.btncancella.UseVisualStyleBackColor = false;
            this.btncancella.Click += new System.EventHandler(this.btncancella_Click);
            // 
            // txbcerca
            // 
            this.txbcerca.Location = new System.Drawing.Point(7, 207);
            this.txbcerca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbcerca.Name = "txbcerca";
            this.txbcerca.Size = new System.Drawing.Size(199, 22);
            this.txbcerca.TabIndex = 3;
            // 
            // btncerca
            // 
            this.btncerca.BackColor = System.Drawing.Color.White;
            this.btncerca.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerca.Location = new System.Drawing.Point(7, 249);
            this.btncerca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncerca.Name = "btncerca";
            this.btncerca.Size = new System.Drawing.Size(197, 55);
            this.btncerca.TabIndex = 2;
            this.btncerca.Text = "Cerca";
            this.btncerca.UseVisualStyleBackColor = false;
            this.btncerca.Click += new System.EventHandler(this.btncerca_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(291, 194);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(171, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 159);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(151, 21);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Quantità Crescente";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 89);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(141, 21);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Prezzo Crescente";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(5, 124);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(167, 21);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Quantità Decrescente";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 55);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(157, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Prezzo Decrescente";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordina per";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(-3, 2);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(753, 178);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codice";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipologia";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Descrizione";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prezzo";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quantità";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Età";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Data scadenza";
            this.columnHeader8.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox txbcerca;
        private System.Windows.Forms.Button btncerca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btncancella;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncarica;
        private System.Windows.Forms.Button btnsalva;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txbsalva;
    }
}

