namespace Gabopver02
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
            this.BtN_Ind = new System.Windows.Forms.Button();
            this.BtN_Beh = new System.Windows.Forms.Button();
            this.BtN_Book = new System.Windows.Forms.Button();
            this.BtN_Seek = new System.Windows.Forms.Button();
            this.Box_Postnr = new System.Windows.Forms.ComboBox();
            this.Box_Klinik = new System.Windows.Forms.ComboBox();
            this.Box_Tandlaege = new System.Windows.Forms.ComboBox();
            this.CBox_Seek = new System.Windows.Forms.ComboBox();
            this.Box_CPR = new System.Windows.Forms.TextBox();
            this.Box_Fornavn = new System.Windows.Forms.TextBox();
            this.Box_Efternavn = new System.Windows.Forms.TextBox();
            this.Box_Mellemnavn = new System.Windows.Forms.TextBox();
            this.Box_Email = new System.Windows.Forms.TextBox();
            this.Box_Tlf = new System.Windows.Forms.TextBox();
            this.Box_Beloeb = new System.Windows.Forms.TextBox();
            this.BtN_Betalt = new System.Windows.Forms.RadioButton();
            this.Box_Dato = new System.Windows.Forms.DateTimePicker();
            this.Box_Behandling = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Box_Adresse = new System.Windows.Forms.TextBox();
            this.BtN_Lukned = new System.Windows.Forms.Button();
            this.BtN_Ryd = new System.Windows.Forms.Button();
            this.Box_Seek_Result = new System.Windows.Forms.DataGridView();
            this.BtN_Opdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Seek_Result)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtN_Ind
            // 
            this.BtN_Ind.Location = new System.Drawing.Point(18, 14);
            this.BtN_Ind.Name = "BtN_Ind";
            this.BtN_Ind.Size = new System.Drawing.Size(75, 23);
            this.BtN_Ind.TabIndex = 0;
            this.BtN_Ind.Text = "Indsæt";
            this.BtN_Ind.UseVisualStyleBackColor = true;
            this.BtN_Ind.Click += new System.EventHandler(this.BtN_Ind_Click);
            // 
            // BtN_Beh
            // 
            this.BtN_Beh.Location = new System.Drawing.Point(216, 14);
            this.BtN_Beh.Name = "BtN_Beh";
            this.BtN_Beh.Size = new System.Drawing.Size(75, 23);
            this.BtN_Beh.TabIndex = 2;
            this.BtN_Beh.Text = "Behandling";
            this.BtN_Beh.UseVisualStyleBackColor = true;
            this.BtN_Beh.Click += new System.EventHandler(this.BtN_Beh_Click);
            // 
            // BtN_Book
            // 
            this.BtN_Book.Location = new System.Drawing.Point(103, 14);
            this.BtN_Book.Name = "BtN_Book";
            this.BtN_Book.Size = new System.Drawing.Size(75, 23);
            this.BtN_Book.TabIndex = 1;
            this.BtN_Book.Text = "Booking";
            this.BtN_Book.UseVisualStyleBackColor = true;
            this.BtN_Book.Click += new System.EventHandler(this.BtN_Book_Click);
            // 
            // BtN_Seek
            // 
            this.BtN_Seek.Location = new System.Drawing.Point(574, 14);
            this.BtN_Seek.Name = "BtN_Seek";
            this.BtN_Seek.Size = new System.Drawing.Size(75, 23);
            this.BtN_Seek.TabIndex = 4;
            this.BtN_Seek.Text = "Søg";
            this.BtN_Seek.UseVisualStyleBackColor = true;
            this.BtN_Seek.Click += new System.EventHandler(this.BtN_Seek_Click);
            // 
            // Box_Postnr
            // 
            this.Box_Postnr.FormattingEnabled = true;
            this.Box_Postnr.Location = new System.Drawing.Point(86, 274);
            this.Box_Postnr.Name = "Box_Postnr";
            this.Box_Postnr.Size = new System.Drawing.Size(121, 21);
            this.Box_Postnr.TabIndex = 13;
            // 
            // Box_Klinik
            // 
            this.Box_Klinik.FormattingEnabled = true;
            this.Box_Klinik.Location = new System.Drawing.Point(259, 156);
            this.Box_Klinik.Name = "Box_Klinik";
            this.Box_Klinik.Size = new System.Drawing.Size(121, 21);
            this.Box_Klinik.TabIndex = 18;
            // 
            // Box_Tandlaege
            // 
            this.Box_Tandlaege.FormattingEnabled = true;
            this.Box_Tandlaege.Location = new System.Drawing.Point(259, 196);
            this.Box_Tandlaege.Name = "Box_Tandlaege";
            this.Box_Tandlaege.Size = new System.Drawing.Size(121, 21);
            this.Box_Tandlaege.TabIndex = 19;
            // 
            // CBox_Seek
            // 
            this.CBox_Seek.FormattingEnabled = true;
            this.CBox_Seek.Items.AddRange(new object[] {
            "CPR",
            "Fornavn",
            "Efternavn",
            "Adresse",
            "Postnr",
            "Tlfnr",
            "Email",
            "Betalt",
            "Tandlaege"});
            this.CBox_Seek.Location = new System.Drawing.Point(619, 78);
            this.CBox_Seek.Name = "CBox_Seek";
            this.CBox_Seek.Size = new System.Drawing.Size(121, 21);
            this.CBox_Seek.TabIndex = 22;
            // 
            // Box_CPR
            // 
            this.Box_CPR.Location = new System.Drawing.Point(86, 80);
            this.Box_CPR.Name = "Box_CPR";
            this.Box_CPR.Size = new System.Drawing.Size(100, 20);
            this.Box_CPR.TabIndex = 8;
            // 
            // Box_Fornavn
            // 
            this.Box_Fornavn.Location = new System.Drawing.Point(86, 119);
            this.Box_Fornavn.Name = "Box_Fornavn";
            this.Box_Fornavn.Size = new System.Drawing.Size(100, 20);
            this.Box_Fornavn.TabIndex = 9;
            // 
            // Box_Efternavn
            // 
            this.Box_Efternavn.Location = new System.Drawing.Point(86, 197);
            this.Box_Efternavn.Name = "Box_Efternavn";
            this.Box_Efternavn.Size = new System.Drawing.Size(100, 20);
            this.Box_Efternavn.TabIndex = 11;
            // 
            // Box_Mellemnavn
            // 
            this.Box_Mellemnavn.Location = new System.Drawing.Point(86, 158);
            this.Box_Mellemnavn.Name = "Box_Mellemnavn";
            this.Box_Mellemnavn.Size = new System.Drawing.Size(100, 20);
            this.Box_Mellemnavn.TabIndex = 10;
            // 
            // Box_Email
            // 
            this.Box_Email.Location = new System.Drawing.Point(86, 351);
            this.Box_Email.Name = "Box_Email";
            this.Box_Email.Size = new System.Drawing.Size(100, 20);
            this.Box_Email.TabIndex = 15;
            // 
            // Box_Tlf
            // 
            this.Box_Tlf.Location = new System.Drawing.Point(86, 312);
            this.Box_Tlf.Name = "Box_Tlf";
            this.Box_Tlf.Size = new System.Drawing.Size(100, 20);
            this.Box_Tlf.TabIndex = 14;
            // 
            // Box_Beloeb
            // 
            this.Box_Beloeb.Location = new System.Drawing.Point(259, 79);
            this.Box_Beloeb.Name = "Box_Beloeb";
            this.Box_Beloeb.Size = new System.Drawing.Size(100, 20);
            this.Box_Beloeb.TabIndex = 16;
            // 
            // BtN_Betalt
            // 
            this.BtN_Betalt.AutoSize = true;
            this.BtN_Betalt.Location = new System.Drawing.Point(259, 119);
            this.BtN_Betalt.Name = "BtN_Betalt";
            this.BtN_Betalt.Size = new System.Drawing.Size(36, 17);
            this.BtN_Betalt.TabIndex = 17;
            this.BtN_Betalt.TabStop = true;
            this.BtN_Betalt.Text = "Ja";
            this.BtN_Betalt.UseVisualStyleBackColor = true;
            // 
            // Box_Dato
            // 
            this.Box_Dato.Location = new System.Drawing.Point(259, 233);
            this.Box_Dato.Name = "Box_Dato";
            this.Box_Dato.Size = new System.Drawing.Size(200, 20);
            this.Box_Dato.TabIndex = 20;
            // 
            // Box_Behandling
            // 
            this.Box_Behandling.Location = new System.Drawing.Point(259, 292);
            this.Box_Behandling.Multiline = true;
            this.Box_Behandling.Name = "Box_Behandling";
            this.Box_Behandling.Size = new System.Drawing.Size(183, 97);
            this.Box_Behandling.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "CPR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fornavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mellemnavn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Efternavn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Postnr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tlf nr.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Beløb";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "KR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(201, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Betalt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Klinik";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(201, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Tandlæge";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(255, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Behandling";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(616, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Vælg søge parameter";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Adresse";
            // 
            // Box_Adresse
            // 
            this.Box_Adresse.Location = new System.Drawing.Point(86, 233);
            this.Box_Adresse.Name = "Box_Adresse";
            this.Box_Adresse.Size = new System.Drawing.Size(100, 20);
            this.Box_Adresse.TabIndex = 12;
            // 
            // BtN_Lukned
            // 
            this.BtN_Lukned.Location = new System.Drawing.Point(794, 387);
            this.BtN_Lukned.Name = "BtN_Lukned";
            this.BtN_Lukned.Size = new System.Drawing.Size(75, 23);
            this.BtN_Lukned.TabIndex = 35;
            this.BtN_Lukned.Text = "Luk";
            this.BtN_Lukned.UseVisualStyleBackColor = true;
            this.BtN_Lukned.Click += new System.EventHandler(this.BtN_Lukned_Click);
            // 
            // BtN_Ryd
            // 
            this.BtN_Ryd.Location = new System.Drawing.Point(891, 387);
            this.BtN_Ryd.Name = "BtN_Ryd";
            this.BtN_Ryd.Size = new System.Drawing.Size(75, 23);
            this.BtN_Ryd.TabIndex = 36;
            this.BtN_Ryd.Text = "Ryd Form";
            this.BtN_Ryd.UseVisualStyleBackColor = true;
            this.BtN_Ryd.Click += new System.EventHandler(this.BtN_Ryd_Click);
            // 
            // Box_Seek_Result
            // 
            this.Box_Seek_Result.AllowUserToOrderColumns = true;
            this.Box_Seek_Result.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Box_Seek_Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Box_Seek_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Box_Seek_Result.Location = new System.Drawing.Point(544, 123);
            this.Box_Seek_Result.Margin = new System.Windows.Forms.Padding(2);
            this.Box_Seek_Result.Name = "Box_Seek_Result";
            this.Box_Seek_Result.RowTemplate.Height = 24;
            this.Box_Seek_Result.Size = new System.Drawing.Size(422, 245);
            this.Box_Seek_Result.TabIndex = 37;
            // 
            // BtN_Opdate
            // 
            this.BtN_Opdate.Location = new System.Drawing.Point(299, 14);
            this.BtN_Opdate.Name = "BtN_Opdate";
            this.BtN_Opdate.Size = new System.Drawing.Size(75, 23);
            this.BtN_Opdate.TabIndex = 3;
            this.BtN_Opdate.Text = "Opdater";
            this.BtN_Opdate.UseVisualStyleBackColor = true;
            this.BtN_Opdate.Click += new System.EventHandler(this.BtN_Opdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtN_Opdate);
            this.groupBox1.Controls.Add(this.BtN_Seek);
            this.groupBox1.Controls.Add(this.BtN_Book);
            this.groupBox1.Controls.Add(this.BtN_Beh);
            this.groupBox1.Controls.Add(this.BtN_Ind);
            this.groupBox1.Location = new System.Drawing.Point(68, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 48);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Box_Seek_Result);
            this.Controls.Add(this.BtN_Ryd);
            this.Controls.Add(this.BtN_Lukned);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Box_Adresse);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Box_Behandling);
            this.Controls.Add(this.Box_Dato);
            this.Controls.Add(this.BtN_Betalt);
            this.Controls.Add(this.Box_Beloeb);
            this.Controls.Add(this.Box_Email);
            this.Controls.Add(this.Box_Tlf);
            this.Controls.Add(this.Box_Efternavn);
            this.Controls.Add(this.Box_Mellemnavn);
            this.Controls.Add(this.Box_Fornavn);
            this.Controls.Add(this.Box_CPR);
            this.Controls.Add(this.CBox_Seek);
            this.Controls.Add(this.Box_Tandlaege);
            this.Controls.Add(this.Box_Klinik);
            this.Controls.Add(this.Box_Postnr);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Box_Seek_Result)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtN_Ind;
        private System.Windows.Forms.Button BtN_Beh;
        private System.Windows.Forms.Button BtN_Book;
        private System.Windows.Forms.Button BtN_Seek;
        private System.Windows.Forms.ComboBox Box_Postnr;
        private System.Windows.Forms.ComboBox Box_Klinik;
        private System.Windows.Forms.ComboBox Box_Tandlaege;
        private System.Windows.Forms.ComboBox CBox_Seek;
        private System.Windows.Forms.TextBox Box_CPR;
        private System.Windows.Forms.TextBox Box_Fornavn;
        private System.Windows.Forms.TextBox Box_Efternavn;
        private System.Windows.Forms.TextBox Box_Mellemnavn;
        private System.Windows.Forms.TextBox Box_Email;
        private System.Windows.Forms.TextBox Box_Tlf;
        private System.Windows.Forms.TextBox Box_Beloeb;
        private System.Windows.Forms.RadioButton BtN_Betalt;
        private System.Windows.Forms.DateTimePicker Box_Dato;
        private System.Windows.Forms.TextBox Box_Behandling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Box_Adresse;
        private System.Windows.Forms.Button BtN_Lukned;
        private System.Windows.Forms.Button BtN_Ryd;
        private System.Windows.Forms.DataGridView Box_Seek_Result;
        private System.Windows.Forms.Button BtN_Opdate;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

