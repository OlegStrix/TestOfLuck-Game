using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino_Game
{
    public partial class Games : Form
    {
        public MainForm mForm;
        public Games()
        {
            InitializeComponent();
        }

        private void Games_Load(object sender, EventArgs e)
        {
            Money.Text = mForm.TextBox_PasteMoney.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
