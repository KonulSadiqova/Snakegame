namespace Snakegame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlGameArea = new Panel();
            pnlControl = new Panel();
            lblScore = new Label();
            btnUp = new Button();
            btnDown = new Button();
            btnRight = new Button();
            btnLeft = new Button();
            btnExit = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            pnlControl.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGameArea
            // 
            pnlGameArea.BorderStyle = BorderStyle.FixedSingle;
            pnlGameArea.Dock = DockStyle.Top;
            pnlGameArea.Location = new Point(0, 0);
            pnlGameArea.Name = "pnlGameArea";
            pnlGameArea.Size = new Size(800, 295);
            pnlGameArea.TabIndex = 0;
            // 
            // pnlControl
            // 
            pnlControl.BackColor = SystemColors.ActiveCaption;
            pnlControl.Controls.Add(btnExit);
            pnlControl.Controls.Add(btnLeft);
            pnlControl.Controls.Add(btnRight);
            pnlControl.Controls.Add(btnDown);
            pnlControl.Controls.Add(btnUp);
            pnlControl.Controls.Add(lblScore);
            pnlControl.Dock = DockStyle.Bottom;
            pnlControl.Location = new Point(0, 301);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new Size(800, 235);
            pnlControl.TabIndex = 1;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.ForeColor = SystemColors.ActiveCaptionText;
            lblScore.Location = new Point(21, 20);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(45, 20);
            lblScore.TabIndex = 0;
            lblScore.Text = "Xal: 0";
            // 
            // btnUp
            // 
            btnUp.BackgroundImage = (Image)resources.GetObject("btnUp.BackgroundImage");
            btnUp.Location = new Point(369, 22);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(47, 80);
            btnUp.TabIndex = 1;
            btnUp.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            btnDown.BackgroundImage = (Image)resources.GetObject("btnDown.BackgroundImage");
            btnDown.Location = new Point(369, 130);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(37, 80);
            btnDown.TabIndex = 2;
            btnDown.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            btnRight.BackgroundImage = (Image)resources.GetObject("btnRight.BackgroundImage");
            btnRight.Location = new Point(412, 97);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(85, 51);
            btnRight.TabIndex = 3;
            btnRight.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            btnLeft.BackgroundImage = (Image)resources.GetObject("btnLeft.BackgroundImage");
            btnLeft.Location = new Point(278, 90);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(85, 58);
            btnLeft.TabIndex = 4;
            btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(676, 175);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(85, 35);
            btnExit.TabIndex = 5;
            btnExit.Text = "Çıxış";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 536);
            Controls.Add(pnlControl);
            Controls.Add(pnlGameArea);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SnakeGame";
            Load += Form1_Load;
            pnlControl.ResumeLayout(false);
            pnlControl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGameArea;
        private Panel pnlControl;
        private Label lblScore;
        private Button btnExit;
        private Button btnLeft;
        private Button btnRight;
        private Button btnDown;
        private Button btnUp;
        private System.Windows.Forms.Timer gameTimer;
    }
}
