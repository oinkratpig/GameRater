using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRater
{
    public partial class FormAddGame : Form
    {
        public delegate void OnGameUpdatedEventHandler(Game newGame);
        public event OnGameUpdatedEventHandler? OnGameUpdated;
        public event OnGameUpdatedEventHandler? OnGameDeleted;

        private int QuestionNumber
        {
            get { return _questionNumber; }
            set
            {
                _questionNumber = value;
                if (_game.Questions != null)
                    labelQuestion.Text = $"Question ({value + 1}/{_game.Questions.Count})";
            }
        }

        private int SelectedRanking
        {
            get
            {
                return (_currentQuestion == null) ? RankingSystem.MinimumRank : _currentQuestion.Ranking;
            }
            set
            {
                if (_currentQuestion == null) return;

                _currentQuestion.Ranking = value;
                numericUpDownRanking.Value = value;
            }
        }

        // Fields
        private Game _game;
        private int _questionNumber;
        private Question? _currentQuestion;

        /* Constructor */
        public FormAddGame(Game game)
        {
            InitializeComponent();
            Select();

            _game = game;

            numericUpDownRanking.Minimum = RankingSystem.MinimumRank;
            numericUpDownRanking.Maximum = RankingSystem.MaximumRank;
            textBoxGameName.Text = _game.Name;

            // Set first question
            SetQuestion(0);

        } // end constructor

        /// <summary>
        /// Sets the question to a specific question by number.
        /// </summary>
        private void SetQuestion(int questionNumber)
        {
            // Invalid question number
            if (_game.Questions == null ||
                    questionNumber > _game.Questions.Count - 1 ||
                    questionNumber < 0)
                return;

            QuestionNumber = questionNumber;
            _currentQuestion = _game.Questions[questionNumber];

            textBoxQuestion.Text = _currentQuestion.Description;
            numericUpDownRanking.Value = _currentQuestion.Ranking;

            checkBoxRelevant.Checked = _currentQuestion.Relevant;

            SetRankings();

        } // end SetQuestion

        /// <summary>
        /// Update the rankings list.
        /// </summary>
        private void SetRankings()
        {
            listViewRankings.Clear();
            if (_currentQuestion != null)
            {
                int i = 0;
                foreach (Rank rank in _currentQuestion.Ranks)
                {
                    ListViewItem lvItem = listViewRankings.Items.Add($"{RankingSystem.MaximumRank - i++}. {{{rank.Name}}} {rank.Description}");
                    lvItem.BackColor = RankingSystem.ColorFromPercent(1 - (float)(i - 1) / RankingSystem.MaximumRank);
                }
            }

        } // end SetRankings

        /* Ranking changed */
        private void numericUpDownRanking_ValueChanged(object sender, EventArgs e)
        {
            SelectedRanking = (int)numericUpDownRanking.Value;

        } // end numericUpDownRanking_ValueChanged

        /* Update game name */
        private void textBoxGameName_TextChanged(object sender, EventArgs e)
        {
            _game.Name = textBoxGameName.Text;

        } // end textBoxGameName_TextChanged

        /* Back */
        private void buttonBack_Click(object sender, EventArgs e)
        {
            SetQuestion(QuestionNumber - 1);

        } // end buttonBack_Click

        /* Forward */
        private void buttonForward_Click(object sender, EventArgs e)
        {
            SetQuestion(QuestionNumber + 1);

        } // end buttonForward_Click

        /* Selected ranking */
        private void listViewRankings_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 1;
            foreach (ListViewItem item in listViewRankings.Items)
            {
                if (item.Selected)
                {
                    SelectedRanking = RankingSystem.MaximumRank - i + 1;
                    return;
                }
                i++;
            }

        } // end listViewRankings_SelectedIndexChanged

        /* Finish */
        private void buttonFinish_Click(object sender, EventArgs e)
        {
            OnGameUpdated?.Invoke(_game);
            Close();

        } // end Finish

        /* Delete game */
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            OnGameDeleted?.Invoke(_game);
            Close();

        } // end buttonDelete_Click

        /* Toggle relevancy */
        private void checkBoxRelevant_CheckedChanged(object sender, EventArgs e)
        {
            if(_currentQuestion != null)
                _currentQuestion.Relevant = checkBoxRelevant.Checked;

        } // end checkBoxRelevant_CheckedChanged

    } // end class FormAddGame

} // end namespace
