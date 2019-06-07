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
        TableLayoutPanel Table { get; set; }

        IDicePanelView DiceFirst { get; }
        IDicePanelView DiceSecond { get; }
        IDicePanelView DiceThird { get; }
        IDicePanelView DiceFourth { get; }
        IDicePanelView DiceFifth { get; }

        PictureBox RollButton { get; set; }
        PictureBox PassButton { get; set; }

        List<Bitmap> DiceResources { get; set; }
        List<Bitmap> DiceOpacityResources { get; set; }

        int Rolls { get; set; }
        int Rounds { get; set; }
        int TotalScore { get; set; }
        List<int> FinalRolls { get; }
        #endregion

        #region Events
        event Action FormLoaded;
        event Action RollButtonClicked;
        event Action PassButtonClicked;
        #endregion


        #region Methods
        void Roll(List<int> randoms);
        void ChooseCategory();
        void NextRound();
        void Exit();
        #endregion
    }
}
