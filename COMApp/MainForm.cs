using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Concurrent;
using System.Threading;

namespace COMApp
{
    public partial class MainForm : Form
    {
        private ConcurrentQueue<byte[]> _WriteQueue;
        private ManualResetEvent _ManualResetEvent;
        private bool _RunThread;
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

        private int _BufferLine;
        private int _BufferPos;
        private string _NewLine;
        private bool _IsAutoCmd;
        private bool _HasRes;
        private bool _DoRet;
        public class CmdParameter
        {
            public System.Windows.Forms.CheckBox HasSTX { set; get; }
            public System.Windows.Forms.TextBox STX { set; get; }

            public System.Windows.Forms.CheckBox HeadAscii { set; get; }
            public System.Windows.Forms.CheckBox HasHead { set; get; }
            public System.Windows.Forms.TextBox Head { set; get; }

            public System.Windows.Forms.CheckBox CmdAscii { set; get; }
            public System.Windows.Forms.CheckBox HasCmd { set; get; }
            public System.Windows.Forms.TextBox Cmd { set; get; }

            public System.Windows.Forms.CheckBox HasDataLen { set; get; }
            public System.Windows.Forms.TextBox DataLen { set; get; }

            public System.Windows.Forms.CheckBox HasData { set; get; }
            public System.Windows.Forms.TextBox Data { set; get; }

            public System.Windows.Forms.CheckBox HasETX { set; get; }
            public System.Windows.Forms.TextBox ETX { set; get; }

            public System.Windows.Forms.CheckBox HasBCC { set; get; }
            public System.Windows.Forms.TextBox BCC { set; get; }

            public CmdParameter(CheckBox hasstx,
                TextBox stx,
                CheckBox headascii,
                CheckBox hashead,
                TextBox head,
                CheckBox cmdascii,
                CheckBox hascmd,
                TextBox cmd,
                CheckBox hasdatalen,
                TextBox datalen,
                CheckBox hasdata,
                TextBox data,
                CheckBox hasetx,
                TextBox etx,
                CheckBox hasbcc,
                TextBox bcc)
            {
                HasSTX = hasstx;
                STX = stx;
                HeadAscii = headascii;
                HasHead = hashead;
                Head = head;
                CmdAscii = cmdascii;
                HasCmd = hascmd;
                Cmd = cmd;
                HasDataLen = hasdatalen;
                DataLen = datalen;
                HasData = hasdata;
                Data = data;
                HasETX = hasetx;
                ETX = etx;
                HasBCC = hasbcc;
                BCC = bcc;
            }
        }


