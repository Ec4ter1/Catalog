namespace aplicatie
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catiecls1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadedateDataSet1 = new aplicatie.bazadedateDataSet();
            this.bazadedateDataSet = new aplicatie.bazadedateDataSet();
            this.catalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogTableAdapter = new aplicatie.bazadedateDataSetTableAdapters.CatalogTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clasaTableAdapter = new aplicatie.bazadedateDataSetTableAdapters.ClasaTableAdapter();
            this.elevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elevTableAdapter = new aplicatie.bazadedateDataSetTableAdapters.ElevTableAdapter();
            this.materieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materieTableAdapter = new aplicatie.bazadedateDataSetTableAdapters.MaterieTableAdapter();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesorTableAdapter = new aplicatie.bazadedateDataSetTableAdapters.ProfesorTableAdapter();
            this.cati_e_cls1TableAdapter = new aplicatie.bazadedateDataSetTableAdapters.cati_e_cls1TableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catiecls1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.catiecls1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(248, 586);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(410, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // nrDataGridViewTextBoxColumn
            // 
            this.nrDataGridViewTextBoxColumn.DataPropertyName = "Nr";
            this.nrDataGridViewTextBoxColumn.HeaderText = "Nr";
            this.nrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrDataGridViewTextBoxColumn.Name = "nrDataGridViewTextBoxColumn";
            this.nrDataGridViewTextBoxColumn.Width = 125;
            // 
            // catiecls1BindingSource
            // 
            this.catiecls1BindingSource.DataMember = "cati_e_cls1";
            this.catiecls1BindingSource.DataSource = this.bazadedateDataSet1;
            // 
            // bazadedateDataSet1
            // 
            this.bazadedateDataSet1.DataSetName = "bazadedateDataSet";
            this.bazadedateDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bazadedateDataSet
            // 
            this.bazadedateDataSet.DataSetName = "bazadedateDataSet";
            this.bazadedateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catalogBindingSource
            // 
            this.catalogBindingSource.DataMember = "Catalog";
            this.catalogBindingSource.DataSource = this.bazadedateDataSet;
            // 
            // catalogTableAdapter
            // 
            this.catalogTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 716);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(854, 631);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // clasaBindingSource
            // 
            this.clasaBindingSource.DataMember = "Clasa";
            this.clasaBindingSource.DataSource = this.bazadedateDataSet1;
            // 
            // clasaTableAdapter
            // 
            this.clasaTableAdapter.ClearBeforeFill = true;
            // 
            // elevBindingSource
            // 
            this.elevBindingSource.DataMember = "Elev";
            this.elevBindingSource.DataSource = this.bazadedateDataSet1;
            // 
            // elevTableAdapter
            // 
            this.elevTableAdapter.ClearBeforeFill = true;
            // 
            // materieBindingSource
            // 
            this.materieBindingSource.DataMember = "Materie";
            this.materieBindingSource.DataSource = this.bazadedateDataSet1;
            // 
            // materieTableAdapter
            // 
            this.materieTableAdapter.ClearBeforeFill = true;
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataMember = "Profesor";
            this.profesorBindingSource.DataSource = this.bazadedateDataSet1;
            // 
            // profesorTableAdapter
            // 
            this.profesorTableAdapter.ClearBeforeFill = true;
            // 
            // cati_e_cls1TableAdapter
            // 
            this.cati_e_cls1TableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(227, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 305);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(189, 43);
            this.textBox2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(100, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(37, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "Identificator";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 43);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(216, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autentificare";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 229);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Verifica";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(362, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(987, 192);
            this.label5.TabIndex = 12;
            this.label5.Text = "Catalog Școlar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1052, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 444);
            this.panel2.TabIndex = 13;
            this.panel2.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 368);
            this.button6.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 60);
            this.button6.TabIndex = 10;
            this.button6.Text = "XI ST1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 292);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 60);
            this.button5.TabIndex = 9;
            this.button5.Text = "IX MI";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 216);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 60);
            this.button4.TabIndex = 8;
            this.button4.Text = "VIII A";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 40);
            this.label6.TabIndex = 7;
            this.label6.Text = "Clasa";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 70);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "V D";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(23, 145);
            this.button7.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 60);
            this.button7.TabIndex = 4;
            this.button7.Text = "VII E";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightCoral;
            this.button8.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(1442, 17);
            this.button8.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 55);
            this.button8.TabIndex = 14;
            this.button8.Text = "X";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1576, 814);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Catalog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catiecls1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadedateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bazadedateDataSet bazadedateDataSet;
        private System.Windows.Forms.BindingSource catalogBindingSource;
        private bazadedateDataSetTableAdapters.CatalogTableAdapter catalogTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private bazadedateDataSet bazadedateDataSet1;
        private System.Windows.Forms.BindingSource clasaBindingSource;
        private bazadedateDataSetTableAdapters.ClasaTableAdapter clasaTableAdapter;
        private System.Windows.Forms.BindingSource elevBindingSource;
        private bazadedateDataSetTableAdapters.ElevTableAdapter elevTableAdapter;
        private System.Windows.Forms.BindingSource materieBindingSource;
        private bazadedateDataSetTableAdapters.MaterieTableAdapter materieTableAdapter;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private bazadedateDataSetTableAdapters.ProfesorTableAdapter profesorTableAdapter;
        private System.Windows.Forms.BindingSource catiecls1BindingSource;
        private bazadedateDataSetTableAdapters.cati_e_cls1TableAdapter cati_e_cls1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

