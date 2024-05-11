namespace LauncherWinFormsFrontEnd.Views.ContentUserControls {
    partial class GameTileView {
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
            title = new Label();
            description = new Label();
            logo = new PictureBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Rubik", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            title.ForeColor = Color.White;
            title.Location = new Point(183, 22);
            title.Name = "title";
            title.Size = new Size(63, 28);
            title.TabIndex = 0;
            title.Text = "Test";
            // 
            // description
            // 
            description.AutoSize = true;
            description.Font = new Font("Rubik", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 238);
            description.ForeColor = Color.White;
            description.Location = new Point(183, 65);
            description.MaximumSize = new Size(700, 0);
            description.Name = "description";
            description.Size = new Size(226, 24);
            description.TabIndex = 1;
            description.Text = "lorem ipsum - test text";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.icon;
            logo.Location = new Point(17, 22);
            logo.Name = "logo";
            logo.Size = new Size(146, 140);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 2;
            logo.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.White;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Rubik", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 238);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(862, 142);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 20);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Check out...";
            linkLabel1.VisitedLinkColor = Color.White;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // GameTileView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(linkLabel1);
            Controls.Add(logo);
            Controls.Add(description);
            Controls.Add(title);
            Margin = new Padding(100, 3, 3, 6);
            Name = "GameTileView";
            Size = new Size(980, 177);
            Load += GameTileView_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label description;
        private PictureBox logo;
        private LinkLabel linkLabel1;
    }
}
