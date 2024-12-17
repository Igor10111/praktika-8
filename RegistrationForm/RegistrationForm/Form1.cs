using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Label lbl1 = new Label();
            lbl1.Location = new System.Drawing.Point(12, 78);
            lbl1.Size = new System.Drawing.Size(50, 16);
            lbl1.Name = "label11";
            lbl1.TabIndex = 2;
            lbl1.Text = "PIN2";
            groupBox1.Controls.Add(lbl1);

            TextBox txt1 = new TextBox();
            txt1.Location = new System.Drawing.Point(72, 78);
            txt1.Size = new System.Drawing.Size(138, 35);
            txt1.Name = "textbox11";
            txt1.TabIndex = 1;
            txt1.Text = "";
            groupBox1.Controls.Add(txt1);

            txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }

            private void radioButton2_CheckedChanged(object sender, EventArgs e)
            {
                groupBox1.Controls.Clear();

                Label lbl1 = new Label();
                lbl1.Location = new System.Drawing.Point(12, 26);
                lbl1.Name = "lblfirst";
                lbl1.Size = new System.Drawing.Size(50, 16);
                lbl1.TabIndex = 4;
                lbl1.Text = "Name";
                groupBox1.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Location = new System.Drawing.Point(12, 52);
                lbl2.Name = "lblsecond";
                lbl2.Size = new System.Drawing.Size(29, 16);
                lbl2.TabIndex = 3;
                lbl2.Text = "PIN";
                groupBox1.Controls.Add(lbl2);

                TextBox txt1 = new TextBox();
                txt1.Location = new System.Drawing.Point(72, 26);
                txt1.Name = "textBox1";
                txt1.Size = new System.Drawing.Size(138, 35);
                txt1.TabIndex = 0;
                txt1.Text = "";
                groupBox1.Controls.Add(txt1);

                TextBox txt2 = new TextBox();
                txt2.Location = new System.Drawing.Point(72, 52);
                txt2.Name = "textBox2";
                txt2.Size = new System.Drawing.Size(138, 35);
                txt2.TabIndex = 1;
                txt2.Text = "";
                groupBox1.Controls.Add(txt2);
            }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lbloutput.Text = "Поле Name не может содержать цифры";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lbloutput.Text = "Поле PIN не может содержать буквы";
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBox1.Text);
                    e.Cancel = false;

                }
                catch
                {
                    e.Cancel = true;
                    lbloutput.Text = "Поле PIN не может содержать буквы";
                }
            }

        }
    }
}
