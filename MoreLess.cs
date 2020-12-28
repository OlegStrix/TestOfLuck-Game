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
    public partial class MoreLess : Form
    {
        public TextBox TextBox_MLMoney;
        public Games gForm;
        public MainForm mform;

        public MoreLess()
        {
            InitializeComponent();
        }

        private void MoreLess_Load(object sender, EventArgs e)
        {
            
            TextBox_MLMoney = MoreLessMoney;
            MoreLessMoney.Text = gForm.TextBox_GamesMoney.Text;
            
        }

        private void MoneyMoreLess_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void MoreLessMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PasteNumberIn_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonMore_Click(object sender, EventArgs e)
        {

            if (PasteNumberIn.Text.Length != 0 && PasteMoney.Text.Length != 0 && PasteNumberOut.Text.Length != 0)
            {
                //NI - значение поля ввода угадываемого числа
                int NI = Convert.ToInt32(PasteNumberIn.Text);
                //M - значение поля ввода ставки
                int M = Convert.ToInt32(PasteMoney.Text);
                //NO -значение поля ввода макс угадываемого числа
                int NO = Convert.ToInt32(PasteNumberOut.Text);
                if (NI > 0)
                {
                    if (M > 0)
                    {
                        if (NO > 0)
                        {
                            MessageBox.Show("Успешно");
                        }
                        else
                        {
                            MessageBox.Show("Число должно быть больше нуля");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ставка должна быть больше нуля");
                    }
                }
                else
                {
                    MessageBox.Show("Число должно быть больше нуля");
                }
            }
            else
            {
                MessageBox.Show("Введите значения в пустые поля");
            }
        }

        private void buttonLess_Click(object sender, EventArgs e)
        {

        }
    }
}