        private List<CmdParameter> _CmdParameterList;
        private byte[] _FileByteData;
        private List<string> _FileTextData;
        public MainForm()
        {
            InitializeComponent();

            this.Text = Properties.Settings.Default.Title;

            _Group0.Text += Properties.Settings.Default.Group0;
            _Group1.Text += Properties.Settings.Default.Group1;
            _Group2.Text += Properties.Settings.Default.Group2;
            _Group3.Text += Properties.Settings.Default.Group3;
            _Group4.Text += Properties.Settings.Default.Group4;
            _Group5.Text += Properties.Settings.Default.Group5;
            _Group6.Text += Properties.Settings.Default.Group6;


            _OpenFileDialog.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;

            _RunThread = false;
            _WriteQueue = new ConcurrentQueue<byte[]>();
            _ManualResetEvent = new ManualResetEvent(true);

 
            _BufferPos = 0;
            _BufferLine = Properties.Settings.Default.BufferLine;
            _NewLine = Environment.NewLine;

            _HasRes = false;

            _CmdParameterList = new List<CmdParameter>();
            _CmdParameterList.Add(new CmdParameter(_HasSTX0, _STX0, _HeadAscii0, _HasHead0, _Head0,
                _CmdAscii0, _HasCmd0, _Cmd0, _HasDataLen0, _DataLen0, _HasData0, _Data0,
                _HasETX0, _ETX0, _HasBCC0, _BCC0));
            _CmdParameterList.Add(new CmdParameter(_HasSTX1, _STX1, _HeadAscii1, _HasHead1, _Head1,
                _CmdAscii1, _HasCmd1, _Cmd1, _HasDataLen1, _DataLen1, _HasData1, _Data1,
                _HasETX1, _ETX1, _HasBCC1, _BCC1));
            _CmdParameterList.Add(new CmdParameter(_HasSTX2, _STX2, _HeadAscii2, _HasHead2, _Head2,
                _CmdAscii2, _HasCmd2, _Cmd2, _HasDataLen2, _DataLen2, _HasData2, _Data2,
                _HasETX2, _ETX2, _HasBCC2, _BCC2));
            _CmdParameterList.Add(new CmdParameter(_HasSTX3, _STX3, _HeadAscii3, _HasHead3, _Head3,
                _CmdAscii3, _HasCmd3, _Cmd3, _HasDataLen3, _DataLen3, _HasData3, _Data3,
                _HasETX3, _ETX3, _HasBCC3, _BCC3));
            _CmdParameterList.Add(new CmdParameter(_HasSTX4, _STX4, _HeadAscii4, _HasHead4, _Head4,
                _CmdAscii4, _HasCmd4, _Cmd4, _HasDataLen4, _DataLen4, _HasData4, _Data4,
                _HasETX4, _ETX4, _HasBCC4, _BCC4));
            _CmdParameterList.Add(new CmdParameter(_HasSTX5, _STX5, _HeadAscii5, _HasHead5, _Head5,
                _CmdAscii5, _HasCmd5, _Cmd5, _HasDataLen5, _DataLen5, _HasData5, _Data5,
                _HasETX5, _ETX5, _HasBCC5, _BCC5));
        }


        public void ThreadPoolCallback(Object threadContext)
        {
            while (_RunThread)
            {
                byte[] buf;
                if (!_WriteQueue.IsEmpty)
                {
                    if (_WriteQueue.TryDequeue(out buf))
                    {
                        int count = buf.Count();
                        string text = String.Format("{0}    | ", DateTime.Now.ToString());
                        try
                        {
                            _SerialPort.Write(buf, 0, count);
                            foreach (byte b in buf)
                            {
                                if (_DoSendAscii.Checked)
                                {
                                    int id = Array.IndexOf(ControlCode, b);
                                    if (id >= 0)
                                    {
                                        text += ControlCodeStr[id];
                                    }
                                    else
                                    {
                                        if (b < 128)
                                        {
                                            text += (char)b;
                                        }
                                        else
                                        {
                                            text += text += @"\x" + b.ToString("x2");
                                        }
                                    }
                                }
                                else
                                {
                                    text += b.ToString("x2") + " ";
                                }
                            }
                            text += _NewLine;
                            this.Invoke((Action)(() =>
                            {
                                _SendData.AppendText(text);
                            }));

                        }
                        catch
                        {
                            this.Invoke((Action)(() =>
                            {
                                MessageBox.Show("シリアル送信に失敗しました。", "エラー");
                                _Connect.Checked = false;
                            }));

                        }
                    }
                }
                Thread.Sleep(0);
            }
            _ManualResetEvent.Set();
        }

