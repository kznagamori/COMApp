namespace COMApp
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this._SerialPort = new System.IO.Ports.SerialPort(this.components);
            this._ComSetting = new System.Windows.Forms.Button();
            this._Connect = new System.Windows.Forms.CheckBox();
            this._SendData = new System.Windows.Forms.TextBox();
            this._ReceiveData = new System.Windows.Forms.TextBox();
            this._ClearSend = new System.Windows.Forms.Button();
            this._ClearReceive = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._DoReceiveAscii = new System.Windows.Forms.CheckBox();
            this._RetEndPlus = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this._LineRetCode = new System.Windows.Forms.TextBox();
            this._Group0 = new System.Windows.Forms.GroupBox();
            this._DataClear0 = new System.Windows.Forms.Button();
            this._Send0 = new System.Windows.Forms.Button();
            this._CmdAscii0 = new System.Windows.Forms.CheckBox();
            this._HeadAscii0 = new System.Windows.Forms.CheckBox();
            this._Data0 = new System.Windows.Forms.TextBox();
            this._Cmd0 = new System.Windows.Forms.TextBox();
            this._Head0 = new System.Windows.Forms.TextBox();
            this._DataLen0 = new System.Windows.Forms.TextBox();
            this._HasData0 = new System.Windows.Forms.CheckBox();
            this._BCC0 = new System.Windows.Forms.TextBox();
            this._ETX0 = new System.Windows.Forms.TextBox();
            this._STX0 = new System.Windows.Forms.TextBox();
            this._HasCmd0 = new System.Windows.Forms.CheckBox();
            this._HasBCC0 = new System.Windows.Forms.CheckBox();
            this._HasDataLen0 = new System.Windows.Forms.CheckBox();
            this._HasETX0 = new System.Windows.Forms.CheckBox();
            this._HasHead0 = new System.Windows.Forms.CheckBox();
            this._HasSTX0 = new System.Windows.Forms.CheckBox();
            this.Group7 = new System.Windows.Forms.GroupBox();
            this._SendF = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._DoResponse = new System.Windows.Forms.RadioButton();
            this._DoAutoInterval = new System.Windows.Forms.RadioButton();
            this._ResponseCode = new System.Windows.Forms.TextBox();
            this._AutoCmdID = new System.Windows.Forms.TextBox();
            this._HasAutoCmd = new System.Windows.Forms.CheckBox();
            this._AutoInterval = new System.Windows.Forms.TextBox();
            this._StartAutoSendF = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._TotalLine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._NextLine = new System.Windows.Forms.TextBox();
            this._IsSendLine = new System.Windows.Forms.CheckBox();
            this._OpenDataF = new System.Windows.Forms.Button();
            this._DataF = new System.Windows.Forms.TextBox();
            this._CmdAsciiF = new System.Windows.Forms.CheckBox();
            this._HeadAsciiF = new System.Windows.Forms.CheckBox();
            this._CmdF = new System.Windows.Forms.TextBox();
            this._HeadF = new System.Windows.Forms.TextBox();
            this._DataLenF = new System.Windows.Forms.TextBox();
            this._BCCF = new System.Windows.Forms.TextBox();
            this._ETXF = new System.Windows.Forms.TextBox();
            this._STXF = new System.Windows.Forms.TextBox();
            this._HasCmdF = new System.Windows.Forms.CheckBox();
            this._HasBCCF = new System.Windows.Forms.CheckBox();
            this._HasDataLenF = new System.Windows.Forms.CheckBox();
            this._HasETXF = new System.Windows.Forms.CheckBox();
            this._HasHeadF = new System.Windows.Forms.CheckBox();
            this._HasSTXF = new System.Windows.Forms.CheckBox();
            this._DoSendAscii = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._Interval = new System.Windows.Forms.TextBox();
            this._IntervalCmdID = new System.Windows.Forms.TextBox();
            this._StartInterval = new System.Windows.Forms.CheckBox();
            this._Group1 = new System.Windows.Forms.GroupBox();
            this._DataClear1 = new System.Windows.Forms.Button();
            this._Send1 = new System.Windows.Forms.Button();
            this._CmdAscii1 = new System.Windows.Forms.CheckBox();
            this._HeadAscii1 = new System.Windows.Forms.CheckBox();
            this._Data1 = new System.Windows.Forms.TextBox();
            this._Cmd1 = new System.Windows.Forms.TextBox();
            this._Head1 = new System.Windows.Forms.TextBox();
            this._DataLen1 = new System.Windows.Forms.TextBox();
            this._HasData1 = new System.Windows.Forms.CheckBox();
            this._BCC1 = new System.Windows.Forms.TextBox();
            this._ETX1 = new System.Windows.Forms.TextBox();
            this._STX1 = new System.Windows.Forms.TextBox();
            this._HasCmd1 = new System.Windows.Forms.CheckBox();
            this._HasBCC1 = new System.Windows.Forms.CheckBox();
            this._HasDataLen1 = new System.Windows.Forms.CheckBox();
            this._HasETX1 = new System.Windows.Forms.CheckBox();
            this._HasHead1 = new System.Windows.Forms.CheckBox();
            this._HasSTX1 = new System.Windows.Forms.CheckBox();
            this._Group2 = new System.Windows.Forms.GroupBox();
            this._DataClear2 = new System.Windows.Forms.Button();
            this._Send2 = new System.Windows.Forms.Button();
            this._CmdAscii2 = new System.Windows.Forms.CheckBox();
            this._HeadAscii2 = new System.Windows.Forms.CheckBox();
            this._Data2 = new System.Windows.Forms.TextBox();
            this._Cmd2 = new System.Windows.Forms.TextBox();
            this._Head2 = new System.Windows.Forms.TextBox();
            this._DataLen2 = new System.Windows.Forms.TextBox();
            this._HasData2 = new System.Windows.Forms.CheckBox();
            this._BCC2 = new System.Windows.Forms.TextBox();
            this._ETX2 = new System.Windows.Forms.TextBox();
            this._STX2 = new System.Windows.Forms.TextBox();
            this._HasCmd2 = new System.Windows.Forms.CheckBox();
            this._HasBCC2 = new System.Windows.Forms.CheckBox();
            this._HasDataLen2 = new System.Windows.Forms.CheckBox();
            this._HasETX2 = new System.Windows.Forms.CheckBox();
            this._HasHead2 = new System.Windows.Forms.CheckBox();
            this._HasSTX2 = new System.Windows.Forms.CheckBox();
            this._Group3 = new System.Windows.Forms.GroupBox();
            this._DataClear3 = new System.Windows.Forms.Button();
            this._Send3 = new System.Windows.Forms.Button();
            this._CmdAscii3 = new System.Windows.Forms.CheckBox();
            this._HeadAscii3 = new System.Windows.Forms.CheckBox();
            this._Data3 = new System.Windows.Forms.TextBox();
            this._Cmd3 = new System.Windows.Forms.TextBox();
            this._Head3 = new System.Windows.Forms.TextBox();
            this._DataLen3 = new System.Windows.Forms.TextBox();
            this._HasData3 = new System.Windows.Forms.CheckBox();
            this._BCC3 = new System.Windows.Forms.TextBox();
            this._ETX3 = new System.Windows.Forms.TextBox();
            this._STX3 = new System.Windows.Forms.TextBox();
            this._HasCmd3 = new System.Windows.Forms.CheckBox();
            this._HasBCC3 = new System.Windows.Forms.CheckBox();
            this._HasDataLen3 = new System.Windows.Forms.CheckBox();
            this._HasETX3 = new System.Windows.Forms.CheckBox();
            this._HasHead3 = new System.Windows.Forms.CheckBox();
            this._HasSTX3 = new System.Windows.Forms.CheckBox();
            this._Group4 = new System.Windows.Forms.GroupBox();
            this._DataClear4 = new System.Windows.Forms.Button();
            this._Send4 = new System.Windows.Forms.Button();
            this._CmdAscii4 = new System.Windows.Forms.CheckBox();
            this._HeadAscii4 = new System.Windows.Forms.CheckBox();
            this._Data4 = new System.Windows.Forms.TextBox();
            this._Cmd4 = new System.Windows.Forms.TextBox();
            this._Head4 = new System.Windows.Forms.TextBox();
            this._DataLen4 = new System.Windows.Forms.TextBox();
            this._HasData4 = new System.Windows.Forms.CheckBox();
            this._BCC4 = new System.Windows.Forms.TextBox();
            this._ETX4 = new System.Windows.Forms.TextBox();
            this._STX4 = new System.Windows.Forms.TextBox();
            this._HasCmd4 = new System.Windows.Forms.CheckBox();
            this._HasBCC4 = new System.Windows.Forms.CheckBox();
            this._HasDataLen4 = new System.Windows.Forms.CheckBox();
            this._HasETX4 = new System.Windows.Forms.CheckBox();
            this._HasHead4 = new System.Windows.Forms.CheckBox();
            this._HasSTX4 = new System.Windows.Forms.CheckBox();
            this._Group5 = new System.Windows.Forms.GroupBox();
            this._DataClear5 = new System.Windows.Forms.Button();
            this._Send5 = new System.Windows.Forms.Button();
            this._CmdAscii5 = new System.Windows.Forms.CheckBox();
            this._HeadAscii5 = new System.Windows.Forms.CheckBox();
            this._Data5 = new System.Windows.Forms.TextBox();
            this._Cmd5 = new System.Windows.Forms.TextBox();
            this._Head5 = new System.Windows.Forms.TextBox();
            this._DataLen5 = new System.Windows.Forms.TextBox();
            this._HasData5 = new System.Windows.Forms.CheckBox();
            this._BCC5 = new System.Windows.Forms.TextBox();
            this._ETX5 = new System.Windows.Forms.TextBox();
            this._STX5 = new System.Windows.Forms.TextBox();
            this._HasCmd5 = new System.Windows.Forms.CheckBox();
            this._HasBCC5 = new System.Windows.Forms.CheckBox();
            this._HasDataLen5 = new System.Windows.Forms.CheckBox();
            this._HasETX5 = new System.Windows.Forms.CheckBox();
            this._HasHead5 = new System.Windows.Forms.CheckBox();
            this._HasSTX5 = new System.Windows.Forms.CheckBox();
            this._Group6 = new System.Windows.Forms.GroupBox();
            this._DataClear6 = new System.Windows.Forms.Button();
            this._Send6 = new System.Windows.Forms.Button();
            this._IsAscii6 = new System.Windows.Forms.CheckBox();
            this._Data6 = new System.Windows.Forms.TextBox();
            this._BCC6 = new System.Windows.Forms.TextBox();
            this._ETX6 = new System.Windows.Forms.TextBox();
            this._STX6 = new System.Windows.Forms.TextBox();
            this._HasBCC6 = new System.Windows.Forms.CheckBox();
            this._HasETX6 = new System.Windows.Forms.CheckBox();
            this._HasSTX6 = new System.Windows.Forms.CheckBox();
            this._OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this._BCCCalcSum = new System.Windows.Forms.RadioButton();
            this._BCCCalcXOR = new System.Windows.Forms.RadioButton();
            this._BCCIncETX = new System.Windows.Forms.CheckBox();
            this._BCCIncSTX = new System.Windows.Forms.CheckBox();
            this._IntervalTimer = new System.Windows.Forms.Timer(this.components);
            this._AutoTimer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this._StatusBar = new System.Windows.Forms.StatusStrip();
            this._StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this._Group0.SuspendLayout();
            this.Group7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this._Group1.SuspendLayout();
            this._Group2.SuspendLayout();
            this._Group3.SuspendLayout();
            this._Group4.SuspendLayout();
            this._Group5.SuspendLayout();
            this._Group6.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this._StatusBar.SuspendLayout();
            this._MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _SerialPort
            // 
            this._SerialPort.WriteTimeout = 1000;
            this._SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this._SerialPort_DataReceived);
            // 
            // _ComSetting
            // 
            this._ComSetting.Location = new System.Drawing.Point(13, 40);
            this._ComSetting.Name = "_ComSetting";
            this._ComSetting.Size = new System.Drawing.Size(75, 51);
            this._ComSetting.TabIndex = 0;
            this._ComSetting.Text = "COM設定";
            this._ComSetting.UseVisualStyleBackColor = true;
            this._ComSetting.Click += new System.EventHandler(this._ComSetting_Click);
            // 
            // _Connect
            // 
            this._Connect.AutoSize = true;
            this._Connect.Location = new System.Drawing.Point(94, 75);
            this._Connect.Name = "_Connect";
            this._Connect.Size = new System.Drawing.Size(48, 16);
            this._Connect.TabIndex = 1;
            this._Connect.Text = "接続";
            this._Connect.UseVisualStyleBackColor = true;
            this._Connect.CheckedChanged += new System.EventHandler(this._Connect_CheckedChanged);
            // 
            // _SendData
            // 
            this._SendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._SendData.Location = new System.Drawing.Point(596, 104);
            this._SendData.Multiline = true;
            this._SendData.Name = "_SendData";
            this._SendData.ReadOnly = true;
            this._SendData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._SendData.Size = new System.Drawing.Size(400, 260);
            this._SendData.TabIndex = 2;
            // 
            // _ReceiveData
            // 
            this._ReceiveData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._ReceiveData.Location = new System.Drawing.Point(596, 444);
            this._ReceiveData.Multiline = true;
            this._ReceiveData.Name = "_ReceiveData";
            this._ReceiveData.ReadOnly = true;
            this._ReceiveData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._ReceiveData.Size = new System.Drawing.Size(400, 260);
            this._ReceiveData.TabIndex = 3;
            // 
            // _ClearSend
            // 
            this._ClearSend.Location = new System.Drawing.Point(921, 80);
            this._ClearSend.Name = "_ClearSend";
            this._ClearSend.Size = new System.Drawing.Size(75, 23);
            this._ClearSend.TabIndex = 4;
            this._ClearSend.Text = "送信クリア";
            this._ClearSend.UseVisualStyleBackColor = true;
            this._ClearSend.Click += new System.EventHandler(this._ClearSend_Click);
            // 
            // _ClearReceive
            // 
            this._ClearReceive.Location = new System.Drawing.Point(921, 419);
            this._ClearReceive.Name = "_ClearReceive";
            this._ClearReceive.Size = new System.Drawing.Size(75, 23);
            this._ClearReceive.TabIndex = 4;
            this._ClearReceive.Text = "受信クリア";
            this._ClearReceive.UseVisualStyleBackColor = true;
            this._ClearReceive.Click += new System.EventHandler(this._ClearReceive_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._DoReceiveAscii);
            this.groupBox1.Controls.Add(this._RetEndPlus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._LineRetCode);
            this.groupBox1.Location = new System.Drawing.Point(596, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "受信表示設定";
            // 
            // _DoReceiveAscii
            // 
            this._DoReceiveAscii.AutoSize = true;
            this._DoReceiveAscii.Location = new System.Drawing.Point(8, 43);
            this._DoReceiveAscii.Name = "_DoReceiveAscii";
            this._DoReceiveAscii.Size = new System.Drawing.Size(65, 16);
            this._DoReceiveAscii.TabIndex = 3;
            this._DoReceiveAscii.Text = "ASCII化";
            this._DoReceiveAscii.UseVisualStyleBackColor = true;
            // 
            // _RetEndPlus
            // 
            this._RetEndPlus.AutoSize = true;
            this._RetEndPlus.Checked = true;
            this._RetEndPlus.CheckState = System.Windows.Forms.CheckState.Checked;
            this._RetEndPlus.Location = new System.Drawing.Point(136, 20);
            this._RetEndPlus.Name = "_RetEndPlus";
            this._RetEndPlus.Size = new System.Drawing.Size(70, 16);
            this._RetEndPlus.TabIndex = 2;
            this._RetEndPlus.Text = "+1で改行";
            this._RetEndPlus.UseVisualStyleBackColor = true;
            this._RetEndPlus.CheckedChanged += new System.EventHandler(this._RetEndPlus_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "改行コード(HEX)";
            // 
            // _LineRetCode
            // 
            this._LineRetCode.Location = new System.Drawing.Point(98, 18);
            this._LineRetCode.Name = "_LineRetCode";
            this._LineRetCode.Size = new System.Drawing.Size(32, 19);
            this._LineRetCode.TabIndex = 0;
            this._LineRetCode.Text = "03";
            this._LineRetCode.TextChanged += new System.EventHandler(this._LineRetCode_TextChanged);
            this._LineRetCode.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _Group0
            // 
            this._Group0.Controls.Add(this._DataClear0);
            this._Group0.Controls.Add(this._Send0);
            this._Group0.Controls.Add(this._CmdAscii0);
            this._Group0.Controls.Add(this._HeadAscii0);
            this._Group0.Controls.Add(this._Data0);
            this._Group0.Controls.Add(this._Cmd0);
            this._Group0.Controls.Add(this._Head0);
            this._Group0.Controls.Add(this._DataLen0);
            this._Group0.Controls.Add(this._HasData0);
            this._Group0.Controls.Add(this._BCC0);
            this._Group0.Controls.Add(this._ETX0);
            this._Group0.Controls.Add(this._STX0);
            this._Group0.Controls.Add(this._HasCmd0);
            this._Group0.Controls.Add(this._HasBCC0);
            this._Group0.Controls.Add(this._HasDataLen0);
            this._Group0.Controls.Add(this._HasETX0);
            this._Group0.Controls.Add(this._HasHead0);
            this._Group0.Controls.Add(this._HasSTX0);
            this._Group0.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._Group0.Location = new System.Drawing.Point(13, 98);
            this._Group0.Name = "_Group0";
            this._Group0.Size = new System.Drawing.Size(578, 65);
            this._Group0.TabIndex = 6;
            this._Group0.TabStop = false;
            this._Group0.Text = "0：";
            // 
            // _DataClear0
            // 
            this._DataClear0.Location = new System.Drawing.Point(385, 19);
            this._DataClear0.Name = "_DataClear0";
            this._DataClear0.Size = new System.Drawing.Size(42, 20);
            this._DataClear0.TabIndex = 4;
            this._DataClear0.Text = "Clear";
            this._DataClear0.UseVisualStyleBackColor = true;
            this._DataClear0.Click += new System.EventHandler(this._DataClear_Click);
            // 
            // _Send0
            // 
            this._Send0.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._Send0.Location = new System.Drawing.Point(536, 10);
            this._Send0.Name = "_Send0";
            this._Send0.Size = new System.Drawing.Size(35, 49);
            this._Send0.TabIndex = 3;
            this._Send0.Text = "送信";
            this._Send0.UseVisualStyleBackColor = true;
            this._Send0.Click += new System.EventHandler(this._Send0_Click);
            // 
            // _CmdAscii0
            // 
            this._CmdAscii0.AutoSize = true;
            this._CmdAscii0.Checked = true;
            this._CmdAscii0.CheckState = System.Windows.Forms.CheckState.Checked;
            this._CmdAscii0.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._CmdAscii0.Location = new System.Drawing.Point(148, 10);
            this._CmdAscii0.Name = "_CmdAscii0";
            this._CmdAscii0.Size = new System.Drawing.Size(51, 15);
            this._CmdAscii0.TabIndex = 2;
            this._CmdAscii0.Text = "ASCII";
            this._CmdAscii0.UseVisualStyleBackColor = true;
            // 
            // _HeadAscii0
            // 
            this._HeadAscii0.AutoSize = true;
            this._HeadAscii0.Checked = true;
            this._HeadAscii0.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HeadAscii0.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HeadAscii0.Location = new System.Drawing.Point(58, 10);
            this._HeadAscii0.Name = "_HeadAscii0";
            this._HeadAscii0.Size = new System.Drawing.Size(51, 15);
            this._HeadAscii0.TabIndex = 2;
            this._HeadAscii0.Text = "ASCII";
            this._HeadAscii0.UseVisualStyleBackColor = true;
            // 
            // _Data0
            // 
            this._Data0.Location = new System.Drawing.Point(272, 40);
            this._Data0.Name = "_Data0";
            this._Data0.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this._Data0.Size = new System.Drawing.Size(155, 18);
            this._Data0.TabIndex = 1;
            // 
            // _Cmd0
            // 
            this._Cmd0.Location = new System.Drawing.Point(148, 40);
            this._Cmd0.Name = "_Cmd0";
            this._Cmd0.Size = new System.Drawing.Size(51, 18);
            this._Cmd0.TabIndex = 1;
            // 
            // _Head0
            // 
            this._Head0.Location = new System.Drawing.Point(58, 40);
            this._Head0.Name = "_Head0";
            this._Head0.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this._Head0.Size = new System.Drawing.Size(84, 18);
            this._Head0.TabIndex = 1;
            // 
            // _DataLen0
            // 
            this._DataLen0.Location = new System.Drawing.Point(205, 40);
            this._DataLen0.Name = "_DataLen0";
            this._DataLen0.Size = new System.Drawing.Size(61, 18);
            this._DataLen0.TabIndex = 1;
            // 
            // _HasData0
            // 
            this._HasData0.AutoSize = true;
            this._HasData0.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasData0.Location = new System.Drawing.Point(272, 25);
            this._HasData0.Name = "_HasData0";
            this._HasData0.Size = new System.Drawing.Size(50, 15);
            this._HasData0.TabIndex = 0;
            this._HasData0.Text = "データ";
            this._HasData0.UseVisualStyleBackColor = true;
            // 
            // _BCC0
            // 
            this._BCC0.Location = new System.Drawing.Point(485, 40);
            this._BCC0.Name = "_BCC0";
            this._BCC0.Size = new System.Drawing.Size(45, 18);
            this._BCC0.TabIndex = 1;
            this._BCC0.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _ETX0
            // 
            this._ETX0.Location = new System.Drawing.Point(434, 40);
            this._ETX0.Name = "_ETX0";
            this._ETX0.Size = new System.Drawing.Size(45, 18);
            this._ETX0.TabIndex = 1;
            this._ETX0.Text = "03";
            this._ETX0.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _STX0
            // 
            this._STX0.Location = new System.Drawing.Point(7, 40);
            this._STX0.Name = "_STX0";
            this._STX0.Size = new System.Drawing.Size(45, 18);
            this._STX0.TabIndex = 1;
            this._STX0.Text = "02";
            this._STX0.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _HasCmd0
            // 
            this._HasCmd0.AutoSize = true;
            this._HasCmd0.Checked = true;
            this._HasCmd0.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasCmd0.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasCmd0.Location = new System.Drawing.Point(148, 25);
            this._HasCmd0.Name = "_HasCmd0";
            this._HasCmd0.Size = new System.Drawing.Size(56, 15);
            this._HasCmd0.TabIndex = 0;
            this._HasCmd0.Text = "コマンド";
            this._HasCmd0.UseVisualStyleBackColor = true;
            // 
            // _HasBCC0
            // 
            this._HasBCC0.AutoSize = true;
            this._HasBCC0.Checked = true;
            this._HasBCC0.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasBCC0.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasBCC0.Location = new System.Drawing.Point(485, 25);
            this._HasBCC0.Name = "_HasBCC0";
            this._HasBCC0.Size = new System.Drawing.Size(45, 15);
            this._HasBCC0.TabIndex = 0;
            this._HasBCC0.Text = "BCC";
            this._HasBCC0.UseVisualStyleBackColor = true;
            // 
            // _HasDataLen0
            // 
            this._HasDataLen0.AutoSize = true;
            this._HasDataLen0.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasDataLen0.Location = new System.Drawing.Point(205, 25);
            this._HasDataLen0.Name = "_HasDataLen0";
            this._HasDataLen0.Size = new System.Drawing.Size(61, 15);
            this._HasDataLen0.TabIndex = 0;
            this._HasDataLen0.Text = "データ長";
            this._HasDataLen0.UseVisualStyleBackColor = true;
            // 
            // _HasETX0
            // 
            this._HasETX0.AutoSize = true;
            this._HasETX0.Checked = true;
            this._HasETX0.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasETX0.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasETX0.Location = new System.Drawing.Point(434, 25);
            this._HasETX0.Name = "_HasETX0";
            this._HasETX0.Size = new System.Drawing.Size(43, 15);
            this._HasETX0.TabIndex = 0;
            this._HasETX0.Text = "ETX";
            this._HasETX0.UseVisualStyleBackColor = true;
            // 
            // _HasHead0
            // 
            this._HasHead0.AutoSize = true;
            this._HasHead0.Checked = true;
            this._HasHead0.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasHead0.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasHead0.Location = new System.Drawing.Point(58, 25);
            this._HasHead0.Name = "_HasHead0";
            this._HasHead0.Size = new System.Drawing.Size(47, 15);
            this._HasHead0.TabIndex = 0;
            this._HasHead0.Text = "ヘッダ";
            this._HasHead0.UseVisualStyleBackColor = true;
            // 
            // _HasSTX0
            // 
            this._HasSTX0.AutoSize = true;
            this._HasSTX0.Checked = true;
            this._HasSTX0.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasSTX0.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasSTX0.Location = new System.Drawing.Point(7, 25);
            this._HasSTX0.Name = "_HasSTX0";
            this._HasSTX0.Size = new System.Drawing.Size(44, 15);
            this._HasSTX0.TabIndex = 0;
            this._HasSTX0.Text = "STX";
            this._HasSTX0.UseVisualStyleBackColor = true;
            // 
            // Group7
            // 
            this.Group7.Controls.Add(this._SendF);
            this.Group7.Controls.Add(this.groupBox5);
            this.Group7.Controls.Add(this.groupBox4);
            this.Group7.Controls.Add(this._OpenDataF);
            this.Group7.Controls.Add(this._DataF);
            this.Group7.Controls.Add(this._CmdAsciiF);
            this.Group7.Controls.Add(this._HeadAsciiF);
            this.Group7.Controls.Add(this._CmdF);
            this.Group7.Controls.Add(this._HeadF);
            this.Group7.Controls.Add(this._DataLenF);
            this.Group7.Controls.Add(this._BCCF);
            this.Group7.Controls.Add(this._ETXF);
            this.Group7.Controls.Add(this._STXF);
            this.Group7.Controls.Add(this._HasCmdF);
            this.Group7.Controls.Add(this._HasBCCF);
            this.Group7.Controls.Add(this._HasDataLenF);
            this.Group7.Controls.Add(this._HasETXF);
            this.Group7.Controls.Add(this._HasHeadF);
            this.Group7.Controls.Add(this._HasSTXF);
            this.Group7.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Group7.Location = new System.Drawing.Point(13, 556);
            this.Group7.Name = "Group7";
            this.Group7.Size = new System.Drawing.Size(577, 150);
            this.Group7.TabIndex = 13;
            this.Group7.TabStop = false;
            this.Group7.Text = "ファイル送信";
            // 
            // _SendF
            // 
            this._SendF.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._SendF.Location = new System.Drawing.Point(535, 12);
            this._SendF.Name = "_SendF";
            this._SendF.Size = new System.Drawing.Size(35, 49);
            this._SendF.TabIndex = 4;
            this._SendF.Text = "送信";
            this._SendF.UseVisualStyleBackColor = true;
            this._SendF.Click += new System.EventHandler(this._SendF_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this._DoResponse);
            this.groupBox5.Controls.Add(this._DoAutoInterval);
            this.groupBox5.Controls.Add(this._ResponseCode);
            this.groupBox5.Controls.Add(this._AutoCmdID);
            this.groupBox5.Controls.Add(this._HasAutoCmd);
            this.groupBox5.Controls.Add(this._AutoInterval);
            this.groupBox5.Controls.Add(this._StartAutoSendF);
            this.groupBox5.Location = new System.Drawing.Point(148, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(354, 76);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "自動送信";
            // 
            // _DoResponse
            // 
            this._DoResponse.AutoSize = true;
            this._DoResponse.Location = new System.Drawing.Point(232, 16);
            this._DoResponse.Name = "_DoResponse";
            this._DoResponse.Size = new System.Drawing.Size(45, 15);
            this._DoResponse.TabIndex = 9;
            this._DoResponse.Text = "応答";
            this._DoResponse.UseVisualStyleBackColor = true;
            this._DoResponse.CheckedChanged += new System.EventHandler(this._DoResponse_CheckedChanged);
            // 
            // _DoAutoInterval
            // 
            this._DoAutoInterval.AutoSize = true;
            this._DoAutoInterval.Checked = true;
            this._DoAutoInterval.Location = new System.Drawing.Point(150, 16);
            this._DoAutoInterval.Name = "_DoAutoInterval";
            this._DoAutoInterval.Size = new System.Drawing.Size(64, 15);
            this._DoAutoInterval.TabIndex = 9;
            this._DoAutoInterval.TabStop = true;
            this._DoAutoInterval.Text = "間隔(ms)";
            this._DoAutoInterval.UseVisualStyleBackColor = true;
            this._DoAutoInterval.CheckedChanged += new System.EventHandler(this._DoAutoInterval_CheckedChanged);
            // 
            // _ResponseCode
            // 
            this._ResponseCode.Location = new System.Drawing.Point(232, 42);
            this._ResponseCode.Name = "_ResponseCode";
            this._ResponseCode.Size = new System.Drawing.Size(64, 18);
            this._ResponseCode.TabIndex = 8;
            this._ResponseCode.Text = "03";
            this._ResponseCode.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _AutoCmdID
            // 
            this._AutoCmdID.Location = new System.Drawing.Point(61, 44);
            this._AutoCmdID.Name = "_AutoCmdID";
            this._AutoCmdID.Size = new System.Drawing.Size(64, 18);
            this._AutoCmdID.TabIndex = 7;
            this._AutoCmdID.Text = "1";
            this._AutoCmdID.Validating += new System.ComponentModel.CancelEventHandler(this._IntervalCmdID_Validating);
            // 
            // _HasAutoCmd
            // 
            this._HasAutoCmd.AutoSize = true;
            this._HasAutoCmd.Location = new System.Drawing.Point(61, 17);
            this._HasAutoCmd.Name = "_HasAutoCmd";
            this._HasAutoCmd.Size = new System.Drawing.Size(78, 15);
            this._HasAutoCmd.TabIndex = 6;
            this._HasAutoCmd.Text = "確認コマンド";
            this._HasAutoCmd.UseVisualStyleBackColor = true;
            // 
            // _AutoInterval
            // 
            this._AutoInterval.Location = new System.Drawing.Point(150, 42);
            this._AutoInterval.Name = "_AutoInterval";
            this._AutoInterval.Size = new System.Drawing.Size(64, 18);
            this._AutoInterval.TabIndex = 4;
            this._AutoInterval.Text = "1000";
            this._AutoInterval.Validating += new System.ComponentModel.CancelEventHandler(this.PositiveInteger_Validating);
            // 
            // _StartAutoSendF
            // 
            this._StartAutoSendF.AutoSize = true;
            this._StartAutoSendF.Location = new System.Drawing.Point(6, 18);
            this._StartAutoSendF.Name = "_StartAutoSendF";
            this._StartAutoSendF.Size = new System.Drawing.Size(46, 15);
            this._StartAutoSendF.TabIndex = 0;
            this._StartAutoSendF.Text = "開始";
            this._StartAutoSendF.UseVisualStyleBackColor = true;
            this._StartAutoSendF.CheckedChanged += new System.EventHandler(this._StartAutoSendF_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._TotalLine);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this._NextLine);
            this.groupBox4.Controls.Add(this._IsSendLine);
            this.groupBox4.Location = new System.Drawing.Point(7, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(135, 77);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "送信方法";
            // 
            // _TotalLine
            // 
            this._TotalLine.Location = new System.Drawing.Point(77, 42);
            this._TotalLine.Name = "_TotalLine";
            this._TotalLine.ReadOnly = true;
            this._TotalLine.Size = new System.Drawing.Size(47, 18);
            this._TotalLine.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 11);
            this.label1.TabIndex = 2;
            this.label1.Text = "/";
            // 
            // _NextLine
            // 
            this._NextLine.Location = new System.Drawing.Point(7, 42);
            this._NextLine.Name = "_NextLine";
            this._NextLine.Size = new System.Drawing.Size(47, 18);
            this._NextLine.TabIndex = 1;
            this._NextLine.Validating += new System.ComponentModel.CancelEventHandler(this.PositiveInteger_Validating);
            // 
            // _IsSendLine
            // 
            this._IsSendLine.AutoSize = true;
            this._IsSendLine.Checked = true;
            this._IsSendLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this._IsSendLine.Location = new System.Drawing.Point(7, 19);
            this._IsSendLine.Name = "_IsSendLine";
            this._IsSendLine.Size = new System.Drawing.Size(81, 15);
            this._IsSendLine.TabIndex = 0;
            this._IsSendLine.Text = "1行ずつ送信";
            this._IsSendLine.UseVisualStyleBackColor = true;
            // 
            // _OpenDataF
            // 
            this._OpenDataF.Location = new System.Drawing.Point(392, 40);
            this._OpenDataF.Name = "_OpenDataF";
            this._OpenDataF.Size = new System.Drawing.Size(35, 23);
            this._OpenDataF.TabIndex = 18;
            this._OpenDataF.Text = "開く";
            this._OpenDataF.UseVisualStyleBackColor = true;
            this._OpenDataF.Click += new System.EventHandler(this._OpenDataF_Click);
            // 
            // _DataF
            // 
            this._DataF.Location = new System.Drawing.Point(271, 42);
            this._DataF.Name = "_DataF";
            this._DataF.ReadOnly = true;
            this._DataF.Size = new System.Drawing.Size(115, 18);
            this._DataF.TabIndex = 17;
            // 
            // _CmdAsciiF
            // 
            this._CmdAsciiF.AutoSize = true;
            this._CmdAsciiF.Checked = true;
            this._CmdAsciiF.CheckState = System.Windows.Forms.CheckState.Checked;
            this._CmdAsciiF.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._CmdAsciiF.Location = new System.Drawing.Point(148, 12);
            this._CmdAsciiF.Name = "_CmdAsciiF";
            this._CmdAsciiF.Size = new System.Drawing.Size(51, 15);
            this._CmdAsciiF.TabIndex = 15;
            this._CmdAsciiF.Text = "ASCII";
            this._CmdAsciiF.UseVisualStyleBackColor = true;
            // 
            // _HeadAsciiF
            // 
            this._HeadAsciiF.AutoSize = true;
            this._HeadAsciiF.Checked = true;
            this._HeadAsciiF.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HeadAsciiF.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HeadAsciiF.Location = new System.Drawing.Point(58, 12);
            this._HeadAsciiF.Name = "_HeadAsciiF";
            this._HeadAsciiF.Size = new System.Drawing.Size(51, 15);
            this._HeadAsciiF.TabIndex = 16;
            this._HeadAsciiF.Text = "ASCII";
            this._HeadAsciiF.UseVisualStyleBackColor = true;
            // 
            // _CmdF
            // 
            this._CmdF.Location = new System.Drawing.Point(148, 42);
            this._CmdF.Name = "_CmdF";
            this._CmdF.Size = new System.Drawing.Size(51, 18);
            this._CmdF.TabIndex = 9;
            // 
            // _HeadF
            // 
            this._HeadF.Location = new System.Drawing.Point(58, 42);
            this._HeadF.Name = "_HeadF";
            this._HeadF.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this._HeadF.Size = new System.Drawing.Size(84, 18);
            this._HeadF.TabIndex = 10;
            // 
            // _DataLenF
            // 
            this._DataLenF.Location = new System.Drawing.Point(205, 42);
            this._DataLenF.Name = "_DataLenF";
            this._DataLenF.Size = new System.Drawing.Size(61, 18);
            this._DataLenF.TabIndex = 11;
            // 
            // _BCCF
            // 
            this._BCCF.Location = new System.Drawing.Point(485, 42);
            this._BCCF.Name = "_BCCF";
            this._BCCF.Size = new System.Drawing.Size(45, 18);
            this._BCCF.TabIndex = 12;
            this._BCCF.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _ETXF
            // 
            this._ETXF.Location = new System.Drawing.Point(434, 42);
            this._ETXF.Name = "_ETXF";
            this._ETXF.Size = new System.Drawing.Size(45, 18);
            this._ETXF.TabIndex = 13;
            this._ETXF.Text = "03";
            this._ETXF.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _STXF
            // 
            this._STXF.Location = new System.Drawing.Point(7, 42);
            this._STXF.Name = "_STXF";
            this._STXF.Size = new System.Drawing.Size(45, 18);
            this._STXF.TabIndex = 14;
            this._STXF.Text = "02";
            this._STXF.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _HasCmdF
            // 
            this._HasCmdF.AutoSize = true;
            this._HasCmdF.Checked = true;
            this._HasCmdF.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasCmdF.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasCmdF.Location = new System.Drawing.Point(148, 27);
            this._HasCmdF.Name = "_HasCmdF";
            this._HasCmdF.Size = new System.Drawing.Size(56, 15);
            this._HasCmdF.TabIndex = 3;
            this._HasCmdF.Text = "コマンド";
            this._HasCmdF.UseVisualStyleBackColor = true;
            // 
            // _HasBCCF
            // 
            this._HasBCCF.AutoSize = true;
            this._HasBCCF.Checked = true;
            this._HasBCCF.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasBCCF.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasBCCF.Location = new System.Drawing.Point(485, 27);
            this._HasBCCF.Name = "_HasBCCF";
            this._HasBCCF.Size = new System.Drawing.Size(45, 15);
            this._HasBCCF.TabIndex = 4;
            this._HasBCCF.Text = "BCC";
            this._HasBCCF.UseVisualStyleBackColor = true;
            // 
            // _HasDataLenF
            // 
            this._HasDataLenF.AutoSize = true;
            this._HasDataLenF.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasDataLenF.Location = new System.Drawing.Point(205, 27);
            this._HasDataLenF.Name = "_HasDataLenF";
            this._HasDataLenF.Size = new System.Drawing.Size(61, 15);
            this._HasDataLenF.TabIndex = 5;
            this._HasDataLenF.Text = "データ長";
            this._HasDataLenF.UseVisualStyleBackColor = true;
            // 
            // _HasETXF
            // 
            this._HasETXF.AutoSize = true;
            this._HasETXF.Checked = true;
            this._HasETXF.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasETXF.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasETXF.Location = new System.Drawing.Point(434, 27);
            this._HasETXF.Name = "_HasETXF";
            this._HasETXF.Size = new System.Drawing.Size(43, 15);
            this._HasETXF.TabIndex = 6;
            this._HasETXF.Text = "ETX";
            this._HasETXF.UseVisualStyleBackColor = true;
            // 
            // _HasHeadF
            // 
            this._HasHeadF.AutoSize = true;
            this._HasHeadF.Checked = true;
            this._HasHeadF.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasHeadF.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasHeadF.Location = new System.Drawing.Point(58, 27);
            this._HasHeadF.Name = "_HasHeadF";
            this._HasHeadF.Size = new System.Drawing.Size(47, 15);
            this._HasHeadF.TabIndex = 7;
            this._HasHeadF.Text = "ヘッダ";
            this._HasHeadF.UseVisualStyleBackColor = true;
            // 
            // _HasSTXF
            // 
            this._HasSTXF.AutoSize = true;
            this._HasSTXF.Checked = true;
            this._HasSTXF.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasSTXF.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasSTXF.Location = new System.Drawing.Point(7, 27);
            this._HasSTXF.Name = "_HasSTXF";
            this._HasSTXF.Size = new System.Drawing.Size(44, 15);
            this._HasSTXF.TabIndex = 8;
            this._HasSTXF.Text = "STX";
            this._HasSTXF.UseVisualStyleBackColor = true;
            // 
            // _DoSendAscii
            // 
            this._DoSendAscii.AutoSize = true;
            this._DoSendAscii.Location = new System.Drawing.Point(8, 19);
            this._DoSendAscii.Name = "_DoSendAscii";
            this._DoSendAscii.Size = new System.Drawing.Size(65, 16);
            this._DoSendAscii.TabIndex = 3;
            this._DoSendAscii.Text = "ASCII化";
            this._DoSendAscii.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._DoSendAscii);
            this.groupBox2.Location = new System.Drawing.Point(596, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 41);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "送信設定";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this._Interval);
            this.groupBox3.Controls.Add(this._IntervalCmdID);
            this.groupBox3.Controls.Add(this._StartInterval);
            this.groupBox3.Location = new System.Drawing.Point(389, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 66);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "定期送信";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "間隔(ms)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "送信データID";
            // 
            // _Interval
            // 
            this._Interval.Location = new System.Drawing.Point(130, 40);
            this._Interval.Name = "_Interval";
            this._Interval.Size = new System.Drawing.Size(64, 19);
            this._Interval.TabIndex = 1;
            this._Interval.Text = "1000";
            this._Interval.Validating += new System.ComponentModel.CancelEventHandler(this.PositiveInteger_Validating);
            // 
            // _IntervalCmdID
            // 
            this._IntervalCmdID.Location = new System.Drawing.Point(60, 40);
            this._IntervalCmdID.Name = "_IntervalCmdID";
            this._IntervalCmdID.Size = new System.Drawing.Size(64, 19);
            this._IntervalCmdID.TabIndex = 1;
            this._IntervalCmdID.Validating += new System.ComponentModel.CancelEventHandler(this._IntervalCmdID_Validating);
            // 
            // _StartInterval
            // 
            this._StartInterval.AutoSize = true;
            this._StartInterval.Location = new System.Drawing.Point(4, 23);
            this._StartInterval.Name = "_StartInterval";
            this._StartInterval.Size = new System.Drawing.Size(48, 16);
            this._StartInterval.TabIndex = 0;
            this._StartInterval.Text = "開始";
            this._StartInterval.UseVisualStyleBackColor = true;
            this._StartInterval.CheckedChanged += new System.EventHandler(this._StartInterval_CheckedChanged);
            // 
            // _Group1
            // 
            this._Group1.Controls.Add(this._DataClear1);
            this._Group1.Controls.Add(this._Send1);
            this._Group1.Controls.Add(this._CmdAscii1);
            this._Group1.Controls.Add(this._HeadAscii1);
            this._Group1.Controls.Add(this._Data1);
            this._Group1.Controls.Add(this._Cmd1);
            this._Group1.Controls.Add(this._Head1);
            this._Group1.Controls.Add(this._DataLen1);
            this._Group1.Controls.Add(this._HasData1);
            this._Group1.Controls.Add(this._BCC1);
            this._Group1.Controls.Add(this._ETX1);
            this._Group1.Controls.Add(this._STX1);
            this._Group1.Controls.Add(this._HasCmd1);
            this._Group1.Controls.Add(this._HasBCC1);
            this._Group1.Controls.Add(this._HasDataLen1);
            this._Group1.Controls.Add(this._HasETX1);
            this._Group1.Controls.Add(this._HasHead1);
            this._Group1.Controls.Add(this._HasSTX1);
            this._Group1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._Group1.Location = new System.Drawing.Point(12, 163);
            this._Group1.Name = "_Group1";
            this._Group1.Size = new System.Drawing.Size(578, 65);
            this._Group1.TabIndex = 15;
            this._Group1.TabStop = false;
            this._Group1.Text = "1：";
            // 
            // _DataClear1
            // 
            this._DataClear1.Location = new System.Drawing.Point(386, 19);
            this._DataClear1.Name = "_DataClear1";
            this._DataClear1.Size = new System.Drawing.Size(42, 20);
            this._DataClear1.TabIndex = 4;
            this._DataClear1.Text = "Clear";
            this._DataClear1.UseVisualStyleBackColor = true;
            this._DataClear1.Click += new System.EventHandler(this._DataClear_Click);
            // 
            // _Send1
            // 
            this._Send1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._Send1.Location = new System.Drawing.Point(537, 10);
            this._Send1.Name = "_Send1";
            this._Send1.Size = new System.Drawing.Size(35, 49);
            this._Send1.TabIndex = 4;
            this._Send1.Text = "送信";
            this._Send1.UseVisualStyleBackColor = true;
            this._Send1.Click += new System.EventHandler(this._Send1_Click);
            // 
            // _CmdAscii1
            // 
            this._CmdAscii1.AutoSize = true;
            this._CmdAscii1.Checked = true;
            this._CmdAscii1.CheckState = System.Windows.Forms.CheckState.Checked;
            this._CmdAscii1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._CmdAscii1.Location = new System.Drawing.Point(149, 10);
            this._CmdAscii1.Name = "_CmdAscii1";
            this._CmdAscii1.Size = new System.Drawing.Size(51, 15);
            this._CmdAscii1.TabIndex = 2;
            this._CmdAscii1.Text = "ASCII";
            this._CmdAscii1.UseVisualStyleBackColor = true;
            // 
            // _HeadAscii1
            // 
            this._HeadAscii1.AutoSize = true;
            this._HeadAscii1.Checked = true;
            this._HeadAscii1.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HeadAscii1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HeadAscii1.Location = new System.Drawing.Point(58, 10);
            this._HeadAscii1.Name = "_HeadAscii1";
            this._HeadAscii1.Size = new System.Drawing.Size(51, 15);
            this._HeadAscii1.TabIndex = 2;
            this._HeadAscii1.Text = "ASCII";
            this._HeadAscii1.UseVisualStyleBackColor = true;
            // 
            // _Data1
            // 
            this._Data1.Location = new System.Drawing.Point(273, 40);
            this._Data1.Name = "_Data1";
            this._Data1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this._Data1.Size = new System.Drawing.Size(155, 18);
            this._Data1.TabIndex = 1;
            // 
            // _Cmd1
            // 
            this._Cmd1.Location = new System.Drawing.Point(149, 40);
            this._Cmd1.Name = "_Cmd1";
            this._Cmd1.Size = new System.Drawing.Size(51, 18);
            this._Cmd1.TabIndex = 1;
            // 
            // _Head1
            // 
            this._Head1.Location = new System.Drawing.Point(58, 40);
            this._Head1.Name = "_Head1";
            this._Head1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this._Head1.Size = new System.Drawing.Size(85, 18);
            this._Head1.TabIndex = 1;
            // 
            // _DataLen1
            // 
            this._DataLen1.Location = new System.Drawing.Point(206, 40);
            this._DataLen1.Name = "_DataLen1";
            this._DataLen1.Size = new System.Drawing.Size(61, 18);
            this._DataLen1.TabIndex = 1;
            // 
            // _HasData1
            // 
            this._HasData1.AutoSize = true;
            this._HasData1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasData1.Location = new System.Drawing.Point(273, 25);
            this._HasData1.Name = "_HasData1";
            this._HasData1.Size = new System.Drawing.Size(50, 15);
            this._HasData1.TabIndex = 0;
            this._HasData1.Text = "データ";
            this._HasData1.UseVisualStyleBackColor = true;
            // 
            // _BCC1
            // 
            this._BCC1.Location = new System.Drawing.Point(485, 40);
            this._BCC1.Name = "_BCC1";
            this._BCC1.Size = new System.Drawing.Size(45, 18);
            this._BCC1.TabIndex = 1;
            this._BCC1.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _ETX1
            // 
            this._ETX1.Location = new System.Drawing.Point(434, 40);
            this._ETX1.Name = "_ETX1";
            this._ETX1.Size = new System.Drawing.Size(45, 18);
            this._ETX1.TabIndex = 1;
            this._ETX1.Text = "03";
            this._ETX1.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _STX1
            // 
            this._STX1.Location = new System.Drawing.Point(7, 40);
            this._STX1.Name = "_STX1";
            this._STX1.Size = new System.Drawing.Size(45, 18);
            this._STX1.TabIndex = 1;
            this._STX1.Text = "02";
            this._STX1.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _HasCmd1
            // 
            this._HasCmd1.AutoSize = true;
            this._HasCmd1.Checked = true;
            this._HasCmd1.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasCmd1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasCmd1.Location = new System.Drawing.Point(149, 25);
            this._HasCmd1.Name = "_HasCmd1";
            this._HasCmd1.Size = new System.Drawing.Size(56, 15);
            this._HasCmd1.TabIndex = 0;
            this._HasCmd1.Text = "コマンド";
            this._HasCmd1.UseVisualStyleBackColor = true;
            // 
            // _HasBCC1
            // 
            this._HasBCC1.AutoSize = true;
            this._HasBCC1.Checked = true;
            this._HasBCC1.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasBCC1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasBCC1.Location = new System.Drawing.Point(485, 25);
            this._HasBCC1.Name = "_HasBCC1";
            this._HasBCC1.Size = new System.Drawing.Size(45, 15);
            this._HasBCC1.TabIndex = 0;
            this._HasBCC1.Text = "BCC";
            this._HasBCC1.UseVisualStyleBackColor = true;
            // 
            // _HasDataLen1
            // 
            this._HasDataLen1.AutoSize = true;
            this._HasDataLen1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasDataLen1.Location = new System.Drawing.Point(206, 25);
            this._HasDataLen1.Name = "_HasDataLen1";
            this._HasDataLen1.Size = new System.Drawing.Size(61, 15);
            this._HasDataLen1.TabIndex = 0;
            this._HasDataLen1.Text = "データ長";
            this._HasDataLen1.UseVisualStyleBackColor = true;
            // 
            // _HasETX1
            // 
            this._HasETX1.AutoSize = true;
            this._HasETX1.Checked = true;
            this._HasETX1.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasETX1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasETX1.Location = new System.Drawing.Point(434, 25);
            this._HasETX1.Name = "_HasETX1";
            this._HasETX1.Size = new System.Drawing.Size(43, 15);
            this._HasETX1.TabIndex = 0;
            this._HasETX1.Text = "ETX";
            this._HasETX1.UseVisualStyleBackColor = true;
            // 
            // _HasHead1
            // 
            this._HasHead1.AutoSize = true;
            this._HasHead1.Checked = true;
            this._HasHead1.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasHead1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasHead1.Location = new System.Drawing.Point(58, 25);
            this._HasHead1.Name = "_HasHead1";
            this._HasHead1.Size = new System.Drawing.Size(47, 15);
            this._HasHead1.TabIndex = 0;
            this._HasHead1.Text = "ヘッダ";
            this._HasHead1.UseVisualStyleBackColor = true;
            // 
            // _HasSTX1
            // 
            this._HasSTX1.AutoSize = true;
            this._HasSTX1.Checked = true;
            this._HasSTX1.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasSTX1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasSTX1.Location = new System.Drawing.Point(7, 25);
            this._HasSTX1.Name = "_HasSTX1";
            this._HasSTX1.Size = new System.Drawing.Size(44, 15);
            this._HasSTX1.TabIndex = 0;
            this._HasSTX1.Text = "STX";
            this._HasSTX1.UseVisualStyleBackColor = true;
            // 
            // _Group2
            // 
            this._Group2.Controls.Add(this._DataClear2);
            this._Group2.Controls.Add(this._Send2);
            this._Group2.Controls.Add(this._CmdAscii2);
            this._Group2.Controls.Add(this._HeadAscii2);
            this._Group2.Controls.Add(this._Data2);
            this._Group2.Controls.Add(this._Cmd2);
            this._Group2.Controls.Add(this._Head2);
            this._Group2.Controls.Add(this._DataLen2);
            this._Group2.Controls.Add(this._HasData2);
            this._Group2.Controls.Add(this._BCC2);
            this._Group2.Controls.Add(this._ETX2);
            this._Group2.Controls.Add(this._STX2);
            this._Group2.Controls.Add(this._HasCmd2);
            this._Group2.Controls.Add(this._HasBCC2);
            this._Group2.Controls.Add(this._HasDataLen2);
            this._Group2.Controls.Add(this._HasETX2);
            this._Group2.Controls.Add(this._HasHead2);
            this._Group2.Controls.Add(this._HasSTX2);
            this._Group2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._Group2.Location = new System.Drawing.Point(13, 228);
            this._Group2.Name = "_Group2";
            this._Group2.Size = new System.Drawing.Size(578, 65);
            this._Group2.TabIndex = 16;
            this._Group2.TabStop = false;
            this._Group2.Text = "2：";
            // 
            // _DataClear2
            // 
            this._DataClear2.Location = new System.Drawing.Point(386, 19);
            this._DataClear2.Name = "_DataClear2";
            this._DataClear2.Size = new System.Drawing.Size(42, 20);
            this._DataClear2.TabIndex = 4;
            this._DataClear2.Text = "Clear";
            this._DataClear2.UseVisualStyleBackColor = true;
            this._DataClear2.Click += new System.EventHandler(this._DataClear_Click);
            // 
            // _Send2
            // 
            this._Send2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._Send2.Location = new System.Drawing.Point(536, 10);
            this._Send2.Name = "_Send2";
            this._Send2.Size = new System.Drawing.Size(35, 49);
            this._Send2.TabIndex = 4;
            this._Send2.Text = "送信";
            this._Send2.UseVisualStyleBackColor = true;
            this._Send2.Click += new System.EventHandler(this._Send2_Click);
            // 
            // _CmdAscii2
            // 
            this._CmdAscii2.AutoSize = true;
            this._CmdAscii2.Checked = true;
            this._CmdAscii2.CheckState = System.Windows.Forms.CheckState.Checked;
            this._CmdAscii2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._CmdAscii2.Location = new System.Drawing.Point(148, 10);
            this._CmdAscii2.Name = "_CmdAscii2";
            this._CmdAscii2.Size = new System.Drawing.Size(51, 15);
            this._CmdAscii2.TabIndex = 2;
            this._CmdAscii2.Text = "ASCII";
            this._CmdAscii2.UseVisualStyleBackColor = true;
            // 
            // _HeadAscii2
            // 
            this._HeadAscii2.AutoSize = true;
            this._HeadAscii2.Checked = true;
            this._HeadAscii2.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HeadAscii2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HeadAscii2.Location = new System.Drawing.Point(58, 10);
            this._HeadAscii2.Name = "_HeadAscii2";
            this._HeadAscii2.Size = new System.Drawing.Size(51, 15);
            this._HeadAscii2.TabIndex = 2;
            this._HeadAscii2.Text = "ASCII";
            this._HeadAscii2.UseVisualStyleBackColor = true;
            // 
            // _Data2
            // 
            this._Data2.Location = new System.Drawing.Point(272, 40);
            this._Data2.Name = "_Data2";
            this._Data2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this._Data2.Size = new System.Drawing.Size(155, 18);
            this._Data2.TabIndex = 1;
            // 
            // _Cmd2
            // 
            this._Cmd2.Location = new System.Drawing.Point(148, 40);
            this._Cmd2.Name = "_Cmd2";
            this._Cmd2.Size = new System.Drawing.Size(51, 18);
            this._Cmd2.TabIndex = 1;
            // 
            // _Head2
            // 
            this._Head2.Location = new System.Drawing.Point(58, 40);
            this._Head2.Name = "_Head2";
            this._Head2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this._Head2.Size = new System.Drawing.Size(84, 18);
            this._Head2.TabIndex = 1;
            // 
            // _DataLen2
            // 
            this._DataLen2.Location = new System.Drawing.Point(205, 40);
            this._DataLen2.Name = "_DataLen2";
            this._DataLen2.Size = new System.Drawing.Size(61, 18);
            this._DataLen2.TabIndex = 1;
            // 
            // _HasData2
            // 
            this._HasData2.AutoSize = true;
            this._HasData2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasData2.Location = new System.Drawing.Point(271, 25);
            this._HasData2.Name = "_HasData2";
            this._HasData2.Size = new System.Drawing.Size(50, 15);
            this._HasData2.TabIndex = 0;
            this._HasData2.Text = "データ";
            this._HasData2.UseVisualStyleBackColor = true;
            // 
            // _BCC2
            // 
            this._BCC2.Location = new System.Drawing.Point(485, 40);
            this._BCC2.Name = "_BCC2";
            this._BCC2.Size = new System.Drawing.Size(45, 18);
            this._BCC2.TabIndex = 1;
            this._BCC2.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _ETX2
            // 
            this._ETX2.Location = new System.Drawing.Point(434, 40);
            this._ETX2.Name = "_ETX2";
            this._ETX2.Size = new System.Drawing.Size(45, 18);
            this._ETX2.TabIndex = 1;
            this._ETX2.Text = "03";
            this._ETX2.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _STX2
            // 
            this._STX2.Location = new System.Drawing.Point(7, 40);
            this._STX2.Name = "_STX2";
            this._STX2.Size = new System.Drawing.Size(45, 18);
            this._STX2.TabIndex = 1;
            this._STX2.Text = "02";
            this._STX2.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _HasCmd2
            // 
            this._HasCmd2.AutoSize = true;
            this._HasCmd2.Checked = true;
            this._HasCmd2.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasCmd2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasCmd2.Location = new System.Drawing.Point(148, 25);
            this._HasCmd2.Name = "_HasCmd2";
            this._HasCmd2.Size = new System.Drawing.Size(56, 15);
            this._HasCmd2.TabIndex = 0;
            this._HasCmd2.Text = "コマンド";
            this._HasCmd2.UseVisualStyleBackColor = true;
            // 
            // _HasBCC2
            // 
            this._HasBCC2.AutoSize = true;
            this._HasBCC2.Checked = true;
            this._HasBCC2.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasBCC2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasBCC2.Location = new System.Drawing.Point(485, 25);
            this._HasBCC2.Name = "_HasBCC2";
            this._HasBCC2.Size = new System.Drawing.Size(45, 15);
            this._HasBCC2.TabIndex = 0;
            this._HasBCC2.Text = "BCC";
            this._HasBCC2.UseVisualStyleBackColor = true;
            // 
            // _HasDataLen2
            // 
            this._HasDataLen2.AutoSize = true;
            this._HasDataLen2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasDataLen2.Location = new System.Drawing.Point(205, 25);
            this._HasDataLen2.Name = "_HasDataLen2";
            this._HasDataLen2.Size = new System.Drawing.Size(61, 15);
            this._HasDataLen2.TabIndex = 0;
            this._HasDataLen2.Text = "データ長";
            this._HasDataLen2.UseVisualStyleBackColor = true;
            // 
            // _HasETX2
            // 
            this._HasETX2.AutoSize = true;
            this._HasETX2.Checked = true;
            this._HasETX2.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasETX2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasETX2.Location = new System.Drawing.Point(434, 25);
            this._HasETX2.Name = "_HasETX2";
            this._HasETX2.Size = new System.Drawing.Size(43, 15);
            this._HasETX2.TabIndex = 0;
            this._HasETX2.Text = "ETX";
            this._HasETX2.UseVisualStyleBackColor = true;
            // 
            // _HasHead2
            // 
            this._HasHead2.AutoSize = true;
            this._HasHead2.Checked = true;
            this._HasHead2.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasHead2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasHead2.Location = new System.Drawing.Point(58, 25);
            this._HasHead2.Name = "_HasHead2";
            this._HasHead2.Size = new System.Drawing.Size(47, 15);
            this._HasHead2.TabIndex = 0;
            this._HasHead2.Text = "ヘッダ";
            this._HasHead2.UseVisualStyleBackColor = true;
            // 
            // _HasSTX2
            // 
            this._HasSTX2.AutoSize = true;
            this._HasSTX2.Checked = true;
            this._HasSTX2.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasSTX2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasSTX2.Location = new System.Drawing.Point(7, 25);
            this._HasSTX2.Name = "_HasSTX2";
            this._HasSTX2.Size = new System.Drawing.Size(44, 15);
            this._HasSTX2.TabIndex = 0;
            this._HasSTX2.Text = "STX";
            this._HasSTX2.UseVisualStyleBackColor = true;
            // 
            // _Group3
            // 
            this._Group3.Controls.Add(this._DataClear3);
            this._Group3.Controls.Add(this._Send3);
            this._Group3.Controls.Add(this._CmdAscii3);
            this._Group3.Controls.Add(this._HeadAscii3);
            this._Group3.Controls.Add(this._Data3);
            this._Group3.Controls.Add(this._Cmd3);
            this._Group3.Controls.Add(this._Head3);
            this._Group3.Controls.Add(this._DataLen3);
            this._Group3.Controls.Add(this._HasData3);
            this._Group3.Controls.Add(this._BCC3);
            this._Group3.Controls.Add(this._ETX3);
            this._Group3.Controls.Add(this._STX3);
            this._Group3.Controls.Add(this._HasCmd3);
            this._Group3.Controls.Add(this._HasBCC3);
            this._Group3.Controls.Add(this._HasDataLen3);
            this._Group3.Controls.Add(this._HasETX3);
            this._Group3.Controls.Add(this._HasHead3);
            this._Group3.Controls.Add(this._HasSTX3);
            this._Group3.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._Group3.Location = new System.Drawing.Point(12, 293);
            this._Group3.Name = "_Group3";
            this._Group3.Size = new System.Drawing.Size(578, 65);
            this._Group3.TabIndex = 17;
            this._Group3.TabStop = false;
            this._Group3.Text = "3：";
            // 
            // _DataClear3
            // 
            this._DataClear3.Location = new System.Drawing.Point(386, 19);
            this._DataClear3.Name = "_DataClear3";
            this._DataClear3.Size = new System.Drawing.Size(42, 20);
            this._DataClear3.TabIndex = 4;
            this._DataClear3.Text = "Clear";
            this._DataClear3.UseVisualStyleBackColor = true;
            this._DataClear3.Click += new System.EventHandler(this._DataClear_Click);
            // 
            // _Send3
            // 
            this._Send3.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._Send3.Location = new System.Drawing.Point(537, 10);
            this._Send3.Name = "_Send3";
            this._Send3.Size = new System.Drawing.Size(35, 49);
            this._Send3.TabIndex = 4;
            this._Send3.Text = "送信";
            this._Send3.UseVisualStyleBackColor = true;
            this._Send3.Click += new System.EventHandler(this._Send3_Click);
            // 
            // _CmdAscii3
            // 
            this._CmdAscii3.AutoSize = true;
            this._CmdAscii3.Checked = true;
            this._CmdAscii3.CheckState = System.Windows.Forms.CheckState.Checked;
            this._CmdAscii3.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._CmdAscii3.Location = new System.Drawing.Point(149, 10);
            this._CmdAscii3.Name = "_CmdAscii3";
            this._CmdAscii3.Size = new System.Drawing.Size(51, 15);
            this._CmdAscii3.TabIndex = 2;
            this._CmdAscii3.Text = "ASCII";
            this._CmdAscii3.UseVisualStyleBackColor = true;
            // 
            // _HeadAscii3
            // 
            this._HeadAscii3.AutoSize = true;
            this._HeadAscii3.Checked = true;
            this._HeadAscii3.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HeadAscii3.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HeadAscii3.Location = new System.Drawing.Point(58, 10);
            this._HeadAscii3.Name = "_HeadAscii3";
            this._HeadAscii3.Size = new System.Drawing.Size(51, 15);
            this._HeadAscii3.TabIndex = 2;
            this._HeadAscii3.Text = "ASCII";
            this._HeadAscii3.UseVisualStyleBackColor = true;
            // 
            // _Data3
            // 
            this._Data3.Location = new System.Drawing.Point(272, 40);
            this._Data3.Name = "_Data3";
            this._Data3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this._Data3.Size = new System.Drawing.Size(156, 18);
            this._Data3.TabIndex = 1;
            // 
            // _Cmd3
            // 
            this._Cmd3.Location = new System.Drawing.Point(149, 40);
            this._Cmd3.Name = "_Cmd3";
            this._Cmd3.Size = new System.Drawing.Size(51, 18);
            this._Cmd3.TabIndex = 1;
            // 
            // _Head3
            // 
            this._Head3.Location = new System.Drawing.Point(58, 40);
            this._Head3.Name = "_Head3";
            this._Head3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this._Head3.Size = new System.Drawing.Size(85, 18);
            this._Head3.TabIndex = 1;
            // 
            // _DataLen3
            // 
            this._DataLen3.Location = new System.Drawing.Point(206, 40);
            this._DataLen3.Name = "_DataLen3";
            this._DataLen3.Size = new System.Drawing.Size(61, 18);
            this._DataLen3.TabIndex = 1;
            // 
            // _HasData3
            // 
            this._HasData3.AutoSize = true;
            this._HasData3.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasData3.Location = new System.Drawing.Point(272, 25);
            this._HasData3.Name = "_HasData3";
            this._HasData3.Size = new System.Drawing.Size(50, 15);
            this._HasData3.TabIndex = 0;
            this._HasData3.Text = "データ";
            this._HasData3.UseVisualStyleBackColor = true;
            // 
            // _BCC3
            // 
            this._BCC3.Location = new System.Drawing.Point(485, 40);
            this._BCC3.Name = "_BCC3";
            this._BCC3.Size = new System.Drawing.Size(45, 18);
            this._BCC3.TabIndex = 1;
            this._BCC3.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _ETX3
            // 
            this._ETX3.Location = new System.Drawing.Point(434, 40);
            this._ETX3.Name = "_ETX3";
            this._ETX3.Size = new System.Drawing.Size(45, 18);
            this._ETX3.TabIndex = 1;
            this._ETX3.Text = "03";
            this._ETX3.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _STX3
            // 
            this._STX3.Location = new System.Drawing.Point(7, 40);
            this._STX3.Name = "_STX3";
            this._STX3.Size = new System.Drawing.Size(45, 18);
            this._STX3.TabIndex = 1;
            this._STX3.Text = "02";
            this._STX3.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _HasCmd3
            // 
            this._HasCmd3.AutoSize = true;
            this._HasCmd3.Checked = true;
            this._HasCmd3.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasCmd3.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasCmd3.Location = new System.Drawing.Point(149, 25);
            this._HasCmd3.Name = "_HasCmd3";
            this._HasCmd3.Size = new System.Drawing.Size(56, 15);
            this._HasCmd3.TabIndex = 0;
            this._HasCmd3.Text = "コマンド";
            this._HasCmd3.UseVisualStyleBackColor = true;
            // 
            // _HasBCC3
            // 
            this._HasBCC3.AutoSize = true;
            this._HasBCC3.Checked = true;
            this._HasBCC3.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasBCC3.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasBCC3.Location = new System.Drawing.Point(485, 25);
            this._HasBCC3.Name = "_HasBCC3";
            this._HasBCC3.Size = new System.Drawing.Size(45, 15);
            this._HasBCC3.TabIndex = 0;
            this._HasBCC3.Text = "BCC";
            this._HasBCC3.UseVisualStyleBackColor = true;
            // 
            // _HasDataLen3
            // 
            this._HasDataLen3.AutoSize = true;
            this._HasDataLen3.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasDataLen3.Location = new System.Drawing.Point(206, 25);
            this._HasDataLen3.Name = "_HasDataLen3";
            this._HasDataLen3.Size = new System.Drawing.Size(61, 15);
            this._HasDataLen3.TabIndex = 0;
            this._HasDataLen3.Text = "データ長";
            this._HasDataLen3.UseVisualStyleBackColor = true;
            // 
            // _HasETX3
            // 
            this._HasETX3.AutoSize = true;
            this._HasETX3.Checked = true;
            this._HasETX3.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasETX3.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasETX3.Location = new System.Drawing.Point(434, 25);
            this._HasETX3.Name = "_HasETX3";
            this._HasETX3.Size = new System.Drawing.Size(43, 15);
            this._HasETX3.TabIndex = 0;
            this._HasETX3.Text = "ETX";
            this._HasETX3.UseVisualStyleBackColor = true;
            // 
            // _HasHead3
            // 
            this._HasHead3.AutoSize = true;
            this._HasHead3.Checked = true;
            this._HasHead3.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasHead3.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasHead3.Location = new System.Drawing.Point(58, 25);
            this._HasHead3.Name = "_HasHead3";
            this._HasHead3.Size = new System.Drawing.Size(47, 15);
            this._HasHead3.TabIndex = 0;
            this._HasHead3.Text = "ヘッダ";
            this._HasHead3.UseVisualStyleBackColor = true;
            // 
            // _HasSTX3
            // 
            this._HasSTX3.AutoSize = true;
            this._HasSTX3.Checked = true;
            this._HasSTX3.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasSTX3.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasSTX3.Location = new System.Drawing.Point(7, 25);
            this._HasSTX3.Name = "_HasSTX3";
            this._HasSTX3.Size = new System.Drawing.Size(44, 15);
            this._HasSTX3.TabIndex = 0;
            this._HasSTX3.Text = "STX";
            this._HasSTX3.UseVisualStyleBackColor = true;
            // 
            // _Group4
            // 
            this._Group4.Controls.Add(this._DataClear4);
            this._Group4.Controls.Add(this._Send4);
            this._Group4.Controls.Add(this._CmdAscii4);
            this._Group4.Controls.Add(this._HeadAscii4);
            this._Group4.Controls.Add(this._Data4);
            this._Group4.Controls.Add(this._Cmd4);
            this._Group4.Controls.Add(this._Head4);
            this._Group4.Controls.Add(this._DataLen4);
            this._Group4.Controls.Add(this._HasData4);
            this._Group4.Controls.Add(this._BCC4);
            this._Group4.Controls.Add(this._ETX4);
            this._Group4.Controls.Add(this._STX4);
            this._Group4.Controls.Add(this._HasCmd4);
            this._Group4.Controls.Add(this._HasBCC4);
            this._Group4.Controls.Add(this._HasDataLen4);
            this._Group4.Controls.Add(this._HasETX4);
            this._Group4.Controls.Add(this._HasHead4);
            this._Group4.Controls.Add(this._HasSTX4);
            this._Group4.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._Group4.Location = new System.Drawing.Point(13, 358);
            this._Group4.Name = "_Group4";
            this._Group4.Size = new System.Drawing.Size(578, 65);
            this._Group4.TabIndex = 18;
            this._Group4.TabStop = false;
            this._Group4.Text = "4：";
            // 
            // _DataClear4
            // 
            this._DataClear4.Location = new System.Drawing.Point(386, 19);
            this._DataClear4.Name = "_DataClear4";
            this._DataClear4.Size = new System.Drawing.Size(42, 20);
            this._DataClear4.TabIndex = 4;
            this._DataClear4.Text = "Clear";
            this._DataClear4.UseVisualStyleBackColor = true;
            this._DataClear4.Click += new System.EventHandler(this._DataClear_Click);
            // 
            // _Send4
            // 
            this._Send4.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._Send4.Location = new System.Drawing.Point(536, 11);
            this._Send4.Name = "_Send4";
            this._Send4.Size = new System.Drawing.Size(35, 49);
            this._Send4.TabIndex = 4;
            this._Send4.Text = "送信";
            this._Send4.UseVisualStyleBackColor = true;
            this._Send4.Click += new System.EventHandler(this._Send4_Click);
            // 
            // _CmdAscii4
            // 
            this._CmdAscii4.AutoSize = true;
            this._CmdAscii4.Checked = true;
            this._CmdAscii4.CheckState = System.Windows.Forms.CheckState.Checked;
            this._CmdAscii4.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._CmdAscii4.Location = new System.Drawing.Point(148, 10);
            this._CmdAscii4.Name = "_CmdAscii4";
            this._CmdAscii4.Size = new System.Drawing.Size(51, 15);
            this._CmdAscii4.TabIndex = 2;
            this._CmdAscii4.Text = "ASCII";
            this._CmdAscii4.UseVisualStyleBackColor = true;
            // 
            // _HeadAscii4
            // 
            this._HeadAscii4.AutoSize = true;
            this._HeadAscii4.Checked = true;
            this._HeadAscii4.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HeadAscii4.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HeadAscii4.Location = new System.Drawing.Point(58, 10);
            this._HeadAscii4.Name = "_HeadAscii4";
            this._HeadAscii4.Size = new System.Drawing.Size(51, 15);
            this._HeadAscii4.TabIndex = 2;
            this._HeadAscii4.Text = "ASCII";
            this._HeadAscii4.UseVisualStyleBackColor = true;
            // 
            // _Data4
            // 
            this._Data4.Location = new System.Drawing.Point(272, 40);
            this._Data4.Name = "_Data4";
            this._Data4.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this._Data4.Size = new System.Drawing.Size(155, 18);
            this._Data4.TabIndex = 1;
            // 
            // _Cmd4
            // 
            this._Cmd4.Location = new System.Drawing.Point(148, 40);
            this._Cmd4.Name = "_Cmd4";
            this._Cmd4.Size = new System.Drawing.Size(51, 18);
            this._Cmd4.TabIndex = 1;
            // 
            // _Head4
            // 
            this._Head4.Location = new System.Drawing.Point(58, 40);
            this._Head4.Name = "_Head4";
            this._Head4.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this._Head4.Size = new System.Drawing.Size(84, 18);
            this._Head4.TabIndex = 1;
            // 
            // _DataLen4
            // 
            this._DataLen4.Location = new System.Drawing.Point(205, 40);
            this._DataLen4.Name = "_DataLen4";
            this._DataLen4.Size = new System.Drawing.Size(61, 18);
            this._DataLen4.TabIndex = 1;
            // 
            // _HasData4
            // 
            this._HasData4.AutoSize = true;
            this._HasData4.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasData4.Location = new System.Drawing.Point(271, 25);
            this._HasData4.Name = "_HasData4";
            this._HasData4.Size = new System.Drawing.Size(50, 15);
            this._HasData4.TabIndex = 0;
            this._HasData4.Text = "データ";
            this._HasData4.UseVisualStyleBackColor = true;
            // 
            // _BCC4
            // 
            this._BCC4.Location = new System.Drawing.Point(485, 40);
            this._BCC4.Name = "_BCC4";
            this._BCC4.Size = new System.Drawing.Size(45, 18);
            this._BCC4.TabIndex = 1;
            this._BCC4.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _ETX4
            // 
            this._ETX4.Location = new System.Drawing.Point(434, 40);
            this._ETX4.Name = "_ETX4";
            this._ETX4.Size = new System.Drawing.Size(45, 18);
            this._ETX4.TabIndex = 1;
            this._ETX4.Text = "03";
            this._ETX4.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _STX4
            // 
            this._STX4.Location = new System.Drawing.Point(7, 40);
            this._STX4.Name = "_STX4";
            this._STX4.Size = new System.Drawing.Size(45, 18);
            this._STX4.TabIndex = 1;
            this._STX4.Text = "02";
            this._STX4.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _HasCmd4
            // 
            this._HasCmd4.AutoSize = true;
            this._HasCmd4.Checked = true;
            this._HasCmd4.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasCmd4.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasCmd4.Location = new System.Drawing.Point(148, 25);
            this._HasCmd4.Name = "_HasCmd4";
            this._HasCmd4.Size = new System.Drawing.Size(56, 15);
            this._HasCmd4.TabIndex = 0;
            this._HasCmd4.Text = "コマンド";
            this._HasCmd4.UseVisualStyleBackColor = true;
            // 
            // _HasBCC4
            // 
            this._HasBCC4.AutoSize = true;
            this._HasBCC4.Checked = true;
            this._HasBCC4.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasBCC4.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasBCC4.Location = new System.Drawing.Point(485, 25);
            this._HasBCC4.Name = "_HasBCC4";
            this._HasBCC4.Size = new System.Drawing.Size(45, 15);
            this._HasBCC4.TabIndex = 0;
            this._HasBCC4.Text = "BCC";
            this._HasBCC4.UseVisualStyleBackColor = true;
            // 
            // _HasDataLen4
            // 
            this._HasDataLen4.AutoSize = true;
            this._HasDataLen4.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasDataLen4.Location = new System.Drawing.Point(205, 25);
            this._HasDataLen4.Name = "_HasDataLen4";
            this._HasDataLen4.Size = new System.Drawing.Size(61, 15);
            this._HasDataLen4.TabIndex = 0;
            this._HasDataLen4.Text = "データ長";
            this._HasDataLen4.UseVisualStyleBackColor = true;
            // 
            // _HasETX4
            // 
            this._HasETX4.AutoSize = true;
            this._HasETX4.Checked = true;
            this._HasETX4.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasETX4.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasETX4.Location = new System.Drawing.Point(434, 25);
            this._HasETX4.Name = "_HasETX4";
            this._HasETX4.Size = new System.Drawing.Size(43, 15);
            this._HasETX4.TabIndex = 0;
            this._HasETX4.Text = "ETX";
            this._HasETX4.UseVisualStyleBackColor = true;
            // 
            // _HasHead4
            // 
            this._HasHead4.AutoSize = true;
            this._HasHead4.Checked = true;
            this._HasHead4.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasHead4.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasHead4.Location = new System.Drawing.Point(58, 25);
            this._HasHead4.Name = "_HasHead4";
            this._HasHead4.Size = new System.Drawing.Size(47, 15);
            this._HasHead4.TabIndex = 0;
            this._HasHead4.Text = "ヘッダ";
            this._HasHead4.UseVisualStyleBackColor = true;
            // 
            // _HasSTX4
            // 
            this._HasSTX4.AutoSize = true;
            this._HasSTX4.Checked = true;
            this._HasSTX4.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasSTX4.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasSTX4.Location = new System.Drawing.Point(7, 25);
            this._HasSTX4.Name = "_HasSTX4";
            this._HasSTX4.Size = new System.Drawing.Size(44, 15);
            this._HasSTX4.TabIndex = 0;
            this._HasSTX4.Text = "STX";
            this._HasSTX4.UseVisualStyleBackColor = true;
            // 
            // _Group5
            // 
            this._Group5.Controls.Add(this._DataClear5);
            this._Group5.Controls.Add(this._Send5);
            this._Group5.Controls.Add(this._CmdAscii5);
            this._Group5.Controls.Add(this._HeadAscii5);
            this._Group5.Controls.Add(this._Data5);
            this._Group5.Controls.Add(this._Cmd5);
            this._Group5.Controls.Add(this._Head5);
            this._Group5.Controls.Add(this._DataLen5);
            this._Group5.Controls.Add(this._HasData5);
            this._Group5.Controls.Add(this._BCC5);
            this._Group5.Controls.Add(this._ETX5);
            this._Group5.Controls.Add(this._STX5);
            this._Group5.Controls.Add(this._HasCmd5);
            this._Group5.Controls.Add(this._HasBCC5);
            this._Group5.Controls.Add(this._HasDataLen5);
            this._Group5.Controls.Add(this._HasETX5);
            this._Group5.Controls.Add(this._HasHead5);
            this._Group5.Controls.Add(this._HasSTX5);
            this._Group5.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._Group5.Location = new System.Drawing.Point(13, 423);
            this._Group5.Name = "_Group5";
            this._Group5.Size = new System.Drawing.Size(578, 65);
            this._Group5.TabIndex = 19;
            this._Group5.TabStop = false;
            this._Group5.Text = "5：";
            // 
            // _DataClear5
            // 
            this._DataClear5.Location = new System.Drawing.Point(386, 19);
            this._DataClear5.Name = "_DataClear5";
            this._DataClear5.Size = new System.Drawing.Size(42, 20);
            this._DataClear5.TabIndex = 4;
            this._DataClear5.Text = "Clear";
            this._DataClear5.UseVisualStyleBackColor = true;
            this._DataClear5.Click += new System.EventHandler(this._DataClear_Click);
            // 
            // _Send5
            // 
            this._Send5.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._Send5.Location = new System.Drawing.Point(536, 10);
            this._Send5.Name = "_Send5";
            this._Send5.Size = new System.Drawing.Size(35, 49);
            this._Send5.TabIndex = 4;
            this._Send5.Text = "送信";
            this._Send5.UseVisualStyleBackColor = true;
            this._Send5.Click += new System.EventHandler(this._Send5_Click);
            // 
            // _CmdAscii5
            // 
            this._CmdAscii5.AutoSize = true;
            this._CmdAscii5.Checked = true;
            this._CmdAscii5.CheckState = System.Windows.Forms.CheckState.Checked;
            this._CmdAscii5.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._CmdAscii5.Location = new System.Drawing.Point(148, 10);
            this._CmdAscii5.Name = "_CmdAscii5";
            this._CmdAscii5.Size = new System.Drawing.Size(51, 15);
            this._CmdAscii5.TabIndex = 2;
            this._CmdAscii5.Text = "ASCII";
            this._CmdAscii5.UseVisualStyleBackColor = true;
            // 
            // _HeadAscii5
            // 
            this._HeadAscii5.AutoSize = true;
            this._HeadAscii5.Checked = true;
            this._HeadAscii5.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HeadAscii5.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HeadAscii5.Location = new System.Drawing.Point(58, 10);
            this._HeadAscii5.Name = "_HeadAscii5";
            this._HeadAscii5.Size = new System.Drawing.Size(51, 15);
            this._HeadAscii5.TabIndex = 2;
            this._HeadAscii5.Text = "ASCII";
            this._HeadAscii5.UseVisualStyleBackColor = true;
            // 
            // _Data5
            // 
            this._Data5.Location = new System.Drawing.Point(272, 40);
            this._Data5.Name = "_Data5";
            this._Data5.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this._Data5.Size = new System.Drawing.Size(155, 18);
            this._Data5.TabIndex = 1;
            // 
            // _Cmd5
            // 
            this._Cmd5.Location = new System.Drawing.Point(148, 40);
            this._Cmd5.Name = "_Cmd5";
            this._Cmd5.Size = new System.Drawing.Size(51, 18);
            this._Cmd5.TabIndex = 1;
            // 
            // _Head5
            // 
            this._Head5.Location = new System.Drawing.Point(58, 40);
            this._Head5.Name = "_Head5";
            this._Head5.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this._Head5.Size = new System.Drawing.Size(84, 18);
            this._Head5.TabIndex = 1;
            // 
            // _DataLen5
            // 
            this._DataLen5.Location = new System.Drawing.Point(205, 40);
            this._DataLen5.Name = "_DataLen5";
            this._DataLen5.Size = new System.Drawing.Size(61, 18);
            this._DataLen5.TabIndex = 1;
            // 
            // _HasData5
            // 
            this._HasData5.AutoSize = true;
            this._HasData5.Checked = true;
            this._HasData5.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasData5.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasData5.Location = new System.Drawing.Point(272, 25);
            this._HasData5.Name = "_HasData5";
            this._HasData5.Size = new System.Drawing.Size(50, 15);
            this._HasData5.TabIndex = 0;
            this._HasData5.Text = "データ";
            this._HasData5.UseVisualStyleBackColor = true;
            // 
            // _BCC5
            // 
            this._BCC5.Location = new System.Drawing.Point(485, 40);
            this._BCC5.Name = "_BCC5";
            this._BCC5.Size = new System.Drawing.Size(45, 18);
            this._BCC5.TabIndex = 1;
            this._BCC5.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _ETX5
            // 
            this._ETX5.Location = new System.Drawing.Point(434, 40);
            this._ETX5.Name = "_ETX5";
            this._ETX5.Size = new System.Drawing.Size(45, 18);
            this._ETX5.TabIndex = 1;
            this._ETX5.Text = "03";
            this._ETX5.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _STX5
            // 
            this._STX5.Location = new System.Drawing.Point(7, 40);
            this._STX5.Name = "_STX5";
            this._STX5.Size = new System.Drawing.Size(45, 18);
            this._STX5.TabIndex = 1;
            this._STX5.Text = "02";
            this._STX5.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _HasCmd5
            // 
            this._HasCmd5.AutoSize = true;
            this._HasCmd5.Checked = true;
            this._HasCmd5.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasCmd5.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasCmd5.Location = new System.Drawing.Point(148, 25);
            this._HasCmd5.Name = "_HasCmd5";
            this._HasCmd5.Size = new System.Drawing.Size(56, 15);
            this._HasCmd5.TabIndex = 0;
            this._HasCmd5.Text = "コマンド";
            this._HasCmd5.UseVisualStyleBackColor = true;
            // 
            // _HasBCC5
            // 
            this._HasBCC5.AutoSize = true;
            this._HasBCC5.Checked = true;
            this._HasBCC5.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasBCC5.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasBCC5.Location = new System.Drawing.Point(485, 25);
            this._HasBCC5.Name = "_HasBCC5";
            this._HasBCC5.Size = new System.Drawing.Size(45, 15);
            this._HasBCC5.TabIndex = 0;
            this._HasBCC5.Text = "BCC";
            this._HasBCC5.UseVisualStyleBackColor = true;
            // 
            // _HasDataLen5
            // 
            this._HasDataLen5.AutoSize = true;
            this._HasDataLen5.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasDataLen5.Location = new System.Drawing.Point(205, 25);
            this._HasDataLen5.Name = "_HasDataLen5";
            this._HasDataLen5.Size = new System.Drawing.Size(61, 15);
            this._HasDataLen5.TabIndex = 0;
            this._HasDataLen5.Text = "データ長";
            this._HasDataLen5.UseVisualStyleBackColor = true;
            // 
            // _HasETX5
            // 
            this._HasETX5.AutoSize = true;
            this._HasETX5.Checked = true;
            this._HasETX5.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasETX5.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasETX5.Location = new System.Drawing.Point(434, 25);
            this._HasETX5.Name = "_HasETX5";
            this._HasETX5.Size = new System.Drawing.Size(43, 15);
            this._HasETX5.TabIndex = 0;
            this._HasETX5.Text = "ETX";
            this._HasETX5.UseVisualStyleBackColor = true;
            // 
            // _HasHead5
            // 
            this._HasHead5.AutoSize = true;
            this._HasHead5.Checked = true;
            this._HasHead5.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasHead5.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasHead5.Location = new System.Drawing.Point(58, 25);
            this._HasHead5.Name = "_HasHead5";
            this._HasHead5.Size = new System.Drawing.Size(47, 15);
            this._HasHead5.TabIndex = 0;
            this._HasHead5.Text = "ヘッダ";
            this._HasHead5.UseVisualStyleBackColor = true;
            // 
            // _HasSTX5
            // 
            this._HasSTX5.AutoSize = true;
            this._HasSTX5.Checked = true;
            this._HasSTX5.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasSTX5.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasSTX5.Location = new System.Drawing.Point(7, 25);
            this._HasSTX5.Name = "_HasSTX5";
            this._HasSTX5.Size = new System.Drawing.Size(44, 15);
            this._HasSTX5.TabIndex = 0;
            this._HasSTX5.Text = "STX";
            this._HasSTX5.UseVisualStyleBackColor = true;
            // 
            // _Group6
            // 
            this._Group6.Controls.Add(this._DataClear6);
            this._Group6.Controls.Add(this._Send6);
            this._Group6.Controls.Add(this._IsAscii6);
            this._Group6.Controls.Add(this._Data6);
            this._Group6.Controls.Add(this._BCC6);
            this._Group6.Controls.Add(this._ETX6);
            this._Group6.Controls.Add(this._STX6);
            this._Group6.Controls.Add(this._HasBCC6);
            this._Group6.Controls.Add(this._HasETX6);
            this._Group6.Controls.Add(this._HasSTX6);
            this._Group6.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._Group6.Location = new System.Drawing.Point(13, 488);
            this._Group6.Name = "_Group6";
            this._Group6.Size = new System.Drawing.Size(578, 65);
            this._Group6.TabIndex = 20;
            this._Group6.TabStop = false;
            this._Group6.Text = "6：";
            // 
            // _DataClear6
            // 
            this._DataClear6.Location = new System.Drawing.Point(386, 19);
            this._DataClear6.Name = "_DataClear6";
            this._DataClear6.Size = new System.Drawing.Size(42, 20);
            this._DataClear6.TabIndex = 4;
            this._DataClear6.Text = "Clear";
            this._DataClear6.UseVisualStyleBackColor = true;
            this._DataClear6.Click += new System.EventHandler(this._DataClear_Click);
            // 
            // _Send6
            // 
            this._Send6.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._Send6.Location = new System.Drawing.Point(536, 10);
            this._Send6.Name = "_Send6";
            this._Send6.Size = new System.Drawing.Size(35, 49);
            this._Send6.TabIndex = 4;
            this._Send6.Text = "送信";
            this._Send6.UseVisualStyleBackColor = true;
            this._Send6.Click += new System.EventHandler(this._Send6_Click);
            // 
            // _IsAscii6
            // 
            this._IsAscii6.AutoSize = true;
            this._IsAscii6.Checked = true;
            this._IsAscii6.CheckState = System.Windows.Forms.CheckState.Checked;
            this._IsAscii6.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._IsAscii6.Location = new System.Drawing.Point(58, 25);
            this._IsAscii6.Name = "_IsAscii6";
            this._IsAscii6.Size = new System.Drawing.Size(51, 15);
            this._IsAscii6.TabIndex = 2;
            this._IsAscii6.Text = "ASCII";
            this._IsAscii6.UseVisualStyleBackColor = true;
            // 
            // _Data6
            // 
            this._Data6.Location = new System.Drawing.Point(58, 40);
            this._Data6.Name = "_Data6";
            this._Data6.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this._Data6.Size = new System.Drawing.Size(370, 18);
            this._Data6.TabIndex = 1;
            // 
            // _BCC6
            // 
            this._BCC6.Location = new System.Drawing.Point(485, 40);
            this._BCC6.Name = "_BCC6";
            this._BCC6.Size = new System.Drawing.Size(45, 18);
            this._BCC6.TabIndex = 1;
            this._BCC6.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _ETX6
            // 
            this._ETX6.Location = new System.Drawing.Point(434, 40);
            this._ETX6.Name = "_ETX6";
            this._ETX6.Size = new System.Drawing.Size(45, 18);
            this._ETX6.TabIndex = 1;
            this._ETX6.Text = "03";
            this._ETX6.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _STX6
            // 
            this._STX6.Location = new System.Drawing.Point(7, 40);
            this._STX6.Name = "_STX6";
            this._STX6.Size = new System.Drawing.Size(45, 18);
            this._STX6.TabIndex = 1;
            this._STX6.Text = "02";
            this._STX6.Validating += new System.ComponentModel.CancelEventHandler(this.ByteHex_Validating);
            // 
            // _HasBCC6
            // 
            this._HasBCC6.AutoSize = true;
            this._HasBCC6.Checked = true;
            this._HasBCC6.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasBCC6.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasBCC6.Location = new System.Drawing.Point(485, 25);
            this._HasBCC6.Name = "_HasBCC6";
            this._HasBCC6.Size = new System.Drawing.Size(45, 15);
            this._HasBCC6.TabIndex = 0;
            this._HasBCC6.Text = "BCC";
            this._HasBCC6.UseVisualStyleBackColor = true;
            // 
            // _HasETX6
            // 
            this._HasETX6.AutoSize = true;
            this._HasETX6.Checked = true;
            this._HasETX6.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasETX6.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasETX6.Location = new System.Drawing.Point(434, 25);
            this._HasETX6.Name = "_HasETX6";
            this._HasETX6.Size = new System.Drawing.Size(43, 15);
            this._HasETX6.TabIndex = 0;
            this._HasETX6.Text = "ETX";
            this._HasETX6.UseVisualStyleBackColor = true;
            // 
            // _HasSTX6
            // 
            this._HasSTX6.AutoSize = true;
            this._HasSTX6.Checked = true;
            this._HasSTX6.CheckState = System.Windows.Forms.CheckState.Checked;
            this._HasSTX6.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._HasSTX6.Location = new System.Drawing.Point(7, 25);
            this._HasSTX6.Name = "_HasSTX6";
            this._HasSTX6.Size = new System.Drawing.Size(44, 15);
            this._HasSTX6.TabIndex = 0;
            this._HasSTX6.Text = "STX";
            this._HasSTX6.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this._BCCCalcSum);
            this.groupBox6.Controls.Add(this._BCCCalcXOR);
            this.groupBox6.Controls.Add(this._BCCIncETX);
            this.groupBox6.Controls.Add(this._BCCIncSTX);
            this.groupBox6.Location = new System.Drawing.Point(183, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 66);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "BCC計算方法";
            // 
            // _BCCCalcSum
            // 
            this._BCCCalcSum.AutoSize = true;
            this._BCCCalcSum.Location = new System.Drawing.Point(93, 26);
            this._BCCCalcSum.Name = "_BCCCalcSum";
            this._BCCCalcSum.Size = new System.Drawing.Size(45, 16);
            this._BCCCalcSum.TabIndex = 1;
            this._BCCCalcSum.TabStop = true;
            this._BCCCalcSum.Text = "Sum";
            this._BCCCalcSum.UseVisualStyleBackColor = true;
            // 
            // _BCCCalcXOR
            // 
            this._BCCCalcXOR.AutoSize = true;
            this._BCCCalcXOR.Checked = true;
            this._BCCCalcXOR.Location = new System.Drawing.Point(93, 9);
            this._BCCCalcXOR.Name = "_BCCCalcXOR";
            this._BCCCalcXOR.Size = new System.Drawing.Size(46, 16);
            this._BCCCalcXOR.TabIndex = 1;
            this._BCCCalcXOR.TabStop = true;
            this._BCCCalcXOR.Text = "XOR";
            this._BCCCalcXOR.UseVisualStyleBackColor = true;
            // 
            // _BCCIncETX
            // 
            this._BCCIncETX.AutoSize = true;
            this._BCCIncETX.Checked = true;
            this._BCCIncETX.CheckState = System.Windows.Forms.CheckState.Checked;
            this._BCCIncETX.Location = new System.Drawing.Point(10, 40);
            this._BCCIncETX.Name = "_BCCIncETX";
            this._BCCIncETX.Size = new System.Drawing.Size(76, 16);
            this._BCCIncETX.TabIndex = 0;
            this._BCCIncETX.Text = "ETXを含む";
            this._BCCIncETX.UseVisualStyleBackColor = true;
            // 
            // _BCCIncSTX
            // 
            this._BCCIncSTX.AutoSize = true;
            this._BCCIncSTX.Location = new System.Drawing.Point(10, 19);
            this._BCCIncSTX.Name = "_BCCIncSTX";
            this._BCCIncSTX.Size = new System.Drawing.Size(76, 16);
            this._BCCIncSTX.TabIndex = 0;
            this._BCCIncSTX.Text = "STXを含む";
            this._BCCIncSTX.UseVisualStyleBackColor = true;
            // 
            // _IntervalTimer
            // 
            this._IntervalTimer.Interval = 1000;
            this._IntervalTimer.Tick += new System.EventHandler(this._IntervalTimer_Tick);
            // 
            // _AutoTimer
            // 
            this._AutoTimer.Tick += new System.EventHandler(this._AutoTimer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(598, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(396, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "バイナリを送信する場合は、2桁のHEXでスペースで区切ってください。(例: 01 0F 03)";
            // 
            // _StatusBar
            // 
            this._StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._StatusLabel});
            this._StatusBar.Location = new System.Drawing.Point(0, 707);
            this._StatusBar.Name = "_StatusBar";
            this._StatusBar.Size = new System.Drawing.Size(1008, 22);
            this._StatusBar.TabIndex = 23;
            this._StatusBar.Text = "statusStrip1";
            // 
            // _StatusLabel
            // 
            this._StatusLabel.Name = "_StatusLabel";
            this._StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // _MenuStrip
            // 
            this._MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this._MenuStrip.Location = new System.Drawing.Point(0, 0);
            this._MenuStrip.Name = "_MenuStrip";
            this._MenuStrip.Size = new System.Drawing.Size(1008, 24);
            this._MenuStrip.TabIndex = 24;
            this._MenuStrip.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.終了XToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(110, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this._StatusBar);
            this.Controls.Add(this._MenuStrip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this._Group6);
            this.Controls.Add(this._Group5);
            this.Controls.Add(this._Group4);
            this.Controls.Add(this._Group3);
            this.Controls.Add(this._Group2);
            this.Controls.Add(this._Group1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Group7);
            this.Controls.Add(this._Group0);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._ClearReceive);
            this.Controls.Add(this._ClearSend);
            this.Controls.Add(this._ReceiveData);
            this.Controls.Add(this._SendData);
            this.Controls.Add(this._Connect);
            this.Controls.Add(this._ComSetting);
            this.MainMenuStrip = this._MenuStrip;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this._Group0.ResumeLayout(false);
            this._Group0.PerformLayout();
            this.Group7.ResumeLayout(false);
            this.Group7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this._Group1.ResumeLayout(false);
            this._Group1.PerformLayout();
            this._Group2.ResumeLayout(false);
            this._Group2.PerformLayout();
            this._Group3.ResumeLayout(false);
            this._Group3.PerformLayout();
            this._Group4.ResumeLayout(false);
            this._Group4.PerformLayout();
            this._Group5.ResumeLayout(false);
            this._Group5.PerformLayout();
            this._Group6.ResumeLayout(false);
            this._Group6.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this._StatusBar.ResumeLayout(false);
            this._StatusBar.PerformLayout();
            this._MenuStrip.ResumeLayout(false);
            this._MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort _SerialPort;
        private System.Windows.Forms.Button _ComSetting;
        private System.Windows.Forms.CheckBox _Connect;
        private System.Windows.Forms.TextBox _SendData;
        private System.Windows.Forms.TextBox _ReceiveData;
        private System.Windows.Forms.Button _ClearSend;
        private System.Windows.Forms.Button _ClearReceive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _LineRetCode;
        private System.Windows.Forms.CheckBox _RetEndPlus;
        private System.Windows.Forms.CheckBox _DoReceiveAscii;
        private System.Windows.Forms.GroupBox _Group0;
        private System.Windows.Forms.GroupBox Group7;
        private System.Windows.Forms.CheckBox _DoSendAscii;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox _StartInterval;
        private System.Windows.Forms.TextBox _IntervalCmdID;
        private System.Windows.Forms.CheckBox _HeadAscii0;
        private System.Windows.Forms.TextBox _Head0;
        private System.Windows.Forms.TextBox _STX0;
        private System.Windows.Forms.CheckBox _HasHead0;
        private System.Windows.Forms.CheckBox _HasSTX0;
        private System.Windows.Forms.CheckBox _CmdAscii0;
        private System.Windows.Forms.TextBox _Cmd0;
        private System.Windows.Forms.TextBox _DataLen0;
        private System.Windows.Forms.CheckBox _HasCmd0;
        private System.Windows.Forms.CheckBox _HasDataLen0;
        private System.Windows.Forms.TextBox _Data0;
        private System.Windows.Forms.CheckBox _HasData0;
        private System.Windows.Forms.TextBox _ETX0;
        private System.Windows.Forms.CheckBox _HasETX0;
        private System.Windows.Forms.TextBox _BCC0;
        private System.Windows.Forms.CheckBox _HasBCC0;
        private System.Windows.Forms.GroupBox _Group1;
        private System.Windows.Forms.CheckBox _CmdAscii1;
        private System.Windows.Forms.CheckBox _HeadAscii1;
        private System.Windows.Forms.TextBox _Data1;
        private System.Windows.Forms.TextBox _Cmd1;
        private System.Windows.Forms.TextBox _Head1;
        private System.Windows.Forms.TextBox _DataLen1;
        private System.Windows.Forms.CheckBox _HasData1;
        private System.Windows.Forms.TextBox _BCC1;
        private System.Windows.Forms.TextBox _ETX1;
        private System.Windows.Forms.TextBox _STX1;
        private System.Windows.Forms.CheckBox _HasCmd1;
        private System.Windows.Forms.CheckBox _HasBCC1;
        private System.Windows.Forms.CheckBox _HasDataLen1;
        private System.Windows.Forms.CheckBox _HasETX1;
        private System.Windows.Forms.CheckBox _HasHead1;
        private System.Windows.Forms.CheckBox _HasSTX1;
        private System.Windows.Forms.GroupBox _Group2;
        private System.Windows.Forms.CheckBox _CmdAscii2;
        private System.Windows.Forms.CheckBox _HeadAscii2;
        private System.Windows.Forms.TextBox _Data2;
        private System.Windows.Forms.TextBox _Cmd2;
        private System.Windows.Forms.TextBox _Head2;
        private System.Windows.Forms.TextBox _DataLen2;
        private System.Windows.Forms.CheckBox _HasData2;
        private System.Windows.Forms.TextBox _BCC2;
        private System.Windows.Forms.TextBox _ETX2;
        private System.Windows.Forms.TextBox _STX2;
        private System.Windows.Forms.CheckBox _HasCmd2;
        private System.Windows.Forms.CheckBox _HasBCC2;
        private System.Windows.Forms.CheckBox _HasDataLen2;
        private System.Windows.Forms.CheckBox _HasETX2;
        private System.Windows.Forms.CheckBox _HasHead2;
        private System.Windows.Forms.CheckBox _HasSTX2;
        private System.Windows.Forms.GroupBox _Group3;
        private System.Windows.Forms.CheckBox _CmdAscii3;
        private System.Windows.Forms.CheckBox _HeadAscii3;
        private System.Windows.Forms.TextBox _Data3;
        private System.Windows.Forms.TextBox _Cmd3;
        private System.Windows.Forms.TextBox _Head3;
        private System.Windows.Forms.TextBox _DataLen3;
        private System.Windows.Forms.CheckBox _HasData3;
        private System.Windows.Forms.TextBox _BCC3;
        private System.Windows.Forms.TextBox _ETX3;
        private System.Windows.Forms.TextBox _STX3;
        private System.Windows.Forms.CheckBox _HasCmd3;
        private System.Windows.Forms.CheckBox _HasBCC3;
        private System.Windows.Forms.CheckBox _HasDataLen3;
        private System.Windows.Forms.CheckBox _HasETX3;
        private System.Windows.Forms.CheckBox _HasHead3;
        private System.Windows.Forms.CheckBox _HasSTX3;
        private System.Windows.Forms.GroupBox _Group4;
        private System.Windows.Forms.CheckBox _CmdAscii4;
        private System.Windows.Forms.CheckBox _HeadAscii4;
        private System.Windows.Forms.TextBox _Data4;
        private System.Windows.Forms.TextBox _Cmd4;
        private System.Windows.Forms.TextBox _Head4;
        private System.Windows.Forms.TextBox _DataLen4;
        private System.Windows.Forms.CheckBox _HasData4;
        private System.Windows.Forms.TextBox _BCC4;
        private System.Windows.Forms.TextBox _ETX4;
        private System.Windows.Forms.TextBox _STX4;
        private System.Windows.Forms.CheckBox _HasCmd4;
        private System.Windows.Forms.CheckBox _HasBCC4;
        private System.Windows.Forms.CheckBox _HasDataLen4;
        private System.Windows.Forms.CheckBox _HasETX4;
        private System.Windows.Forms.CheckBox _HasHead4;
        private System.Windows.Forms.CheckBox _HasSTX4;
        private System.Windows.Forms.GroupBox _Group5;
        private System.Windows.Forms.CheckBox _CmdAscii5;
        private System.Windows.Forms.CheckBox _HeadAscii5;
        private System.Windows.Forms.TextBox _Data5;
        private System.Windows.Forms.TextBox _Cmd5;
        private System.Windows.Forms.TextBox _Head5;
        private System.Windows.Forms.TextBox _DataLen5;
        private System.Windows.Forms.CheckBox _HasData5;
        private System.Windows.Forms.TextBox _BCC5;
        private System.Windows.Forms.TextBox _ETX5;
        private System.Windows.Forms.TextBox _STX5;
        private System.Windows.Forms.CheckBox _HasCmd5;
        private System.Windows.Forms.CheckBox _HasBCC5;
        private System.Windows.Forms.CheckBox _HasDataLen5;
        private System.Windows.Forms.CheckBox _HasETX5;
        private System.Windows.Forms.CheckBox _HasHead5;
        private System.Windows.Forms.CheckBox _HasSTX5;
        private System.Windows.Forms.GroupBox _Group6;
        private System.Windows.Forms.CheckBox _IsAscii6;
        private System.Windows.Forms.TextBox _Data6;
        private System.Windows.Forms.TextBox _BCC6;
        private System.Windows.Forms.TextBox _ETX6;
        private System.Windows.Forms.TextBox _STX6;
        private System.Windows.Forms.CheckBox _HasBCC6;
        private System.Windows.Forms.CheckBox _HasETX6;
        private System.Windows.Forms.CheckBox _HasSTX6;
        private System.Windows.Forms.Button _Send0;
        private System.Windows.Forms.Button _Send1;
        private System.Windows.Forms.Button _Send2;
        private System.Windows.Forms.Button _Send3;
        private System.Windows.Forms.Button _Send4;
        private System.Windows.Forms.Button _Send5;
        private System.Windows.Forms.Button _Send6;
        private System.Windows.Forms.CheckBox _CmdAsciiF;
        private System.Windows.Forms.CheckBox _HeadAsciiF;
        private System.Windows.Forms.TextBox _CmdF;
        private System.Windows.Forms.TextBox _HeadF;
        private System.Windows.Forms.TextBox _DataLenF;
        private System.Windows.Forms.TextBox _BCCF;
        private System.Windows.Forms.TextBox _ETXF;
        private System.Windows.Forms.TextBox _STXF;
        private System.Windows.Forms.CheckBox _HasCmdF;
        private System.Windows.Forms.CheckBox _HasBCCF;
        private System.Windows.Forms.CheckBox _HasDataLenF;
        private System.Windows.Forms.CheckBox _HasETXF;
        private System.Windows.Forms.CheckBox _HasHeadF;
        private System.Windows.Forms.CheckBox _HasSTXF;
        private System.Windows.Forms.TextBox _DataF;
        private System.Windows.Forms.Button _OpenDataF;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox _IsSendLine;
        private System.Windows.Forms.Button _SendF;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox _Interval;
        private System.Windows.Forms.OpenFileDialog _OpenFileDialog;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox _BCCIncETX;
        private System.Windows.Forms.CheckBox _BCCIncSTX;
        private System.Windows.Forms.RadioButton _BCCCalcSum;
        private System.Windows.Forms.RadioButton _BCCCalcXOR;
        private System.Windows.Forms.TextBox _NextLine;
        private System.Windows.Forms.TextBox _TotalLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox _StartAutoSendF;
        private System.Windows.Forms.TextBox _AutoInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _AutoCmdID;
        private System.Windows.Forms.CheckBox _HasAutoCmd;
        private System.Windows.Forms.Timer _IntervalTimer;
        private System.Windows.Forms.Timer _AutoTimer;
        private System.Windows.Forms.TextBox _ResponseCode;
        private System.Windows.Forms.RadioButton _DoResponse;
        private System.Windows.Forms.RadioButton _DoAutoInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip _StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel _StatusLabel;
        private System.Windows.Forms.MenuStrip _MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.Button _DataClear0;
        private System.Windows.Forms.Button _DataClear1;
        private System.Windows.Forms.Button _DataClear2;
        private System.Windows.Forms.Button _DataClear3;
        private System.Windows.Forms.Button _DataClear4;
        private System.Windows.Forms.Button _DataClear5;
        private System.Windows.Forms.Button _DataClear6;
    }
}

