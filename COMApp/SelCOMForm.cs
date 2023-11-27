using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace COMApp
{
	public partial class SelCOMForm : Form
	{
        private static readonly ReadOnlyCollection<int> _BaudRateList =
            Array.AsReadOnly(new int[] { 4800, 9600, 19200, 38400, 115200 });
        private static readonly ReadOnlyCollection<int> _DataBitsList =
            Array.AsReadOnly(new int[] { 7, 8 });

        private static readonly ReadOnlyCollection<System.IO.Ports.Parity> _ParityList =
            Array.AsReadOnly(new System.IO.Ports.Parity[] { System.IO.Ports.Parity.Even,
                                                            System.IO.Ports.Parity.Mark,
                                                            System.IO.Ports.Parity.None,
                                                            System.IO.Ports.Parity.Odd,
                                                            System.IO.Ports.Parity.Space });

        private static readonly ReadOnlyCollection<System.IO.Ports.StopBits> _StopBitsList =
            Array.AsReadOnly(new System.IO.Ports.StopBits[] { System.IO.Ports.StopBits.One,
                                                            System.IO.Ports.StopBits.OnePointFive,
                                                            System.IO.Ports.StopBits.Two});

        private static readonly ReadOnlyCollection<System.IO.Ports.Handshake> _HandshakeList =
            Array.AsReadOnly(new System.IO.Ports.Handshake[] { System.IO.Ports.Handshake.None,
                                                            System.IO.Ports.Handshake.RequestToSend,
                                                            System.IO.Ports.Handshake.RequestToSendXOnXOff,
                                                            System.IO.Ports.Handshake.XOnXOff});

        public static string ConfigName = @"SerialPortInfo.xml";

        public class SerialPortInfo
        { 
			public string PortName { set; get; }
			public int BaudRate { set; get; }
			public int DataBits { set; get; }
			public System.IO.Ports.Parity Parity { set; get; }
			public System.IO.Ports.StopBits StopBits { set; get; }
			public bool RtsEnable { set; get; }
			public bool DtrEnable { set; get; }
			public System.IO.Ports.Handshake Handshake { set; get; }
			public string Encoding { set; get; }
			public string NewLine { set; get; }
		}

		private string[] _Ports { set; get; }
        private string _FileName;
        public SelCOMForm()
		{
			InitializeComponent();
            _FileName = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, ConfigName);
        }

		private void SelCOMForm_Load(object sender, EventArgs e)
		{
            _Ports = System.IO.Ports.SerialPort.GetPortNames();
            if (_Ports.Count() < 1)
            {
                throw new Exception("使用可能なポートがありません。");
            }
            try
            {
                System.Xml.Serialization.XmlSerializer serializer =
                    new System.Xml.Serialization.XmlSerializer(typeof(SerialPortInfo));
                using (System.IO.FileStream fs = new System.IO.FileStream(_FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    Program.SerialPortInfo = (SerialPortInfo)serializer.Deserialize(fs);
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                Program.SerialPortInfo = new SerialPortInfo();
                Program.SerialPortInfo.PortName = _Ports[0];
                Program.SerialPortInfo.BaudRate = _BaudRateList[0];
                Program.SerialPortInfo.DataBits = _DataBitsList[0];
                Program.SerialPortInfo.Parity = _ParityList[0];
                Program.SerialPortInfo.StopBits = _StopBitsList[0];
                Program.SerialPortInfo.RtsEnable = false;
                Program.SerialPortInfo.DtrEnable = false;
                Program.SerialPortInfo.Handshake = System.IO.Ports.Handshake.None;
                Program.SerialPortInfo.Encoding = "utf-8";
                Program.SerialPortInfo.NewLine = "LF";
            }
            finally
            {              
                _Port.DataSource = _Ports.ToList();
                if (_Port.FindString(Program.SerialPortInfo.PortName) < 0)
                {
                    _Port.SelectedIndex = 0;
                }
                else
                {
                    _Port.SelectedIndex = _Port.FindString(Program.SerialPortInfo.PortName);
                }
                _BaudRate.DataSource = _BaudRateList.ToList();
                _BaudRate.SelectedIndex = _BaudRate.FindString(Program.SerialPortInfo.BaudRate.ToString());

                _DataBits.DataSource = _DataBitsList.ToList();
                _DataBits.SelectedIndex = _DataBits.FindString(Program.SerialPortInfo.DataBits.ToString());

                _Parity.DataSource = _ParityList.ToList();
                _Parity.SelectedIndex = _Parity.FindString(Program.SerialPortInfo.Parity.ToString());

                _StopBits.DataSource = _StopBitsList.ToList();
                _StopBits.SelectedIndex = _StopBits.FindString(Program.SerialPortInfo.StopBits.ToString());

                _Handshake.DataSource = _HandshakeList.ToList();
                _Handshake.SelectedIndex = _Handshake.FindString(Program.SerialPortInfo.Handshake.ToString());

            }
        }

		private void SelCOMForm_FormClosing(object sender, FormClosingEventArgs e)
		{

		}

		private void OKButton_Click(object sender, EventArgs e)
		{
            Program.SerialPortInfo.PortName = _Port.SelectedItem.ToString();
            Program.SerialPortInfo.BaudRate = _BaudRateList[_BaudRate.SelectedIndex];
            Program.SerialPortInfo.DataBits = _DataBitsList[_DataBits.SelectedIndex];
            Program.SerialPortInfo.Parity = _ParityList[_Parity.SelectedIndex];
            Program.SerialPortInfo.StopBits = _StopBitsList[_StopBits.SelectedIndex];

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SerialPortInfo));
                
                using (System.IO.FileStream fs = System.IO.File.Create(_FileName))
                {
                    serializer.Serialize(fs, Program.SerialPortInfo);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            this.Close();
		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
