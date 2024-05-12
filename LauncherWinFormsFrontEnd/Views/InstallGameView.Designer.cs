namespace LauncherWinFormsFrontEnd.Views {
    partial class InstallGameView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallGameView));
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rubik", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(14, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 44);
            label1.TabIndex = 0;
            label1.Text = "Install Game";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 137);
            textBox1.Margin = new Padding(5, 4, 5, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(522, 35);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(546, 137);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(45, 35);
            button1.TabIndex = 2;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(691, 302);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(164, 41);
            button2.TabIndex = 3;
            button2.Text = "Install";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(508, 302);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(164, 41);
            button3.TabIndex = 4;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 53);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 5;
            label2.Text = "Game Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 105);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 28);
            label3.TabIndex = 6;
            label3.Text = "Path:";
            // 
            // InstallGameView
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(869, 356);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Rubik", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "InstallGameView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Install Game View";
            Load += InstallGameView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
    }
}