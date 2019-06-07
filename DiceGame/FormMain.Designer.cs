namespace DiceGame
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tableScore = new System.Windows.Forms.TableLayoutPanel();
            this.labelPause = new System.Windows.Forms.Label();
            this.labelPointsSum = new System.Windows.Forms.Label();
            this.labelCategorySum = new System.Windows.Forms.Label();
            this.labelPointsChance = new System.Windows.Forms.Label();
            this.labelChance = new System.Windows.Forms.Label();
            this.labelPointsYahtzee = new System.Windows.Forms.Label();
            this.labelCategoryYahtzee = new System.Windows.Forms.Label();
            this.labelPointsLargeStraight = new System.Windows.Forms.Label();
            this.labelCategoryLargeStraight = new System.Windows.Forms.Label();
            this.labelPointsSmallStraight = new System.Windows.Forms.Label();
            this.labelCategorySmallStraight = new System.Windows.Forms.Label();
            this.labelPointsFullHouse = new System.Windows.Forms.Label();
            this.labelCategoryFullHouse = new System.Windows.Forms.Label();
            this.labelPointsFourKind = new System.Windows.Forms.Label();
            this.labelCategoryFourKind = new System.Windows.Forms.Label();
            this.labelPointsThreeKind = new System.Windows.Forms.Label();
            this.labelCategoryThreeKind = new System.Windows.Forms.Label();
            this.labelPointsSixes = new System.Windows.Forms.Label();
            this.labelCategorySixes = new System.Windows.Forms.Label();
            this.labelPointsFives = new System.Windows.Forms.Label();
            this.labelCategoryFives = new System.Windows.Forms.Label();
            this.labelPointsFours = new System.Windows.Forms.Label();
            this.labelCategoryFours = new System.Windows.Forms.Label();
            this.labelPointsThrees = new System.Windows.Forms.Label();
            this.labelCategoryThrees = new System.Windows.Forms.Label();
            this.labelPointsTwos = new System.Windows.Forms.Label();
            this.labelCategoryTwos = new System.Windows.Forms.Label();
            this.labelPointsAces = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelCategoryAces = new System.Windows.Forms.Label();
            this.labelCategoryPause = new System.Windows.Forms.Label();
            this.labelRulesMain = new System.Windows.Forms.Label();
            this.labelRulesContent = new System.Windows.Forms.Label();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            this.pictureBoxRoll = new System.Windows.Forms.PictureBox();
            this.dicePanel4 = new DiceGame.DicePanel();
            this.dicePanel3 = new DiceGame.DicePanel();
            this.dicePanel5 = new DiceGame.DicePanel();
            this.dicePanel2 = new DiceGame.DicePanel();
            this.dicePanel1 = new DiceGame.DicePanel();
            this.tableScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoll)).BeginInit();
            this.SuspendLayout();
            // 
            // tableScore
            // 
            this.tableScore.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableScore.ColumnCount = 2;
            this.tableScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableScore.Controls.Add(this.labelPause, 1, 14);
            this.tableScore.Controls.Add(this.labelPointsSum, 1, 15);
            this.tableScore.Controls.Add(this.labelCategorySum, 0, 15);
            this.tableScore.Controls.Add(this.labelPointsChance, 1, 13);
            this.tableScore.Controls.Add(this.labelChance, 0, 13);
            this.tableScore.Controls.Add(this.labelPointsYahtzee, 1, 12);
            this.tableScore.Controls.Add(this.labelCategoryYahtzee, 0, 12);
            this.tableScore.Controls.Add(this.labelPointsLargeStraight, 1, 11);
            this.tableScore.Controls.Add(this.labelCategoryLargeStraight, 0, 11);
            this.tableScore.Controls.Add(this.labelPointsSmallStraight, 1, 10);
            this.tableScore.Controls.Add(this.labelCategorySmallStraight, 0, 10);
            this.tableScore.Controls.Add(this.labelPointsFullHouse, 1, 9);
            this.tableScore.Controls.Add(this.labelCategoryFullHouse, 0, 9);
            this.tableScore.Controls.Add(this.labelPointsFourKind, 1, 8);
            this.tableScore.Controls.Add(this.labelCategoryFourKind, 0, 8);
            this.tableScore.Controls.Add(this.labelPointsThreeKind, 1, 7);
            this.tableScore.Controls.Add(this.labelCategoryThreeKind, 0, 7);
            this.tableScore.Controls.Add(this.labelPointsSixes, 1, 6);
            this.tableScore.Controls.Add(this.labelCategorySixes, 0, 6);
            this.tableScore.Controls.Add(this.labelPointsFives, 1, 5);
            this.tableScore.Controls.Add(this.labelCategoryFives, 0, 5);
            this.tableScore.Controls.Add(this.labelPointsFours, 1, 4);
            this.tableScore.Controls.Add(this.labelCategoryFours, 0, 4);
            this.tableScore.Controls.Add(this.labelPointsThrees, 1, 3);
            this.tableScore.Controls.Add(this.labelCategoryThrees, 0, 3);
            this.tableScore.Controls.Add(this.labelPointsTwos, 1, 2);
            this.tableScore.Controls.Add(this.labelCategoryTwos, 0, 2);
            this.tableScore.Controls.Add(this.labelPointsAces, 1, 1);
            this.tableScore.Controls.Add(this.labelPoints, 1, 0);
            this.tableScore.Controls.Add(this.labelCategory, 0, 0);
            this.tableScore.Controls.Add(this.labelCategoryAces, 0, 1);
            this.tableScore.Controls.Add(this.labelCategoryPause, 0, 14);
            this.tableScore.Location = new System.Drawing.Point(12, 12);
            this.tableScore.Margin = new System.Windows.Forms.Padding(0);
            this.tableScore.Name = "tableScore";
            this.tableScore.RowCount = 16;
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableScore.Size = new System.Drawing.Size(200, 500);
            this.tableScore.TabIndex = 5;
            // 
            // labelPause
            // 
            this.labelPause.AutoSize = true;
            this.labelPause.Location = new System.Drawing.Point(113, 436);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(79, 13);
            this.labelPause.TabIndex = 33;
            this.labelPause.Text = "____________";
            // 
            // labelPointsSum
            // 
            this.labelPointsSum.AutoSize = true;
            this.labelPointsSum.Location = new System.Drawing.Point(113, 467);
            this.labelPointsSum.Name = "labelPointsSum";
            this.labelPointsSum.Size = new System.Drawing.Size(13, 13);
            this.labelPointsSum.TabIndex = 31;
            this.labelPointsSum.Text = "0";
            // 
            // labelCategorySum
            // 
            this.labelCategorySum.AutoSize = true;
            this.labelCategorySum.Location = new System.Drawing.Point(5, 467);
            this.labelCategorySum.Name = "labelCategorySum";
            this.labelCategorySum.Size = new System.Drawing.Size(28, 13);
            this.labelCategorySum.TabIndex = 30;
            this.labelCategorySum.Text = "Sum";
            // 
            // labelPointsChance
            // 
            this.labelPointsChance.AutoSize = true;
            this.labelPointsChance.Location = new System.Drawing.Point(113, 405);
            this.labelPointsChance.Name = "labelPointsChance";
            this.labelPointsChance.Size = new System.Drawing.Size(16, 13);
            this.labelPointsChance.TabIndex = 27;
            this.labelPointsChance.Text = "-1";
            // 
            // labelChance
            // 
            this.labelChance.AutoSize = true;
            this.labelChance.Location = new System.Drawing.Point(5, 405);
            this.labelChance.Name = "labelChance";
            this.labelChance.Size = new System.Drawing.Size(44, 13);
            this.labelChance.TabIndex = 26;
            this.labelChance.Text = "Chance";
            // 
            // labelPointsYahtzee
            // 
            this.labelPointsYahtzee.AutoSize = true;
            this.labelPointsYahtzee.Location = new System.Drawing.Point(113, 374);
            this.labelPointsYahtzee.Name = "labelPointsYahtzee";
            this.labelPointsYahtzee.Size = new System.Drawing.Size(16, 13);
            this.labelPointsYahtzee.TabIndex = 25;
            this.labelPointsYahtzee.Text = "-1";
            // 
            // labelCategoryYahtzee
            // 
            this.labelCategoryYahtzee.AutoSize = true;
            this.labelCategoryYahtzee.Location = new System.Drawing.Point(5, 374);
            this.labelCategoryYahtzee.Name = "labelCategoryYahtzee";
            this.labelCategoryYahtzee.Size = new System.Drawing.Size(46, 13);
            this.labelCategoryYahtzee.TabIndex = 24;
            this.labelCategoryYahtzee.Text = "Yahtzee";
            // 
            // labelPointsLargeStraight
            // 
            this.labelPointsLargeStraight.AutoSize = true;
            this.labelPointsLargeStraight.Location = new System.Drawing.Point(113, 343);
            this.labelPointsLargeStraight.Name = "labelPointsLargeStraight";
            this.labelPointsLargeStraight.Size = new System.Drawing.Size(16, 13);
            this.labelPointsLargeStraight.TabIndex = 23;
            this.labelPointsLargeStraight.Text = "-1";
            // 
            // labelCategoryLargeStraight
            // 
            this.labelCategoryLargeStraight.AutoSize = true;
            this.labelCategoryLargeStraight.Location = new System.Drawing.Point(5, 343);
            this.labelCategoryLargeStraight.Name = "labelCategoryLargeStraight";
            this.labelCategoryLargeStraight.Size = new System.Drawing.Size(73, 13);
            this.labelCategoryLargeStraight.TabIndex = 22;
            this.labelCategoryLargeStraight.Text = "Large Straight";
            // 
            // labelPointsSmallStraight
            // 
            this.labelPointsSmallStraight.AutoSize = true;
            this.labelPointsSmallStraight.Location = new System.Drawing.Point(113, 312);
            this.labelPointsSmallStraight.Name = "labelPointsSmallStraight";
            this.labelPointsSmallStraight.Size = new System.Drawing.Size(16, 13);
            this.labelPointsSmallStraight.TabIndex = 21;
            this.labelPointsSmallStraight.Text = "-1";
            // 
            // labelCategorySmallStraight
            // 
            this.labelCategorySmallStraight.AutoSize = true;
            this.labelCategorySmallStraight.Location = new System.Drawing.Point(5, 312);
            this.labelCategorySmallStraight.Name = "labelCategorySmallStraight";
            this.labelCategorySmallStraight.Size = new System.Drawing.Size(71, 13);
            this.labelCategorySmallStraight.TabIndex = 20;
            this.labelCategorySmallStraight.Text = "Small Straight";
            // 
            // labelPointsFullHouse
            // 
            this.labelPointsFullHouse.AutoSize = true;
            this.labelPointsFullHouse.Location = new System.Drawing.Point(113, 281);
            this.labelPointsFullHouse.Name = "labelPointsFullHouse";
            this.labelPointsFullHouse.Size = new System.Drawing.Size(16, 13);
            this.labelPointsFullHouse.TabIndex = 19;
            this.labelPointsFullHouse.Text = "-1";
            // 
            // labelCategoryFullHouse
            // 
            this.labelCategoryFullHouse.AutoSize = true;
            this.labelCategoryFullHouse.Location = new System.Drawing.Point(5, 281);
            this.labelCategoryFullHouse.Name = "labelCategoryFullHouse";
            this.labelCategoryFullHouse.Size = new System.Drawing.Size(57, 13);
            this.labelCategoryFullHouse.TabIndex = 18;
            this.labelCategoryFullHouse.Text = "Full House";
            // 
            // labelPointsFourKind
            // 
            this.labelPointsFourKind.AutoSize = true;
            this.labelPointsFourKind.Location = new System.Drawing.Point(113, 250);
            this.labelPointsFourKind.Name = "labelPointsFourKind";
            this.labelPointsFourKind.Size = new System.Drawing.Size(16, 13);
            this.labelPointsFourKind.TabIndex = 17;
            this.labelPointsFourKind.Text = "-1";
            // 
            // labelCategoryFourKind
            // 
            this.labelCategoryFourKind.AutoSize = true;
            this.labelCategoryFourKind.Location = new System.Drawing.Point(5, 250);
            this.labelCategoryFourKind.Name = "labelCategoryFourKind";
            this.labelCategoryFourKind.Size = new System.Drawing.Size(72, 13);
            this.labelCategoryFourKind.TabIndex = 16;
            this.labelCategoryFourKind.Text = "Four of a kind";
            // 
            // labelPointsThreeKind
            // 
            this.labelPointsThreeKind.AutoSize = true;
            this.labelPointsThreeKind.Location = new System.Drawing.Point(113, 219);
            this.labelPointsThreeKind.Name = "labelPointsThreeKind";
            this.labelPointsThreeKind.Size = new System.Drawing.Size(16, 13);
            this.labelPointsThreeKind.TabIndex = 15;
            this.labelPointsThreeKind.Text = "-1";
            // 
            // labelCategoryThreeKind
            // 
            this.labelCategoryThreeKind.AutoSize = true;
            this.labelCategoryThreeKind.Location = new System.Drawing.Point(5, 219);
            this.labelCategoryThreeKind.Name = "labelCategoryThreeKind";
            this.labelCategoryThreeKind.Size = new System.Drawing.Size(79, 13);
            this.labelCategoryThreeKind.TabIndex = 14;
            this.labelCategoryThreeKind.Text = "Three of a kind";
            // 
            // labelPointsSixes
            // 
            this.labelPointsSixes.AutoSize = true;
            this.labelPointsSixes.Location = new System.Drawing.Point(113, 188);
            this.labelPointsSixes.Name = "labelPointsSixes";
            this.labelPointsSixes.Size = new System.Drawing.Size(16, 13);
            this.labelPointsSixes.TabIndex = 13;
            this.labelPointsSixes.Text = "-1";
            // 
            // labelCategorySixes
            // 
            this.labelCategorySixes.AutoSize = true;
            this.labelCategorySixes.Location = new System.Drawing.Point(5, 188);
            this.labelCategorySixes.Name = "labelCategorySixes";
            this.labelCategorySixes.Size = new System.Drawing.Size(32, 13);
            this.labelCategorySixes.TabIndex = 12;
            this.labelCategorySixes.Text = "Sixes";
            // 
            // labelPointsFives
            // 
            this.labelPointsFives.AutoSize = true;
            this.labelPointsFives.Location = new System.Drawing.Point(113, 157);
            this.labelPointsFives.Name = "labelPointsFives";
            this.labelPointsFives.Size = new System.Drawing.Size(16, 13);
            this.labelPointsFives.TabIndex = 11;
            this.labelPointsFives.Text = "-1";
            // 
            // labelCategoryFives
            // 
            this.labelCategoryFives.AutoSize = true;
            this.labelCategoryFives.Location = new System.Drawing.Point(5, 157);
            this.labelCategoryFives.Name = "labelCategoryFives";
            this.labelCategoryFives.Size = new System.Drawing.Size(32, 13);
            this.labelCategoryFives.TabIndex = 10;
            this.labelCategoryFives.Text = "Fives";
            // 
            // labelPointsFours
            // 
            this.labelPointsFours.AutoSize = true;
            this.labelPointsFours.Location = new System.Drawing.Point(113, 126);
            this.labelPointsFours.Name = "labelPointsFours";
            this.labelPointsFours.Size = new System.Drawing.Size(16, 13);
            this.labelPointsFours.TabIndex = 9;
            this.labelPointsFours.Text = "-1";
            // 
            // labelCategoryFours
            // 
            this.labelCategoryFours.AutoSize = true;
            this.labelCategoryFours.Location = new System.Drawing.Point(5, 126);
            this.labelCategoryFours.Name = "labelCategoryFours";
            this.labelCategoryFours.Size = new System.Drawing.Size(33, 13);
            this.labelCategoryFours.TabIndex = 8;
            this.labelCategoryFours.Text = "Fours";
            // 
            // labelPointsThrees
            // 
            this.labelPointsThrees.AutoSize = true;
            this.labelPointsThrees.Location = new System.Drawing.Point(113, 95);
            this.labelPointsThrees.Name = "labelPointsThrees";
            this.labelPointsThrees.Size = new System.Drawing.Size(16, 13);
            this.labelPointsThrees.TabIndex = 7;
            this.labelPointsThrees.Text = "-1";
            // 
            // labelCategoryThrees
            // 
            this.labelCategoryThrees.AutoSize = true;
            this.labelCategoryThrees.Location = new System.Drawing.Point(5, 95);
            this.labelCategoryThrees.Name = "labelCategoryThrees";
            this.labelCategoryThrees.Size = new System.Drawing.Size(40, 13);
            this.labelCategoryThrees.TabIndex = 6;
            this.labelCategoryThrees.Text = "Threes";
            // 
            // labelPointsTwos
            // 
            this.labelPointsTwos.AutoSize = true;
            this.labelPointsTwos.Location = new System.Drawing.Point(113, 64);
            this.labelPointsTwos.Name = "labelPointsTwos";
            this.labelPointsTwos.Size = new System.Drawing.Size(16, 13);
            this.labelPointsTwos.TabIndex = 5;
            this.labelPointsTwos.Text = "-1";
            // 
            // labelCategoryTwos
            // 
            this.labelCategoryTwos.AutoSize = true;
            this.labelCategoryTwos.Location = new System.Drawing.Point(5, 64);
            this.labelCategoryTwos.Name = "labelCategoryTwos";
            this.labelCategoryTwos.Size = new System.Drawing.Size(33, 13);
            this.labelCategoryTwos.TabIndex = 4;
            this.labelCategoryTwos.Text = "Twos";
            // 
            // labelPointsAces
            // 
            this.labelPointsAces.AutoSize = true;
            this.labelPointsAces.Location = new System.Drawing.Point(113, 33);
            this.labelPointsAces.Name = "labelPointsAces";
            this.labelPointsAces.Size = new System.Drawing.Size(16, 13);
            this.labelPointsAces.TabIndex = 3;
            this.labelPointsAces.Text = "-1";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoints.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPoints.Location = new System.Drawing.Point(110, 2);
            this.labelPoints.Margin = new System.Windows.Forms.Padding(0);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(74, 20);
            this.labelPoints.TabIndex = 1;
            this.labelPoints.Text = "Points";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCategory.Location = new System.Drawing.Point(2, 2);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(102, 20);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Category";
            // 
            // labelCategoryAces
            // 
            this.labelCategoryAces.AutoSize = true;
            this.labelCategoryAces.Location = new System.Drawing.Point(5, 33);
            this.labelCategoryAces.Name = "labelCategoryAces";
            this.labelCategoryAces.Size = new System.Drawing.Size(31, 13);
            this.labelCategoryAces.TabIndex = 2;
            this.labelCategoryAces.Text = "Aces";
            // 
            // labelCategoryPause
            // 
            this.labelCategoryPause.AutoSize = true;
            this.labelCategoryPause.Location = new System.Drawing.Point(5, 436);
            this.labelCategoryPause.Name = "labelCategoryPause";
            this.labelCategoryPause.Size = new System.Drawing.Size(97, 13);
            this.labelCategoryPause.TabIndex = 32;
            this.labelCategoryPause.Text = "_______________";
            // 
            // labelRulesMain
            // 
            this.labelRulesMain.AutoSize = true;
            this.labelRulesMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRulesMain.Location = new System.Drawing.Point(428, 9);
            this.labelRulesMain.Name = "labelRulesMain";
            this.labelRulesMain.Size = new System.Drawing.Size(201, 73);
            this.labelRulesMain.TabIndex = 7;
            this.labelRulesMain.Text = "Rules";
            // 
            // labelRulesContent
            // 
            this.labelRulesContent.AutoSize = true;
            this.labelRulesContent.Location = new System.Drawing.Point(233, 76);
            this.labelRulesContent.Name = "labelRulesContent";
            this.labelRulesContent.Size = new System.Drawing.Size(574, 52);
            this.labelRulesContent.TabIndex = 8;
            this.labelRulesContent.Text = resources.GetString("labelRulesContent.Text");
            this.labelRulesContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPass
            // 
            this.pictureBoxPass.Image = global::DiceGame.Properties.Resources.DicePassOpacity;
            this.pictureBoxPass.Location = new System.Drawing.Point(544, 409);
            this.pictureBoxPass.Name = "pictureBoxPass";
            this.pictureBoxPass.Size = new System.Drawing.Size(250, 100);
            this.pictureBoxPass.TabIndex = 14;
            this.pictureBoxPass.TabStop = false;
            this.pictureBoxPass.Click += new System.EventHandler(this.pictureBoxPass_Click);
            // 
            // pictureBoxRoll
            // 
            this.pictureBoxRoll.Image = global::DiceGame.Properties.Resources.DiceRoll;
            this.pictureBoxRoll.Location = new System.Drawing.Point(258, 409);
            this.pictureBoxRoll.Name = "pictureBoxRoll";
            this.pictureBoxRoll.Size = new System.Drawing.Size(250, 100);
            this.pictureBoxRoll.TabIndex = 6;
            this.pictureBoxRoll.TabStop = false;
            this.pictureBoxRoll.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dicePanel4
            // 
            this.dicePanel4.Location = new System.Drawing.Point(585, 284);
            this.dicePanel4.Margin = new System.Windows.Forms.Padding(0);
            this.dicePanel4.Name = "dicePanel4";
            this.dicePanel4.Size = new System.Drawing.Size(100, 100);
            this.dicePanel4.TabIndex = 13;
            // 
            // dicePanel3
            // 
            this.dicePanel3.Location = new System.Drawing.Point(476, 284);
            this.dicePanel3.Margin = new System.Windows.Forms.Padding(0);
            this.dicePanel3.Name = "dicePanel3";
            this.dicePanel3.Size = new System.Drawing.Size(100, 100);
            this.dicePanel3.TabIndex = 12;
            // 
            // dicePanel5
            // 
            this.dicePanel5.Location = new System.Drawing.Point(694, 284);
            this.dicePanel5.Margin = new System.Windows.Forms.Padding(0);
            this.dicePanel5.Name = "dicePanel5";
            this.dicePanel5.Size = new System.Drawing.Size(100, 100);
            this.dicePanel5.TabIndex = 11;
            // 
            // dicePanel2
            // 
            this.dicePanel2.Location = new System.Drawing.Point(367, 284);
            this.dicePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.dicePanel2.Name = "dicePanel2";
            this.dicePanel2.Size = new System.Drawing.Size(100, 100);
            this.dicePanel2.TabIndex = 10;
            // 
            // dicePanel1
            // 
            this.dicePanel1.Location = new System.Drawing.Point(258, 284);
            this.dicePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.dicePanel1.Name = "dicePanel1";
            this.dicePanel1.Size = new System.Drawing.Size(100, 100);
            this.dicePanel1.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 521);
            this.Controls.Add(this.pictureBoxPass);
            this.Controls.Add(this.dicePanel4);
            this.Controls.Add(this.dicePanel3);
            this.Controls.Add(this.dicePanel5);
            this.Controls.Add(this.dicePanel2);
            this.Controls.Add(this.dicePanel1);
            this.Controls.Add(this.labelRulesContent);
            this.Controls.Add(this.labelRulesMain);
            this.Controls.Add(this.pictureBoxRoll);
            this.Controls.Add(this.tableScore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 560);
            this.MinimumSize = new System.Drawing.Size(850, 560);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice game";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableScore.ResumeLayout(false);
            this.tableScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableScore;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.PictureBox pictureBoxRoll;
        private System.Windows.Forms.Label labelRulesMain;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Label labelPointsSum;
        private System.Windows.Forms.Label labelCategorySum;
        private System.Windows.Forms.Label labelPointsChance;
        private System.Windows.Forms.Label labelChance;
        private System.Windows.Forms.Label labelPointsYahtzee;
        private System.Windows.Forms.Label labelCategoryYahtzee;
        private System.Windows.Forms.Label labelPointsLargeStraight;
        private System.Windows.Forms.Label labelCategoryLargeStraight;
        private System.Windows.Forms.Label labelPointsSmallStraight;
        private System.Windows.Forms.Label labelCategorySmallStraight;
        private System.Windows.Forms.Label labelPointsFullHouse;
        private System.Windows.Forms.Label labelCategoryFullHouse;
        private System.Windows.Forms.Label labelPointsFourKind;
        private System.Windows.Forms.Label labelCategoryFourKind;
        private System.Windows.Forms.Label labelPointsThreeKind;
        private System.Windows.Forms.Label labelCategoryThreeKind;
        private System.Windows.Forms.Label labelPointsSixes;
        private System.Windows.Forms.Label labelCategorySixes;
        private System.Windows.Forms.Label labelPointsFives;
        private System.Windows.Forms.Label labelCategoryFives;
        private System.Windows.Forms.Label labelPointsFours;
        private System.Windows.Forms.Label labelCategoryFours;
        private System.Windows.Forms.Label labelPointsThrees;
        private System.Windows.Forms.Label labelCategoryThrees;
        private System.Windows.Forms.Label labelPointsTwos;
        private System.Windows.Forms.Label labelCategoryTwos;
        private System.Windows.Forms.Label labelPointsAces;
        private System.Windows.Forms.Label labelCategoryAces;
        private System.Windows.Forms.Label labelCategoryPause;
        private System.Windows.Forms.Label labelRulesContent;
        private DicePanel dicePanel1;
        private DicePanel dicePanel2;
        private DicePanel dicePanel5;
        private DicePanel dicePanel3;
        private DicePanel dicePanel4;
        private System.Windows.Forms.PictureBox pictureBoxPass;
    }
}

