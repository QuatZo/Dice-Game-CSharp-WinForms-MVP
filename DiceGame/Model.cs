using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    class Model
    {
        public void InitializeDices(List<PictureBox> dices, List<PictureBox> buttons, List<Bitmap> diceResources, List<Bitmap> diceOpacityResources)
        {
            for (int i = 0; i < dices.Count; i++)
            {
                dices[i].Image = diceResources[0]; // pustka kostka dla wszystkich
            }
            buttons[0].Image = diceResources[7]; // 7 - roll
            buttons[1].Image = diceOpacityResources[8]; // 8 - pass
        }

        public void ChangeDiceStatus(List<Bitmap> diceResources, List<Bitmap> diceOpacityResources, PictureBox dice)
        {
            if (diceResources.Contains(dice.Image) && dice.Image != diceResources[0])
            {
                for (int i = 1; i <= 6; i++)
                {
                    if (dice.Image == diceResources[i])
                    {
                        dice.Image = diceOpacityResources[i];
                        break;
                    }

                }
            }
            else if (diceOpacityResources.Contains(dice.Image) && dice.Image != diceOpacityResources[0])
            {
                for (int i = 1; i <= 6; i++)
                {
                    if (dice.Image == diceOpacityResources[i])
                    {
                        dice.Image = diceResources[i];
                        break;
                    }

                }
            }
        }

        public List<int> RandomPips()
        {
            List<int> randoms = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                randoms.Add(rand.Next(1, 7)); // 1 - 6
            }
            return randoms;
        }

        public int PrepareForNextRound(TableLayoutPanel table, GameEngine game, Label cell)
        {
            game.ChosenCategory(table.GetRow(cell));

            cell.Text = game.Score.ToString(); // tymczasowo, potem będą tutaj wzorki potworki

            return game.TotalScore;
        }
    }
}
