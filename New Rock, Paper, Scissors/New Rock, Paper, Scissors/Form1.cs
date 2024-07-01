using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Rock__Paper__Scissors
{
    public partial class Form1 : Form
    {
        public int enemy, player = 4;
        public string winner, tPlayer, tEnemy;
        public Label WhoWinner;
        public Random random = new Random();

        private void Rock_Click(object sender, EventArgs e)
        {
            this.player = 0;
            Logic();
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            this.player = 1;
            Logic();
        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            this.player = 2;
            Logic();
        }

        public Form1()
        {
            InitializeComponent();
            WeaponEnemy();
            Logic();

            WhoWinner = new Label();
            WhoWinner.Text = $"Выберите оружие";
            WhoWinner.Location = new Point(300, 145);
            WhoWinner.Width = 200;
            WhoWinner.Height = 80;
            this.Controls.Add(WhoWinner);
        }

        public void Logic()
        {
            WeaponEnemy();

            if (player == 0 && enemy == 0)
            {
                winner = "дружба";
                eRock.Location = new Point(300, 10);
                ePaper.Location = new Point(300, -130);
                eScissors.Location = new Point(300, -130);
            }
            else if (player == 0 && enemy == 1)
            {
                winner = "Игрок";
                eRock.Location = new Point(300, -130);
                ePaper.Location = new Point(300, 10);
                eScissors.Location = new Point(300, -130);
            }
            else if (player == 0 && enemy == 2)
            {
                winner = "Противник";
                eRock.Location = new Point(300, -130);
                ePaper.Location = new Point(300, -130);
                eScissors.Location = new Point(300, 10);
            }
            else if (player == 1 && enemy == 0)
            {
                winner = "Противник";
                eRock.Location = new Point(300, 10);
                ePaper.Location = new Point(300, -130);
                eScissors.Location = new Point(300, -130);
            }
            else if (player == 1 && enemy == 1)
            {
                winner = "дружба";
                eRock.Location = new Point(300, -130);
                ePaper.Location = new Point(300, 10);
                eScissors.Location = new Point(300, -130);
            }
            else if (player == 1 && enemy == 2)
            {
                winner = "Игрок";
                eRock.Location = new Point(300, -130);
                ePaper.Location = new Point(300, -130);
                eScissors.Location = new Point(300, 10);
            }
            else if (player == 2 && enemy == 0)
            {
                winner = "Игрок";
                eRock.Location = new Point(300, 10);
                ePaper.Location = new Point(300, -130);
                eScissors.Location = new Point(300, -130);
            }
            else if (player == 2 && enemy == 1)
            {
                winner = "Противник";
                eRock.Location = new Point(300, -130);
                ePaper.Location = new Point(300, 10);
                eScissors.Location = new Point(300, -130);
            }
            else if (player == 2 && enemy == 2)
            {
                winner = "дружба";
                eRock.Location = new Point(300, -130);
                ePaper.Location = new Point(300, -130);
                eScissors.Location = new Point(300, 10);
            }

            

            if (player != 4)
                WhoWinner.Text = $"У противника {tEnemy} \n\n\n\n\nПобеждает {winner}!!";
        }

        public void WeaponEnemy()
        {            
            enemy = random.Next(3);

            if (enemy == 0)
            {
                tEnemy = "Камень";
            }
            else if (enemy == 1)
            {
                tEnemy = "Ножницы";
            }
            else if (enemy == 2)
            {
                tEnemy = "Бумага";
            }
        }

        public void TypeEnemy()
        {

        }
    }
}
