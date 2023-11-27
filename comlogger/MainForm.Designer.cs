namespace COMLogger
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.接続1BOX = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.COM1_Flow = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.COM1_StopBits = new System.Windows.Forms.ComboBox();
            this.COM1_Open = new System.Windows.Forms.Button();
            this.COM1_DtrEnable = new System.Windows.Forms.CheckBox();
            this.COM1_RtsEnable = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.COM1_Parity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.COM1_DataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.COM1_BitRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.COM1_Port = new System.Windows.Forms.ComboBox();
            this.接続2Box = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.COM2_Flow = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.COM2_StopBits = new System.Windows.Forms.ComboBox();
            this.COM2_Open = new System.Windows.Forms.Button();
            this.COM2_DtrEnable = new System.Windows.Forms.CheckBox();
            this.COM2_RtsEnable = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.COM2_Parity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.COM2_DataBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.COM2_BitRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.COM2_Port = new System.Windows.Forms.ComboBox();
            this._SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this._SerialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.COM1TO2 = new System.Windows.Forms.CheckBox();
            this.COM2TO1 = new System.Windows.Forms.CheckBox();
            this._Timer0 = new System.Windows.Forms.Timer(this.components);
            this.AutoSave = new System.Windows.Forms.CheckBox();
            this.SaveFileName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this._SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveDialog_Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LogClear = new System.Windows.Forms.Button();
            this.ViewUpdate = new System.Windows.Forms.CheckBox();
            this.SendFileToCOM1 = new System.Windows.Forms.Button();
            this._OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SendFileToCOM2 = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.IsAscii = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.RetCode1 = new System.Windows.Forms.TextBox();
            this.RetEndPlus = new System.Windows.Forms.CheckBox();
            this._StatusBar = new System.Windows.Forms.StatusStrip();
            this._StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.RetCode2 = new System.Windows.Forms.TextBox();
            this.接続1BOX.SuspendLayout();
            this.接続2Box.SuspendLayout();
            this._StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // 接続1BOX
            // 
            this.接続1BOX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.接続1BOX.Controls.Add(this.label14);
            this.接続1BOX.Controls.Add(this.COM1_Flow);
            this.接続1BOX.Controls.Add(this.label9);
            this.接続1BOX.Controls.Add(this.COM1_StopBits);
            this.接続1BOX.Controls.Add(this.COM1_Open);
            this.接続1BOX.Controls.Add(this.COM1_DtrEnable);
            this.接続1BOX.Controls.Add(this.COM1_RtsEnable);
            this.接続1BOX.Controls.Add(this.label7);
            this.接続1BOX.Controls.Add(this.COM1_Parity);
            this.接続1BOX.Controls.Add(this.label5);
            this.接続1BOX.Controls.Add(this.COM1_DataBits);
            this.接続1BOX.Controls.Add(this.label3);
            this.接続1BOX.Controls.Add(this.COM1_BitRate);
            this.接続1BOX.Controls.Add(this.label1);
            this.接続1BOX.Controls.Add(this.COM1_Port);
            this.接続1BOX.Location = new System.Drawing.Point(10, 15);
            this.接続1BOX.Name = "接続1BOX";
            this.接続1BOX.Size = new System.Drawing.Size(500, 110);
            this.接続1BOX.TabIndex = 0;
            this.接続1BOX.TabStop = false;
            this.接続1BOX.Text = "接続1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(325, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 12);
            this.label14.TabIndex = 16;
            this.label14.Text = "フロー制御";
            // 
            // COM1_Flow
            // 
            this.COM1_Flow.FormattingEnabled = true;
            this.COM1_Flow.Location = new System.Drawing.Point(390, 50);
            this.COM1_Flow.Name = "COM1_Flow";
            this.COM1_Flow.Size = new System.Drawing.Size(91, 20);
            this.COM1_Flow.TabIndex = 13;
            this.COM1_Flow.SelectedIndexChanged += new System.EventHandler(this.COM1_Flow_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "StopBits";
            // 
            // COM1_StopBits
            // 
            this.COM1_StopBits.FormattingEnabled = true;
            this.COM1_StopBits.Location = new System.Drawing.Point(220, 50);
            this.COM1_StopBits.Name = "COM1_StopBits";
            this.COM1_StopBits.Size = new System.Drawing.Size(91, 20);
            this.COM1_StopBits.TabIndex = 11;
            this.COM1_StopBits.SelectedIndexChanged += new System.EventHandler(this.COM1_StopBits_SelectedIndexChanged);
            // 
            // COM1_Open
            // 
            this.COM1_Open.Location = new System.Drawing.Point(380, 80);
            this.COM1_Open.Name = "COM1_Open";
            this.COM1_Open.Size = new System.Drawing.Size(110, 25);
            this.COM1_Open.TabIndex = 10;
            this.COM1_Open.Text = "接続";
            this.COM1_Open.UseVisualStyleBackColor = true;
            this.COM1_Open.Click += new System.EventHandler(this.COM1_Open_Click);
            // 
            // COM1_DtrEnable
            // 
            this.COM1_DtrEnable.AutoSize = true;
            this.COM1_DtrEnable.Location = new System.Drawing.Point(110, 80);
            this.COM1_DtrEnable.Name = "COM1_DtrEnable";
            this.COM1_DtrEnable.Size = new System.Drawing.Size(74, 16);
            this.COM1_DtrEnable.TabIndex = 9;
            this.COM1_DtrEnable.Text = "DtrEnable";
            this.COM1_DtrEnable.UseVisualStyleBackColor = true;
            this.COM1_DtrEnable.CheckedChanged += new System.EventHandler(this.COM1_DtrEnable_CheckedChanged);
            // 
            // COM1_RtsEnable
            // 
            this.COM1_RtsEnable.AutoSize = true;
            this.COM1_RtsEnable.Location = new System.Drawing.Point(10, 80);
            this.COM1_RtsEnable.Name = "COM1_RtsEnable";
            this.COM1_RtsEnable.Size = new System.Drawing.Size(76, 16);
            this.COM1_RtsEnable.TabIndex = 8;
            this.COM1_RtsEnable.Text = "RtsEnable";
            this.COM1_RtsEnable.UseVisualStyleBackColor = true;
            this.COM1_RtsEnable.CheckedChanged += new System.EventHandler(this.COM1_RtsEnable_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "パリティ";
            // 
            // COM1_Parity
            // 
            this.COM1_Parity.FormattingEnabled = true;
            this.COM1_Parity.Location = new System.Drawing.Point(50, 50);
            this.COM1_Parity.Name = "COM1_Parity";
            this.COM1_Parity.Size = new System.Drawing.Size(91, 20);
            this.COM1_Parity.TabIndex = 6;
            this.COM1_Parity.SelectedIndexChanged += new System.EventHandler(this.COM1_Parity_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "DataBits";
            // 
            // COM1_DataBits
            // 
            this.COM1_DataBits.FormattingEnabled = true;
            this.COM1_DataBits.Location = new System.Drawing.Point(390, 20);
            this.COM1_DataBits.Name = "COM1_DataBits";
            this.COM1_DataBits.Size = new System.Drawing.Size(91, 20);
            this.COM1_DataBits.TabIndex = 4;
            this.COM1_DataBits.SelectedIndexChanged += new System.EventHandler(this.COM1_DataBits_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "通信速度";
            // 
            // COM1_BitRate
            // 
            this.COM1_BitRate.FormattingEnabled = true;
            this.COM1_BitRate.Location = new System.Drawing.Point(220, 20);
            this.COM1_BitRate.Name = "COM1_BitRate";
            this.COM1_BitRate.Size = new System.Drawing.Size(91, 20);
            this.COM1_BitRate.TabIndex = 2;
            this.COM1_BitRate.SelectedIndexChanged += new System.EventHandler(this.COM1_BitRate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM";
            // 
            // COM1_Port
            // 
            this.COM1_Port.FormattingEnabled = true;
            this.COM1_Port.Location = new System.Drawing.Point(50, 20);
            this.COM1_Port.Name = "COM1_Port";
            this.COM1_Port.Size = new System.Drawing.Size(91, 20);
            this.COM1_Port.TabIndex = 0;
            this.COM1_Port.SelectedIndexChanged += new System.EventHandler(this.COM1_comboBox_SelectedIndexChanged);
            // 
            // 接続2Box
            // 
            this.接続2Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.接続2Box.Controls.Add(this.label15);
            this.接続2Box.Controls.Add(this.COM2_Flow);
            this.接続2Box.Controls.Add(this.label10);
            this.接続2Box.Controls.Add(this.COM2_StopBits);
            this.接続2Box.Controls.Add(this.COM2_Open);
            this.接続2Box.Controls.Add(this.COM2_DtrEnable);
            this.接続2Box.Controls.Add(this.COM2_RtsEnable);
            this.接続2Box.Controls.Add(this.label8);
            this.接続2Box.Controls.Add(this.COM2_Parity);
            this.接続2Box.Controls.Add(this.label6);
            this.接続2Box.Controls.Add(this.COM2_DataBits);
            this.接続2Box.Controls.Add(this.label4);
            this.接続2Box.Controls.Add(this.COM2_BitRate);
            this.接続2Box.Controls.Add(this.label2);
            this.接続2Box.Controls.Add(this.COM2_Port);
            this.接続2Box.Location = new System.Drawing.Point(10, 135);
            this.接続2Box.Name = "接続2Box";
            this.接続2Box.Size = new System.Drawing.Size(500, 110);
            this.接続2Box.TabIndex = 1;
            this.接続2Box.TabStop = false;
            this.接続2Box.Text = "接続2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(325, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 12);
            this.label15.TabIndex = 17;
            this.label15.Text = "フロー制御";
            // 
            // COM2_Flow
            // 
            this.COM2_Flow.FormattingEnabled = true;
            this.COM2_Flow.Location = new System.Drawing.Point(390, 50);
            this.COM2_Flow.Name = "COM2_Flow";
            this.COM2_Flow.Size = new System.Drawing.Size(91, 20);
            this.COM2_Flow.TabIndex = 15;
            this.COM2_Flow.SelectedIndexChanged += new System.EventHandler(this.COM2_Flow_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "StopBits";
            // 
            // COM2_StopBits
            // 
            this.COM2_StopBits.FormattingEnabled = true;
            this.COM2_StopBits.Location = new System.Drawing.Point(220, 50);
            this.COM2_StopBits.Name = "COM2_StopBits";
            this.COM2_StopBits.Size = new System.Drawing.Size(91, 20);
            this.COM2_StopBits.TabIndex = 13;
            this.COM2_StopBits.SelectedIndexChanged += new System.EventHandler(this.COM2_StopBits_SelectedIndexChanged);
            // 
            // COM2_Open
            // 
            this.COM2_Open.Location = new System.Drawing.Point(380, 80);
            this.COM2_Open.Name = "COM2_Open";
            this.COM2_Open.Size = new System.Drawing.Size(110, 25);
            this.COM2_Open.TabIndex = 12;
            this.COM2_Open.Text = "接続";
            this.COM2_Open.UseVisualStyleBackColor = true;
            this.COM2_Open.Click += new System.EventHandler(this.COM2_Open_Click);
            // 
            // COM2_DtrEnable
            // 
            this.COM2_DtrEnable.AutoSize = true;
            this.COM2_DtrEnable.Location = new System.Drawing.Point(110, 80);
            this.COM2_DtrEnable.Name = "COM2_DtrEnable";
            this.COM2_DtrEnable.Size = new System.Drawing.Size(74, 16);
            this.COM2_DtrEnable.TabIndex = 11;
            this.COM2_DtrEnable.Text = "DtrEnable";
            this.COM2_DtrEnable.UseVisualStyleBackColor = true;
            this.COM2_DtrEnable.CheckStateChanged += new System.EventHandler(this.COM2_DtrEnable_CheckStateChanged);
            // 
            // COM2_RtsEnable
            // 
            this.COM2_RtsEnable.AutoSize = true;
            this.COM2_RtsEnable.Location = new System.Drawing.Point(10, 80);
            this.COM2_RtsEnable.Name = "COM2_RtsEnable";
            this.COM2_RtsEnable.Size = new System.Drawing.Size(76, 16);
            this.COM2_RtsEnable.TabIndex = 10;
            this.COM2_RtsEnable.Text = "RtsEnable";
            this.COM2_RtsEnable.UseVisualStyleBackColor = true;
            this.COM2_RtsEnable.CheckedChanged += new System.EventHandler(this.COM2_RtsEnable_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "パリティ";
            // 
            // COM2_Parity
            // 
            this.COM2_Parity.FormattingEnabled = true;
            this.COM2_Parity.Location = new System.Drawing.Point(50, 50);
            this.COM2_Parity.Name = "COM2_Parity";
            this.COM2_Parity.Size = new System.Drawing.Size(91, 20);
            this.COM2_Parity.TabIndex = 8;
            this.COM2_Parity.SelectedIndexChanged += new System.EventHandler(this.COM2_Parity_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "DataBits";
            // 
            // COM2_DataBits
            // 
            this.COM2_DataBits.FormattingEnabled = true;
            this.COM2_DataBits.Location = new System.Drawing.Point(390, 20);
            this.COM2_DataBits.Name = "COM2_DataBits";
            this.COM2_DataBits.Size = new System.Drawing.Size(91, 20);
            this.COM2_DataBits.TabIndex = 6;
            this.COM2_DataBits.SelectedIndexChanged += new System.EventHandler(this.COM2_DataBits_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "通信速度";
            // 
            // COM2_BitRate
            // 
            this.COM2_BitRate.FormattingEnabled = true;
            this.COM2_BitRate.Location = new System.Drawing.Point(220, 20);
            this.COM2_BitRate.Name = "COM2_BitRate";
            this.COM2_BitRate.Size = new System.Drawing.Size(91, 20);
            this.COM2_BitRate.TabIndex = 4;
            this.COM2_BitRate.SelectedIndexChanged += new System.EventHandler(this.COM2_BitRate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "COM";
            // 
            // COM2_Port
            // 
            this.COM2_Port.FormattingEnabled = true;
            this.COM2_Port.Location = new System.Drawing.Point(50, 20);
            this.COM2_Port.Name = "COM2_Port";
            this.COM2_Port.Size = new System.Drawing.Size(91, 20);
            this.COM2_Port.TabIndex = 2;
            this.COM2_Port.SelectedIndexChanged += new System.EventHandler(this.COM2_Port_SelectedIndexChanged);
            // 
            // _SerialPort1
            // 
            this._SerialPort1.WriteTimeout = 1000;
            this._SerialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this._SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // _SerialPort2
            // 
            this._SerialPort2.WriteTimeout = 1000;
            this._SerialPort2.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort2_ErrorReceived);
            this._SerialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // COM1TO2
            // 
            this.COM1TO2.AutoSize = true;
            this.COM1TO2.Location = new System.Drawing.Point(15, 265);
            this.COM1TO2.Name = "COM1TO2";
            this.COM1TO2.Size = new System.Drawing.Size(112, 16);
            this.COM1TO2.TabIndex = 3;
            this.COM1TO2.Text = "接続1から2へ送信";
            this.COM1TO2.UseVisualStyleBackColor = true;
            this.COM1TO2.CheckedChanged += new System.EventHandler(this.COM1TO2_CheckedChanged);
            // 
            // COM2TO1
            // 
            this.COM2TO1.AutoSize = true;
            this.COM2TO1.Location = new System.Drawing.Point(150, 265);
            this.COM2TO1.Name = "COM2TO1";
            this.COM2TO1.Size = new System.Drawing.Size(112, 16);
            this.COM2TO1.TabIndex = 4;
            this.COM2TO1.Text = "接続2から1へ送信";
            this.COM2TO1.UseVisualStyleBackColor = true;
            this.COM2TO1.CheckedChanged += new System.EventHandler(this.COM2TO1_CheckedChanged);
            // 
            // _Timer0
            // 
            this._Timer0.Interval = 500;
            this._Timer0.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AutoSave
            // 
            this.AutoSave.AutoSize = true;
            this.AutoSave.Location = new System.Drawing.Point(15, 300);
            this.AutoSave.Name = "AutoSave";
            this.AutoSave.Size = new System.Drawing.Size(72, 16);
            this.AutoSave.TabIndex = 5;
            this.AutoSave.Text = "自動保存";
            this.AutoSave.UseVisualStyleBackColor = true;
            this.AutoSave.CheckedChanged += new System.EventHandler(this.AutoSave_CheckedChanged);
            // 
            // SaveFileName
            // 
            this.SaveFileName.Location = new System.Drawing.Point(160, 300);
            this.SaveFileName.Name = "SaveFileName";
            this.SaveFileName.Size = new System.Drawing.Size(240, 19);
            this.SaveFileName.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(105, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "ファイル名";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _SaveFileDialog
            // 
            this._SaveFileDialog.DefaultExt = "cvs";
            this._SaveFileDialog.Filter = "CSVファイル(*.csv) |*.csv";
            this._SaveFileDialog.Title = "ログファイルの指定";
            // 
            // SaveDialog_Open
            // 
            this.SaveDialog_Open.Location = new System.Drawing.Point(405, 300);
            this.SaveDialog_Open.Name = "SaveDialog_Open";
            this.SaveDialog_Open.Size = new System.Drawing.Size(30, 20);
            this.SaveDialog_Open.TabIndex = 8;
            this.SaveDialog_Open.Text = "...";
            this.SaveDialog_Open.UseVisualStyleBackColor = true;
            this.SaveDialog_Open.Click += new System.EventHandler(this.SaveDialog_Open_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(440, 300);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(65, 20);
            this.Save.TabIndex = 9;
            this.Save.Text = "保存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(10, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(500, 2);
            this.label12.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(10, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(500, 2);
            this.label13.TabIndex = 11;
            // 
            // LogClear
            // 
            this.LogClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogClear.Location = new System.Drawing.Point(430, 515);
            this.LogClear.Name = "LogClear";
            this.LogClear.Size = new System.Drawing.Size(75, 23);
            this.LogClear.TabIndex = 12;
            this.LogClear.Text = "クリア";
            this.LogClear.UseVisualStyleBackColor = true;
            this.LogClear.Click += new System.EventHandler(this.LogClear_Click);
            // 
            // ViewUpdate
            // 
            this.ViewUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ViewUpdate.AutoSize = true;
            this.ViewUpdate.Location = new System.Drawing.Point(5, 520);
            this.ViewUpdate.Name = "ViewUpdate";
            this.ViewUpdate.Size = new System.Drawing.Size(81, 16);
            this.ViewUpdate.TabIndex = 13;
            this.ViewUpdate.Text = "更新を停止";
            this.ViewUpdate.UseVisualStyleBackColor = true;
            // 
            // SendFileToCOM1
            // 
            this.SendFileToCOM1.Location = new System.Drawing.Point(275, 263);
            this.SendFileToCOM1.Name = "SendFileToCOM1";
            this.SendFileToCOM1.Size = new System.Drawing.Size(111, 20);
            this.SendFileToCOM1.TabIndex = 14;
            this.SendFileToCOM1.Text = "COM1にファイル送信";
            this.SendFileToCOM1.UseVisualStyleBackColor = true;
            this.SendFileToCOM1.Click += new System.EventHandler(this.SendFileToCOM1_Click);
            // 
            // _OpenFileDialog
            // 
            this._OpenFileDialog.FileName = "1";
            // 
            // SendFileToCOM2
            // 
            this.SendFileToCOM2.Location = new System.Drawing.Point(396, 263);
            this.SendFileToCOM2.Name = "SendFileToCOM2";
            this.SendFileToCOM2.Size = new System.Drawing.Size(111, 20);
            this.SendFileToCOM2.TabIndex = 15;
            this.SendFileToCOM2.Text = "COM2にファイル送信";
            this.SendFileToCOM2.UseVisualStyleBackColor = true;
            this.SendFileToCOM2.Click += new System.EventHandler(this.SendFileToCOM2_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTextBox.Location = new System.Drawing.Point(15, 323);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTextBox.Size = new System.Drawing.Size(491, 186);
            this.LogTextBox.TabIndex = 16;
            // 
            // IsAscii
            // 
            this.IsAscii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IsAscii.AutoSize = true;
            this.IsAscii.Location = new System.Drawing.Point(86, 520);
            this.IsAscii.Name = "IsAscii";
            this.IsAscii.Size = new System.Drawing.Size(65, 16);
            this.IsAscii.TabIndex = 13;
            this.IsAscii.Text = "ASCII化";
            this.IsAscii.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(148, 523);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 12);
            this.label16.TabIndex = 17;
            this.label16.Text = "改行コード1";
            // 
            // RetCode1
            // 
            this.RetCode1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RetCode1.Location = new System.Drawing.Point(207, 519);
            this.RetCode1.Name = "RetCode1";
            this.RetCode1.Size = new System.Drawing.Size(34, 19);
            this.RetCode1.TabIndex = 18;
            this.RetCode1.Text = "03";
            this.RetCode1.TextChanged += new System.EventHandler(this.RetCode_TextChanged);
            // 
            // RetEndPlus
            // 
            this.RetEndPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RetEndPlus.AutoSize = true;
            this.RetEndPlus.Checked = true;
            this.RetEndPlus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RetEndPlus.Location = new System.Drawing.Point(354, 523);
            this.RetEndPlus.Name = "RetEndPlus";
            this.RetEndPlus.Size = new System.Drawing.Size(70, 16);
            this.RetEndPlus.TabIndex = 19;
            this.RetEndPlus.Text = "+1で改行";
            this.RetEndPlus.UseVisualStyleBackColor = true;
            this.RetEndPlus.CheckedChanged += new System.EventHandler(this.RetEndPlus_CheckedChanged);
            // 
            // _StatusBar
            // 
            this._StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._StatusLabel});
            this._StatusBar.Location = new System.Drawing.Point(0, 540);
            this._StatusBar.Name = "_StatusBar";
            this._StatusBar.Size = new System.Drawing.Size(518, 22);
            this._StatusBar.TabIndex = 20;
            this._StatusBar.Text = "statusStrip1";
            // 
            // _StatusLabel
            // 
            this._StatusLabel.Name = "_StatusLabel";
            this._StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(247, 523);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 12);
            this.label17.TabIndex = 17;
            this.label17.Text = "改行コード2";
            // 
            // RetCode2
            // 
            this.RetCode2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RetCode2.Location = new System.Drawing.Point(308, 519);
            this.RetCode2.Name = "RetCode2";
            this.RetCode2.Size = new System.Drawing.Size(34, 19);
            this.RetCode2.TabIndex = 18;
            this.RetCode2.Text = "03";
            this.RetCode2.TextChanged += new System.EventHandler(this.RetCode_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 562);
            this.Controls.Add(this._StatusBar);
            this.Controls.Add(this.RetEndPlus);
            this.Controls.Add(this.RetCode2);
            this.Controls.Add(this.RetCode1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.SendFileToCOM2);
            this.Controls.Add(this.SendFileToCOM1);
            this.Controls.Add(this.IsAscii);
            this.Controls.Add(this.ViewUpdate);
            this.Controls.Add(this.LogClear);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.SaveDialog_Open);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SaveFileName);
            this.Controls.Add(this.AutoSave);
            this.Controls.Add(this.COM2TO1);
            this.Controls.Add(this.COM1TO2);
            this.Controls.Add(this.接続2Box);
            this.Controls.Add(this.接続1BOX);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "COM Logger";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.接続1BOX.ResumeLayout(false);
            this.接続1BOX.PerformLayout();
            this.接続2Box.ResumeLayout(false);
            this.接続2Box.PerformLayout();
            this._StatusBar.ResumeLayout(false);
            this._StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox 接続1BOX;
		private System.Windows.Forms.GroupBox 接続2Box;
		private System.IO.Ports.SerialPort _SerialPort1;
		private System.IO.Ports.SerialPort _SerialPort2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox COM1_Port;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox COM2_Port;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox COM1_BitRate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox COM2_BitRate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox COM1_DataBits;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox COM2_DataBits;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox COM1_Parity;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox COM2_Parity;
		private System.Windows.Forms.CheckBox COM1_RtsEnable;
		private System.Windows.Forms.CheckBox COM1_DtrEnable;
		private System.Windows.Forms.CheckBox COM2_DtrEnable;
		private System.Windows.Forms.CheckBox COM2_RtsEnable;
		private System.Windows.Forms.Button COM1_Open;
		private System.Windows.Forms.Button COM2_Open;
		private System.Windows.Forms.CheckBox COM1TO2;
		private System.Windows.Forms.CheckBox COM2TO1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox COM1_StopBits;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox COM2_StopBits;
		private System.Windows.Forms.Timer _Timer0;
		private System.Windows.Forms.CheckBox AutoSave;
		private System.Windows.Forms.TextBox SaveFileName;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.SaveFileDialog _SaveFileDialog;
		private System.Windows.Forms.Button SaveDialog_Open;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button LogClear;
		private System.Windows.Forms.ComboBox COM1_Flow;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox COM2_Flow;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.CheckBox ViewUpdate;
        private System.Windows.Forms.Button SendFileToCOM1;
        private System.Windows.Forms.OpenFileDialog _OpenFileDialog;
        private System.Windows.Forms.Button SendFileToCOM2;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.CheckBox IsAscii;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox RetCode1;
        private System.Windows.Forms.CheckBox RetEndPlus;
        private System.Windows.Forms.StatusStrip _StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel _StatusLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox RetCode2;
    }
}

