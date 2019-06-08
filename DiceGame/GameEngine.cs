using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public class GameEngine
    {
        private Categories categories;

        #region Properties
        public int Rolls { get; set; }
        public int Rounds { get; set; }
        public int Score { get; set; }
        public int TotalScore { get; set; }
        public List<int> FinalRolls { get; set; }
        #endregion

        #region Methods
        public void Start()
        {
            categories = new Categories();
            Rolls = 0;
            Rounds = 0;
            TotalScore = 0;
            FinalRolls = new List<int>();
        }
        public void Roll(List<int> randoms, List<PictureBox> dices, List<Bitmap> diceResources)
        {
            for(int i = 0; i < dices.Count; i++)

            if (diceResources.Contains(dices[i].Image)) { dices[i].Image = diceResources[randoms[i]]; }

            Rolls++;
        }

        public void ChosenCategory(int row)
        {
            switch (row)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6: Score = categories.SumOfSameDices(FinalRolls, row);
                    break;
                case 7: Score = categories.ThreeOfAKind(FinalRolls);
                    break;
                case 8: Score = categories.ThreeOfAKind(FinalRolls);
                    break;
                case 9: Score = categories.FullHouse(FinalRolls);
                    break;
                case 10:Score = categories.SmallStraight(FinalRolls);
                    break;
                case 11: Score = categories.LargeStraight(FinalRolls);
                    break;
                case 12: Score = categories.Yahtzee(FinalRolls);
                    break;
                case 13: Score = categories.Chance(FinalRolls);
                    break;
                default: MessageBox.Show("Ups! Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            TotalScore += Score;
        }

        public void SetFinalRolls(List<PictureBox> dices, List<Bitmap> diceResources, List<Bitmap> diceOpacityResources)
        {
            List<int> finalRolls = new List<int>();

            List<bool> diceFlags = new List<bool> { false, false, false, false, false };
            for (int i = 1; i <= 6; i++)
            {
                if (!diceFlags[0] && (dices[0].Image == diceResources[i] || dices[0].Image == diceOpacityResources[i]))
                {
                    finalRolls.Add(i);
                    diceFlags[0] = true;
                }
                if (!diceFlags[1] && (dices[1].Image == diceResources[i] || dices[1].Image == diceOpacityResources[i]))
                {
                    finalRolls.Add(i);
                    diceFlags[1] = true;
                }
                if (!diceFlags[2] && (dices[2].Image == diceResources[i] || dices[2].Image == diceOpacityResources[i]))
                {
                    finalRolls.Add(i);
                    diceFlags[2] = true;
                }
                if (!diceFlags[3] && (dices[3].Image == diceResources[i] || dices[3].Image == diceOpacityResources[i]))
                {
                    finalRolls.Add(i);
                    diceFlags[3] = true;
                }
                if (!diceFlags[4] && (dices[4].Image == diceResources[i] || dices[4].Image == diceOpacityResources[i]))
                {
                    finalRolls.Add(i);
                    diceFlags[4] = true;
                }
            }

            FinalRolls = finalRolls;
        }

        public void NextRound(List<PictureBox> dices, List<PictureBox> buttons, List<Bitmap> diceResources, List<Bitmap> diceOpacityResources)
        {
            Rounds++;

            dices[0].Image = diceResources[0];
            dices[1].Image = diceResources[0];
            dices[2].Image = diceResources[0];
            dices[3].Image = diceResources[0];
            dices[4].Image = diceResources[0];

            buttons[0].Image = diceResources[7];
            buttons[1].Image = diceOpacityResources[8];

            Rolls = 0;
        }

        public void End()
        {
            if (Rounds == 13)
            {
                MessageBox.Show($"Congratulations! You got {TotalScore} points. I am proud of you! Compare points with your friend.", "Endgame", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("This game shouldn't end yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

    }
}
