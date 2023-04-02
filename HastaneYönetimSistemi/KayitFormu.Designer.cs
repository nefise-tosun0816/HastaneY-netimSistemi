namespace HastaneYönetimSistemi
{
    partial class KayitFormu
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
            this.kayitOlButton = new System.Windows.Forms.Button();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxTCKimlik = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kayitOlButton
            // 
            this.kayitOlButton.Location = new System.Drawing.Point(136, 318);
            this.kayitOlButton.Name = "kayitOlButton";
            this.kayitOlButton.Size = new System.Drawing.Size(83, 26);
            this.kayitOlButton.TabIndex = 0;
            this.kayitOlButton.Text = "KAYIT OL";
            this.kayitOlButton.UseVisualStyleBackColor = true;
            this.kayitOlButton.Click += new System.EventHandler(this.kayitOlButton_Click);
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(525, 95);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(141, 22);
            this.adTextBox.TabIndex = 1;
            this.adTextBox.Enter += new System.EventHandler(this.adTextBox_Enter);
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(107, 153);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(141, 22);
            this.soyadTextBox.TabIndex = 2;
            this.soyadTextBox.Enter += new System.EventHandler(this.soyadTextBox_Enter);
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(107, 256);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(141, 22);
            this.sifreTextBox.TabIndex = 3;
            this.sifreTextBox.Enter += new System.EventHandler(this.sifreTextBox_Enter);
            this.sifreTextBox.Leave += new System.EventHandler(this.sifreTextBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 449);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.textBoxTCKimlik);
            this.panel2.Controls.Add(this.soyadTextBox);
            this.panel2.Controls.Add(this.sifreTextBox);
            this.panel2.Controls.Add(this.kayitOlButton);
            this.panel2.Location = new System.Drawing.Point(418, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 449);
            this.panel2.TabIndex = 5;
            // 
            // textBoxTCKimlik
            // 
            this.textBoxTCKimlik.Location = new System.Drawing.Point(107, 203);
            this.textBoxTCKimlik.Name = "textBoxTCKimlik";
            this.textBoxTCKimlik.Size = new System.Drawing.Size(141, 22);
            this.textBoxTCKimlik.TabIndex = 1;
            this.textBoxTCKimlik.TextChanged += new System.EventHandler(this.textBoxTCKimlik_TextChanged);
            // 
            // KayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.panel2);
            this.Name = "KayitFormu";
            this.Text = "KayitFormu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kayitOlButton;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxTCKimlik;
    }
}