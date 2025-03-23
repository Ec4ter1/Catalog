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
    public partial class Form2 : Form
    {
        int el=0, st, dr;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int x, int a, int b)
        {
            InitializeComponent();
            el = x;
            st = a; 
            dr = b;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazadedateDataSet2.elev1' table. You can move, or remove it, as needed.
            //this.elev1TableAdapter.Fill(this.bazadedateDataSet.elev1);
            // TODO: This line of code loads data into the 'bazadedateDataSet2.Elev' table. You can move, or remove it, as needed.
            //this.eleviTableAdapter.Fill(bazadedateDataSet.Elevi, 1);
            this.eleviTableAdapter.Fill(bazadedateDataSet3.Elevi, 1);
            // TODO: This line of code loads data into the 'bazadedateDataSet.Catalog1' table. You can move, or remove it, as needed.
            //this.catalog1TableAdapter.Fill(this.bazadedateDataSet.Catalog1);
            // TODO: This line of code loads data into the 'bazadedateDataSet.elev2' table. You can move, or remove it, as needed.
            //this.elev2TableAdapter.Fill(this.bazadedateDataSet.elev2);
            // TODO: This line of code loads data into the 'bazadedateDataSet.elev1' table. You can move, or remove it, as needed.
            //this.elev1TableAdapter.Fill(this.bazadedateDataSet.elev1);
            profesor1TableAdapter.Fill(bazadedateDataSet.Profesor1,1);
            if(el==0)//e profesor
            {
                panel2.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
            if(el>st && el <=dr)
            {
                catalog1TableAdapter.Fill(bazadedateDataSet.Catalog1, el);
                pictureBox3.Visible = false;
                dataGridView3.Visible = true;
            }
            else
            {
                MessageBox.Show("Indtroduceți un identificator valid", "Eroare");
                ok = 0;
            }
            if (ok == 1)
                panel2.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;
            pictureBox3.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;
            pictureBox3.Visible = true;
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
