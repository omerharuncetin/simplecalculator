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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabToplama = new System.Windows.Forms.TabPage();
            this.txtIkinciSayi = new System.Windows.Forms.TextBox();
            this.lblIkinciSayi = new System.Windows.Forms.Label();
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.lblBirinciSayi = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabToplama.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabToplama);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // tabToplama
            // 
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
            this.tabToplama.Size = new System.Drawing.Size(638, 400);
            this.tabToplama.TabIndex = 0;
            this.tabToplama.Text = "Toplama";
            this.tabToplama.UseVisualStyleBackColor = true;
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
            this.btnTopla.Location = new System.Drawing.Point(179, 182);
            this.btnTopla.Margin = new System.Windows.Forms.Padding(4);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(205, 40);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // lblBirinciSayi
            // 
            this.lblBirinciSayi.AutoSize = true;
            this.lblBirinciSayi.Location = new System.Drawing.Point(34, 54);
            this.lblBirinciSayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirinciSayi.Name = "lblBirinciSayi";
            this.lblBirinciSayi.Size = new System.Drawing.Size(94, 20);
            this.lblBirinciSayi.TabIndex = 5;
            this.lblBirinciSayi.Text = "Birinci Sayı";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(147, 290);
            this.txtSonuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(284, 27);
            this.txtSonuc.TabIndex = 11;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(67, 293);
            this.lblSonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(61, 20);
            this.lblSonuc.TabIndex = 10;
            this.lblSonuc.Text = "Sonuç:";
            // 
            // FormTopla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 433);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTopla";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplama";
            this.Shown += new System.EventHandler(this.FormTopla_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabToplama.ResumeLayout(false);
            this.tabToplama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabToplama;
        private System.Windows.Forms.TextBox txtIkinciSayi;
        private System.Windows.Forms.Label lblIkinciSayi;
        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Label lblBirinciSayi;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label lblSonuc;
    }
}