        private void UpdateSerialPort()
        {
            if (_SerialPort.IsOpen)
            {
                _SerialPort.Close();
                _Connect.Checked = false;
            }
            _SerialPort.PortName = Program.SerialPortInfo.PortName;
            _SerialPort.BaudRate = Program.SerialPortInfo.BaudRate;
            _SerialPort.DataBits = Program.SerialPortInfo.DataBits;
            _SerialPort.Parity = Program.SerialPortInfo.Parity;
            _SerialPort.StopBits = Program.SerialPortInfo.StopBits;
            _SerialPort.RtsEnable = Program.SerialPortInfo.RtsEnable;
            _SerialPort.DtrEnable = Program.SerialPortInfo.DtrEnable;
            _SerialPort.Handshake = Program.SerialPortInfo.Handshake;
            _SerialPort.Encoding = Encoding.GetEncoding(Program.SerialPortInfo.Encoding);
            if (Program.SerialPortInfo.NewLine == "CR")
            {
                _SerialPort.NewLine = "\r";
            }
            else if (Program.SerialPortInfo.NewLine == "LF")
            {
                _SerialPort.NewLine = "\n";
            }
            else if ((Program.SerialPortInfo.NewLine == "CRLF"))
            {
                _SerialPort.NewLine = "\r\n";
            }
            else
            {
                /* Unknown */
            }
        }
        private void SendCmd(CmdParameter param)
        {
            List<byte> cmd = new List<byte>();
            
            int bcc_start = 0;
            int bcc_end = 0;

            if (param.HasSTX.Checked)
            {
                AddByteList(cmd, param.STX.Text, false);
            }
            if (!_BCCIncSTX.Checked)
            {
                bcc_start = cmd.Count;
            }

            if (param.HasHead.Checked)
            {
                AddByteList(cmd, param.Head.Text, param.HeadAscii.Checked);
            }
            if (param.HasCmd.Checked)
            {
                AddByteList(cmd, param.Cmd.Text, param.CmdAscii.Checked);
            }
            if (param.HasDataLen.Checked)
            {
                AddByteList(cmd, param.DataLen.Text, true);
            }
            if (param.HasData.Checked)
            {
                AddByteList(cmd, param.Data.Text, true);
            }
            bcc_end = cmd.Count;
            if (param.HasETX.Checked)
            {
                AddByteList(cmd, param.ETX.Text, false);
            }
            if (_BCCIncETX.Checked)
            {
                bcc_end = cmd.Count;
            }

            if (param.HasBCC.Checked)
            {
                if (param.BCC.Text == "")
                {
                    int i;
                    byte bcc = 0;
                    for (i = bcc_start; i < bcc_end; ++i)
                    {
                        bcc = CalcBCC(bcc, cmd[i]);
                    }
                    cmd.Add(bcc);
                }
                else
                {
                    AddByteList(cmd, param.BCC.Text, false);
                }
            }

            _WriteQueue.Enqueue(cmd.ToArray());
        }

        private void AddByteList(List<byte> byte_list, string text, bool ascii)
        {
            if (ascii)
            {
                char[] cs = text.ToCharArray();
                foreach(var c in cs)
                {
                    int code = (int)c;
                    byte_list.Add((byte)code);
                }
            }
            else
            {
                string[] ss = text.Split(' ');
                foreach (var s in ss)
                {
                    byte b = 0;
                    if (byte.TryParse(s, System.Globalization.NumberStyles.HexNumber, null, out b))
                    {
                        byte_list.Add(b);
                    }
                }
            }
        }

        private byte CalcBCC(byte prev, byte bcc)
        {

            if (_BCCCalcSum.Checked)
            {
                prev += bcc;
            }
            else if (_BCCCalcXOR.Checked)
            {
                prev ^= bcc;
            }
            return prev;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateSerialPort();
        }

        private void _ComSetting_Click(object sender, EventArgs e)
        {
            SelCOMForm form = new SelCOMForm();
            form.ShowDialog();
            UpdateSerialPort();
        }

        private void _Connect_CheckedChanged(object sender, EventArgs e)
        {
            _DoRet = false;
            if (_Connect.Checked)
            {
                if (_SerialPort.IsOpen)
                {
                    _SerialPort.Close();
                }
                try
                {
                    _SerialPort.Open();
                    _RunThread = true;
                    _ManualResetEvent.Reset();
                    ThreadPool.QueueUserWorkItem(ThreadPoolCallback, this);

                }
                catch
                {
                    _Connect.Checked = false;
                    MessageBox.Show("シリアルポートを開く処理が失敗しました。設定を確認してください。", "エラー");
                }
                finally
                {

                }
            }
            else
            {
                _RunThread = false;
                _ManualResetEvent.WaitOne();
                if (_SerialPort.IsOpen)
                {
                    _SerialPort.Close();
                }
            }
        }

