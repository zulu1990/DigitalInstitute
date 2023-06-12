namespace Ninja
{
    partial class RPG_Game
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
            timer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            pbxFire2 = new PictureBox();
            pbxFire1 = new PictureBox();
            btnPerson1Attack = new Button();
            pbxPerson1AddLevel = new PictureBox();
            pbxPerson1AddStrength = new PictureBox();
            pbxPerson1AddArmore = new PictureBox();
            pbxPerson1AddHealth = new PictureBox();
            label16 = new Label();
            lblPerson2Level = new Label();
            lblPerson1Level = new Label();
            lblPerson1Strength = new Label();
            lblPerson2Strength = new Label();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            label14 = new Label();
            lblPerson1Armor = new Label();
            lblPerson2Armor = new Label();
            label3 = new Label();
            label12 = new Label();
            lblPerson1Av_Points = new Label();
            lblPerson2Av_Points = new Label();
            label2 = new Label();
            label10 = new Label();
            lblPerson2Health = new Label();
            lblPerson1Health = new Label();
            lblAttackStatus = new Label();
            lblPerson2Name = new Label();
            lblPerson1Name = new Label();
            lblAttackValue = new Label();
            lblInfoLevel = new Label();
            lblInfoStrength = new Label();
            lblInfoArmor = new Label();
            lblInfoHealth = new Label();
            lblHealthTitle = new Label();
            lblExit = new Label();
            pbxPerson2 = new PictureBox();
            pbxPerson1 = new PictureBox();
            pbxBackground = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxFire2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFire1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPerson1AddLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPerson1AddStrength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPerson1AddArmore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPerson1AddHealth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPerson2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPerson1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBackground).BeginInit();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pbxFire2);
            panel1.Controls.Add(pbxFire1);
            panel1.Controls.Add(btnPerson1Attack);
            panel1.Controls.Add(pbxPerson1AddLevel);
            panel1.Controls.Add(pbxPerson1AddStrength);
            panel1.Controls.Add(pbxPerson1AddArmore);
            panel1.Controls.Add(pbxPerson1AddHealth);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(lblPerson2Level);
            panel1.Controls.Add(lblPerson1Level);
            panel1.Controls.Add(lblPerson1Strength);
            panel1.Controls.Add(lblPerson2Strength);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(lblPerson1Armor);
            panel1.Controls.Add(lblPerson2Armor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(lblPerson1Av_Points);
            panel1.Controls.Add(lblPerson2Av_Points);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(lblPerson2Health);
            panel1.Controls.Add(lblPerson1Health);
            panel1.Controls.Add(lblAttackStatus);
            panel1.Controls.Add(lblPerson2Name);
            panel1.Controls.Add(lblPerson1Name);
            panel1.Controls.Add(lblAttackValue);
            panel1.Controls.Add(lblInfoLevel);
            panel1.Controls.Add(lblInfoStrength);
            panel1.Controls.Add(lblInfoArmor);
            panel1.Controls.Add(lblInfoHealth);
            panel1.Controls.Add(lblHealthTitle);
            panel1.Controls.Add(lblExit);
            panel1.Controls.Add(pbxPerson2);
            panel1.Controls.Add(pbxPerson1);
            panel1.Controls.Add(pbxBackground);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 561);
            panel1.TabIndex = 0;
            // 
            // pbxFire2
            // 
            pbxFire2.BackColor = Color.Transparent;
            pbxFire2.Image = Properties.Resources.Fire_Ball_Left1;
            pbxFire2.InitialImage = null;
            pbxFire2.Location = new Point(557, 279);
            pbxFire2.Name = "pbxFire2";
            pbxFire2.Size = new Size(127, 105);
            pbxFire2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFire2.TabIndex = 8;
            pbxFire2.TabStop = false;
            // 
            // pbxFire1
            // 
            pbxFire1.BackColor = Color.Transparent;
            pbxFire1.Image = Properties.Resources.Fire_Ball_Right2;
            pbxFire1.InitialImage = null;
            pbxFire1.Location = new Point(280, 279);
            pbxFire1.Name = "pbxFire1";
            pbxFire1.Size = new Size(127, 105);
            pbxFire1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFire1.TabIndex = 8;
            pbxFire1.TabStop = false;
            // 
            // btnPerson1Attack
            // 
            btnPerson1Attack.BackColor = Color.IndianRed;
            btnPerson1Attack.BackgroundImage = Properties.Resources.Battle_Background;
            btnPerson1Attack.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnPerson1Attack.ForeColor = Color.Transparent;
            btnPerson1Attack.Location = new Point(137, 460);
            btnPerson1Attack.Name = "btnPerson1Attack";
            btnPerson1Attack.Size = new Size(118, 62);
            btnPerson1Attack.TabIndex = 7;
            btnPerson1Attack.Text = "Attack";
            btnPerson1Attack.UseVisualStyleBackColor = false;
            btnPerson1Attack.Click += btnPerson1Attack_Click;
            // 
            // pbxPerson1AddLevel
            // 
            pbxPerson1AddLevel.Image = Properties.Resources.Add;
            pbxPerson1AddLevel.Location = new Point(192, 171);
            pbxPerson1AddLevel.Name = "pbxPerson1AddLevel";
            pbxPerson1AddLevel.Size = new Size(30, 30);
            pbxPerson1AddLevel.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPerson1AddLevel.TabIndex = 6;
            pbxPerson1AddLevel.TabStop = false;
            pbxPerson1AddLevel.Click += pbxPerson1AddLevel_Click;
            pbxPerson1AddLevel.MouseLeave += pbxPerson1AddLevel_MouseLeave;
            pbxPerson1AddLevel.MouseMove += pbxPerson1AddLevel_MouseMove;
            // 
            // pbxPerson1AddStrength
            // 
            pbxPerson1AddStrength.Image = Properties.Resources.Add;
            pbxPerson1AddStrength.Location = new Point(192, 133);
            pbxPerson1AddStrength.Name = "pbxPerson1AddStrength";
            pbxPerson1AddStrength.Size = new Size(30, 30);
            pbxPerson1AddStrength.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPerson1AddStrength.TabIndex = 6;
            pbxPerson1AddStrength.TabStop = false;
            pbxPerson1AddStrength.Click += pbxPerson1AddStrength_Click;
            pbxPerson1AddStrength.MouseLeave += pbxPerson1AddStrength_MouseLeave;
            pbxPerson1AddStrength.MouseMove += pbxPerson1AddStrength_MouseMove;
            // 
            // pbxPerson1AddArmore
            // 
            pbxPerson1AddArmore.Image = Properties.Resources.Add;
            pbxPerson1AddArmore.Location = new Point(192, 94);
            pbxPerson1AddArmore.Name = "pbxPerson1AddArmore";
            pbxPerson1AddArmore.Size = new Size(30, 30);
            pbxPerson1AddArmore.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPerson1AddArmore.TabIndex = 6;
            pbxPerson1AddArmore.TabStop = false;
            pbxPerson1AddArmore.Click += pbxPerson1AddArmore_Click;
            pbxPerson1AddArmore.MouseLeave += pbxPerson1AddArmore_MouseLeave;
            pbxPerson1AddArmore.MouseMove += pbxPerson1AddArmore_MouseMove;
            // 
            // pbxPerson1AddHealth
            // 
            pbxPerson1AddHealth.Image = Properties.Resources.Add;
            pbxPerson1AddHealth.Location = new Point(193, 24);
            pbxPerson1AddHealth.Name = "pbxPerson1AddHealth";
            pbxPerson1AddHealth.Size = new Size(30, 30);
            pbxPerson1AddHealth.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPerson1AddHealth.TabIndex = 6;
            pbxPerson1AddHealth.TabStop = false;
            pbxPerson1AddHealth.Click += pbxPerson1AddHealth_Click;
            pbxPerson1AddHealth.MouseLeave += pbxPerson1AddHealth_MouseLeave;
            pbxPerson1AddHealth.MouseMove += pbxPerson1AddHealth_MouseMove;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(0, 0, 64);
            label16.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(890, 136);
            label16.Name = "label16";
            label16.Size = new Size(83, 25);
            label16.TabIndex = 5;
            label16.Text = ":Strength";
            // 
            // lblPerson2Level
            // 
            lblPerson2Level.AutoSize = true;
            lblPerson2Level.BackColor = Color.FromArgb(0, 0, 64);
            lblPerson2Level.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerson2Level.ForeColor = Color.White;
            lblPerson2Level.Location = new Point(825, 171);
            lblPerson2Level.Name = "lblPerson2Level";
            lblPerson2Level.Size = new Size(22, 25);
            lblPerson2Level.TabIndex = 5;
            lblPerson2Level.Text = "1";
            // 
            // lblPerson1Level
            // 
            lblPerson1Level.AutoSize = true;
            lblPerson1Level.BackColor = Color.FromArgb(0, 0, 64);
            lblPerson1Level.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerson1Level.ForeColor = Color.White;
            lblPerson1Level.Location = new Point(123, 171);
            lblPerson1Level.Name = "lblPerson1Level";
            lblPerson1Level.Size = new Size(22, 25);
            lblPerson1Level.TabIndex = 5;
            lblPerson1Level.Text = "1";
            lblPerson1Level.MouseLeave += lblPerson1Level_MouseLeave;
            lblPerson1Level.MouseMove += lblPerson1Level_MouseMove;
            // 
            // lblPerson1Strength
            // 
            lblPerson1Strength.AutoSize = true;
            lblPerson1Strength.BackColor = Color.FromArgb(0, 0, 64);
            lblPerson1Strength.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerson1Strength.ForeColor = Color.White;
            lblPerson1Strength.Location = new Point(123, 136);
            lblPerson1Strength.Name = "lblPerson1Strength";
            lblPerson1Strength.Size = new Size(42, 25);
            lblPerson1Strength.TabIndex = 5;
            lblPerson1Strength.Text = "100";
            lblPerson1Strength.MouseLeave += lblPerson1Strength_MouseLeave;
            lblPerson1Strength.MouseMove += lblPerson1Strength_MouseMove;
            // 
            // lblPerson2Strength
            // 
            lblPerson2Strength.AutoSize = true;
            lblPerson2Strength.BackColor = Color.FromArgb(0, 0, 64);
            lblPerson2Strength.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerson2Strength.ForeColor = Color.White;
            lblPerson2Strength.Location = new Point(825, 136);
            lblPerson2Strength.Name = "lblPerson2Strength";
            lblPerson2Strength.Size = new Size(42, 25);
            lblPerson2Strength.TabIndex = 5;
            lblPerson2Strength.Text = "100";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 64);
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(890, 171);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 5;
            label5.Text = ":Level";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 171);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 5;
            label1.Text = "Level:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 64);
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 136);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 5;
            label4.Text = "Stength:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(0, 0, 64);
            label14.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(890, 99);
            label14.Name = "label14";
            label14.Size = new Size(67, 25);
            label14.TabIndex = 5;
            label14.Text = ":Armor";
            // 
            // lblPerson1Armor
            // 
            lblPerson1Armor.AutoSize = true;
            lblPerson1Armor.BackColor = Color.FromArgb(0, 0, 64);
            lblPerson1Armor.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerson1Armor.ForeColor = Color.White;
            lblPerson1Armor.Location = new Point(123, 99);
            lblPerson1Armor.Name = "lblPerson1Armor";
            lblPerson1Armor.Size = new Size(42, 25);
            lblPerson1Armor.TabIndex = 5;
            lblPerson1Armor.Text = "100";
            lblPerson1Armor.MouseLeave += lblPerson1Armor_MouseLeave;
            lblPerson1Armor.MouseMove += lblPerson1Armor_MouseMove;
            // 
            // lblPerson2Armor
            // 
            lblPerson2Armor.AutoSize = true;
            lblPerson2Armor.BackColor = Color.FromArgb(0, 0, 64);
            lblPerson2Armor.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerson2Armor.ForeColor = Color.White;
            lblPerson2Armor.Location = new Point(825, 99);
            lblPerson2Armor.Name = "lblPerson2Armor";
            lblPerson2Armor.Size = new Size(42, 25);
            lblPerson2Armor.TabIndex = 5;
            lblPerson2Armor.Text = "100";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 64);
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 99);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 5;
            label3.Text = "Armor:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(0, 0, 64);
            label12.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(890, 61);
            label12.Name = "label12";
            label12.Size = new Size(89, 25);
            label12.TabIndex = 5;
            label12.Text = ":Av.Points";
            // 
            // lblPerson1Av_Points
            // 
            lblPerson1Av_Points.AutoSize = true;
            lblPerson1Av_Points.BackColor = Color.FromArgb(0, 0, 64);
            lblPerson1Av_Points.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerson1Av_Points.ForeColor = Color.White;
            lblPerson1Av_Points.Location = new Point(123, 61);
            lblPerson1Av_Points.Name = "lblPerson1Av_Points";
            lblPerson1Av_Points.Size = new Size(42, 25);
            lblPerson1Av_Points.TabIndex = 5;
            lblPerson1Av_Points.Text = "100";
            // 
            // lblPerson2Av_Points
            // 
            lblPerson2Av_Points.AutoSize = true;
            lblPerson2Av_Points.BackColor = Color.FromArgb(0, 0, 64);
            lblPerson2Av_Points.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerson2Av_Points.ForeColor = Color.White;
            lblPerson2Av_Points.Location = new Point(825, 61);
            lblPerson2Av_Points.Name = "lblPerson2Av_Points";
            lblPerson2Av_Points.Size = new Size(42, 25);
            lblPerson2Av_Points.TabIndex = 5;
            lblPerson2Av_Points.Text = "100";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 64);
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 61);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 5;
            label2.Text = "Av.Points:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(0, 0, 64);
            label10.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(890, 24);
            label10.Name = "label10";
            label10.Size = new Size(67, 25);
            label10.TabIndex = 5;
            label10.Text = ":Health";
            // 
            // lblPerson2Health
            // 
            lblPerson2Health.AutoSize = true;
            lblPerson2Health.BackColor = Color.FromArgb(0, 0, 64);
            lblPerson2Health.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerson2Health.ForeColor = Color.White;
            lblPerson2Health.Location = new Point(825, 24);
            lblPerson2Health.Name = "lblPerson2Health";
            lblPerson2Health.Size = new Size(42, 25);
            lblPerson2Health.TabIndex = 5;
            lblPerson2Health.Text = "100";
            // 
            // lblPerson1Health
            // 
            lblPerson1Health.AutoSize = true;
            lblPerson1Health.BackColor = Color.FromArgb(0, 0, 64);
            lblPerson1Health.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerson1Health.ForeColor = Color.White;
            lblPerson1Health.Location = new Point(123, 24);
            lblPerson1Health.Name = "lblPerson1Health";
            lblPerson1Health.Size = new Size(42, 25);
            lblPerson1Health.TabIndex = 5;
            lblPerson1Health.Text = "100";
            lblPerson1Health.MouseLeave += lblPerson1Health_MouseLeave;
            lblPerson1Health.MouseMove += lblPerson1Health_MouseMove;
            // 
            // lblAttackStatus
            // 
            lblAttackStatus.AutoSize = true;
            lblAttackStatus.BackColor = Color.FromArgb(0, 0, 64);
            lblAttackStatus.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblAttackStatus.ForeColor = Color.White;
            lblAttackStatus.Location = new Point(431, 26);
            lblAttackStatus.Name = "lblAttackStatus";
            lblAttackStatus.Size = new Size(100, 28);
            lblAttackStatus.TabIndex = 5;
            lblAttackStatus.Text = "Your attak";
            // 
            // lblPerson2Name
            // 
            lblPerson2Name.AutoSize = true;
            lblPerson2Name.BackColor = Color.FromArgb(0, 0, 64);
            lblPerson2Name.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerson2Name.ForeColor = Color.White;
            lblPerson2Name.Location = new Point(743, 212);
            lblPerson2Name.Name = "lblPerson2Name";
            lblPerson2Name.Size = new Size(59, 25);
            lblPerson2Name.TabIndex = 5;
            lblPerson2Name.Text = "Name";
            // 
            // lblPerson1Name
            // 
            lblPerson1Name.AutoSize = true;
            lblPerson1Name.BackColor = Color.FromArgb(0, 0, 64);
            lblPerson1Name.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerson1Name.ForeColor = Color.White;
            lblPerson1Name.Location = new Point(163, 212);
            lblPerson1Name.Name = "lblPerson1Name";
            lblPerson1Name.Size = new Size(59, 25);
            lblPerson1Name.TabIndex = 5;
            lblPerson1Name.Text = "Name";
            // 
            // lblAttackValue
            // 
            lblAttackValue.AutoSize = true;
            lblAttackValue.BackColor = Color.FromArgb(0, 0, 64);
            lblAttackValue.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblAttackValue.ForeColor = Color.Red;
            lblAttackValue.Location = new Point(451, 171);
            lblAttackValue.Name = "lblAttackValue";
            lblAttackValue.Size = new Size(45, 54);
            lblAttackValue.TabIndex = 5;
            lblAttackValue.Text = "0";
            // 
            // lblInfoLevel
            // 
            lblInfoLevel.AutoSize = true;
            lblInfoLevel.BackColor = Color.FromArgb(0, 0, 64);
            lblInfoLevel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoLevel.ForeColor = Color.White;
            lblInfoLevel.Location = new Point(228, 175);
            lblInfoLevel.Name = "lblInfoLevel";
            lblInfoLevel.Size = new Size(74, 19);
            lblInfoLevel.TabIndex = 5;
            lblInfoLevel.Text = "100 Points";
            lblInfoLevel.Visible = false;
            // 
            // lblInfoStrength
            // 
            lblInfoStrength.AutoSize = true;
            lblInfoStrength.BackColor = Color.FromArgb(0, 0, 64);
            lblInfoStrength.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoStrength.ForeColor = Color.White;
            lblInfoStrength.Location = new Point(229, 136);
            lblInfoStrength.Name = "lblInfoStrength";
            lblInfoStrength.Size = new Size(66, 19);
            lblInfoStrength.TabIndex = 5;
            lblInfoStrength.Text = "20 Points";
            lblInfoStrength.Visible = false;
            // 
            // lblInfoArmor
            // 
            lblInfoArmor.AutoSize = true;
            lblInfoArmor.BackColor = Color.FromArgb(0, 0, 64);
            lblInfoArmor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoArmor.ForeColor = Color.White;
            lblInfoArmor.Location = new Point(229, 98);
            lblInfoArmor.Name = "lblInfoArmor";
            lblInfoArmor.Size = new Size(66, 19);
            lblInfoArmor.TabIndex = 5;
            lblInfoArmor.Text = "20 Points";
            lblInfoArmor.Visible = false;
            // 
            // lblInfoHealth
            // 
            lblInfoHealth.AutoSize = true;
            lblInfoHealth.BackColor = Color.FromArgb(0, 0, 64);
            lblInfoHealth.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoHealth.ForeColor = Color.White;
            lblInfoHealth.Location = new Point(229, 28);
            lblInfoHealth.Name = "lblInfoHealth";
            lblInfoHealth.Size = new Size(155, 19);
            lblInfoHealth.TabIndex = 5;
            lblInfoHealth.Text = "100 Points / 100 Health";
            lblInfoHealth.Visible = false;
            // 
            // lblHealthTitle
            // 
            lblHealthTitle.AutoSize = true;
            lblHealthTitle.BackColor = Color.FromArgb(0, 0, 64);
            lblHealthTitle.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblHealthTitle.ForeColor = Color.White;
            lblHealthTitle.Location = new Point(24, 24);
            lblHealthTitle.Name = "lblHealthTitle";
            lblHealthTitle.Size = new Size(67, 25);
            lblHealthTitle.TabIndex = 5;
            lblHealthTitle.Text = "Health:";
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.Indigo;
            lblExit.BorderStyle = BorderStyle.FixedSingle;
            lblExit.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblExit.ForeColor = Color.Transparent;
            lblExit.Location = new Point(455, 513);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(61, 39);
            lblExit.TabIndex = 3;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            // 
            // pbxPerson2
            // 
            pbxPerson2.BackColor = Color.Black;
            pbxPerson2.BackgroundImage = Properties.Resources.Battle_Background;
            pbxPerson2.ErrorImage = null;
            pbxPerson2.Image = Properties.Resources.Person2_Right1;
            pbxPerson2.InitialImage = null;
            pbxPerson2.Location = new Point(679, 240);
            pbxPerson2.Name = "pbxPerson2";
            pbxPerson2.Size = new Size(198, 214);
            pbxPerson2.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPerson2.TabIndex = 2;
            pbxPerson2.TabStop = false;
            // 
            // pbxPerson1
            // 
            pbxPerson1.BackColor = Color.Transparent;
            pbxPerson1.BackgroundImage = Properties.Resources.Battle_Background;
            pbxPerson1.ErrorImage = null;
            pbxPerson1.Image = Properties.Resources.Person1_Left;
            pbxPerson1.InitialImage = null;
            pbxPerson1.Location = new Point(94, 240);
            pbxPerson1.Name = "pbxPerson1";
            pbxPerson1.Size = new Size(198, 214);
            pbxPerson1.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPerson1.TabIndex = 2;
            pbxPerson1.TabStop = false;
            // 
            // pbxBackground
            // 
            pbxBackground.BackColor = Color.Transparent;
            pbxBackground.Dock = DockStyle.Fill;
            pbxBackground.Image = Properties.Resources.Battle_Background;
            pbxBackground.Location = new Point(0, 0);
            pbxBackground.Name = "pbxBackground";
            pbxBackground.Size = new Size(984, 561);
            pbxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBackground.TabIndex = 0;
            pbxBackground.TabStop = false;
            // 
            // RPG_Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RPG_Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += RPG_Game_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxFire2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFire1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPerson1AddLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPerson1AddStrength).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPerson1AddArmore).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPerson1AddHealth).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPerson2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPerson1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private Panel panel1;
        private PictureBox pbxBackground;
        private PictureBox pbxPerson1;
        private Label lblExit;
        private Label label16;
        private Label lblPerson1Strength;
        private Label lblPerson2Strength;
        private Label label4;
        private Label label14;
        private Label lblPerson1Armor;
        private Label lblPerson2Armor;
        private Label label3;
        private Label label12;
        private Label lblPerson1Av_Points;
        private Label lblPerson2Av_Points;
        private Label label2;
        private Label label10;
        private Label lblPerson2Health;
        private Label lblPerson1Health;
        private Label lblHealthTitle;
        private PictureBox pbxPerson2;
        private Label lblPerson2Name;
        private Label lblPerson1Name;
        private PictureBox pbxPerson1AddHealth;
        private PictureBox pbxPerson1AddStrength;
        private PictureBox pbxPerson1AddArmore;
        private Label lblAttackStatus;
        private PictureBox pbxPerson1AddLevel;
        private Label lblPerson2Level;
        private Label lblPerson1Level;
        private Label label5;
        private Label label1;
        private Label lblAttackValue;
        private Button btnPerson1Attack;
        private PictureBox pbxFire1;
        private PictureBox pbxFire2;
        private Label lblInfoArmor;
        private Label lblInfoHealth;
        private Label lblInfoStrength;
        private Label lblInfoLevel;
    }
}