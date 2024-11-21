namespace Time_Table.Saydullo_main_menu
{
    partial class Search
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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            textBox9 = new TextBox();
            label11 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(37, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(1537, 770);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1483, 647);
            dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1537, 66);
            panel1.TabIndex = 0;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox9.Location = new Point(159, 15);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(283, 36);
            textBox9.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(27, 15);
            label11.Name = "label11";
            label11.Size = new Size(113, 33);
            label11.TabIndex = 3;
            label11.Text = "Search :";
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1612, 880);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Search";
            Text = "Search";
            Load += Search_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox textBox9;
        private Label label11;
    }
}