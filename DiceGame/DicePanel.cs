using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class DicePanel : UserControl, IDicePanelView
    {
        #region Properties
        public PictureBox Dice
        {
            get
            {
                return pictureBoxDice;
            }
            set
            {
                pictureBoxDice = value;
            }
        }
        #endregion

        #region Events
        public event Action<PictureBox> DiceClicked;
        #endregion

        public DicePanel()
        {
            InitializeComponent();
        }

        private void pictureBoxDice_Click(object sender, EventArgs e)
        {
            DiceClicked?.Invoke(Dice);
        }
    }
}
