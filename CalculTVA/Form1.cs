using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculTVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p, tva, ptva, cota;
            p = Convert.ToDouble(textBox1.Text);
            int nr=comboBox1.SelectedIndex;
            if (nr == 0)
                cota = 0;
            else
                if (nr == 1)
                    cota = 9;
                else
                    cota = 19;
            tva = cota / 100 * p;
            ptva = p + tva;
            textBox2.Text = Convert.ToString(tva);
            textBox3.Text = Convert.ToString(ptva);
        }
    }
}
