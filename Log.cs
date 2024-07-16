using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yolo_Demo
{
    public partial class Form1 : Form
    {
        UInt32 LogMaxCount = 3000;      // 300 default
        public bool bLogLogFlag = true;
        public bool bLogErrFlag = true;
        public bool bLogDbgFlag = true;
        public bool bLogInfoFlag = false;

        public void _L(string str)
        {
            try
            {
                if (richTextBoxLog.InvokeRequired)
                {
                    richTextBoxLog.Invoke(new MethodInvoker(delegate ()
                    {
                        if (richTextBoxLog.Lines.Length > LogMaxCount)
                            LOG_Clear();

                        richTextBoxLog.AppendText(str);
                        richTextBoxLog.ScrollToCaret();
                    }));
                }
                else
                {
                    if (richTextBoxLog.Lines.Length > LogMaxCount)
                        LOG_Clear();

                    richTextBoxLog.AppendText(str);
                    richTextBoxLog.ScrollToCaret();
                }
            }
            catch (Exception ex)
            {
                ERR(ex.Message);
            }
        }

        public void _L(string str, Color userColor)
        {
            try
            {
                str = "[" + DateTime.Now.ToString("HH:mm:ss") + "] " + str;
                if (richTextBoxLog.InvokeRequired)
                {
                    richTextBoxLog.Invoke(new MethodInvoker(delegate ()
                    {
                        richTextBoxLog.SelectionColor = userColor;
                        if (richTextBoxLog.Lines.Length > LogMaxCount)
                            LOG_Clear();

                        richTextBoxLog.AppendText(str);
                        richTextBoxLog.ScrollToCaret();
                        richTextBoxLog.SelectionColor = richTextBoxLog.ForeColor;
                    }));
                }
                else
                {
                    richTextBoxLog.SelectionColor = userColor;
                    if (richTextBoxLog.Lines.Length > LogMaxCount)
                        LOG_Clear();

                    richTextBoxLog.AppendText(str);
                    richTextBoxLog.ScrollToCaret();
                    richTextBoxLog.SelectionColor = richTextBoxLog.ForeColor;
                }
            }
            catch (Exception ex)
            {
                DBG(ex.Message);
            }
        }

        public void LOG(string str)
        {
            if(bLogLogFlag)
                _L(str, Color.Black);
        }

        public void LOG(string str, Color clr)
        {
            if (bLogLogFlag)
                _L(str, clr);
        }

        public void ERR(string str)
        {
            if (bLogErrFlag)
                _L(str + "\n", Color.Red);
        }

        public void ERR(string str, [CallerMemberName] string memberName = "", [CallerLineNumber] int sourceLine = 0)
        {
            if (bLogErrFlag)
                _L("[" + memberName + ", " + sourceLine + "] " + str + "\n", Color.Red);

        }

        public void LOG_Clear()
        {
            richTextBoxLog.Clear();
        }

        public void DBG(string str)
        {
            try
            {
                if (bLogDbgFlag)
                    Debug.Print("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + str);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        public void API(string str)
        {
             _L(str, Color.Blue);
        }


        public void INFO(string str)
        {
            if (bLogInfoFlag)
                _L(str, Color.Black);
        }
    }
}
