using Newtonsoft.Json;
using System.Buffers.Text;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace GameRater
{
    public partial class Form1 : Form
    {
        public List<Game> Games
        {
            get { return _games; }
            set { _games = value; }
        }

        // Fields
        private FormAddGame? _addGameForm;
        private List<Game> _games;

        /* Constructor */
        public Form1()
        {
            InitializeComponent();
            Select();

            _games = new List<Game>();

            if (File.Exists(GameRater.PATH_GAMES))
            {
                string data = File.ReadAllText(GameRater.PATH_GAMES);
                if(data != string.Empty)
                {
                    //List<Game>? games = JsonSerializer.Deserialize<List<Game>>(data);
                    List<Game>? games = JsonConvert.DeserializeObject<List<Game>>(GameRater.Base64Decode(data));
                    if (games != null)
                        Games = games;
                }
            }
            UpdateGameList();

        } // end constructor

        /* Add game */
        private void buttonAddGame_Click(object sender, EventArgs e)
        {
            Game game = new Game("New Game");
            game.Questions = Game.DefaultQuestions();
            _addGameForm = new FormAddGame(game);
            _addGameForm.OnGameUpdated += OnGameUpdated;
            _addGameForm.OnGameDeleted += OnGameDeleted;
            _addGameForm.ShowDialog();

        } // end buttonAddGame_Click

        /* Double click existing game */
        private void listViewGames_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listViewGames.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                _addGameForm = new FormAddGame(Games[item.Index]);
                _addGameForm.OnGameUpdated += OnGameUpdated;
                _addGameForm.OnGameDeleted += OnGameDeleted;
                _addGameForm.ShowDialog();
            }

        } // end listViewGames_MouseDoubleClick

        /* Game updated */
        public void OnGameUpdated(Game newGame)
        {
            // Edit existing game
            for (int i = 0; i < Games.Count; i++)
                if (Games[i].Name == newGame.Name)
                {
                    Games[i] = newGame;
                    UpdateGameList();
                    SaveGames();
                    return;
                }

            // New game
            Games.Add(newGame);
            UpdateGameList();
            SaveGames();

        } // end OnGameUpdated

        /* Game deleted */
        public void OnGameDeleted(Game game)
        {
            Games.Remove(game);
            UpdateGameList();

        } // end OnGameDeleted

        /* Update game list */
        public void UpdateGameList()
        {
            listViewGames.Items.Clear();

            // Sort games
            List<Game> SortedGames = Games.OrderBy(o => o.RankScore).ToList();
            SortedGames.Reverse();
            Games = SortedGames;

            // Add games to list
            int i = 1;
            foreach (Game game in Games)
            {
                ListViewItem item = listViewGames.Items.Add($"{i++}. ({Math.Round(game.RankScore * 100)}%) {game.Name}");
                item.BackColor = RankingSystem.ColorFromPercent(game.RankScore);
            }

        } // end UpdateGameList

        /* Export as .txt */
        private void buttonExportTxt_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(GameRater.PATH_EXPORT))
            {
                foreach (ListViewItem item in listViewGames.Items)
                    writer.WriteLine(item.Text);
                if(GameRater.PATH_RELATIVE != null)
                    Process.Start("explorer.exe", GameRater.PATH_RELATIVE);
            }

        } // end buttonExportTxt_Click

        /* Save games */
        private void SaveGames()
        {
            // Update games file
            //string json = JsonSerializer.Serialize(Games);
            string json = JsonConvert.SerializeObject(Games);
            File.WriteAllText(GameRater.PATH_GAMES, GameRater.Base64Encode(json));

        } // end SaveGames

    } // end class Form1

} // end namespace