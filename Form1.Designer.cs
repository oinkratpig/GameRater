namespace GameRater
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewGames = new ListView();
            buttonAddGame = new Button();
            buttonExportTxt = new Button();
            SuspendLayout();
            // 
            // listViewGames
            // 
            listViewGames.Location = new Point(12, 12);
            listViewGames.Name = "listViewGames";
            listViewGames.Size = new Size(246, 288);
            listViewGames.TabIndex = 8;
            listViewGames.UseCompatibleStateImageBehavior = false;
            listViewGames.View = View.List;
            listViewGames.MouseDoubleClick += listViewGames_MouseDoubleClick;
            // 
            // buttonAddGame
            // 
            buttonAddGame.Location = new Point(12, 306);
            buttonAddGame.Name = "buttonAddGame";
            buttonAddGame.Size = new Size(246, 23);
            buttonAddGame.TabIndex = 9;
            buttonAddGame.Text = "Add new game";
            buttonAddGame.UseVisualStyleBackColor = true;
            buttonAddGame.Click += buttonAddGame_Click;
            // 
            // buttonExportTxt
            // 
            buttonExportTxt.BackColor = SystemColors.Info;
            buttonExportTxt.Location = new Point(12, 335);
            buttonExportTxt.Name = "buttonExportTxt";
            buttonExportTxt.Size = new Size(246, 23);
            buttonExportTxt.TabIndex = 10;
            buttonExportTxt.Text = "Export .txt";
            buttonExportTxt.UseVisualStyleBackColor = false;
            buttonExportTxt.Click += buttonExportTxt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 370);
            Controls.Add(buttonExportTxt);
            Controls.Add(buttonAddGame);
            Controls.Add(listViewGames);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Game Rankings";
            ResumeLayout(false);
        }

        #endregion
        private ListView listViewGames;
        private Button buttonAddGame;
        private Button buttonExportTxt;
    }
}