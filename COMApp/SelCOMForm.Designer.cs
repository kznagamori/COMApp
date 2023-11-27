namespace COMApp
{
    partial class SelCOMForm
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
            this._Port = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._BaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._DataBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._Parity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this._StopBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this._Handshake = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _Port
            // 
            this._Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._Port.FormattingEnabled = true;
            this._Port.Location = new System.Drawing.Point(85, 12);
            this._Port.Name = "_Port";
            this._Port.Size = new System.Drawing.Size(122, 20);
            this._Port.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 186);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(132, 186);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Cancel";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port";
            // 
            // _BaudRate
            // 
            this._BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._BaudRate.FormattingEnabled = true;
            this._BaudRate.Location = new System.Drawing.Point(85, 38);
            this._BaudRate.Name = "_BaudRate";
            this._BaudRate.Size = new System.Drawing.Size(122, 20);
            this._BaudRate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "BaudRate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "DataBits";
            // 
            // _DataBits
            // 
            this._DataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._DataBits.FormattingEnabled = true;
            this._DataBits.Location = new System.Drawing.Point(85, 64);
            this._DataBits.Name = "_DataBits";
            this._DataBits.Size = new System.Drawing.Size(122, 20);
            this._DataBits.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parity";
            // 
            // _Parity
            // 
            this._Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._Parity.FormattingEnabled = true;
            this._Parity.Location = new System.Drawing.Point(85, 90);
            this._Parity.Name = "_Parity";
            this._Parity.Size = new System.Drawing.Size(122, 20);
            this._Parity.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "StopBits";
            // 
            // _StopBits
            // 
            this._StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._StopBits.FormattingEnabled = true;
            this._StopBits.Location = new System.Drawing.Point(85, 116);
            this._StopBits.Name = "_StopBits";
            this._StopBits.Size = new System.Drawing.Size(122, 20);
            this._StopBits.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Handshake";
            // 
            // _Handshake
            // 
            this._Handshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._Handshake.FormattingEnabled = true;
            this._Handshake.Location = new System.Drawing.Point(85, 142);
            this._Handshake.Name = "_Handshake";
            this._Handshake.Size = new System.Drawing.Size(122, 20);
            this._Handshake.TabIndex = 10;
            // 
            // SelCOMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 221);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._Handshake);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._StopBits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._Parity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._DataBits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this._BaudRate);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this._Port);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SelCOMForm";
            this.Text = "COMポートの選択";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelCOMForm_FormClosing);
            this.Load += new System.EventHandler(this.SelCOMForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _Port;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _BaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _DataBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _Parity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _StopBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox _Handshake;
    }
}