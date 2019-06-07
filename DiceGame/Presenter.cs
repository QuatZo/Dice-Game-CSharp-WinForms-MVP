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
            this.view.RollButtonClicked += View_RollButtonClicked;
            this.view.PassButtonClicked += View_PassButtonClicked;

            this.view.DiceFirst.DiceClicked += Dice_DiceClicked1;
            this.view.DiceSecond.DiceClicked += Dice_DiceClicked1;
            this.view.DiceThird.DiceClicked += Dice_DiceClicked1;
            this.view.DiceFourth.DiceClicked += Dice_DiceClicked1;
            this.view.DiceFifth.DiceClicked += Dice_DiceClicked1;
        }

        private void View_PassButtonClicked()
        {
            if (view.DiceResources.Contains(view.PassButton.Image))
            {
                view.PassButton.Image = view.DiceOpacityResources[8];
                if (view.DiceResources.Contains(view.RollButton.Image)) { view.RollButton.Image = view.DiceOpacityResources[7]; }
                if (view.Rolls != 3) { view.Rolls = 3; }

                view.ChooseCategory();
            }
            
        }

        private void View_RollButtonClicked()
        {
            if (view.Rolls < 3)
            {
                List<int> randoms = new List<int>();
                Random rand = new Random();

                for (int i = 0; i < 5; i++)
                {
                    randoms.Add(rand.Next(1, 7)); // 1 - 6
                }

                view.Roll(randoms);

                if (view.Rolls > 0 && view.DiceOpacityResources.Contains(view.PassButton.Image)) { view.PassButton.Image = view.DiceResources[8]; }
                if (view.Rolls == 3 && view.DiceResources.Contains(view.RollButton.Image)) { view.RollButton.Image = view.DiceOpacityResources[7]; }
            }

        }

        private void View_FormLoaded()
        {
            foreach (Label cell in view.Table.Controls)
            {
                cell.MouseClick += new MouseEventHandler(cellClicked);
            }

            view.DiceFirst.Dice.Image = view.DiceResources[0]; // 0 - pusta kostka
            view.DiceSecond.Dice.Image = view.DiceResources[0]; // [1 - 6] - wartości 1-6
            view.DiceThird.Dice.Image = view.DiceResources[0];
            view.DiceFourth.Dice.Image = view.DiceResources[0];
            view.DiceFifth.Dice.Image = view.DiceResources[0];
            view.RollButton.Image = view.DiceResources[7]; // 7 - roll
            view.PassButton.Image = view.DiceOpacityResources[8]; // 8 - pass
        }

        private void Dice_DiceClicked1(PictureBox obj)
        {
            Console.WriteLine(obj.Parent.Name); // nazwa panelu (czyt. przycisku z poziomu FormMain); możliwe, że niepotrzebne

            model.ChangeDiceStatus(view.DiceResources, view.DiceOpacityResources, obj);
        }

        private void cellClicked(object sender, MouseEventArgs e)
        {
            Label cell = (Label)sender;

            if(view.Table.GetColumn(cell) == 1 && view.Table.GetRow(cell) > 0 && view.Table.GetRow(cell) < 14 && int.Parse(cell.Text) == -1)
            {
                if(view.DiceOpacityResources.Contains(view.RollButton.Image) && view.DiceOpacityResources.Contains(view.PassButton.Image))
                {
                    int score = view.FinalRolls.Sum();
                    cell.Text = score.ToString(); // tymczasowo
                    view.TotalScore += score;
                    view.NextRound();
                }
                else { MessageBox.Show("You must finish the turn before choosing a category!", "Wrong move", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            else { MessageBox.Show("You can't use a category that has already been used!", "Wrong move", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            if(view.Rounds == 13)
            {
                MessageBox.Show($"Congratulations! You got {view.TotalScore} points. I am proud of you! Check points with your friend.", "Endgame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                view.Exit();
            }
        }
    }
}
