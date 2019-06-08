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
        public GameEngine Game { get; set; }

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

        public int ScoreLabel
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

        public List<PictureBox> Dices
        {
            get
            {
                return new List<PictureBox>
                {
                    DiceFirst.Dice,
                    DiceSecond.Dice,
                    DiceThird.Dice,
                    DiceFourth.Dice,
                    DiceFifth.Dice,
                };
            }
            set
            {
                DiceFirst.Dice = value[0];
                DiceSecond.Dice = value[1];
                DiceThird.Dice = value[2];
                DiceFourth.Dice = value[3];
                DiceFifth.Dice = value[4];

            }
        }
        public List<PictureBox> Buttons
        {
            get
            {
                return new List<PictureBox>
                {
                    RollButton,
                    PassButton
                };
            }
            set
            {
                RollButton = value[0];
                PassButton = value[1];
            }
        }

        public List<Bitmap> DiceResources { get; set; }
        public List<Bitmap> DiceOpacityResources { get; set; }
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

        public void Exit()
        {
            Close();
        }
        #endregion
    }
}
