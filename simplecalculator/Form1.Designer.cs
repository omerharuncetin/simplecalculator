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
            this.lblBirinciSayi = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.txtIkinciSayi = new System.Windows.Forms.TextBox();
            this.lblIkinciSayi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBirinciSayi
            // 
            this.lblBirinciSayi.AutoSize = true;
            this.lblBirinciSayi.Location = new System.Drawing.Point(15, 49);
            this.lblBirinciSayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirinciSayi.Name = "lblBirinciSayi";
            this.lblBirinciSayi.Size = new System.Drawing.Size(94, 20);
            this.lblBirinciSayi.TabIndex = 0;
            this.lblBirinciSayi.Text = "Birinci Sayı";
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(302, 164);
            this.btnTopla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(109, 40);
            this.btnTopla.TabIndex = 1;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // txtBirinciSayi
            // 
            this.txtBirinciSayi.Location = new System.Drawing.Point(126, 49);
            this.txtBirinciSayi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            this.txtBirinciSayi.Size = new System.Drawing.Size(284, 27);
            this.txtBirinciSayi.TabIndex = 2;
            // 
            // txtIkinciSayi
            // 
            this.txtIkinciSayi.Location = new System.Drawing.Point(126, 100);
            this.txtIkinciSayi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIkinciSayi.Name = "txtIkinciSayi";
            this.txtIkinciSayi.Size = new System.Drawing.Size(284, 27);
            this.txtIkinciSayi.TabIndex = 4;
            // 
            // lblIkinciSayi
            // 
            this.lblIkinciSayi.AutoSize = true;
            this.lblIkinciSayi.Location = new System.Drawing.Point(15, 100);
            this.lblIkinciSayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIkinciSayi.Name = "lblIkinciSayi";
            this.lblIkinciSayi.Size = new System.Drawing.Size(84, 20);
            this.lblIkinciSayi.TabIndex = 3;
            this.lblIkinciSayi.Text = "İkinci Sayı";
            // 
            // FormTopla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 300);
            this.Controls.Add(this.txtIkinciSayi);
            this.Controls.Add(this.lblIkinciSayi);
            this.Controls.Add(this.txtBirinciSayi);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.lblBirinciSayi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTopla";
            this.ShowIcon = false;
            this.Text = "Toplama";
            this.Shown += new System.EventHandler(this.FormTopla_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBirinciSayi;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.TextBox txtIkinciSayi;
        private System.Windows.Forms.Label lblIkinciSayi;
    }
}

