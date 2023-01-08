using Microsoft.VisualBasic.ApplicationServices;

namespace Kosci
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnZasady_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zasady zasady = new Zasady();
            zasady.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGraj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game();
            game.ShowDialog();
        }
    }
}