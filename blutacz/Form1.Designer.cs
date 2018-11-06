namespace blutacz
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
            this.adapterBox = new System.Windows.Forms.ListBox();
            this.macAdressLabel = new System.Windows.Forms.Label();
            this.AdresMAC = new System.Windows.Forms.Label();
            this.szukajAdaptBt = new System.Windows.Forms.Button();
            this.wybierzBt = new System.Windows.Forms.Button();
            this.deviceBox = new System.Windows.Forms.ListBox();
            this.szukajUrzBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adapterBox
            // 
            this.adapterBox.FormattingEnabled = true;
            this.adapterBox.ItemHeight = 16;
            this.adapterBox.Location = new System.Drawing.Point(175, 23);
            this.adapterBox.Name = "adapterBox";
            this.adapterBox.Size = new System.Drawing.Size(258, 84);
            this.adapterBox.TabIndex = 0;
            // 
            // macAdressLabel
            // 
            this.macAdressLabel.AutoSize = true;
            this.macAdressLabel.Location = new System.Drawing.Point(314, 221);
            this.macAdressLabel.Name = "macAdressLabel";
            this.macAdressLabel.Size = new System.Drawing.Size(0, 17);
            this.macAdressLabel.TabIndex = 1;
            // 
            // AdresMAC
            // 
            this.AdresMAC.AutoSize = true;
            this.AdresMAC.Location = new System.Drawing.Point(214, 221);
            this.AdresMAC.Name = "AdresMAC";
            this.AdresMAC.Size = new System.Drawing.Size(82, 17);
            this.AdresMAC.TabIndex = 2;
            this.AdresMAC.Text = "Adres MAC:";
            // 
            // szukajAdaptBt
            // 
            this.szukajAdaptBt.Location = new System.Drawing.Point(175, 272);
            this.szukajAdaptBt.Name = "szukajAdaptBt";
            this.szukajAdaptBt.Size = new System.Drawing.Size(258, 53);
            this.szukajAdaptBt.TabIndex = 3;
            this.szukajAdaptBt.Text = "Szukaj adapter";
            this.szukajAdaptBt.UseVisualStyleBackColor = true;
            this.szukajAdaptBt.Click += new System.EventHandler(this.szukajAdaptBt_Click);
            // 
            // wybierzBt
            // 
            this.wybierzBt.Location = new System.Drawing.Point(175, 390);
            this.wybierzBt.Name = "wybierzBt";
            this.wybierzBt.Size = new System.Drawing.Size(258, 53);
            this.wybierzBt.TabIndex = 4;
            this.wybierzBt.Text = "Wybierz";
            this.wybierzBt.UseVisualStyleBackColor = true;
            this.wybierzBt.Click += new System.EventHandler(this.wybierzBt_Click);
            // 
            // deviceBox
            // 
            this.deviceBox.FormattingEnabled = true;
            this.deviceBox.ItemHeight = 16;
            this.deviceBox.Location = new System.Drawing.Point(175, 109);
            this.deviceBox.Name = "deviceBox";
            this.deviceBox.Size = new System.Drawing.Size(258, 84);
            this.deviceBox.TabIndex = 5;
            this.deviceBox.SelectedIndexChanged += new System.EventHandler(this.deviceBox_SelectedIndexChanged);
            // 
            // szukajUrzBt
            // 
            this.szukajUrzBt.Location = new System.Drawing.Point(175, 331);
            this.szukajUrzBt.Name = "szukajUrzBt";
            this.szukajUrzBt.Size = new System.Drawing.Size(258, 53);
            this.szukajUrzBt.TabIndex = 6;
            this.szukajUrzBt.Text = "Szukaj urządzenie";
            this.szukajUrzBt.UseVisualStyleBackColor = true;
            this.szukajUrzBt.Click += new System.EventHandler(this.szukajUrzBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 455);
            this.Controls.Add(this.szukajUrzBt);
            this.Controls.Add(this.deviceBox);
            this.Controls.Add(this.wybierzBt);
            this.Controls.Add(this.szukajAdaptBt);
            this.Controls.Add(this.AdresMAC);
            this.Controls.Add(this.macAdressLabel);
            this.Controls.Add(this.adapterBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox adapterBox;
        private System.Windows.Forms.Label macAdressLabel;
        private System.Windows.Forms.Label AdresMAC;
        private System.Windows.Forms.Button szukajAdaptBt;
        private System.Windows.Forms.Button wybierzBt;
        private System.Windows.Forms.ListBox deviceBox;
        private System.Windows.Forms.Button szukajUrzBt;
    }
}

