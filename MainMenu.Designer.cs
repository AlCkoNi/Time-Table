namespace CRMStom
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            Data1_Add_custom = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Asosiy_panel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1862, 40);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(1835, 9);
            label2.Name = "label2";
            label2.Size = new Size(24, 25);
            label2.TabIndex = 0;
            label2.Text = "X";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(Data1_Add_custom);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 880);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.FlatAppearance.MouseDownBackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.White;
            button3.Location = new Point(28, 376);
            button3.Name = "button3";
            button3.Size = new Size(191, 47);
            button3.TabIndex = 4;
            button3.Text = "Data3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseDownBackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.White;
            button2.Location = new Point(28, 293);
            button2.Name = "button2";
            button2.Size = new Size(191, 47);
            button2.TabIndex = 3;
            button2.Text = "Data2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Data1_Add_custom
            // 
            Data1_Add_custom.FlatAppearance.MouseDownBackColor = Color.Navy;
            Data1_Add_custom.FlatStyle = FlatStyle.Flat;
            Data1_Add_custom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Data1_Add_custom.ForeColor = Color.White;
            Data1_Add_custom.Location = new Point(28, 209);
            Data1_Add_custom.Name = "Data1_Add_custom";
            Data1_Add_custom.Size = new Size(191, 47);
            Data1_Add_custom.TabIndex = 2;
            Data1_Add_custom.Text = "Data1";
            Data1_Add_custom.UseVisualStyleBackColor = true;
            Data1_Add_custom.Click += Data1_Add_custom_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(54, 144);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 1;
            label1.Text = "Welcome Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Asosiy_panel
            // 
            Asosiy_panel.Dock = DockStyle.Fill;
            Asosiy_panel.Location = new Point(250, 40);
            Asosiy_panel.Name = "Asosiy_panel";
            Asosiy_panel.Size = new Size(1612, 880);
            Asosiy_panel.TabIndex = 2;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1862, 920);
            ControlBox = false;
            Controls.Add(Asosiy_panel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainMenu";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += MainMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button Data1_Add_custom;
        private Label label1;
        private Label label2;
        private Panel Asosiy_panel;
    }
}