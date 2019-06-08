using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    interface IView
    {
        #region Properties
        GameEngine Game { get; set; }

        TableLayoutPanel Table { get; set; }
        int ScoreLabel { get; set; }

        PictureBox RollButton { get; set; }
        PictureBox PassButton { get; set; }

        IDicePanelView DiceFirst { get; }
        IDicePanelView DiceSecond { get; }
        IDicePanelView DiceThird { get; }
        IDicePanelView DiceFourth { get; }
        IDicePanelView DiceFifth { get; }

        List<PictureBox> Dices { get; set; }
        List<PictureBox> Buttons { get; set; }

        List<Bitmap> DiceResources { get; set; }
        List<Bitmap> DiceOpacityResources { get; set; }
        #endregion

        #region Events
        event Action FormLoaded;
        event Action RollButtonClicked;
        event Action PassButtonClicked;
        #endregion

        #region Methods
        void Exit();
        #endregion
    }
}
