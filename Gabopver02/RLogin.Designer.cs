namespace Gabopver02
{
    partial class RLogin
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
            this.Btn_log = new System.Windows.Forms.Button();
            this.Btn_ext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoX_Bruger = new System.Windows.Forms.TextBox();
            this.BoX_Kode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_log
            // 
            this.Btn_log.Location = new System.Drawing.Point(169, 178);
            this.Btn_log.Name = "Btn_log";
            this.Btn_log.Size = new System.Drawing.Size(75, 23);
            this.Btn_log.TabIndex = 0;
            this.Btn_log.Text = "&LOGIN";
            this.Btn_log.UseVisualStyleBackColor = true;
            this.Btn_log.Click += new System.EventHandler(this.Btn_log_Click);
            // 
            // Btn_ext
            // 
            this.Btn_ext.Location = new System.Drawing.Point(273, 178);
            this.Btn_ext.Name = "Btn_ext";
            this.Btn_ext.Size = new System.Drawing.Size(75, 23);
            this.Btn_ext.TabIndex = 1;
            this.Btn_ext.Text = "E&XIT";
            this.Btn_ext.UseVisualStyleBackColor = true;
            this.Btn_ext.Click += new System.EventHandler(this.Btn_ext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brugernavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adgangskode";
            // 
            // BoX_Bruger
            // 
            this.BoX_Bruger.Location = new System.Drawing.Point(169, 82);
            this.BoX_Bruger.Name = "BoX_Bruger";
            this.BoX_Bruger.Size = new System.Drawing.Size(179, 20);
            this.BoX_Bruger.TabIndex = 5;
            this.BoX_Bruger.Text = "SecRec_01";
            // 
            // BoX_Kode
            // 
            this.BoX_Kode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoX_Kode.Location = new System.Drawing.Point(169, 136);
            this.BoX_Kode.Name = "BoX_Kode";
            this.BoX_Kode.Size = new System.Drawing.Size(179, 20);
            this.BoX_Kode.TabIndex = 6;
            this.BoX_Kode.Text = "MinlilleKode01";
            this.BoX_Kode.UseSystemPasswordChar = true;
            // 
            // RLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(531, 284);
            this.Controls.Add(this.BoX_Kode);
            this.Controls.Add(this.BoX_Bruger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_ext);
            this.Controls.Add(this.Btn_log);
            this.Name = "RLogin";
            this.Text = "RLogin";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_log;
        private System.Windows.Forms.Button Btn_ext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoX_Bruger;
        private System.Windows.Forms.TextBox BoX_Kode;
    }
}