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
    public partial class MainForm : Form
    {
        public TextBox TextBox_PasteMoney;
        Games GamesForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GamesForm = new Games();
            TextBox_PasteMoney = PasteMoney;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(PasteMoney.Text) > 0)
            {
                GamesForm.mForm = this;
                GamesForm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Сумма должна быть положительна");
            }
              
        }

        private void PasteMoney_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
