using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kosci
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dice1, dice2, dice3, dice4, dice5, dice6;
            Random random = new Random();
            dice1 = random.Next(1, 6);
            if (dice1 == 1) dice01.Image = Kosci.Properties.Resources.dices1;
            if (dice1 == 2) dice01.Image = Kosci.Properties.Resources.dices2;
            if (dice1 == 3) dice01.Image = Kosci.Properties.Resources.dices3;
            if (dice1 == 4) dice01.Image = Kosci.Properties.Resources.dices4;
            if (dice1 == 5) dice01.Image = Kosci.Properties.Resources.dices5;
            if (dice1 == 6) dice01.Image = Kosci.Properties.Resources.dices6;

            dice2 = random.Next(1, 6);
            if (dice2 == 1) dice02.Image = Kosci.Properties.Resources.dices1;
            if (dice2 == 2) dice02.Image = Kosci.Properties.Resources.dices2;
            if (dice2 == 3) dice02.Image = Kosci.Properties.Resources.dices3;
            if (dice2 == 4) dice02.Image = Kosci.Properties.Resources.dices4;  //wiem jak to wygląda...
            if (dice2 == 5) dice02.Image = Kosci.Properties.Resources.dices5;
            if (dice2 == 6) dice02.Image = Kosci.Properties.Resources.dices6;

            dice3 = random.Next(1, 6);
            if (dice3 == 1) dice03.Image = Kosci.Properties.Resources.dices1;
            if (dice3 == 2) dice03.Image = Kosci.Properties.Resources.dices2;
            if (dice3 == 3) dice03.Image = Kosci.Properties.Resources.dices3;
            if (dice3 == 4) dice03.Image = Kosci.Properties.Resources.dices4;
            if (dice3 == 5) dice03.Image = Kosci.Properties.Resources.dices5;
            if (dice3 == 6) dice03.Image = Kosci.Properties.Resources.dices6;

            dice4 = random.Next(1, 6);
            if (dice4 == 1) dice04.Image = Kosci.Properties.Resources.dices1;
            if (dice4 == 2) dice04.Image = Kosci.Properties.Resources.dices2;
            if (dice4 == 3) dice04.Image = Kosci.Properties.Resources.dices3;
            if (dice4 == 4) dice04.Image = Kosci.Properties.Resources.dices4;
            if (dice4 == 5) dice04.Image = Kosci.Properties.Resources.dices5;
            if (dice4 == 6) dice04.Image = Kosci.Properties.Resources.dices6;

            dice5 = random.Next(1, 6);
            if (dice5 == 1) dice05.Image = Kosci.Properties.Resources.dices1;
            if (dice5 == 2) dice05.Image = Kosci.Properties.Resources.dices2;
            if (dice5 == 3) dice05.Image = Kosci.Properties.Resources.dices3;
            if (dice5 == 4) dice05.Image = Kosci.Properties.Resources.dices4;
            if (dice5 == 5) dice05.Image = Kosci.Properties.Resources.dices5;
            if (dice5 == 6) dice05.Image = Kosci.Properties.Resources.dices6;

            dice6 = random.Next(1, 6);
            if (dice6 == 1) dice06.Image = Kosci.Properties.Resources.dices1;
            if (dice6 == 2) dice06.Image = Kosci.Properties.Resources.dices2;
            if (dice6 == 3) dice06.Image = Kosci.Properties.Resources.dices3;
            if (dice6 == 4) dice06.Image = Kosci.Properties.Resources.dices4;
            if (dice6 == 5) dice06.Image = Kosci.Properties.Resources.dices5;
            if (dice6 == 6) dice06.Image = Kosci.Properties.Resources.dices6;
        }

        private void brnPowrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void dice1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dice01_Click(object sender, EventArgs e)
        {

        }
    }
}
