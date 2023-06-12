using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ninja
{
    public partial class GameLancher : Form
    {

        public GameLancher()
        {
            InitializeComponent();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            Hide();
            using (RPG_Game newRound = new RPG_Game())
            {
                newRound.ShowDialog();
            }
            Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
