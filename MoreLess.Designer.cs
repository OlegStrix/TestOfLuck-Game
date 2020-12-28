
namespace Casino_Game
{
    partial class MoreLess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.MoreLessMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasteNumberIn = new System.Windows.Forms.TextBox();
            this.PasteNumberOut = new System.Windows.Forms.TextBox();
            this.buttonLess = new System.Windows.Forms.Button();
            this.buttonMore = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PasteMoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Средства:";
            // 
            // MoreLessMoney
            // 
            this.MoreLessMoney.Enabled = false;
            this.MoreLessMoney.Location = new System.Drawing.Point(127, 206);
            this.MoreLessMoney.Name = "MoreLessMoney";
            this.MoreLessMoney.Size = new System.Drawing.Size(100, 20);
            this.MoreLessMoney.TabIndex = 9;
            this.MoreLessMoney.TextChanged += new System.EventHandler(this.MoreLessMoney_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Из чисел";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PasteNumberIn
            // 
            this.PasteNumberIn.Location = new System.Drawing.Point(44, 82);
            this.PasteNumberIn.Name = "PasteNumberIn";
            this.PasteNumberIn.Size = new System.Drawing.Size(78, 20);
            this.PasteNumberIn.TabIndex = 12;
            this.PasteNumberIn.TextChanged += new System.EventHandler(this.PasteNumberIn_TextChanged);
            // 
            // PasteNumberOut
            // 
            this.PasteNumberOut.Location = new System.Drawing.Point(392, 82);
            this.PasteNumberOut.Name = "PasteNumberOut";
            this.PasteNumberOut.Size = new System.Drawing.Size(100, 20);
            this.PasteNumberOut.TabIndex = 13;
            // 
            // buttonLess
            // 
            this.buttonLess.Location = new System.Drawing.Point(275, 103);
            this.buttonLess.Name = "buttonLess";
            this.buttonLess.Size = new System.Drawing.Size(75, 23);
            this.buttonLess.TabIndex = 14;
            this.buttonLess.Text = "<";
            this.buttonLess.UseVisualStyleBackColor = true;
            this.buttonLess.Click += new System.EventHandler(this.buttonLess_Click);
            // 
            // buttonMore
            // 
            this.buttonMore.Location = new System.Drawing.Point(275, 62);
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.Size = new System.Drawing.Size(75, 23);
            this.buttonMore.TabIndex = 15;
            this.buttonMore.Text = ">";
            this.buttonMore.UseVisualStyleBackColor = true;
            this.buttonMore.Click += new System.EventHandler(this.buttonMore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ставка";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PasteMoney
            // 
            this.PasteMoney.Location = new System.Drawing.Point(161, 82);
            this.PasteMoney.Name = "PasteMoney";
            this.PasteMoney.Size = new System.Drawing.Size(93, 20);
            this.PasteMoney.TabIndex = 17;
            // 
            // MoreLess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 251);
            this.Controls.Add(this.PasteMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonMore);
            this.Controls.Add(this.buttonLess);
            this.Controls.Add(this.PasteNumberOut);
            this.Controls.Add(this.PasteNumberIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoreLessMoney);
            this.Controls.Add(this.label3);
            this.Name = "MoreLess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoreLess";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MoreLessClosed);
            this.Load += new System.EventHandler(this.MoreLess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MoreLessMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasteNumberIn;
        private System.Windows.Forms.TextBox PasteNumberOut;
        private System.Windows.Forms.Button buttonLess;
        private System.Windows.Forms.Button buttonMore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasteMoney;
    }
}