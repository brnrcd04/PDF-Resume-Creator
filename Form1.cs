using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PDF_Resume_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.openFDJSON.Filter = "|*.json";

            if (openFDJSON.ShowDialog() == DialogResult.OK)
            {
                txtBoxSelected.Text = System.IO.Path.GetFullPath(openFDJSON.FileName);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Normal;
            ps.Arguments = @"/k md C:\Users\bern\source\repos\PDF-Resume-Creator\bin\Debug";
            Process.Start(ps);
        }

        private void txtBoxSelected_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
