using DiceGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class FormMain : Form, IView
    {
        #region Properties
        public TableLayoutPanel Table
        {
            get
            {
                return tableScore;
            }
            set
            {
                tableScore = value;
            }
        }

        public IDicePanelView DiceFirst
        {
            get
            {
                return dicePanel1;
            }
        }
        public IDicePanelView DiceSecond
        {
            get
            {
                return dicePanel2;
            }
        }
        public IDicePanelView DiceThird
        {
            get
            {
                return dicePanel5;
            }
        }
        public IDicePanelView DiceFourth
        {
            get
            {
                return dicePanel3;
            }
        }
        public IDicePanelView DiceFifth
        {
            get
            {
                return dicePanel4;
            }
        }

        public PictureBox RollButton
        {
            get
            {
                return pictureBoxRoll;
            }
            set
            {
                pictureBoxRoll = value;
            }
        }
        public PictureBox PassButton
        {
            get
            {
                return pictureBoxPass;
            }
            set
            {
                pictureBoxPass = value;
            }
        }

        public List<Bitmap> DiceResources { get; set; }
        public List<Bitmap> DiceOpacityResources { get; set; }

        public int Rolls { get; set; } = 0;
        public int Rounds { get; set; } = 0;
        public int TotalScore
        {
            get
            {
                return int.Parse(labelPointsSum.Text);
            }
            set
            {
                labelPointsSum.Text = value.ToString();
            }
        }
        public List<int> FinalRolls
        {
            get
            {
                List<int> finalRolls = new List<int>();

                List<bool> diceFlags = new List<bool> { false, false, false, false, false };
                for (int i = 1; i <= 6; i++)
                {
                    if (!diceFlags[0] && (DiceFirst.Dice.Image == DiceResources[i] || DiceFirst.Dice.Image == DiceOpacityResources[i]))
                    {
                        finalRolls.Add(i);
                        diceFlags[0] = true;
                    }
                    if (!diceFlags[1] && (DiceSecond.Dice.Image == DiceResources[i] || DiceSecond.Dice.Image == DiceOpacityResources[i]))
                    {
                        finalRolls.Add(i);
                        diceFlags[1] = true;
                    }
                    if (!diceFlags[2] && (DiceThird.Dice.Image == DiceResources[i] || DiceThird.Dice.Image == DiceOpacityResources[i]))
                    {
                        finalRolls.Add(i);
                        diceFlags[2] = true;
                    }
                    if (!diceFlags[3] && (DiceFourth.Dice.Image == DiceResources[i] || DiceFourth.Dice.Image == DiceOpacityResources[i]))
                    {
                        finalRolls.Add(i);
                        diceFlags[3] = true;
                    }
                    if (!diceFlags[4] && (DiceFifth.Dice.Image == DiceResources[i] || DiceFifth.Dice.Image == DiceOpacityResources[i]))
                    {
                        finalRolls.Add(i);
                        diceFlags[4] = true;
                    }
                }

                return finalRolls;
            }
        }
        #endregion

        public FormMain()
        {
            InitializeComponent();

            List<Bitmap> diceResources = new List<Bitmap>
            {
                Resources.Dice0,
                Resources.Dice1,
                Resources.Dice2,
                Resources.Dice3,
                Resources.Dice4,
                Resources.Dice5,
                Resources.Dice6,
                Resources.DiceRoll,
                Resources.DicePass
            };
            DiceResources = diceResources;

            List<Bitmap> diceOpacityResources = new List<Bitmap>
            {
                Resources.Dice0Opacity,
                Resources.Dice1Opacity,
                Resources.Dice2Opacity,
                Resources.Dice3Opacity,
                Resources.Dice4Opacity,
                Resources.Dice5Opacity,
                Resources.Dice6Opacity,
                Resources.DiceRollOpacity,
                Resources.DicePassOpacity
            };
            DiceOpacityResources = diceOpacityResources;
        }

        #region Events
        public event Action FormLoaded;
        public event Action RollButtonClicked;
        public event Action PassButtonClicked;
        #endregion


        #region Methods
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RollButtonClicked?.Invoke();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLoaded?.Invoke();
        }

        private void pictureBoxPass_Click(object sender, EventArgs e)
        {
            PassButtonClicked?.Invoke();
        }

        public void Roll(List<int> randoms)
        {
            if (DiceResources.Contains(DiceFirst.Dice.Image)) { DiceFirst.Dice.Image = DiceResources[randoms[0]]; }
            if (DiceResources.Contains(DiceSecond.Dice.Image)) { DiceSecond.Dice.Image = DiceResources[randoms[1]]; }
            if (DiceResources.Contains(DiceThird.Dice.Image)) { DiceThird.Dice.Image = DiceResources[randoms[2]]; }
            if (DiceResources.Contains(DiceFourth.Dice.Image)) { DiceFourth.Dice.Image = DiceResources[randoms[3]]; }
            if (DiceResources.Contains(DiceFifth.Dice.Image)) { DiceFifth.Dice.Image = DiceResources[randoms[4]]; }

            Rolls++;
        }

        public void ChooseCategory()
        {
            foreach(var finalRoll in FinalRolls)
            {
                Console.WriteLine(finalRoll);
            }
            
        }

        public void NextRound()
        {
            Rounds++;

            DiceFirst.Dice.Image = DiceResources[0];
            DiceSecond.Dice.Image = DiceResources[0];
            DiceThird.Dice.Image = DiceResources[0];
            DiceFourth.Dice.Image = DiceResources[0];
            DiceFifth.Dice.Image = DiceResources[0];

            RollButton.Image = DiceResources[7];
            PassButton.Image = DiceResources[8];

            Rolls = 0;
        }
        public void Exit()
        {
            Close();
        }
        #endregion
    }
}
