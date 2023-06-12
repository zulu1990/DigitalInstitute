namespace Ninja
{
    public partial class RPG_Game : Form
    {
        private Warrior person1 = new Warrior();
        private Warrior person2 = new Warrior();
        private bool _attackingPerson1 = true;

        public RPG_Game()
        {
            InitializeComponent();
        }


        private void RPG_Game_Load(object sender, EventArgs e)
        {
            // Initial persons info and set default.
            person1.Name = "You";
            person2.Name = "PC";
            lblPerson1Name.Text = person1.Name;
            lblPerson2Name.Text = person2.Name;

            pbxFire1.Visible = false;
            pbxFire2.Visible = false;

            // Initial Person Data.
            FillPerson1Info();
            FillPerson2Info();

            // Initial default available points.
            UpdateAvailablePoints();

            // Update Perosn datas.
            UpdatePerson1Info();
            UpdatePerson2Info();
        }
        /// <summary>
        /// Waits antill first person is attacking.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (!_attackingPerson1)
            {
                Thread person2Attack = new Thread(AttackPerson2);
                person2Attack.Start();
                _attackingPerson1 = true;
            }
        }
        private DialogResult GameOver()
        {
            return MessageBox.Show("Game Over.","Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FillPerson1Info()
        {
            person1.Level = 1;
            person1.Name = "You";
            person1.Strength = 10;
            person1.Armor = 100;
            person1.Health = 100;
            person1.AvailablePoints = 250;

        }
        private void FillPerson2Info()
        {
            person2.Level = 1;
            person2.Name = "PC";
            person2.Strength = 10;
            person2.Armor = 100;
            person2.Health = 1000;
            person2.AvailablePoints = 0;
        }
        private void UpdateAvailablePoints()
        {
            // Person 1
            // Armor
            if (person1.AvailablePoints >= 20)
                pbxPerson1AddArmore.Visible = true;
            else
                pbxPerson1AddArmore.Visible = false;
            // Strength
            if (person1.AvailablePoints >= 50)
                pbxPerson1AddStrength.Visible = true;
            else
                pbxPerson1AddStrength.Visible = false;
            //Level and Health
            if (person1.AvailablePoints >= 100)
            {
                pbxPerson1AddLevel.Visible = true;
                pbxPerson1AddHealth.Visible = true;
            }
            else
            {
                pbxPerson1AddLevel.Visible = false;
                pbxPerson1AddHealth.Visible = false;
            }
        }
        private void UpdatePerson1Info()
        {
            lblPerson1Armor.Text = person1.Armor.ToString();
            lblPerson1Health.Text = person1.Health.ToString();
            lblPerson1Level.Text = person1.Level.ToString();
            lblPerson1Strength.Text = person1.Strength.ToString();
            lblPerson1Av_Points.Text = person1.AvailablePoints.ToString();
        }
        private void UpdatePerson2Info()
        {
            lblPerson2Armor.Text = person2.Armor.ToString();
            lblPerson2Health.Text = person2.Health.ToString();
            lblPerson2Level.Text = person2.Level.ToString();
            lblPerson2Strength.Text = person2.Strength.ToString();
            lblPerson2Av_Points.Text = person2.AvailablePoints.ToString();
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ნამდვილად გსურთ თამაშიდან გასვლა?", "დახურვა", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Dispose();
        }
        /// <summary>
        /// First person attack.
        /// </summary>
        private void AttackPerson1()
        {
            // Attack 1
            int attack = person1.Attack(ref person2);
            Invoke((MethodInvoker)delegate ()
            {
                btnPerson1Attack.Enabled = false;
                lblAttackStatus.Text = "YOU";
            });
            Invoke((MethodInvoker)delegate ()
            {
                pbxFire1.Visible = true;
            });
            for (int i = 0; i < 280; i += 10)
            {
                Invoke((MethodInvoker)delegate ()
                {
                    pbxFire1.Location = new Point(290 + i, 280);
                });
                Thread.Sleep(100);
            }
            Invoke((MethodInvoker)delegate ()
            {
                pbxFire1.Visible = false;

                lblAttackValue.Text = attack.ToString();

            });
            Thread.Sleep(1000);
            Invoke((MethodInvoker)delegate ()
            {
                UpdatePerson2Info();
                if (person2.Health <= 0)
                {
                    lblPerson2Health.Text = "0";
                    lblAttackStatus.Text = "Game Over";
                    lblAttackValue.Text = "You Win!";
                    DialogResult = GameOver();
                }
                _attackingPerson1 = false;
            });
        }
        private void AttackPerson2()
        {
            int attack = 0; ;
            Invoke((MethodInvoker)delegate ()
            {
                attack = person2.Attack(ref person1);
                pbxFire2.Visible = true;
                lblAttackStatus.Text = "PC";
            });
            for (int i = 0; i < 280; i += 10)
            {
                Invoke((MethodInvoker)delegate ()
                {
                    pbxFire2.Location = new Point(570 - i, 280);
                });
                Thread.Sleep(100);
            }
            Invoke((MethodInvoker)delegate ()
            {
                pbxFire2.Visible = false;

                lblAttackValue.Text = attack.ToString();
            });
            Thread.Sleep(1000);
            Invoke((MethodInvoker)delegate ()
            {
                UpdatePerson1Info();
                if (person1.Health <= 0)
                {
                    lblPerson1Health.Text = "0";
                    lblAttackStatus.Text = "Game Over";
                    lblAttackValue.Text = "You Won!";
                    DialogResult = GameOver();
                }
                lblAttackStatus.Text = "Your Attack";
                lblAttackValue.Text = "";
                btnPerson1Attack.Enabled = true;
                timer.Stop();
                UpdateAvailablePoints();
            });
        }
        private void pbxPerson1AddLevel_Click(object sender, EventArgs e)
        {
            person1.IncreaseLevel();
            lblPerson1Level.Text = person1.Level.ToString();
            UpdateAvailablePoints();
            UpdatePerson1Info();
            UpdatePerson2Info();
        }
        private void pbxPerson1AddStrength_Click(object sender, EventArgs e)
        {
            person1.Strength += person1.IncreaseStrength(person1.AvailablePoints);
            lblPerson1Strength.Text = person1.Strength.ToString();
            UpdateAvailablePoints();
            UpdatePerson1Info();
            UpdatePerson2Info();
        }
        private void pbxPerson1AddArmore_Click(object sender, EventArgs e)
        {
            person1.Armor += person1.IncreaseArmor(person1.AvailablePoints);
            lblPerson1Armor.Text = person1.Armor.ToString();
            UpdateAvailablePoints();
            UpdatePerson1Info();
            UpdatePerson2Info();
        }
        private void pbxPerson1AddHealth_Click(object sender, EventArgs e)
        {
            // Increase Health
            person1.Health += person1.IncreaseHealth(person1.AvailablePoints);
            // Display increased Health.
            lblPerson1Health.Text = person1.Health.ToString();
            //Update data and info
            UpdateAvailablePoints();
            UpdatePerson1Info();
            UpdatePerson2Info();
        }

        private void btnPerson1Attack_Click(object sender, EventArgs e)
        {
            btnPerson1Attack.Enabled = false;
            Thread person1Attack = new Thread(AttackPerson1);
            person1Attack.Start();
            timer.Start();
        }

        private void lblPerson1Health_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfoHealth.Visible = true;
        }

        private void pbxPerson1AddHealth_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfoHealth.Visible = true;
        }

        private void pbxPerson1AddHealth_MouseLeave(object sender, EventArgs e)
        {
            lblInfoHealth.Visible = false;
        }

        private void lblPerson1Health_MouseLeave(object sender, EventArgs e)
        {
            lblInfoHealth.Visible = false;

        }

        private void pbxPerson1AddArmore_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfoArmor.Visible = true;
        }

        private void pbxPerson1AddArmore_MouseLeave(object sender, EventArgs e)
        {
            lblInfoArmor.Visible = false;
        }

        private void lblPerson1Armor_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfoArmor.Visible = true;
        }

        private void lblPerson1Armor_MouseLeave(object sender, EventArgs e)
        {
            lblInfoArmor.Visible = false;
        }

        private void pbxPerson1AddStrength_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfoStrength.Visible = true;
        }

        private void pbxPerson1AddStrength_MouseLeave(object sender, EventArgs e)
        {
            lblInfoStrength.Visible = false;
        }

        private void lblPerson1Strength_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfoStrength.Visible = true;
        }

        private void lblPerson1Strength_MouseLeave(object sender, EventArgs e)
        {
            lblInfoStrength.Visible = false;
        }

        private void lblPerson1Level_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfoLevel.Visible = true;
        }

        private void lblPerson1Level_MouseLeave(object sender, EventArgs e)
        {
            lblInfoLevel.Visible = false;
        }

        private void pbxPerson1AddLevel_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfoLevel.Visible = true;
        }

        private void pbxPerson1AddLevel_MouseLeave(object sender, EventArgs e)
        {
            lblInfoLevel.Visible = false;
        }
    }
}