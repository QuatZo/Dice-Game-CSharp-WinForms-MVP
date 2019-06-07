namespace DiceGame
{
    partial class DicePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxDice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDice)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDice
            // 
            this.pictureBoxDice.Image = global::DiceGame.Properties.Resources.Dice0;
            this.pictureBoxDice.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDice.Name = "pictureBoxDice";
            this.pictureBoxDice.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxDice.TabIndex = 1;
            this.pictureBoxDice.TabStop = false;
            this.pictureBoxDice.Click += new System.EventHandler(this.pictureBoxDice_Click);
            // 
            // DicePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxDice);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DicePanel";
            this.Size = new System.Drawing.Size(100, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDice;
    }
}
