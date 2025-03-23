using aplicatie.bazadedateDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicatie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazadedateDataSet1.cati_e_cls1' table. You can move, or remove it, as needed.
            //this.cati_e_cls1TableAdapter.Fill(this.bazadedateDataSet1.cati_e_cls1);
            // TODO: This line of code loads data into the 'bazadedateDataSet1.Profesor' table. You can move, or remove it, as needed.
           // this.profesorTableAdapter.Fill(this.bazadedateDataSet1.Profesor);
            // TODO: This line of code loads data into the 'bazadedateDataSet1.Materie' table. You can move, or remove it, as needed.
          //  this.materieTableAdapter.Fill(this.bazadedateDataSet1.Materie);
            // TODO: This line of code loads data into the 'bazadedateDataSet1.Elev' table. You can move, or remove it, as needed.
          //  this.elevTableAdapter.Fill(this.bazadedateDataSet1.Elev);
            // TODO: This line of code loads data into the 'bazadedateDataSet1.Clasa' table. You can move, or remove it, as needed.
           // this.clasaTableAdapter.Fill(this.bazadedateDataSet1.Clasa);
            // TODO: This line of code loads data into the 'bazadedateDataSet.Catalog' table. You can move, or remove it, as needed.
           // this.catalogTableAdapter.Fill(this.bazadedateDataSet.Catalog);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.
             label1.Text = "" + this.elevTableAdapter.Cati_e_cls(2);
        }
        int[] nr = new int[8];

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("date_e.txt");
            String[] cuv = new string[41];
            int i = 1;
            while (!sr.EndOfStream)
            {
                cuv[i] = sr.ReadLine();
                i++;
            }
            int ok = 0;
            int k=1, j, s=0, n;
            n = 7;
            for(j=1;j<=n;j++)
            {
                nr[j] = s;
                s = s+ Convert.ToInt32(this.elevTableAdapter.Cati_e_cls(j));
                //Nr de elevi din fiecare clasa
            }
            j = 1;
            for (i = 1; i < cuv.Length; i++)
            {
                if (textBox1.Text == cuv[i])
                {
                    ok = 1;
                    if (textBox2.Text == "1234")
                    {
                        label1.Text =" "+i;
                        if (i > nr[j] && i <= nr[j+1])
                        {
                            Form2 form2 = new Form2(i, nr[j], nr[j+1]);
                            form2.Show();
                        }
                        j++;
                        label1.Text = label1.Text + " " + nr[j];
                        if (i > nr[j] && i <= nr[j+1])
                        {
                            Form3 form3 = new Form3(i, nr[j], nr[j + 1]);
                            form3.Show();
                        }
                        j++;
                        if(i> nr[j]  && i <= nr[j+1])
                        {
                            Form4 form4 = new Form4(i, nr[j], nr[j + 1]);
                            form4.Show();
                        }
                        j++;
                        if (i > nr[j] && i <= nr[j + 1])
                        {
                            Form5 form5 = new Form5(i, nr[j], nr[j + 1]);
                            form5.Show();
                        }
                        j++;
                        if (i > nr[j] && i <= nr[j + 1])
                        {
                            Form6 form6 = new Form6(i, nr[j], nr[j+1]);
                            form6.Show();
                        }
                    }
                }
            }
            if (textBox1.Text != "profesor" && ok == 0)
                MessageBox.Show("Identificator incorect", "Eroare");
            else
            if (textBox1.Text == "profesor" && textBox2.Text != "1234")
                MessageBox.Show("Parola incorecta", "Eroare");
            else
            if (ok == 1 && textBox2.Text != "1234")
                MessageBox.Show("Parola incorecta", "Eroare");
            else
                MessageBox.Show("Date corecte");
            if (textBox1.Text == "profesor" && textBox2.Text == "1234")
            {
                panel2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(0, nr[1], nr[2]);
            form2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(0, nr[2], nr[3]);
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(0, nr[3], nr[4]);
            form4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(0, nr[4], nr[5]);
            form5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(0, nr[5], nr[6]);
            form6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Sigur dorești să închizi aplicația?", "Atenție", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }  
}
