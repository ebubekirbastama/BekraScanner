using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BekraKıll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kıll_Process k = new Kıll_Process();
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] klasorler =Directory.CreateDirectory("D:ebs");
            for (int j = 0; j < klasorler.Length; j++)
            {
                MessageBox.Show(klasorler[j].ToString());
            }

        }
    }
}
