using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace RemotePlayMasher_2020
{
    public partial class frmMainWindow : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        const int WM_KEYDOWN = 0x0100;
        const int WM_KEYUP = 0x0101;
        const int VK_RETURN = 0x0D;

        private KeyHandler ghk;
        private Thread masherThread;

        public frmMainWindow()
        {
            InitializeComponent();
            ghk = new KeyHandler(Keys.Back, this);
            ghk.Register();
        }

        private void StartMasherThread()
        {
            if (cboWindowFocus.SelectedIndex == 0)
            {
                btnStart.Text = "STOP";
                masherThread = new Thread(() =>
                {
                    try
                    {
                        string buttonToMash = "{ENTER}";
                        Thread.CurrentThread.IsBackground = true;
                        IntPtr zero = IntPtr.Zero;
                        for (int i = 0; (i < 60) && (zero == IntPtr.Zero); i++)
                        {
                            Thread.Sleep(500);
                            zero = FindWindow(null, "PS Remote Play");
                        }
                        while (true)
                        {
                            if (zero != IntPtr.Zero)
                            {
                                SetForegroundWindow(zero);
                                SendKeys.SendWait(buttonToMash);
                                SendKeys.Flush();
                                Thread.Sleep(1000 / (int)numTimesPerSecond.Value);
                            }
                        }
                    }
                    catch (Exception e)
                    {

                    }
                });
                masherThread.Start();
            }
            else if (cboWindowFocus.SelectedIndex == 1)
            {
                btnStart.Text = "STOP";
                masherThread = new Thread(() =>
                {
                    try
                    {
                        int buttonToMash = VK_RETURN;
                        Thread.CurrentThread.IsBackground = true;
                        IntPtr zero = IntPtr.Zero;
                        for (int i = 0; (i < 60) && (zero == IntPtr.Zero); i++)
                        {
                            Thread.Sleep(500);
                            zero = FindWindow(null, "PS Remote Play");
                        }
                        while (true)
                        {
                            if (zero != IntPtr.Zero)
                            {
                                int msPauseBetweenPresses = 1000 / (int)numTimesPerSecond.Value;
                                SendMessage(zero, WM_KEYDOWN, new IntPtr(buttonToMash), IntPtr.Zero);
                                Thread.Sleep(10);
                                SendMessage(zero, WM_KEYUP, new IntPtr(buttonToMash), IntPtr.Zero);
                                /*
                                SetForegroundWindow(zero);
                                SendKeys.SendWait(buttonToMash);
                                SendKeys.Flush();
                                */
                                Thread.Sleep(msPauseBetweenPresses);
                            }
                        }
                    }
                    catch (Exception e)
                    {

                    }
                });
                masherThread.Start();
            }
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            btnStart.Text = "START";
            cboWindowFocus.SelectedIndex = 1;
            picCross.BackColor = SystemColors.Highlight;
            //StartMasherThread();
        }
        private void EscapeKeyPressed()
        {
            if (masherThread != null)
            {
                masherThread.Abort();
                masherThread = null;
                btnStart.Text = "START";
            }
            this.Activate();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                EscapeKeyPressed();
            base.WndProc(ref m);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (masherThread == null) StartMasherThread();
            else
            {
                masherThread.Abort();
                masherThread = null;
                btnStart.Text = "START";
            }
        }

        private void picButtonClicked(object sender, EventArgs e)
        {
            picCross.BackColor = picSquare.BackColor = picCircle.BackColor = picTriangle.BackColor = SystemColors.Control;
            (sender as Control).BackColor = SystemColors.Highlight;
        }
    }
}
