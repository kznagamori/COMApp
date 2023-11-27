using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace COMLogger
{
	public partial class MainForm : Form
	{
		private string[] Ports { set; get; }
		private readonly int[] BitRate = { 300, 600, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200 };
		private readonly int[] DataBits = { 7, 8 };
        private readonly int[] ControlCode = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07,
                                               0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F,
                                               0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17,
                                               0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F,
                                               0x20, 0x5C, 0x7F};
        private readonly string[] ControlCodeStr = { @"\NUL", @"\SOH", @"\STX", @"\ETX", @"\EOT", @"\ENQ", @"\ACK", @"\BEL",
                                                     @"\BS",  @"\HT",  @"\LF",  @"\VT",  @"\FF",  @"\CR",  @"\SO",  @"\SI",
                                                     @"\DLE", @"\DC1", @"\DC2", @"\DC3", @"\DC4", @"\NAC", @"\SYN", @"\ETB",
                                                     @"\CAN", @"\EM",  @"\SUB", @"\ESC",  @"\FS",  @"\GS",  @"\RS", @"\US",
                                                     @" ",  @"\\", @"\DEL"};
        
		private Stopwatch Stopwatch = new Stopwatch();
		class PortBuff
		{
			public TimeSpan Time { set; get; }
            public string src { set; get; }
            public string dst { set; get; }
			public string Data { set; get; }
			public PortBuff(TimeSpan time, string src, string dst, string data)
			{
				this.Time = time;
                this.src = src;
                this.dst = dst;
				this.Data = data;
			}
		}
		private List<PortBuff> PortBuffList = new List<PortBuff>();
		private object PortBuffSyc = new object();

		private delegate void WritePort1(byte[] datas);
		private delegate void WritePort2(byte[] datas);

		private WritePort1 AsyncWritePort1;
		private WritePort2 AsyncWritePort2;

        private string Port1Text = "";
        private string Port2Text = "";
        private bool DoRet1 = false;
        private bool DoRet2 = false;
        private int _BufferLine = 16;

        public MainForm()
		{
			InitializeComponent();
            _BufferLine = Properties.Settings.Default.BufferLine;
        }

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.Ports = System.IO.Ports.SerialPort.GetPortNames();

			this.AsyncWritePort1 = new WritePort1(this.AsyncWritePort1_Callback);
			this.AsyncWritePort2 = new WritePort2(this.AsyncWritePort2_Callback);

			if (this.Ports.Length < 1)
			{
				throw new Exception("使用できるCOMポートがありません");
			}
			else
			{
				this.InitSerialPort();
				this.InitUI();
				this._Timer0.Enabled = true;
			}
		}

		private void InitSerialPort()
		{
			this._SerialPort1.PortName = this.Ports[0];
			this._SerialPort1.BaudRate = this.BitRate[0];
			this._SerialPort1.DataBits = this.DataBits[0];
			this._SerialPort1.Parity = System.IO.Ports.Parity.None;
			this._SerialPort1.StopBits = System.IO.Ports.StopBits.One;
			this._SerialPort1.RtsEnable = this.COM1_RtsEnable.Checked;
			this._SerialPort1.DtrEnable = this.COM1_DtrEnable.Checked;
			this._SerialPort1.Handshake = System.IO.Ports.Handshake.None;
			this._SerialPort1.Encoding = System.Text.Encoding.UTF8;
			this._SerialPort1.NewLine = "\r";

			this._SerialPort2.PortName = this.Ports[0];
			this._SerialPort2.BaudRate = this.BitRate[0];
			this._SerialPort2.DataBits = this.DataBits[0];
			this._SerialPort2.Parity = System.IO.Ports.Parity.None;
			this._SerialPort2.StopBits = System.IO.Ports.StopBits.One;
			this._SerialPort2.RtsEnable = this.COM2_RtsEnable.Checked;
			this._SerialPort2.DtrEnable = this.COM2_DtrEnable.Checked;
			this._SerialPort2.Handshake = System.IO.Ports.Handshake.None;
			this._SerialPort2.Encoding = System.Text.Encoding.UTF8;
			this._SerialPort2.NewLine = "\r";
		}

		private void InitUI()
		{
			this.COM1_Port.Items.AddRange(this.Ports);
			this.COM2_Port.Items.AddRange(this.Ports);
			this.COM1_Port.DropDownStyle = ComboBoxStyle.DropDownList;
			this.COM2_Port.DropDownStyle = ComboBoxStyle.DropDownList;
			this.COM1_Port.SelectedIndex = 0;
			this.COM2_Port.SelectedIndex = 0;

			foreach (int rate in this.BitRate)
			{
				this.COM1_BitRate.Items.Add(rate.ToString());
				this.COM2_BitRate.Items.Add(rate.ToString());
			}
			this.COM1_BitRate.DropDownStyle = ComboBoxStyle.DropDownList;
			this.COM2_BitRate.DropDownStyle = ComboBoxStyle.DropDownList;
			this.COM1_BitRate.SelectedIndex = 0;
			this.COM2_BitRate.SelectedIndex = 0;

			foreach (int bits in this.DataBits)
			{
				this.COM1_DataBits.Items.Add(bits.ToString());
				this.COM2_DataBits.Items.Add(bits.ToString());
			}
			this.COM1_DataBits.DropDownStyle = ComboBoxStyle.DropDownList;
			this.COM2_DataBits.DropDownStyle = ComboBoxStyle.DropDownList;
			this.COM1_DataBits.SelectedIndex = 0;
			this.COM2_DataBits.SelectedIndex = 0;

			this.COM1_Parity.Items.AddRange(Enum.GetNames(typeof(System.IO.Ports.Parity)));
			this.COM2_Parity.Items.AddRange(Enum.GetNames(typeof(System.IO.Ports.Parity)));
			this.COM1_Parity.DropDownStyle = ComboBoxStyle.DropDownList;
			this.COM2_Parity.DropDownStyle = ComboBoxStyle.DropDownList;
			this.COM1_Parity.SelectedIndex = 0;
			this.COM2_Parity.SelectedIndex = 0;

			this.COM1_StopBits.Items.AddRange(Enum.GetNames(typeof(System.IO.Ports.StopBits)));
			this.COM2_StopBits.Items.AddRange(Enum.GetNames(typeof(System.IO.Ports.StopBits)));
			this.COM1_StopBits.DropDownStyle = ComboBoxStyle.DropDownList;
			this.COM2_StopBits.DropDownStyle = ComboBoxStyle.DropDownList;
			this.COM1_StopBits.Items.Remove("None");
			this.COM2_StopBits.Items.Remove("None");
			this.COM1_StopBits.SelectedIndex = 0;
			this.COM2_StopBits.SelectedIndex = 0;

			this.COM1_Flow.Items.AddRange(Enum.GetNames(typeof(System.IO.Ports.Handshake)));
			this.COM2_Flow.Items.AddRange(Enum.GetNames(typeof(System.IO.Ports.Handshake)));
			this.COM1_Flow.DropDownStyle = ComboBoxStyle.DropDownList;
			this.COM2_Flow.DropDownStyle = ComboBoxStyle.DropDownList;
			this.COM1_Flow.SelectedIndex = 0;
			this.COM2_Flow.SelectedIndex = 0;

			this.COM1_RtsEnable.Checked = true;
			this.COM2_RtsEnable.Checked = true;

			this.COM1_DtrEnable.Checked = true;
			this.COM2_DtrEnable.Checked = true;

			this.AutoSave.Checked = false;
			this.SaveFileName.Text = "";

		}

		private void COM1_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this._SerialPort1.PortName = this.Ports[this.COM1_Port.SelectedIndex];
		}

		private void COM2_Port_SelectedIndexChanged(object sender, EventArgs e)
		{
			this._SerialPort2.PortName = this.Ports[this.COM2_Port.SelectedIndex];
		}

		private void COM1_BitRate_SelectedIndexChanged(object sender, EventArgs e)
		{
			this._SerialPort1.BaudRate = this.BitRate[this.COM1_BitRate.SelectedIndex];
		}

		private void COM2_BitRate_SelectedIndexChanged(object sender, EventArgs e)
		{
			this._SerialPort2.BaudRate = this.BitRate[this.COM2_BitRate.SelectedIndex];
		}

		private void COM1_DataBits_SelectedIndexChanged(object sender, EventArgs e)
		{
			this._SerialPort1.DataBits = this.DataBits[this.COM1_DataBits.SelectedIndex];
		}

		private void COM2_DataBits_SelectedIndexChanged(object sender, EventArgs e)
		{
			this._SerialPort2.DataBits = this.DataBits[this.COM2_DataBits.SelectedIndex];
		}

		private void COM1_Parity_SelectedIndexChanged(object sender, EventArgs e)
		{
			this._SerialPort1.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), COM1_Parity.Text);
		}

		private void COM2_Parity_SelectedIndexChanged(object sender, EventArgs e)
		{
			this._SerialPort2.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), COM2_Parity.Text);
		}

		private void COM1_StopBits_SelectedIndexChanged(object sender, EventArgs e)
		{
			this._SerialPort1.StopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), COM1_StopBits.Text);
		}

		private void COM2_StopBits_SelectedIndexChanged(object sender, EventArgs e)
		{
			this._SerialPort2.StopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), COM2_StopBits.Text);
		}

		private void COM1_Flow_SelectedIndexChanged(object sender, EventArgs e)
		{
			this._SerialPort1.Handshake = (System.IO.Ports.Handshake)Enum.Parse(typeof(System.IO.Ports.Handshake), COM1_Flow.Text);
		}

		private void COM2_Flow_SelectedIndexChanged(object sender, EventArgs e)
		{
			this._SerialPort2.Handshake = (System.IO.Ports.Handshake)Enum.Parse(typeof(System.IO.Ports.Handshake), COM2_Flow.Text);
		}

		private void COM1_RtsEnable_CheckedChanged(object sender, EventArgs e)
		{
			this._SerialPort1.RtsEnable = this.COM1_RtsEnable.Checked;
		}

		private void COM2_RtsEnable_CheckedChanged(object sender, EventArgs e)
		{
			this._SerialPort2.RtsEnable = this.COM2_RtsEnable.Checked;
		}

		private void COM1_DtrEnable_CheckedChanged(object sender, EventArgs e)
		{
			this._SerialPort1.DtrEnable = this.COM1_DtrEnable.Checked;
		}

		private void COM2_DtrEnable_CheckStateChanged(object sender, EventArgs e)
		{
			this._SerialPort2.DtrEnable = this.COM2_DtrEnable.Checked;
		}

		private void COM1_Open_Click(object sender, EventArgs e)
		{
            DoRet1 = false;
			if (this._SerialPort1.IsOpen)
			{
				try
				{
					this._SerialPort1.Close();
					this.COM1_Open.Text = "接続";
				}
				catch
				{

				}
			}
			else
			{
				try
				{
					this._SerialPort1.Open();
					this.COM1_Open.Text = "切断";
				}
				catch
				{
                    this.COM1_Open.Text = "接続";
                    MessageBox.Show("ポートが開けませんでした。", "エラー");
				}
			}
		}

		private void COM2_Open_Click(object sender, EventArgs e)
		{
            DoRet2 = false;
            if (this._SerialPort2.IsOpen)
			{
				try
				{
					this._SerialPort2.Close();
					this.COM2_Open.Text = "接続";
				}
				catch
				{

				}
			}
			else
			{
				try
				{
					this._SerialPort2.Open();
					this.COM2_Open.Text = "切断";
				}
				catch
				{
                    this.COM2_Open.Text = "接続";
                    MessageBox.Show("ポートが開けませんでした。", "エラー");

                }
			}
		}

		private void COM1TO2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void COM2TO1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void AsyncWritePort1_Callback(byte[] datas)
		{
			if (this.COM2TO1.Checked)
			{
				if (this._SerialPort1.IsOpen)
				{
					try
					{
                        this._SerialPort1.Write(datas, 0, datas.Count());
					}
					catch
					{							
						IAsyncResult ar = this.BeginInvoke((MethodInvoker)delegate()
						{
                            COM1_Open_Click(this, new EventArgs());
                            _StatusLabel.Text = String.Format("{0}: 書き込みがタイムアウトしました。", DateTime.Now.ToString());
						});
						this.EndInvoke(ar);
					}
				}
			}
		}

		private void AsyncWritePort2_Callback(byte[] datas)
        {
			if (this.COM1TO2.Checked)
			{
				if (this._SerialPort2.IsOpen)
				{
					try
					{
                        this._SerialPort2.Write(datas, 0, datas.Count());
                    }
					catch
					{						
						IAsyncResult ar = this.BeginInvoke((MethodInvoker)delegate()
						{
                            COM2_Open_Click(this, new EventArgs());
                            _StatusLabel.Text = String.Format("{0}: 書き込みがタイムアウトしました。", DateTime.Now.ToString());
                        });
						this.EndInvoke(ar);
					}
				}
			}
		}

		private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
            if (!this.Stopwatch.IsRunning)
			{
				this.Stopwatch.Start();
			}
            TimeSpan span;
            string dst;
            int size = _SerialPort1.BytesToRead;
            byte[] buf = new byte[size];
            byte ret_code = 0;
            bool ret = byte.TryParse(RetCode1.Text, System.Globalization.NumberStyles.HexNumber, null, out ret_code);
            _SerialPort1.Read(buf, 0, size);
            span = this.Stopwatch.Elapsed;

            if (this.COM1TO2.Checked)
            {
                dst = "COM2";
            }
            else
            {
                dst = "アプリ";
            }

            foreach (byte b in buf)
            {
                if (IsAscii.Checked)
                {
                    int i = 0;
                    bool ascii = false;
                    for (i = 0; i < ControlCode.Count(); ++i)
                    {
                        if (ControlCode[i] == (int)b)
                        {
                            ascii = true;
                            break;
                        }
                    }
                    if (ascii)
                    {
                        Port1Text += ControlCodeStr[i];
                    }
                    else
                    {
                        if (b < 128)
                        {
                            Port1Text += (char)b;
                        }
                        else
                        {
                            Port1Text += @"\x" + b.ToString("X2");
                        }
                    }
                }
                else
                {
                    Port1Text += b.ToString("X2") + " ";
                }
                if (ret)
                {
                    if (DoRet1)
                    {
                        lock (this.PortBuffSyc)
                        {
                            this.PortBuffList.Add(new PortBuff(span, "COM1", dst, Port1Text));
                        }
                        Port1Text = "";
                        DoRet1 = false;
                    }
                    if (b == ret_code)
                    {
                        if (RetEndPlus.Checked)
                        {
                            DoRet1 = true;
                        }
                        else
                        {
                            lock (this.PortBuffSyc)
                            {
                                this.PortBuffList.Add(new PortBuff(span, "COM1", dst, Port1Text));
                            }
                            Port1Text = "";
                            DoRet1 = false;
                        }
                    }
                }
            }
            if (!ret)
            {
                if (Port1Text.Length > _BufferLine)
                {
                    lock (this.PortBuffSyc)
                    {
                        this.PortBuffList.Add(new PortBuff(span, "COM1", dst, Port1Text));
                    }
                    Port1Text = "";
                    DoRet1 = false;
                }
                IAsyncResult ar = this.BeginInvoke((MethodInvoker)delegate ()
                {
                    _StatusLabel.Text = string.Format("P1:{0},  P2:{1}", Port1Text, Port2Text);
                });
                this.EndInvoke(ar);
            }
            this.AsyncWritePort2.BeginInvoke(buf, null, null);
        }

		private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
            if (!this.Stopwatch.IsRunning)
            {
                this.Stopwatch.Start();
            }
            TimeSpan span;
            string dst;
            int size = _SerialPort2.BytesToRead;
            byte[] buf = new byte[size];
            byte ret_code = 0;
            bool ret = byte.TryParse(RetCode2.Text, System.Globalization.NumberStyles.HexNumber, null, out ret_code);
            _SerialPort2.Read(buf, 0, size);
            span = this.Stopwatch.Elapsed;

            if (this.COM2TO1.Checked)
            {
                dst = "COM1";
            }
            else
            {
                dst = "アプリ";
            }
            foreach (byte b in buf)
            {
                if (IsAscii.Checked)
                {
                    int i = 0;
                    bool ascii = false;
                    for (i = 0; i < ControlCode.Count(); ++i)
                    {
                        if (ControlCode[i] == (int)b)
                        {
                            ascii = true;
                            break;
                        }
                    }
                    if (ascii)
                    {
                        Port2Text += ControlCodeStr[i];
                    }
                    else
                    {
                        if (b < 128)
                        {
                            Port2Text += (char)b;
                        }
                        else
                        {
                            Port2Text += @"\x" + b.ToString("X2");
                        }
                    }
                }
                else
                {
                    Port2Text += b.ToString("X2") + " ";
                }
                if (ret)
                {
                    if (DoRet2)
                    {
                        lock (this.PortBuffSyc)
                        {
                            this.PortBuffList.Add(new PortBuff(span, "COM2", dst, Port2Text));
                        }
                        Port2Text = "";
                        DoRet2 = false;
                    }
                    if (b == ret_code)
                    {
                        if (RetEndPlus.Checked)
                        {
                            DoRet2 = true;
                        }
                        else
                        {
                            lock (this.PortBuffSyc)
                            {
                                this.PortBuffList.Add(new PortBuff(span, "COM2", dst, Port2Text));
                            }
                            Port2Text = "";
                            DoRet2 = false;
                        }
                    }
                }
            }
            if (!ret)
            {
                if (Port2Text.Length > _BufferLine)
                {
                    lock (this.PortBuffSyc)
                    {
                        this.PortBuffList.Add(new PortBuff(span, "COM2", dst, Port2Text));
                    }
                    Port2Text = "";
                    DoRet2 = false;
                }
                IAsyncResult ar = this.BeginInvoke((MethodInvoker)delegate ()
                {
                    _StatusLabel.Text = string.Format("P1:{0},  P2:{1}", Port1Text, Port2Text);
                });
                this.EndInvoke(ar);
            }
            AsyncWritePort1.BeginInvoke(buf, null, null);
        }

		private void PortParseString()
		{
            lock (this.PortBuffSyc)
            {
                foreach (var d in PortBuffList)
                {
                    if (!ViewUpdate.Checked)
                    {
                        LogTextBox.AppendText(String.Format("{0}, {1}, {2}, {3}", d.src, d.dst, d.Time.ToString(), d.Data) + Environment.NewLine);
                    }
                }
                this.PortBuffList.Clear();
            }
			return;
		}


		private void timer1_Tick(object sender, EventArgs e)
		{
            this.AutoSaveData();
            this.PortParseString();
		}

		private void AutoSaveData()
		{
			if (this.AutoSave.Checked)
			{
                if (this.PortBuffList.Count() != 0)
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(this.SaveFileName.Text, true, System.Text.Encoding.UTF8))
                    {
                        foreach (var d in PortBuffList)
                        {
                            sw.Write(String.Format("{0}, {1}, {2}, {3}", d.src, d.dst, d.Time.ToString(), d.Data) + Environment.NewLine);
                        }
                    }
                }
			}
		}

		private void SaveDialog_Open_Click(object sender, EventArgs e)
		{
			if (this.AutoSave.Checked)
			{
				throw new Exception("自動保存のチェックを外してください。");
			}
			else
			{
				if (this._SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
				{
					return;
				}
				else
				{
					if (this.SaveFileName.Text != this._SaveFileDialog.FileName)
					{
						this.SaveFileName.Text = this._SaveFileDialog.FileName;
					}
				}
			}
		}

		private void AutoSave_CheckedChanged(object sender, EventArgs e)
		{
			if (this.AutoSave.Checked)
			{
				if (this.SaveFileName.Text == "")
				{
					this.AutoSave.Checked = false;
					throw new Exception("ファイル名が指定されていません。");
				}
			}
		}

		private void Save_Click(object sender, EventArgs e)
		{
			if (this.AutoSave.Checked)
			{
				this.AutoSaveData();
			}
			else
			{
				if (this.SaveFileName.Text == "")
				{
					if (this._SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
					{
						return;
					}
					else
					{
						if (this.SaveFileName.Text != this._SaveFileDialog.FileName)
						{
							this.SaveFileName.Text = this._SaveFileDialog.FileName;
						}
					}
				}
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(this.SaveFileName.Text, true, System.Text.Encoding.UTF8))
                {
                    sw.Write(LogTextBox.Text);
                }
			}
		}

		private void LogClear_Click(object sender, EventArgs e)
		{
            LogTextBox.Clear();
		}

		private void serialPort1_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
		{
			if (this._SerialPort1.IsOpen)
			{
				this._SerialPort1.Close();
				this.COM1_Open.Text = "接続";
			}
		}

		private void serialPort2_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
		{
			if (this._SerialPort2.IsOpen)
			{
				this._SerialPort2.Close();
				this.COM2_Open.Text = "接続";
			}
		}

        private void SendFileToCOM_Click(object sender, EventArgs e, System.IO.Ports.SerialPort port)
        {
            Button COM_Open;
            string src = "ファイル";
            string dst;
            if (port == this._SerialPort1)
            {
                COM_Open = this.COM1_Open;
                dst = "COM1";
            }
            else
            {
                COM_Open = this.COM2_Open;
                dst = "COM2";
            }
            if (port.IsOpen)
            {
                if (this._OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (System.IO.File.Exists(this._OpenFileDialog.FileName))
                    {
                        try
                        {
                            byte[] bs = null;
                            
                            using (System.IO.FileStream fs = new System.IO.FileStream(this._OpenFileDialog.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                            {
                                bs = new byte[fs.Length];
                                fs.Read(bs, 0, bs.Length);
                            }
                            string buff = "";
                            foreach (byte b in bs)
                            {
                                buff += b.ToString("X2") + " ";
                            }
                            TimeSpan span;
                            if (!this.Stopwatch.IsRunning)
                            {
                                this.Stopwatch.Start();
                            }
                            span = this.Stopwatch.Elapsed;
                            try
                            {
                                port.Write(bs, 0, bs.Count());
                                lock (this.PortBuffSyc)
                                {

                                    PortBuffList.Add(new PortBuff(span, src, dst, buff));
                                }
                             }
                             catch
                             {
                                 port.Close();
                                 COM_Open.Text = "接続";
                                 IAsyncResult ar = this.BeginInvoke((MethodInvoker)delegate()
                                 {
                                     throw new Exception("書き込みがタイムアウトしました。");
                                 });
                                 this.EndInvoke(ar);
                             }
                         }
                         catch
                         {
                             throw new Exception("ファイル読み込みに失敗しました。");
                         }
                     }
                     else
                     {
                         throw new Exception("不正なファイルが指定されました。");
                     }
                 }
            }
            else
            {
                throw new Exception(string.Format("{0}を接続してください。", dst));
            }

        }
        private void SendFileToCOM1_Click(object sender, EventArgs e)
        {
            SendFileToCOM_Click(sender, e, this._SerialPort1);
        }

        private void SendFileToCOM2_Click(object sender, EventArgs e)
        {
            SendFileToCOM_Click(sender, e, this._SerialPort2);
        }

        private void RetCode_TextChanged(object sender, EventArgs e)
        {
            DoRet1 = false;
            DoRet2 = false;
        }

        private void RetEndPlus_CheckedChanged(object sender, EventArgs e)
        {
            DoRet1 = false;
            DoRet2 = false;
        }
    }
}
