﻿namespace Time_Table.Saydullo_main_menu
{
    partial class Add
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            doctors_select = new ComboBox();
            button1 = new Button();
            dateofbirth = new DateTimePicker();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            tel = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            name_box = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(35, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(1537, 412);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1477, 323);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(29, 12);
            label1.Name = "label1";
            label1.Size = new Size(156, 33);
            label1.TabIndex = 0;
            label1.Text = "Information";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(doctors_select);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dateofbirth);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(tel);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(name_box);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(35, 485);
            panel2.Name = "panel2";
            panel2.Size = new Size(1537, 361);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // doctors_select
            // 
            doctors_select.Enabled = false;
            doctors_select.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            doctors_select.FormattingEnabled = true;
            doctors_select.Location = new Point(201, 101);
            doctors_select.Name = "doctors_select";
            doctors_select.Size = new Size(268, 31);
            doctors_select.TabIndex = 2;
            doctors_select.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(729, 261);
            button1.Name = "button1";
            button1.Size = new Size(117, 50);
            button1.TabIndex = 18;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateofbirth
            // 
            dateofbirth.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateofbirth.Location = new Point(729, 32);
            dateofbirth.Name = "dateofbirth";
            dateofbirth.Size = new Size(268, 27);
            dateofbirth.TabIndex = 17;
            dateofbirth.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox8.Location = new Point(1238, 166);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(268, 30);
            textBox8.TabIndex = 16;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox7.Location = new Point(1238, 98);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(268, 30);
            textBox7.TabIndex = 15;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // tel
            // 
            tel.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tel.Location = new Point(1238, 33);
            tel.Name = "tel";
            tel.Size = new Size(268, 30);
            tel.TabIndex = 14;
            tel.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox5.Location = new Point(729, 166);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(268, 30);
            textBox5.TabIndex = 13;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(729, 98);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(268, 30);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(201, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 30);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // name_box
            // 
            name_box.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            name_box.Location = new Point(201, 33);
            name_box.Name = "name_box";
            name_box.Size = new Size(268, 30);
            name_box.TabIndex = 9;
            name_box.Text = "Name";
            name_box.TextAlign = HorizontalAlignment.Center;
            name_box.TextChanged += name_box_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(1040, 169);
            label10.Name = "label10";
            label10.Size = new Size(192, 23);
            label10.TabIndex = 8;
            label10.Text = "Amount with discount";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(1040, 105);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 7;
            label9.Text = "Discount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(1040, 35);
            label8.Name = "label8";
            label8.Size = new Size(134, 23);
            label8.TabIndex = 6;
            label8.Text = "Phone number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(529, 169);
            label7.Name = "label7";
            label7.Size = new Size(194, 23);
            label7.TabIndex = 5;
            label7.Text = "Admission information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(529, 101);
            label6.Name = "label6";
            label6.Size = new Size(144, 23);
            label6.TabIndex = 4;
            label6.Text = "Name of service";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(529, 36);
            label5.Name = "label5";
            label5.Size = new Size(115, 23);
            label5.TabIndex = 3;
            label5.Text = "Year of birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(29, 169);
            label4.Name = "label4";
            label4.Size = new Size(170, 23);
            label4.TabIndex = 2;
            label4.Text = "Visit type - booking";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(29, 101);
            label3.Name = "label3";
            label3.Size = new Size(157, 23);
            label3.TabIndex = 1;
            label3.Text = "Consultant doctor";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(29, 36);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 0;
            label2.Text = "Patient";
            label2.Click += label2_Click;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1612, 880);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add";
            RightToLeft = RightToLeft.No;
            Text = "Add";
            Load += Add_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private DateTimePicker dateofbirth;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox tel;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox name_box;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dataGridView1;
        private ComboBox doctors_select;
    }
}