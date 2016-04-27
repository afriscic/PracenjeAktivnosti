using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PracenjeAktivnosti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Screen.GetWorkingArea(this).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.GetWorkingArea(this).Width - this.Size.Width, 0);
            this.Height = Screen.GetWorkingArea(this).Height;
        }
    }
}
