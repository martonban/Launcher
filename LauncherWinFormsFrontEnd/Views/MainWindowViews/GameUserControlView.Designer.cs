namespace LauncherWinFormsFrontEnd.Views.MainWindowViews {
    partial class GameUserControlView {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon;
            pictureBox1.Location = new Point(16, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rubik", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(163, 52);
            label1.Name = "label1";
            label1.Size = new Size(250, 51);
            label1.TabIndex = 1;
            label1.Text = "Game Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rubik", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.White;
            label3.Location = new Point(177, 103);
            label3.Name = "label3";
            label3.Size = new Size(61, 24);
            label3.TabIndex = 3;
            label3.Text = "Devs:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rubik", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(244, 103);
            label2.Name = "label2";
            label2.Size = new Size(105, 24);
            label2.TabIndex = 4;
            label2.Text = "Developer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rubik", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 828);
            label4.Name = "label4";
            label4.Size = new Size(128, 24);
            label4.TabIndex = 5;
            label4.Text = "Shiped ❤️ by";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rubik", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.White;
            label5.Location = new Point(150, 828);
            label5.Name = "label5";
            label5.Size = new Size(98, 24);
            label5.TabIndex = 6;
            label5.Text = "Publisher";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.button_install3;
            pictureBox2.Location = new Point(887, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(187, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rubik", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 191);
            label6.Name = "label6";
            label6.Size = new Size(133, 24);
            label6.TabIndex = 8;
            label6.Text = "Description:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rubik", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.White;
            label7.Location = new Point(24, 224);
            label7.Name = "label7";
            label7.Size = new Size(810, 22);
            label7.TabIndex = 9;
            label7.Text = "A Lorem Ipsum egy latin szöveg, amelyet a nyomdászatban és a grafikai tervezésben használnak\r\n";
            // 
            // GameUserControlView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "GameUserControlView";
            Size = new Size(1208, 865);
            Load += GameUserControlView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label7;
    }
}
