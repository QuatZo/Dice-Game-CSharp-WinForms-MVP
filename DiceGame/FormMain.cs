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
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            List<int> randoms = new List<int>();
            Random rand = new Random();

            for(int i = 0; i < 5; i++)
            {
                randoms.Add(rand.Next(1, 7)); // 1 - 6
            }

            // TO NIŻEJ TRZEBA ZAMIENIĆ, ALE NIE BĘDZIE DZIAŁAĆ PÓKI TE IFY WYŻEJ NIE ZACZNĄ -_-
            if (DiceResources.Contains(DiceFirst.Dice.Image)) { DiceFirst.Dice.Image = DiceResources[randoms[0]]; }
            if (DiceResources.Contains(DiceSecond.Dice.Image)) { DiceSecond.Dice.Image = DiceResources[randoms[1]]; }
            if (DiceResources.Contains(DiceThird.Dice.Image)) { DiceThird.Dice.Image = DiceResources[randoms[2]]; }
            if (DiceResources.Contains(DiceFourth.Dice.Image)) { DiceFourth.Dice.Image = DiceResources[randoms[3]]; }
            if (DiceResources.Contains(DiceFifth.Dice.Image)) { DiceFifth.Dice.Image = DiceResources[randoms[4]]; }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLoaded?.Invoke();
        }
    }
}
