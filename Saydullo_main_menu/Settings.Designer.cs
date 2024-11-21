namespace Time_Table.Saydullo_main_menu
{
    partial class Settings
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            btnChangeMode = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(114, 77);
            label1.Name = "label1";
            label1.Size = new Size(151, 40);
            label1.TabIndex = 0;
            label1.Text = "Language:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "English", "Русcкий", "O`zbek" });
            comboBox1.Location = new Point(398, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(202, 38);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(670, 283);
            button1.Name = "button1";
            button1.Size = new Size(161, 62);
            button1.TabIndex = 2;
            button1.Text = "Launch";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnChangeMode
            // 
            btnChangeMode.BackgroundImageLayout = ImageLayout.Zoom;
            btnChangeMode.FlatStyle = FlatStyle.Flat;
            btnChangeMode.Location = new Point(398, 147);
            btnChangeMode.Name = "btnChangeMode";
            btnChangeMode.Size = new Size(202, 45);
            btnChangeMode.TabIndex = 3;
            btnChangeMode.Text = "Enable Dark Mode";
            btnChangeMode.UseVisualStyleBackColor = true;
            btnChangeMode.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(114, 152);
            label2.Name = "label2";
            label2.Size = new Size(263, 40);
            label2.TabIndex = 4;
            label2.Text = "Dark / Light mode:";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1596, 841);
            Controls.Add(label2);
            Controls.Add(btnChangeMode);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private Button btnChangeMode;
        private Label label2;
    }
}