namespace GameRater
{
    partial class FormAddGame
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
            textBoxQuestion = new TextBox();
            listViewRankings = new ListView();
            buttonBack = new Button();
            labelQuestion = new Label();
            buttonForward = new Button();
            numericUpDownRanking = new NumericUpDown();
            textBoxGameName = new TextBox();
            labelGameName = new Label();
            buttonFinish = new Button();
            buttonDelete = new Button();
            checkBoxRelevant = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRanking).BeginInit();
            SuspendLayout();
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.Location = new Point(12, 71);
            textBoxQuestion.Multiline = true;
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.ReadOnly = true;
            textBoxQuestion.Size = new Size(324, 38);
            textBoxQuestion.TabIndex = 0;
            textBoxQuestion.Text = "this is line 1\r\nthis is line 2";
            // 
            // listViewRankings
            // 
            listViewRankings.Location = new Point(12, 115);
            listViewRankings.MultiSelect = false;
            listViewRankings.Name = "listViewRankings";
            listViewRankings.Size = new Size(324, 188);
            listViewRankings.TabIndex = 1;
            listViewRankings.UseCompatibleStateImageBehavior = false;
            listViewRankings.View = View.List;
            listViewRankings.SelectedIndexChanged += listViewRankings_SelectedIndexChanged;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(12, 309);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(25, 23);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "<";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelQuestion
            // 
            labelQuestion.AutoSize = true;
            labelQuestion.Location = new Point(12, 53);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(89, 15);
            labelQuestion.TabIndex = 3;
            labelQuestion.Text = "Question (x / y)";
            // 
            // buttonForward
            // 
            buttonForward.Location = new Point(311, 309);
            buttonForward.Name = "buttonForward";
            buttonForward.Size = new Size(25, 23);
            buttonForward.TabIndex = 4;
            buttonForward.Text = ">";
            buttonForward.UseVisualStyleBackColor = true;
            buttonForward.Click += buttonForward_Click;
            // 
            // numericUpDownRanking
            // 
            numericUpDownRanking.Location = new Point(139, 309);
            numericUpDownRanking.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRanking.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRanking.Name = "numericUpDownRanking";
            numericUpDownRanking.Size = new Size(62, 23);
            numericUpDownRanking.TabIndex = 5;
            numericUpDownRanking.TextAlign = HorizontalAlignment.Center;
            numericUpDownRanking.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRanking.ValueChanged += numericUpDownRanking_ValueChanged;
            // 
            // textBoxGameName
            // 
            textBoxGameName.Location = new Point(12, 27);
            textBoxGameName.Name = "textBoxGameName";
            textBoxGameName.Size = new Size(324, 23);
            textBoxGameName.TabIndex = 6;
            textBoxGameName.TextChanged += textBoxGameName_TextChanged;
            // 
            // labelGameName
            // 
            labelGameName.AutoSize = true;
            labelGameName.Location = new Point(12, 9);
            labelGameName.Name = "labelGameName";
            labelGameName.Size = new Size(73, 15);
            labelGameName.TabIndex = 7;
            labelGameName.Text = "Game Name";
            // 
            // buttonFinish
            // 
            buttonFinish.Location = new Point(120, 338);
            buttonFinish.Name = "buttonFinish";
            buttonFinish.Size = new Size(100, 23);
            buttonFinish.TabIndex = 8;
            buttonFinish.Text = "Finish";
            buttonFinish.UseVisualStyleBackColor = true;
            buttonFinish.Click += buttonFinish_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Tomato;
            buttonDelete.Location = new Point(12, 374);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 23);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // checkBoxRelevant
            // 
            checkBoxRelevant.AutoSize = true;
            checkBoxRelevant.Location = new Point(208, 376);
            checkBoxRelevant.Name = "checkBoxRelevant";
            checkBoxRelevant.Size = new Size(130, 19);
            checkBoxRelevant.TabIndex = 10;
            checkBoxRelevant.Text = "Question is relevant";
            checkBoxRelevant.UseVisualStyleBackColor = true;
            checkBoxRelevant.CheckedChanged += checkBoxRelevant_CheckedChanged;
            // 
            // FormAddGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 409);
            Controls.Add(checkBoxRelevant);
            Controls.Add(buttonDelete);
            Controls.Add(buttonFinish);
            Controls.Add(labelGameName);
            Controls.Add(textBoxGameName);
            Controls.Add(numericUpDownRanking);
            Controls.Add(buttonForward);
            Controls.Add(labelQuestion);
            Controls.Add(buttonBack);
            Controls.Add(listViewRankings);
            Controls.Add(textBoxQuestion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAddGame";
            Text = "Add Game";
            ((System.ComponentModel.ISupportInitialize)numericUpDownRanking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxQuestion;
        private ListView listViewRankings;
        private Button buttonBack;
        private Label labelQuestion;
        private Button buttonForward;
        private NumericUpDown numericUpDownRanking;
        private TextBox textBoxGameName;
        private Label labelGameName;
        private Button buttonFinish;
        private Button buttonDelete;
        private CheckBox checkBoxRelevant;
    }
}