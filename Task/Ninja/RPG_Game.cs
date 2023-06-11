namespace Ninja
{
    public partial class RPG_Game : Form
    {
        private Warrior person1 = new Warrior();
        private Warrior person2 = new Warrior();

        public RPG_Game()
        {
            InitializeComponent();
        }


        private void RPG_Game_Load(object sender, EventArgs e)
        {
            person1.Name = "You";
            person2.Name = "PC";
            lblPerson1Name.Text = person1.Name;
            lblPerson2Name.Text = person2.Name;
            lblAttak.Text = "";

            UpdateAvailablePoints();
        }

        private void timer_Tick(object sender, EventArgs e)
        {


        }
        private void UpdateAvailablePoints()
        {
            // Person 1
            if (person1.AvailablePoints >= 20)
                pbxPerson1AddArmore.Visible = true;
            else
                pbxPerson1AddArmore.Visible = false;

            if (person1.AvailablePoints >= 50)
                pbxPerson1AddStrength.Visible = true;
            else
                pbxPerson1AddStrength.Visible = false;

            if (person1.AvailablePoints >= 100)
                pbxPerson1AddLevel.Visible = true;
            else
                pbxPerson1AddLevel.Visible = false;
            // Person 2
            if (person2.AvailablePoints >= 20)
                pbxPerson2AddAromr.Visible = true;
            else
                pbxPerson2AddAromr.Visible = false;

            if (person2.AvailablePoints >= 50)
                pbxPerson2AddStrength.Visible = true;
            else
                pbxPerson2AddStrength.Visible = false;

            if (person2.AvailablePoints >= 100)
                pbxPerson2AddLevel.Visible = true;
            else
                pbxPerson2AddLevel.Visible = false;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ნამდვილად გსურთ თამაშიდან გასვლა?", "დახურვა", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Dispose();
        }

        private void pbxPerson1_Click(object sender, EventArgs e)
        {
            person1.Attack(ref person2);
        }

        private void pbxPerson2_Click(object sender, EventArgs e)
        {
            person2.Attack(ref person1);
        }

        private void pbxPerson1AddLevel_Click(object sender, EventArgs e)
        {

        }

        private void pbxPerson2AddLevel_Click(object sender, EventArgs e)
        {

        }

        private void pbxPerson2AddStrength_Click(object sender, EventArgs e)
        {

        }

        private void pbxPerson2AddAromr_Click(object sender, EventArgs e)
        {

        }

        private void pbxPerson2AddHealth_Click(object sender, EventArgs e)
        {

        }

        private void pbxPerson1AddStrength_Click(object sender, EventArgs e)
        {

        }

        private void pbxPerson1AddArmore_Click(object sender, EventArgs e)
        {
            person1.Armor += person1.IncreaseArmor(person1.AvailablePoints);
        }

        private void pbxPerson1AddHealth_Click(object sender, EventArgs e)
        {

        }
    }
}