        private void _ClearSend_Click(object sender, EventArgs e)
        {
            _SendData.Text = "";
        }

        private void _ClearReceive_Click(object sender, EventArgs e)
        {
            _ReceiveData.Text = "";
        }

        private void _SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string text = "";
            int ret_code = -1;
            int size = _SerialPort.BytesToRead;
            byte[] buf = new byte[size];
            byte res_code = Byte.Parse(_ResponseCode.Text, System.Globalization.NumberStyles.HexNumber);
            _SerialPort.Read(buf, 0, size);

            if (_LineRetCode.Text != "")
            {
                int.TryParse(_LineRetCode.Text, System.Globalization.NumberStyles.HexNumber, null, out ret_code);
            }
            foreach(var b in buf)
            {
                if (_DoResponse.Checked)
                {
                    if (b == res_code)
                    {
                        _HasRes = true;
                    }
                }
                if (_BufferPos == 0)
                {
                    text += String.Format("{0}    | ", DateTime.Now.ToString());
                }
                if (_DoReceiveAscii.Checked)
                {
                    int id = Array.IndexOf(ControlCode, b);
                    if (id >= 0)
                    {
                        text += ControlCodeStr[id];
                    }
                    else
                    {
                        if (b < 128)
                        {
                            text += (char)b;
                        }
                        else
                        {
                            text += @"\x" + b.ToString("x2");
                        }
                    }
                }
                else
                {
                    text += b.ToString("x2") + " ";
                }
                ++_BufferPos;
                if (_DoRet)
                {
                    text += _NewLine;
                    _DoRet = false;
                    _BufferPos = 0;
                }
                if (ret_code >= 0 && ret_code <= 256)
                {
                    if (b == (byte)ret_code)
                    {
                        if (_RetEndPlus.Checked)
                        {
                            _DoRet = true;
                        }
                        else
                        {
                            text += _NewLine;
                            _BufferPos = 0;
                        }
                    }
                }
                else
                {
                    if (_BufferPos == _BufferLine)
                    {
                        text += _NewLine;
                        _BufferPos = 0;
                    }
                }
            }
            this.Invoke((Action)(() =>
            {
                _ReceiveData.AppendText(text);
            }));
        }

        private void _Send0_Click(object sender, EventArgs e)
        {
            SendCmd(_CmdParameterList[0]);
        }

        private void _Send1_Click(object sender, EventArgs e)
        {
            SendCmd(_CmdParameterList[1]);
        }

        private void _Send2_Click(object sender, EventArgs e)
        {
            SendCmd(_CmdParameterList[2]);
        }

        private void _Send3_Click(object sender, EventArgs e)
        {
            SendCmd(_CmdParameterList[3]);
        }

        private void _Send4_Click(object sender, EventArgs e)
        {
            SendCmd(_CmdParameterList[4]);
        }

        private void _Send5_Click(object sender, EventArgs e)
        {
            SendCmd(_CmdParameterList[5]);
        }

        private void _Send6_Click(object sender, EventArgs e)
        {
            List<byte> cmd = new List<byte>();

            int bcc_start = 0;
            int bcc_end = 0;

            if (_HasSTX6.Checked)
            {
                AddByteList(cmd, _STX6.Text, false);
            }
            if (!_BCCIncSTX.Checked)
            {
                bcc_start = cmd.Count;
            }

            AddByteList(cmd, _Data6.Text, _IsAscii6.Checked);

            bcc_end = cmd.Count;
            if (_HasETX6.Checked)
            {
                AddByteList(cmd, _ETX6.Text, false);
            }
            if (_BCCIncETX.Checked)
            {
                bcc_end = cmd.Count;
            }

            if (_HasBCC6.Checked)
            {
                if (_BCC6.Text == "")
                {
                    int i;
                    byte bcc = 0;
                    for (i = bcc_start; i < bcc_end; ++i)
                    {
                        bcc = CalcBCC(bcc, cmd[i]);
                    }
                    cmd.Add(bcc);
                }
                else
                {
                    AddByteList(cmd, _BCC6.Text, false);
                }
            }
            _WriteQueue.Enqueue(cmd.ToArray());
        }

