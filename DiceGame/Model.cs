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

    }
}
