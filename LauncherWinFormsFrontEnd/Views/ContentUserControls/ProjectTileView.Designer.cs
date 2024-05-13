namespace LauncherWinFormsFrontEnd.Views.ContentUserControls {
    partial class ProjectTileView {
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rubik", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 12);
            label1.Name = "label1";
            label1.Size = new Size(146, 24);
            label1.TabIndex = 0;
            label1.Text = "Project Name";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Rubik", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(361, 60);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rubik", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 43);
            label2.Name = "label2";
            label2.Size = new Size(44, 18);
            label2.TabIndex = 2;
            label2.Text = "Suite";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rubik", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 71);
            label3.Name = "label3";
            label3.Size = new Size(260, 18);
            label3.TabIndex = 3;
            label3.Text = "ProjectPathProjectPathProjectPath";
            // 
            // ProjectTileView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(100, 5, 30, 3);
            Name = "ProjectTileView";
            Size = new Size(474, 105);
            Load += ProjectTileView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}