        private void _SendF_Click(object sender, EventArgs e)
        {
            List<byte> cmd = new List<byte>();
            int bcc_start = 0;
            int bcc_end = 0;

            if (!System.IO.File.Exists(_DataF.Text)
                || _FileByteData == null 
                || _FileTextData == null)
            {
                return;
            }
            if (_IsSendLine.Checked)
            {
                int pos = Convert.ToInt32(_NextLine.Text);
                int total = Convert.ToInt32(_TotalLine.Text);
                if (total < pos)
                {
                    return;
                }

            }

            if (_HasSTXF.Checked)
            {
                AddByteList(cmd, _STXF.Text, false);
            }
            if (!_BCCIncSTX.Checked)
            {
                bcc_start = cmd.Count;
            }

            if (_HasHeadF.Checked)
            {
                AddByteList(cmd, _HeadF.Text, _HeadAsciiF.Checked);
            }
            if (_HasCmdF.Checked)
            {
                AddByteList(cmd, _CmdF.Text, _CmdAsciiF.Checked);
            }
            if (_HasDataLenF.Checked)
            {
                AddByteList(cmd, _DataLenF.Text, true);
            }

            if (_IsSendLine.Checked)
            {
                int pos = Convert.ToInt32(_NextLine.Text);
                AddByteList(cmd, _FileTextData[pos - 1], true);
            }
            else
            {
                foreach (var b in _FileByteData)
                {
                    cmd.Add(b);
                }
            }
            bcc_end = cmd.Count;
            if (_HasETXF.Checked)
            {
                AddByteList(cmd, _ETXF.Text, false);
            }
            if (_BCCIncETX.Checked)
            {
                bcc_end = cmd.Count;
            }

            if (_HasBCCF.Checked)
            {
                if (_BCCF.Text == "")
                {
                    int i;
                    byte bcc = 0;
                    for (i = bcc_start; i < bcc_end; ++i)
                    {
                        bcc = CalcBCC(bcc, cmd[i]);
                    }
                    cmd.Add(bcc);
                }
                else
                {
                    AddByteList(cmd, _BCCF.Text, false);
                }
            }
            _WriteQueue.Enqueue(cmd.ToArray());

            if (_IsSendLine.Checked)
            {
                int pos = Convert.ToInt32(_NextLine.Text);
                int total = Convert.ToInt32(_TotalLine.Text);
                if (pos < total)
                {
                    _NextLine.Text = (pos + 1).ToString();
                }
            }
        }

