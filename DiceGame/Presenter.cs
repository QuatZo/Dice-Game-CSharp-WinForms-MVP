using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    class Presenter
    {
        #region Classes
        IView view;
        Model model;
        #endregion

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.FormLoaded += View_FormLoaded;
            this.view.RollButtonClicked += View_RollButtonClicked;
            this.view.PassButtonClicked += View_PassButtonClicked;

            this.view.DiceFirst.DiceClicked += Dice_DiceClicked1;
            this.view.DiceSecond.DiceClicked += Dice_DiceClicked1;
            this.view.DiceThird.DiceClicked += Dice_DiceClicked1;
            this.view.DiceFourth.DiceClicked += Dice_DiceClicked1;
            this.view.DiceFifth.DiceClicked += Dice_DiceClicked1;
        }

        #region Methods
        private void View_PassButtonClicked()
        {
            if (view.DiceResources.Contains(view.PassButton.Image))
            {
                view.PassButton.Image = view.DiceOpacityResources[8];
                if (view.DiceResources.Contains(view.RollButton.Image)) { view.RollButton.Image = view.DiceOpacityResources[7]; }
                if (view.Game.Rolls != 3) { view.Game.Rolls = 3; }

                view.Game.SetFinalRolls(view.Dices, view.DiceResources, view.DiceOpacityResources);

                if (view.Game.Rounds == 0) { MessageBox.Show("Please, select a category from the table on the left.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            
        }

        private void View_RollButtonClicked()
        {
            if (view.Game.Rolls < 3)
            {
                view.Game.Roll(model.RandomPips(), view.Dices, view.DiceResources);

                if (view.Game.Rolls > 0 && view.DiceOpacityResources.Contains(view.PassButton.Image)) { view.PassButton.Image = view.DiceResources[8]; }
                if (view.Game.Rolls == 3 && view.DiceResources.Contains(view.RollButton.Image)) { view.RollButton.Image = view.DiceOpacityResources[7]; }
            }

        }

        private void View_FormLoaded()
        {
            view.Game = new GameEngine();
            view.Game.Start();

            foreach (Label cell in view.Table.Controls)
            {
                cell.MouseClick += new MouseEventHandler(cellClicked);
            }

            model.InitializeDices(view.Dices, view.Buttons, view.DiceResources, view.DiceOpacityResources);
        }

        private void Dice_DiceClicked1(PictureBox obj)
        {
            model.ChangeDiceStatus(view.DiceResources, view.DiceOpacityResources, obj);
        }

        private void cellClicked(object sender, MouseEventArgs e)
        {
            Label cell = (Label)sender;

            if(view.Table.GetColumn(cell) == 1 && view.Table.GetRow(cell) > 0 && view.Table.GetRow(cell) < 14 && int.Parse(cell.Text) == -1)
            {
                if(view.DiceOpacityResources.Contains(view.RollButton.Image) && view.DiceOpacityResources.Contains(view.PassButton.Image))
                {
                    view.ScoreLabel = model.PrepareForNextRound(view.Table, view.Game, cell);
                    view.Game.NextRound(view.Dices, view.Buttons, view.DiceResources, view.DiceOpacityResources);
                }
                else { MessageBox.Show("You must finish the turn before choosing a category!", "Wrong move", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            else { MessageBox.Show("You can't use a category that has already been used!", "Wrong move", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            if(view.Game.Rounds == 13)
            {
                view.Game.End();
                view.Exit();
            }
        }
        #endregion
    }
}
