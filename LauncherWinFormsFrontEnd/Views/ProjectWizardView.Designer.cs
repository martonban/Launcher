namespace LauncherWinFormsFrontEnd.Views {
    partial class ProjectWizardView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectWizardView));
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rubik", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(280, 9);
            label1.Name = "label1";
            label1.Size = new Size(266, 40);
            label1.TabIndex = 0;
            label1.Text = "Project Wizard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rubik", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 168);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 1;
            label2.Text = "Project Type:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bag Project" });
            comboBox1.Location = new Point(56, 204);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(258, 28);
            comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rubik", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(44, 67);
            label3.Name = "label3";
            label3.Size = new Size(164, 28);
            label3.TabIndex = 3;
            label3.Text = "Project Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(56, 298);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 27);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rubik", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(44, 267);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 5;
            label4.Text = "Path:";
            // 
            // button1
            // 
            button1.Font = new Font("Rubik", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(320, 298);
            button1.Name = "button1";
            button1.Size = new Size(36, 29);
            button1.TabIndex = 7;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Rubik", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.Location = new Point(606, 379);
            button2.Name = "button2";
            button2.Size = new Size(164, 41);
            button2.TabIndex = 8;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ProjectWizardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProjectWizardView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Project Wizard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}