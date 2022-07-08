using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Resume_Creator
{
    public partial class msgboxConverted : Form
    {
        public msgboxConverted()
        {
            InitializeComponent();
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.Move("C:\Users\bern\source\repos\PDF-Resume-Creator\bin\Debug\resume.pdf", newNameFullPath);
        }
    }
}
