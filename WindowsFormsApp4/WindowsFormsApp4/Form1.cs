using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int ModPow(int x, int y, int z)
=> y == 0 ? 1 : (x * ModPow(x, y - 1, z)) % z;
        private void button1_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(textBox2.Text), q = Convert.ToInt32(textBox1.Text), l = 5, d = 25;
            int n, c = 0, m, r = 0;
            string s;
            n = p * q;
            s = textBox3.Text;
            m = Convert.ToInt32(s);
            textBox6.Text = l.ToString() + ", " + n.ToString();
            textBox7.Text = d.ToString() + ", " + n.ToString();
            if (m >= 0 && m < (n - 1))
            {
                c = ModPow(m, l, n);
                textBox4.Text = c.ToString();
                r = ModPow(c, d, n);
                textBox5.Text = r.ToString();
            }
            else MessageBox.Show("Слишком большое число");
        }
    }
}
