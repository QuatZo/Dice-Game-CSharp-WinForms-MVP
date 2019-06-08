using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Categories
    {
        #region Methods
        public int SumOfSameDices(List<int> dices, int category)
        {
            int sum = 0;
            foreach(var dice in dices)
            {
                if(dice == category) { sum += category; }
            }
            return sum;
        }

        public int ThreeOfAKind(List<int> dices)
        {
            int sum = 0;
            Dictionary<int, int> dicesAmount = new Dictionary<int, int>
            {
                { 1, 0 },
                { 2, 0 },
                { 3, 0 },
                { 4, 0 },
                { 5, 0 },
                { 6, 0 },
            };
            for (int i = 0; i < dices.Count; i++)
            {
                dicesAmount[dices[i]]++;
            }
            foreach(KeyValuePair<int, int> diceAmount in dicesAmount)
            {
                if(diceAmount.Value >= 3)
                {
                    sum = dices.Sum();
                    break;
                }
            }
            return sum;
        }

        public int FourOfAKind(List<int> dices)
        {
            int sum = 0;
            Dictionary<int, int> dicesAmount = new Dictionary<int, int>
            {
                { 1, 0 },
                { 2, 0 },
                { 3, 0 },
                { 4, 0 },
                { 5, 0 },
                { 6, 0 },
            };
            for (int i = 0; i < dices.Count; i++)
            {
                dicesAmount[dices[i]]++;
            }
            foreach (KeyValuePair<int, int> diceAmount in dicesAmount)
            {
                if (diceAmount.Value >= 4)
                {
                    sum = dices.Sum();
                    break;
                }
            }
            return sum;
        }

        public int FullHouse(List<int> dices)
        {
            bool threes = false;
            bool twos = false;

            Dictionary<int, int> dicesAmount = new Dictionary<int, int>
            {
                { 1, 0 },
                { 2, 0 },
                { 3, 0 },
                { 4, 0 },
                { 5, 0 },
                { 6, 0 },
            };
            for (int i = 0; i < dices.Count; i++)
            {
                dicesAmount[dices[i]]++;
            }

            foreach (KeyValuePair<int, int> diceAmount in dicesAmount)
            {
                if (diceAmount.Value == 2) { twos = true; }
                if(diceAmount.Value == 3) { threes = true; }

                if( twos && threes) { return 25; }
            }
            return 0;
        }

        public int SmallStraight(List<int> dices)
        {
            dices.Sort();
            int pairs = 0;

            for(int i = 0; i < dices.Count - 1; i++)
            {
                if(dices[i] == dices[i+1] - 1)
                {
                    pairs++;
                    if (pairs == 3) { return 30; }
                }

            }
            return 0;
        }
        public int LargeStraight(List<int> dices)
        {
            dices.Sort();
            int pairs = 0;

            for (int i = 0; i < dices.Count - 1; i++)
            {
                if (dices[i] == dices[i + 1] - 1)
                {
                    pairs++;
                    if (pairs == 4) { return 40; }
                }

            }
            return 0;
        }

        public int Yahtzee(List<int> dices)
        {
            for(int i = 1; i < dices.Count; i++)
            {
                if(dices[i] != dices[0])
                {
                    return 0;
                }
            }
            return 50;
        }

        public int Chance(List<int> dices)
        {
            return dices.Sum();
        }
        #endregion
    }
}
