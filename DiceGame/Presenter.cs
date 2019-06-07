using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    class Presenter
    {
        IView view;
        Model model;

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.FormLoaded += View_FormLoaded;

            this.view.DiceFirst.DiceClicked += Dice_DiceClicked1;
            this.view.DiceSecond.DiceClicked += Dice_DiceClicked1;
            this.view.DiceThird.DiceClicked += Dice_DiceClicked1;
            this.view.DiceFourth.DiceClicked += Dice_DiceClicked1;
            this.view.DiceFifth.DiceClicked += Dice_DiceClicked1;
        }

        private void View_FormLoaded()
        {
            view.DiceFirst.Dice.Image = view.DiceResources[0]; // 0 - pusta kostka
            view.DiceSecond.Dice.Image = view.DiceResources[0]; // [1 - 6] - wartości 1-6
            view.DiceThird.Dice.Image = view.DiceResources[0];
            view.DiceFourth.Dice.Image = view.DiceResources[0];
            view.DiceFifth.Dice.Image = view.DiceResources[0];
            view.RollButton.Image = view.DiceResources[7]; // 7 - roll; 8 - pass;
            view.PassButton.Image = view.DiceOpacityResources[8]; // 7 - roll; 8 - pass;
        }

        private void Dice_DiceClicked1(PictureBox obj)
        {
            Console.WriteLine(obj.Parent.Name); // nazwa panelu (czyt. przycisku z poziomu FormMain); możliwe, że niepotrzebne

            model.ChangeDiceStatus(view.DiceResources, view.DiceOpacityResources, obj);
        }
    }
}
