using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elsoWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            lbl_udvozles.Text = "Hello 5/13SZ";
        }

        private void btn_kiir_Click(object sender, EventArgs e)
        {
            lbl_udvozles.Text = tb_szoveg.Text;
        }
    }
}
