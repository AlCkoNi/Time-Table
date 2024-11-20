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
            chiqish_btn = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            Search_btn = new Button();
            pictureBox2 = new PictureBox();
            Add_btn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Change_panel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(chiqish_btn);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1874, 40);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(787, 9);
            label2.Name = "label2";
            label2.Size = new Size(273, 19);
            label2.TabIndex = 0;
            label2.Text = "Healthcare Management System";
            // 
            // chiqish_btn
            // 
            chiqish_btn.AutoSize = true;
            chiqish_btn.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chiqish_btn.Location = new Point(3, 4);
            chiqish_btn.Name = "chiqish_btn";
            chiqish_btn.Size = new Size(80, 33);
            chiqish_btn.TabIndex = 1;
            chiqish_btn.Text = "EXIT";
            chiqish_btn.Click += chiqish_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(Search_btn);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(Add_btn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 880);
            panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 310);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // Search_btn
            // 
            Search_btn.FlatAppearance.BorderSize = 0;
            Search_btn.FlatStyle = FlatStyle.Flat;
            Search_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Search_btn.Location = new Point(3, 310);
            Search_btn.Name = "Search_btn";
            Search_btn.Size = new Size(247, 52);
            Search_btn.TabIndex = 4;
            Search_btn.Text = "Search";
            Search_btn.UseVisualStyleBackColor = true;
            Search_btn.Click += Search_btn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 231);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Add_btn
            // 
            Add_btn.FlatAppearance.BorderSize = 0;
            Add_btn.FlatStyle = FlatStyle.Flat;
            Add_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Add_btn.Location = new Point(3, 231);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(247, 52);
            Add_btn.TabIndex = 2;
            Add_btn.Text = "Insert";
            Add_btn.UseVisualStyleBackColor = true;
            Add_btn.Click += Add_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(37, 164);
            label1.Name = "label1";
            label1.Size = new Size(175, 30);
            label1.TabIndex = 1;
            label1.Text = "Welcome Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Change_panel
            // 
            Change_panel.Dock = DockStyle.Fill;
            Change_panel.Location = new Point(250, 40);
            Change_panel.Name = "Change_panel";
            Change_panel.Size = new Size(1624, 880);
            Change_panel.TabIndex = 2;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1874, 920);
            ControlBox = false;
            Controls.Add(Change_panel);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button Add_btn;
        private PictureBox pictureBox2;
        private Panel Change_panel;
        private Button Search_btn;
        private PictureBox pictureBox3;
        private Label label2;
        private Label chiqish_btn;
    }
}