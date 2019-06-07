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
        IDicePanelView DiceFirst { get; }
        IDicePanelView DiceSecond { get; }
        IDicePanelView DiceThird { get; }
        IDicePanelView DiceFourth { get; }
        IDicePanelView DiceFifth { get; }

        PictureBox RollButton { get; set; }
        PictureBox PassButton { get; set; }

        List<Bitmap> DiceResources { get; set; }
        List<Bitmap> DiceOpacityResources { get; set; }
        #endregion

        #region Events
        event Action FormLoaded;
        #endregion

    }
}
