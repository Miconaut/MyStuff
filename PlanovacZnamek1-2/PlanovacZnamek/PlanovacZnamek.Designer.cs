
namespace PlanovacZnamek
{
    partial class PlanovacZnamek
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
            this.buttonObnovit = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxPrumer = new System.Windows.Forms.TextBox();
            this.prumer = new System.Windows.Forms.Label();
            this.buttonPridat = new System.Windows.Forms.Button();
            this.textBoxPopis = new System.Windows.Forms.TextBox();
            this.popis = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.Label();
            this.vaha = new System.Windows.Forms.Label();
            this.znamka = new System.Windows.Forms.Label();
            this.pridatZnamku = new System.Windows.Forms.Label();
            this.predmet = new System.Windows.Forms.Label();
            this.comboBoxPredmet = new System.Windows.Forms.ComboBox();
            this.comboBoxZnamka = new System.Windows.Forms.ComboBox();
            this.comboBoxVaha = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.buttonOdstranitRadek = new System.Windows.Forms.Button();
            this.prumerPredmet = new System.Windows.Forms.Label();
            this.comboBoxPredmetPrumer = new System.Windows.Forms.ComboBox();
            this.labelPredmetPrumer = new System.Windows.Forms.Label();
            this.buttonVymazatVse = new System.Windows.Forms.Button();
            this.buttonVypocitatPrumer = new System.Windows.Forms.Button();
            this.buttonOdstranitVse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonObnovit
            // 
            this.buttonObnovit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonObnovit.Location = new System.Drawing.Point(113, 208);
            this.buttonObnovit.Name = "buttonObnovit";
            this.buttonObnovit.Size = new System.Drawing.Size(75, 23);
            this.buttonObnovit.TabIndex = 13;
            this.buttonObnovit.Text = "Obnovit";
            this.buttonObnovit.UseVisualStyleBackColor = true;
            this.buttonObnovit.Click += new System.EventHandler(this.buttonObnovit_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(289, 46);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(689, 392);
            this.dataGridView.TabIndex = 12;
            // 
            // textBoxPrumer
            // 
            this.textBoxPrumer.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPrumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPrumer.ForeColor = System.Drawing.Color.Red;
            this.textBoxPrumer.Location = new System.Drawing.Point(89, 342);
            this.textBoxPrumer.Name = "textBoxPrumer";
            this.textBoxPrumer.ReadOnly = true;
            this.textBoxPrumer.Size = new System.Drawing.Size(65, 22);
            this.textBoxPrumer.TabIndex = 11;
            // 
            // prumer
            // 
            this.prumer.AutoSize = true;
            this.prumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prumer.ForeColor = System.Drawing.Color.Red;
            this.prumer.Location = new System.Drawing.Point(13, 345);
            this.prumer.Name = "prumer";
            this.prumer.Size = new System.Drawing.Size(61, 16);
            this.prumer.TabIndex = 10;
            this.prumer.Text = "Průměr:";
            // 
            // buttonPridat
            // 
            this.buttonPridat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPridat.Location = new System.Drawing.Point(32, 208);
            this.buttonPridat.Name = "buttonPridat";
            this.buttonPridat.Size = new System.Drawing.Size(75, 23);
            this.buttonPridat.TabIndex = 9;
            this.buttonPridat.Text = "Přidat";
            this.buttonPridat.UseVisualStyleBackColor = true;
            this.buttonPridat.Click += new System.EventHandler(this.buttonPridat_Click);
            // 
            // textBoxPopis
            // 
            this.textBoxPopis.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPopis.Location = new System.Drawing.Point(16, 169);
            this.textBoxPopis.MaxLength = 50;
            this.textBoxPopis.Name = "textBoxPopis";
            this.textBoxPopis.Size = new System.Drawing.Size(194, 20);
            this.textBoxPopis.TabIndex = 8;
            // 
            // popis
            // 
            this.popis.AutoSize = true;
            this.popis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.popis.Location = new System.Drawing.Point(13, 150);
            this.popis.Name = "popis";
            this.popis.Size = new System.Drawing.Size(52, 16);
            this.popis.TabIndex = 4;
            this.popis.Text = "Popis:";
            // 
            // datum
            // 
            this.datum.AutoSize = true;
            this.datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datum.Location = new System.Drawing.Point(13, 120);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(56, 16);
            this.datum.TabIndex = 3;
            this.datum.Text = "Datum:";
            // 
            // vaha
            // 
            this.vaha.AutoSize = true;
            this.vaha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vaha.Location = new System.Drawing.Point(13, 92);
            this.vaha.Name = "vaha";
            this.vaha.Size = new System.Drawing.Size(48, 16);
            this.vaha.TabIndex = 2;
            this.vaha.Text = "Váha:";
            // 
            // znamka
            // 
            this.znamka.AutoSize = true;
            this.znamka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.znamka.Location = new System.Drawing.Point(13, 65);
            this.znamka.Name = "znamka";
            this.znamka.Size = new System.Drawing.Size(59, 16);
            this.znamka.TabIndex = 1;
            this.znamka.Text = "Zámka:";
            // 
            // pridatZnamku
            // 
            this.pridatZnamku.AutoSize = true;
            this.pridatZnamku.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridatZnamku.Location = new System.Drawing.Point(12, 9);
            this.pridatZnamku.Name = "pridatZnamku";
            this.pridatZnamku.Size = new System.Drawing.Size(148, 24);
            this.pridatZnamku.TabIndex = 0;
            this.pridatZnamku.Text = "Přidat známku:";
            // 
            // predmet
            // 
            this.predmet.AutoSize = true;
            this.predmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.predmet.Location = new System.Drawing.Point(13, 39);
            this.predmet.Name = "predmet";
            this.predmet.Size = new System.Drawing.Size(70, 16);
            this.predmet.TabIndex = 14;
            this.predmet.Text = "Předmět:";
            // 
            // comboBoxPredmet
            // 
            this.comboBoxPredmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPredmet.FormattingEnabled = true;
            this.comboBoxPredmet.Items.AddRange(new object[] {
            "",
            "Anglický jazyk",
            "Biologie",
            "Český jazyk",
            "Dějepis",
            "Elektrotechnika",
            "Fyzika",
            "Hardware",
            "Chemie",
            "Chemie-ekologie",
            "Informatika a výpočetní technika",
            "Matematika",
            "Německý jazyk",
            "Počítačové sítě",
            "Praktická cvičení",
            "Prezentační dovednosti",
            "Programování a vývoj aplikací",
            "Technické kreslení",
            "Tělesná výchova",
            "Výtvarná výchova",
            "Základy společenských věd",
            "Zeměpis"});
            this.comboBoxPredmet.Location = new System.Drawing.Point(89, 38);
            this.comboBoxPredmet.Name = "comboBoxPredmet";
            this.comboBoxPredmet.Size = new System.Drawing.Size(183, 21);
            this.comboBoxPredmet.TabIndex = 16;
            // 
            // comboBoxZnamka
            // 
            this.comboBoxZnamka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZnamka.FormattingEnabled = true;
            this.comboBoxZnamka.Items.AddRange(new object[] {
            "",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5"});
            this.comboBoxZnamka.Location = new System.Drawing.Point(89, 64);
            this.comboBoxZnamka.Name = "comboBoxZnamka";
            this.comboBoxZnamka.Size = new System.Drawing.Size(48, 21);
            this.comboBoxZnamka.TabIndex = 17;
            // 
            // comboBoxVaha
            // 
            this.comboBoxVaha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVaha.FormattingEnabled = true;
            this.comboBoxVaha.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxVaha.Location = new System.Drawing.Point(89, 91);
            this.comboBoxVaha.Name = "comboBoxVaha";
            this.comboBoxVaha.Size = new System.Drawing.Size(48, 21);
            this.comboBoxVaha.TabIndex = 18;
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatum.Location = new System.Drawing.Point(89, 120);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(91, 20);
            this.dateTimePickerDatum.TabIndex = 19;
            // 
            // buttonOdstranitRadek
            // 
            this.buttonOdstranitRadek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOdstranitRadek.Location = new System.Drawing.Point(289, 12);
            this.buttonOdstranitRadek.Name = "buttonOdstranitRadek";
            this.buttonOdstranitRadek.Size = new System.Drawing.Size(183, 28);
            this.buttonOdstranitRadek.TabIndex = 20;
            this.buttonOdstranitRadek.Text = "Odstranit vybraný řádek";
            this.buttonOdstranitRadek.UseVisualStyleBackColor = true;
            this.buttonOdstranitRadek.Click += new System.EventHandler(this.buttonOdstranitRadek_Click);
            // 
            // prumerPredmet
            // 
            this.prumerPredmet.AutoSize = true;
            this.prumerPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prumerPredmet.Location = new System.Drawing.Point(12, 250);
            this.prumerPredmet.Name = "prumerPredmet";
            this.prumerPredmet.Size = new System.Drawing.Size(181, 24);
            this.prumerPredmet.TabIndex = 21;
            this.prumerPredmet.Text = "Průměr - předmět:";
            // 
            // comboBoxPredmetPrumer
            // 
            this.comboBoxPredmetPrumer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPredmetPrumer.FormattingEnabled = true;
            this.comboBoxPredmetPrumer.Items.AddRange(new object[] {
            "",
            "Anglický jazyk",
            "Biologie",
            "Český jazyk",
            "Dějepis",
            "Elektrotechnika",
            "Fyzika",
            "Hardware",
            "Chemie",
            "Chemie-ekologie",
            "Informatika a výpočetní technika",
            "Matematika",
            "Německý jazyk",
            "Počítačové sítě",
            "Praktická cvičení",
            "Prezentační dovednosti",
            "Programování a vývoj aplikací",
            "Technické kreslení",
            "Tělesná výchova",
            "Výtvarná výchova",
            "Základy společenských věd",
            "Zeměpis"});
            this.comboBoxPredmetPrumer.Location = new System.Drawing.Point(89, 282);
            this.comboBoxPredmetPrumer.Name = "comboBoxPredmetPrumer";
            this.comboBoxPredmetPrumer.Size = new System.Drawing.Size(183, 21);
            this.comboBoxPredmetPrumer.TabIndex = 23;
            // 
            // labelPredmetPrumer
            // 
            this.labelPredmetPrumer.AutoSize = true;
            this.labelPredmetPrumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPredmetPrumer.Location = new System.Drawing.Point(13, 283);
            this.labelPredmetPrumer.Name = "labelPredmetPrumer";
            this.labelPredmetPrumer.Size = new System.Drawing.Size(70, 16);
            this.labelPredmetPrumer.TabIndex = 22;
            this.labelPredmetPrumer.Text = "Předmět:";
            // 
            // buttonVymazatVse
            // 
            this.buttonVymazatVse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVymazatVse.Location = new System.Drawing.Point(16, 410);
            this.buttonVymazatVse.Name = "buttonVymazatVse";
            this.buttonVymazatVse.Size = new System.Drawing.Size(106, 28);
            this.buttonVymazatVse.TabIndex = 24;
            this.buttonVymazatVse.Text = "Vymazat vše";
            this.buttonVymazatVse.UseVisualStyleBackColor = true;
            // 
            // buttonVypocitatPrumer
            // 
            this.buttonVypocitatPrumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVypocitatPrumer.Location = new System.Drawing.Point(40, 309);
            this.buttonVypocitatPrumer.Name = "buttonVypocitatPrumer";
            this.buttonVypocitatPrumer.Size = new System.Drawing.Size(139, 27);
            this.buttonVypocitatPrumer.TabIndex = 25;
            this.buttonVypocitatPrumer.Text = "Vypočítat průměr";
            this.buttonVypocitatPrumer.UseVisualStyleBackColor = true;
            this.buttonVypocitatPrumer.Click += new System.EventHandler(this.buttonVypocitatPrumer_Click);
            // 
            // buttonOdstranitVse
            // 
            this.buttonOdstranitVse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOdstranitVse.Location = new System.Drawing.Point(871, 9);
            this.buttonOdstranitVse.Name = "buttonOdstranitVse";
            this.buttonOdstranitVse.Size = new System.Drawing.Size(107, 28);
            this.buttonOdstranitVse.TabIndex = 26;
            this.buttonOdstranitVse.Text = "Odstranit vše";
            this.buttonOdstranitVse.UseVisualStyleBackColor = true;
            this.buttonOdstranitVse.Click += new System.EventHandler(this.buttonOdstranitVse_Click);
            // 
            // PlanovacZnamek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 450);
            this.Controls.Add(this.buttonOdstranitVse);
            this.Controls.Add(this.buttonVypocitatPrumer);
            this.Controls.Add(this.buttonVymazatVse);
            this.Controls.Add(this.comboBoxPredmetPrumer);
            this.Controls.Add(this.labelPredmetPrumer);
            this.Controls.Add(this.prumerPredmet);
            this.Controls.Add(this.buttonOdstranitRadek);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.comboBoxVaha);
            this.Controls.Add(this.comboBoxZnamka);
            this.Controls.Add(this.comboBoxPredmet);
            this.Controls.Add(this.predmet);
            this.Controls.Add(this.buttonObnovit);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxPrumer);
            this.Controls.Add(this.pridatZnamku);
            this.Controls.Add(this.prumer);
            this.Controls.Add(this.znamka);
            this.Controls.Add(this.buttonPridat);
            this.Controls.Add(this.vaha);
            this.Controls.Add(this.textBoxPopis);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.popis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PlanovacZnamek";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plánovač známek";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPrumer;
        private System.Windows.Forms.Label prumer;
        private System.Windows.Forms.Button buttonPridat;
        private System.Windows.Forms.TextBox textBoxPopis;
        private System.Windows.Forms.Label popis;
        private System.Windows.Forms.Label datum;
        private System.Windows.Forms.Label vaha;
        private System.Windows.Forms.Label znamka;
        private System.Windows.Forms.Label pridatZnamku;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonObnovit;
        private System.Windows.Forms.Label predmet;
        private System.Windows.Forms.ComboBox comboBoxPredmet;
        private System.Windows.Forms.ComboBox comboBoxZnamka;
        private System.Windows.Forms.ComboBox comboBoxVaha;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.Button buttonOdstranitRadek;
        private System.Windows.Forms.Label prumerPredmet;
        private System.Windows.Forms.ComboBox comboBoxPredmetPrumer;
        private System.Windows.Forms.Label labelPredmetPrumer;
        private System.Windows.Forms.Button buttonVymazatVse;
        private System.Windows.Forms.Button buttonVypocitatPrumer;
        private System.Windows.Forms.Button buttonOdstranitVse;
    }
}

