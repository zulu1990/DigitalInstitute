namespace Ninja
{
    partial class GameLancher
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
            lblStart = new Label();
            lblExit = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.BackColor = Color.Transparent;
            lblStart.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblStart.ForeColor = Color.White;
            lblStart.Location = new Point(137, 195);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(105, 54);
            lblStart.TabIndex = 0;
            lblStart.Text = "Start";
            lblStart.Click += lblStart_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.Transparent;
            lblExit.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblExit.ForeColor = Color.White;
            lblExit.Location = new Point(487, 195);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(85, 54);
            lblExit.TabIndex = 0;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(242, 26);
            label1.Name = "label1";
            label1.Size = new Size(221, 54);
            label1.TabIndex = 1;
            label1.Text = "Kings Road";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(470, 409);
            label2.Name = "label2";
            label2.Size = new Size(217, 20);
            label2.TabIndex = 1;
            label2.Text = "Created By: Giorgi Koghuashvili";
            // 
            // GameLancher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Battle_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(699, 438);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblExit);
            Controls.Add(lblStart);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "GameLancher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameLancher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStart;
        private Label lblExit;
        private Label label1;
        private Label label2;
    }
}