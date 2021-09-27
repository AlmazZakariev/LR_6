using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                var rate = new Rates(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                textBox4.Text = Convert.ToString(rate.SumCalculation());
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Проверьте введённые данные", "Ошибка", MessageBoxButtons.OK  );
            }           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