        private void _IntervalTimer_Tick(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(_IntervalCmdID.Text, out n))
            {
                if (n < _CmdParameterList.Count)
                {
                    SendCmd(_CmdParameterList[n]);
                }
            }
        }

        private void _StartInterval_CheckedChanged(object sender, EventArgs e)
        {
            if (_StartInterval.Checked)
            {
                _IntervalTimer.Interval = Convert.ToInt32(_Interval.Text);
                _IntervalTimer.Start(); 
            }
            else
            {
                _IntervalTimer.Stop();
            }
        }

        private void _AutoTimer_Tick(object sender, EventArgs e)
        {
            bool do_sendF = true;
            if (_DoResponse.Checked)
            {
                if (!_HasRes)
                {
                    return;
                }
                _HasRes = false;
            }

            if (_HasAutoCmd.Checked)
            {
                if (_IsAutoCmd)
                {
                    do_sendF = false;
                    _IsAutoCmd = false;
                }
                else
                {
                    _IsAutoCmd = true;
                }
            }
            if (do_sendF)
            {
                if (_IsSendLine.Checked)
                {
                    int pos = Convert.ToInt32(_NextLine.Text);
                    int total = Convert.ToInt32(_TotalLine.Text);
                    if (pos >= total)
                    {
                        _StartAutoSendF.Checked = false;
                    }
                }
                _SendF_Click(sender, e);


            }
            else
            {
                SendCmd(_CmdParameterList[Convert.ToInt32(_AutoCmdID.Text)]);
            }
        }

        private void _StartAutoSendF_CheckedChanged(object sender, EventArgs e)
        {
            if (_StartAutoSendF.Checked)
            {
                _HasRes = true;
                _IsAutoCmd = false;
                if (_DoAutoInterval.Checked)
                {
                    _AutoTimer.Interval = Convert.ToInt32(_AutoInterval.Text);
                }
                else
                {
                    _AutoTimer.Interval = 1;
                }
                _AutoTimer.Start();
            }
            else
            {
                _AutoTimer.Stop();
            }
        }

        private void _OpenDataF_Click(object sender, EventArgs e)
        {
            if (_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                _DataF.Text = _OpenFileDialog.FileName;
                _FileByteData = null;
                _FileTextData = null;
                using (var fs = new System.IO.FileStream(_DataF.Text,
                    System.IO.FileMode.Open,
                    System.IO.FileAccess.Read))
                {
                    _FileByteData = new byte[fs.Length];
                    fs.Read(_FileByteData, 0, _FileByteData.Length);
                }
                using (var sr = new System.IO.StreamReader(_DataF.Text, Encoding.Default))
                {
                    string line;
                    _FileTextData = new List<string>();
                    while ((line = sr.ReadLine()) != null)
                    {
                        _FileTextData.Add(line);
                    }
                    _TotalLine.Text = _FileTextData.Count.ToString();
                    _NextLine.Text = 1.ToString();
                }
            }
        }

        private void _DoAutoInterval_CheckedChanged(object sender, EventArgs e)
        {
            if (_DoAutoInterval.Checked)
            {
                _AutoTimer.Interval = Convert.ToInt32(_AutoInterval.Text);
            }
        }

        private void _DoResponse_CheckedChanged(object sender, EventArgs e)
        {
            if (_DoResponse.Checked)
            {
                _AutoTimer.Interval = 10;
            }
        }

        private void ByteHex_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox)
            {
                string text = ((TextBox)sender).Text;
                if (text != "")
                {
                    byte b;
                    e.Cancel = !byte.TryParse(text, System.Globalization.NumberStyles.HexNumber, null, out b);
                }
            }
        }

        private void _IntervalCmdID_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox)
            {
                string text = ((TextBox)sender).Text;
                if (text != "")
                {
                    int n;
                    if (int.TryParse(text, System.Globalization.NumberStyles.HexNumber, null, out n))
                    {
                        if (n < 0 || n > 6)
                        {
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
        private void PositiveInteger_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox)
            {
                string text = ((TextBox)sender).Text;
                if (text != "")
                {
                    int n;
                    if (int.TryParse(text, out n))
                    {
                        if (n < 0)
                        {
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void _LineRetCode_TextChanged(object sender, EventArgs e)
        {
            _DoRet = false;
        }

        private void _RetEndPlus_CheckedChanged(object sender, EventArgs e)
        {
            _DoRet = false;
        }

        private void _DataClear_Click(object sender, EventArgs e)
        {
            if (sender.Equals(_DataClear0))
            {
                _Data0.Clear();
            }
            else if (sender.Equals(_DataClear1))
            {
                _Data1.Clear();
            }
            else if (sender.Equals(_DataClear2))
            {
                _Data2.Clear();
            }
            else if (sender.Equals(_DataClear3))
            {
                _Data3.Clear();
            }
            else if (sender.Equals(_DataClear4))
            {
                _Data4.Clear();
            }
            else if (sender.Equals(_DataClear5))
            {
                _Data5.Clear();
            }
            else if (sender.Equals(_DataClear6))
            {
                _Data6.Clear();
            }
            else
            {

            }

        }
    }
}
