using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static List<string> cheats = new List<string>();
        public bool gtfound = false;
        public DataGridViewRow srow;

        public string nocliph = "";
        public string modflyh = "";
        public string onehith = "";
        public string arespawnh = "";

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, long lpBaseAddress, byte[] lpBuffer, int dwSize, ref int IpNumberOfBytesWritten);

        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VN_OPERATION = 0x0008;

        public long getbase(Process g)
        {
            return (long)g.MainModule.BaseAddress;
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Start();

            MessageBox.Show("wth made by niko#0420. Join the discord: https://discord.gg/KdVCYW2");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gtfound)
            {
                if (checkBox1.Checked)
                {
                    Process gt = Process.GetProcessesByName("Growtopia")[0];
                    IntPtr gthandle = OpenProcess(0x1F0FFF, true, gt.Id);
                    int w = 0;
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x24F56C, new byte[] { 0x90, 0x90, 0x90, 0x90 }, 4, ref w);
                   // MessageBox.Show(getbase(gt).ToString());
                   // MessageBox.Show(getbase(gt).ToString());
                    cheats.Add(checkBox1.Text);
                }
                else
                {
                    Process gt = Process.GetProcessesByName("Growtopia")[0];
                    IntPtr gthandle = OpenProcess(0x1F0FFF, true, gt.Id);
                    int w = 0;
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x24F56C, new byte[] { 0x80, 0x79, 0x12, 0x00 }, 4, ref w);
                    cheats.Remove(checkBox1.Text);
                }
            }
            else
            {
                MessageBox.Show("Gt isn't found");
                checkBox1.Checked = false;
            }
        } 

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] gt = Process.GetProcessesByName("Growtopia");
            if (gt.Length == 0)
            {
                StatusLabel.ForeColor = Color.Red;
                StatusLabel.Text = "Not found";
                gtfound = false;
                checkBox4.Checked = false;
            }
            else
            {
                StatusLabel.ForeColor = Color.Green;
                StatusLabel.Text = "Found";
                gtfound = true;
                checkBox4.Checked = true;
            }
            richTextBox1.Text = "";
            foreach (string x in cheats)
            {
                richTextBox1.AppendText(x+ "\n");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (gtfound)
            {
                if (checkBox2.Checked)
                {
                    Process gt = Process.GetProcessesByName("Growtopia")[0];
                    IntPtr gthandle = OpenProcess(0x1F0FFF, true, gt.Id);
                    int w = 0;
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x209F6E, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 }, 6, ref w);
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x209DFD, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 }, 8, ref w);
                    cheats.Add(checkBox2.Text);
                }
                else
                {
                    Process gt = Process.GetProcessesByName("Growtopia")[0];
                    IntPtr gthandle = OpenProcess(0x1F0FFF, true, gt.Id);
                    int w = 0;
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x209F6E, new byte[] { 0x0F, 0x85, 0x2C, 0x02, 0x00, 0x00 }, 6, ref w);
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x209DFD, new byte[] { 0xF3, 0x0F, 0x11, 0x83, 0x50, 0x01, 0x00, 0x00 }, 8, ref w);
                    cheats.Remove(checkBox2.Text);
                }
            }
            else
            {
                MessageBox.Show("Gt isn't found");
                checkBox2.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (gtfound)
            {
                if (checkBox3.Checked)
                {
                    Process gt = Process.GetProcessesByName("Growtopia")[0];
                    IntPtr gthandle = OpenProcess(0x1F0FFF, true, gt.Id);
                    int w = 0;
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x25FE38, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 }, 6, ref w);
                    cheats.Add(checkBox3.Text);
                }
                else
                {
                    Process gt = Process.GetProcessesByName("Growtopia")[0];
                    IntPtr gthandle = OpenProcess(0x1F0FFF, true, gt.Id);
                    int w = 0;
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x25FE38, new byte[] { 0x0F, 0x84, 0x88, 0x00, 0x00, 0x00 }, 6, ref w);
                    cheats.Remove(checkBox3.Text);
                }
            }
            else
            {
                MessageBox.Show("Gt isn't found");
                checkBox1.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (gtfound)
            {
                if (checkBox4.Checked)
                {
                    Process gt = Process.GetProcessesByName("Growtopia")[0];
                    IntPtr gthandle = OpenProcess(0x1F0FFF, true, gt.Id);
                    int w = 0;
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x18B59E, new byte[] { 0x90,0x90 }, 2, ref w);
                }
                else
                {
                    Process gt = Process.GetProcessesByName("Growtopia")[0];
                    IntPtr gthandle = OpenProcess(0x1F0FFF, true, gt.Id);
                    int w = 0;
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x18B59E, new byte[] { 0x75, 0x08 }, 2, ref w);
                }
            }
            else
            {
                //MessageBox.Show("Gt isn't found");
                checkBox1.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (gtfound)
            {
                if (checkBox6.Checked)
                {
                    Process gt = Process.GetProcessesByName("Growtopia")[0];
                    IntPtr gthandle = OpenProcess(0x1F0FFF, true, gt.Id);
                    int w = 0;
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x24F579, new byte[] { 0x90, 0x90 }, 2, ref w);
                    cheats.Add(checkBox6.Text);
                }
                else
                {
                    Process gt = Process.GetProcessesByName("Growtopia")[0];
                    IntPtr gthandle = OpenProcess(0x1F0FFF, true, gt.Id);
                    int w = 0;
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x24F579, new byte[] { 0x75, 0x07 }, 2, ref w);
                    cheats.Remove(checkBox6.Text);
                }
            }
            else
            {
                MessageBox.Show("Gt isn't found");
                checkBox1.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && comboBox1.Text != "")
            {

            }
                this.HotkeyGrid.Rows.Add(comboBox1.Text,comboBox2.Text);
        }

        private void HotkeyGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (HotkeyGrid.SelectedRows.Count == 1)
            {
                srow = HotkeyGrid.SelectedRows[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (HotkeyGrid.SelectedRows.Count > 0)
            {
                HotkeyGrid.Rows.Remove(HotkeyGrid.SelectedRows[0]);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (gtfound)
            {
                if (checkBox7.Checked)
                {
                    Process gt = Process.GetProcessesByName("Growtopia")[0];
                    IntPtr gthandle = OpenProcess(0x1F0FFF, true, gt.Id);
                    int w = 0;
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x189553, new byte[] { 0x74, 0x23 }, 2, ref w);
                    cheats.Add(checkBox6.Text);
                }
                else
                {
                    Process gt = Process.GetProcessesByName("Growtopia")[0];
                    IntPtr gthandle = OpenProcess(0x1F0FFF, true, gt.Id);
                    int w = 0;
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x189553, new byte[] { 0x75, 0x23 }, 2, ref w);
                    cheats.Remove(checkBox6.Text);
                }
            }
            else
            {
                MessageBox.Show("Gt isn't found");
                checkBox1.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (gtfound)
            {
                if (checkBox7.Checked)
                {
                    Process gt = Process.GetProcessesByName("Growtopia")[0];
                    IntPtr gthandle = OpenProcess(0x1F0FFF, true, gt.Id);
                    int w = 0;
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x18A3B2, new byte[] { 0x83, 0xC0, 0x50 }, 3, ref w);
                    cheats.Add(checkBox6.Text);
                }
                else
                {
                    Process gt = Process.GetProcessesByName("Growtopia")[0];
                    IntPtr gthandle = OpenProcess(0x1F0FFF, true, gt.Id);
                    int w = 0;
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x18A3B2, new byte[] { 0x83, 0xC0, 0x02 }, 3, ref w);
                    cheats.Remove(checkBox6.Text);
                }
            }
            else
            {
                MessageBox.Show("Gt isn't found");
                checkBox1.Checked = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (gtfound)
            {
                if (checkBox7.Checked)
                {
                    Process gt = Process.GetProcessesByName("Growtopia")[0];
                    IntPtr gthandle = OpenProcess(0x1F0FFF, true, gt.Id);
                    int w = 0;
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0xBC941, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 }, 7, ref w);
                    cheats.Add(checkBox6.Text);
                }
                else
                {
                    Process gt = Process.GetProcessesByName("Growtopia")[0];
                    IntPtr gthandle = OpenProcess(0x1F0FFF, true, gt.Id);
                    int w = 0;
                    WriteProcessMemory((int)gthandle, (long)getbase(gt) + 0x18A3B2, new byte[] { 0x80, 0xB9, 0xFC, 0x11, 0x00, 0x00, 0x00 }, 7, ref w);
                    cheats.Remove(checkBox6.Text);
                }
            }
            else
            {
                MessageBox.Show("Gt isn't found");
                checkBox1.Checked = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/KdVCYW2");
        }
    }
}
