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
            Random rnd = new Random();
            
            if (PasteNumberIn.Text.Length != 0 && PasteMoney.Text.Length != 0 && PasteNumberOut.Text.Length != 0)
            {
                double coef = 0;
                int variable = 0;
                double money;
                //NI - значение поля ввода угадываемого числа
                int NI = Convert.ToInt32(PasteNumberIn.Text);
                //M - значение поля ввода ставки
                double M = Convert.ToDouble(PasteMoney.Text);
                //NO -значение поля ввода макс угадываемого числа
                int NO = Convert.ToInt32(PasteNumberOut.Text);
                double NO_double = Convert.ToDouble(NO);
                double NI_double = Convert.ToDouble(NI);
                if (NI > 0 && M > 0 && NO > 0 && M <= Convert.ToDouble(MoreLessMoney.Text) && NI<=NO)
                {
                    coef = NO_double / (NO_double-NI_double)-0.07;
                    MessageBox.Show(Convert.ToString(coef));
                    money = M * coef ;
                    variable = rnd.Next(0, NO);
                    if(variable>=NI && variable <= NO)
                    {           
                        MessageBox.Show($"Вы выиграли : {money}");
                        double final = Convert.ToDouble(MoreLessMoney.Text) + money;
                        MoreLessMoney.Text = Convert.ToString(final);
                    }
                    else
                    {
                        MessageBox.Show($"Вы проиграли : {M}");
                        double final = Convert.ToDouble(MoreLessMoney.Text) - M;
                        this.MoreLessMoney.Text = Convert.ToString(final);
                    }           
                }
                else
                {
                    MessageBox.Show("Проверьте корректность введенных полей");
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

        private void MoreLessClosed(object sender, FormClosedEventArgs e)
        {
            gForm.TextBox_GamesMoney.Text = MoreLessMoney.Text;
            gForm.Show();
            this.Visible = false;
        }
    }
}
