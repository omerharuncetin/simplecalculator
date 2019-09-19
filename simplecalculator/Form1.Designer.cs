namespace simplecalculator
{
    partial class FormTopla
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
            this.tabToplam = new System.Windows.Forms.TabControl();
            this.tabToplama = new System.Windows.Forms.TabPage();
            this.txtIkinciSayi = new System.Windows.Forms.TextBox();
            this.lblIkinciSayi = new System.Windows.Forms.Label();
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.lblBirinciSayi = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.btnIleri = new System.Windows.Forms.Button();
            this.lvLog = new System.Windows.Forms.ListView();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.tabToplam.SuspendLayout();
            this.tabToplama.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabToplam
            // 
            this.tabToplam.Controls.Add(this.tabToplama);
            this.tabToplam.Controls.Add(this.tabLog);
            this.tabToplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabToplam.Location = new System.Drawing.Point(0, 0);
            this.tabToplam.Name = "tabToplam";
            this.tabToplam.SelectedIndex = 0;
            this.tabToplam.Size = new System.Drawing.Size(550, 433);
            this.tabToplam.TabIndex = 0;
            // 
            // tabToplama
            // 
            this.tabToplama.BackColor = System.Drawing.Color.SlateGray;
            this.tabToplama.Controls.Add(this.btnIleri);
            this.tabToplama.Controls.Add(this.txtSonuc);
            this.tabToplama.Controls.Add(this.lblSonuc);
            this.tabToplama.Controls.Add(this.txtIkinciSayi);
            this.tabToplama.Controls.Add(this.lblIkinciSayi);
            this.tabToplama.Controls.Add(this.txtBirinciSayi);
            this.tabToplama.Controls.Add(this.btnTopla);
            this.tabToplama.Controls.Add(this.lblBirinciSayi);
            this.tabToplama.Location = new System.Drawing.Point(4, 29);
            this.tabToplama.Name = "tabToplama";
            this.tabToplama.Padding = new System.Windows.Forms.Padding(1);
            this.tabToplama.Size = new System.Drawing.Size(542, 400);
            this.tabToplama.TabIndex = 0;
            this.tabToplama.Text = "Toplama";
            // 
            // txtIkinciSayi
            // 
            this.txtIkinciSayi.Location = new System.Drawing.Point(147, 107);
            this.txtIkinciSayi.Margin = new System.Windows.Forms.Padding(4);
            this.txtIkinciSayi.Name = "txtIkinciSayi";
            this.txtIkinciSayi.Size = new System.Drawing.Size(284, 27);
            this.txtIkinciSayi.TabIndex = 1;
            this.txtIkinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIkinciSayi_KeyPress);
            // 
            // lblIkinciSayi
            // 
            this.lblIkinciSayi.AutoSize = true;
            this.lblIkinciSayi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblIkinciSayi.Location = new System.Drawing.Point(34, 105);
            this.lblIkinciSayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIkinciSayi.Name = "lblIkinciSayi";
            this.lblIkinciSayi.Size = new System.Drawing.Size(84, 20);
            this.lblIkinciSayi.TabIndex = 8;
            this.lblIkinciSayi.Text = "İkinci Sayı";
            // 
            // txtBirinciSayi
            // 
            this.txtBirinciSayi.Location = new System.Drawing.Point(147, 56);
            this.txtBirinciSayi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            this.txtBirinciSayi.Size = new System.Drawing.Size(284, 27);
            this.txtBirinciSayi.TabIndex = 0;
            this.txtBirinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirinciSayi_KeyPress);
            // 
            // btnTopla
            // 
            this.btnTopla.BackColor = System.Drawing.Color.Transparent;
            this.btnTopla.FlatAppearance.BorderSize = 0;
            this.btnTopla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTopla.Location = new System.Drawing.Point(183, 170);
            this.btnTopla.Margin = new System.Windows.Forms.Padding(4);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(215, 38);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = false;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // lblBirinciSayi
            // 
            this.lblBirinciSayi.AutoSize = true;
            this.lblBirinciSayi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblBirinciSayi.Location = new System.Drawing.Point(34, 54);
            this.lblBirinciSayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirinciSayi.Name = "lblBirinciSayi";
            this.lblBirinciSayi.Size = new System.Drawing.Size(94, 20);
            this.lblBirinciSayi.TabIndex = 5;
            this.lblBirinciSayi.Text = "Birinci Sayı";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(147, 263);
            this.txtSonuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(337, 27);
            this.txtSonuc.TabIndex = 11;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSonuc.Location = new System.Drawing.Point(67, 266);
            this.lblSonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(61, 20);
            this.lblSonuc.TabIndex = 10;
            this.lblSonuc.Text = "Sonuç:";
            // 
            // tabLog
            // 
            this.tabLog.BackColor = System.Drawing.Color.SlateGray;
            this.tabLog.Controls.Add(this.btnYazdir);
            this.tabLog.Controls.Add(this.btnTemizle);
            this.tabLog.Controls.Add(this.btnGeri);
            this.tabLog.Controls.Add(this.lvLog);
            this.tabLog.Location = new System.Drawing.Point(4, 29);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(542, 400);
            this.tabLog.TabIndex = 1;
            this.tabLog.Text = "Loglama";
            // 
            // btnIleri
            // 
            this.btnIleri.BackColor = System.Drawing.Color.Transparent;
            this.btnIleri.FlatAppearance.BorderSize = 0;
            this.btnIleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIleri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIleri.Location = new System.Drawing.Point(363, 326);
            this.btnIleri.Margin = new System.Windows.Forms.Padding(4);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(121, 33);
            this.btnIleri.TabIndex = 12;
            this.btnIleri.Text = "İleri";
            this.btnIleri.UseVisualStyleBackColor = false;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // lvLog
            // 
            this.lvLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvLog.ForeColor = System.Drawing.SystemColors.Window;
            this.lvLog.HideSelection = false;
            this.lvLog.Location = new System.Drawing.Point(0, 0);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(542, 352);
            this.lvLog.TabIndex = 0;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.List;
            // 
            // btnGeri
            // 
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeri.Location = new System.Drawing.Point(33, 359);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(121, 33);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTemizle.Location = new System.Drawing.Point(211, 358);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(121, 33);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.FlatAppearance.BorderSize = 0;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazdir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYazdir.Location = new System.Drawing.Point(393, 358);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(121, 33);
            this.btnYazdir.TabIndex = 3;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // FormTopla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 433);
            this.Controls.Add(this.tabToplam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTopla";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplama";
            this.Shown += new System.EventHandler(this.FormTopla_Shown);
            this.tabToplam.ResumeLayout(false);
            this.tabToplama.ResumeLayout(false);
            this.tabToplama.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabToplam;
        private System.Windows.Forms.TabPage tabToplama;
        private System.Windows.Forms.TextBox txtIkinciSayi;
        private System.Windows.Forms.Label lblIkinciSayi;
        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Label lblBirinciSayi;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.Button btnYazdir;
    }
}

