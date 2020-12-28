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
        public TextBox TextBox_GamesMoney;
        MoreLess MoreLessForm;
        public MainForm mForm;
        public Games()
        {
            InitializeComponent();
        }

        private void Games_Load(object sender, EventArgs e)
        {
            TextBox_GamesMoney = Money;
            Money.Text = mForm.TextBox_PasteMoney.Text;
            MoreLessForm = new MoreLess();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoreLessForm.gForm = this;
            MoreLessForm.Show();
            this.Visible = false;
        }

        private void Money_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
