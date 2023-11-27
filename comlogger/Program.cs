using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Threading;

namespace COMLogger
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                //すでに起動していると判断して終了
                MessageBox.Show("アプリケーションがすでに立ち上がっています。");
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler((sender, e) =>
                {
                    MessageBox.Show(e.Exception.ToString(), "例外発生");
                    Application.Exit();
                });
                System.Threading.Thread.GetDomain().UnhandledException += new UnhandledExceptionEventHandler((sender, e) =>
                {
                    Exception exception = e.ExceptionObject as Exception;
                    if (exception != null)
                    {
                        MessageBox.Show(exception.ToString(), "例外発生");
                        Application.Exit();
                    }
                });

                Application.Run(new MainForm());
            }
        }
    }
}
