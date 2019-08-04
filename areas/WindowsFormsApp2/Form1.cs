using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void calculation()
        {
            double n;
            double n1;
            double n2;
            bool b = false;
            
            if (comboBox1.SelectedIndex == 0 && double.TryParse(textBox1.Text, out n))
            {
                label1.Text = Areas_Library.Area.Circle(n).ToString();
                if (label1.Text == "0")
                {
                    label1.Text = "ошибка";
                    label1.Update();
                    return;
                }
                label1.Update();
            }
            if (comboBox1.SelectedIndex == 1 && double.TryParse(textBox1.Text, out n))
            {
                label1.Text = Areas_Library.Area.square_or_rectangle(n).ToString();
                if (label1.Text == "0")
                {
                    label1.Text = "ошибка";
                    label1.Update();
                    return;
                }
                label1.Update();
            }
            if (comboBox1.SelectedIndex == 2 && double.TryParse(textBox1.Text, out n) && double.TryParse(textBox2.Text, out n1))
            {
                label1.Text = Areas_Library.Area.square_or_rectangle(n, n1).ToString();
                if (label1.Text == "0")
                {
                    label1.Text = "ошибка";
                    label1.Update();
                    return;
                }
                label1.Update();
            }
            if (comboBox1.SelectedIndex == 3 && double.TryParse(textBox1.Text, out n) && double.TryParse(textBox2.Text, out n1) && double.TryParse(textBox2.Text, out n2))
            {
                label1.Text = Areas_Library.Area.triangle(n, n1, n2, ref b).ToString();
                if (label1.Text == "0")
                {
                    label1.Text = "ошибка";
                    label1.Update();
                    return;
                }
                if (b)
                    label1.Text += " Треугольник прямоугольный";
                else
                    label1.Text += " Треугольник не прямоугольный";
                label1.Update();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            calculation();
        }
    }
}
