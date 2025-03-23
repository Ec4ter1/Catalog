using aplicatie.bazadedateDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicatie
{
    public partial class Form6 : Form
    {
        int el, st, dr;
        public Form6()
        {
            InitializeComponent();
        }
        public Form6(int x, int a, int b)
        {
            InitializeComponent();
            el = x;
            st = a;
            dr = b;

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int ok = 0;
            if (el == 0)
            {
                if (textBox1.Text == string.Empty)
                    MessageBox.Show("Indtroduceți un identificator valid", "Eroare");
                else
                {
                    el = Convert.ToInt32(textBox1.Text);
                    ok = 1;
                }

            }
            if (el > st && el <= dr)
            {
                catalog1TableAdapter.Fill(bazadedateDataSet.Catalog1, el);
                pictureBox3.Visible = false;
                dataGridView1.Visible = true;
            }
            else
            {
                MessageBox.Show("Indtroduceți un identificator valid", "Eroare");
                ok = 0;
            }
            if (ok == 1)
                panel2.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            pictureBox3.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            pictureBox3.Visible = true;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            profesor1TableAdapter.Fill(bazadedateDataSet.Profesor1, 5);
            eleviTableAdapter.Fill(bazadedateDataSet1.Elevi, 5);
            if (el == 0)
            {
                panel2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
