using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SteamTracker.dtos;
using Microsoft.VisualBasic;
using SteamTracker.components;

//TODO: request for each game image upon load
//TODO: Auto resize grid when fullscreen
//TODO: Validate if user input is between 0 and 10
//TODO: Implement link click
namespace SteamTracker
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async void refreshData()
        {
            List<Game> gamesList = await refreshSteamData();
            gamesGrid.DataSource = gamesList.OrderByDescending(item => item.likelihoodToPlay).ToList();
            gamesGrid.AutoResizeColumns();
            totalGamesLabel.Text = gamesGrid.RowCount.ToString();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshData();
            saveData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void saveData()
        {
            var json = JsonConvert.SerializeObject(gamesGrid.DataSource);
            System.IO.File.WriteAllText(@"SteamTracker.txt", json);
        }

        private async Task<List<Game>> refreshSteamData()
        {
            string path = "http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key=D689A642B656C78C87F50E9B4DB60516&steamid=76561198007510946&format=json&include_appinfo=true";
            HttpResponseMessage response = await client.GetAsync(path);
            response.EnsureSuccessStatusCode();
            string steamJson = await response.Content.ReadAsStringAsync();
            List<Game> steamGamesList = JsonConvert.DeserializeObject<SteamResponse>(steamJson).response.games;

            string fileJson = getFileData();
            List<Game> fileGamesList = new List<Game>();
            List<Game> deserializedFile = JsonConvert.DeserializeObject<List<Game>>(fileJson);

            if(deserializedFile != null)
            {
                fileGamesList = deserializedFile;
            }

            List<Game> fiteredGamesList = steamGamesList.Where(steamItem => {
                foreach (var fileItem in fileGamesList)
                {
                    if (fileItem.appid == steamItem.appid)
                    {
                        return false;
                    }
                }
                return true;
            }).ToList();

            fileGamesList.AddRange(fiteredGamesList);

            foreach (var item in fileGamesList)
            {
                item.storePageLink = $"https://store.steampowered.com/app/{item.appid}";
            }

            return fileGamesList;
        }

        private string getFileData()
        {
            return System.IO.File.ReadAllText(@"SteamTracker.txt");
        }

        private void gamesGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            var gamesList = (List<Game>) gamesGrid.DataSource;
            gamesList[index].latestUpdated = DateTime.Now;
            this.BeginInvoke(new MethodInvoker(() =>
            {
                gamesGrid.DataSource = gamesList.OrderByDescending(item => item.likelihoodToPlay).ToList();
                var rowIndex = gamesGrid.Rows.Count == index - 1 ? index + 1 : index;
                gamesGrid.CurrentCell = gamesGrid.Rows[rowIndex].Cells[e.ColumnIndex];
                saveData();
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchForItem();
        }

        private void searchForItem()
        {
            string searchText = searchTextBox.Text.ToLower();
            var gamesList = (List<Game>)gamesGrid.DataSource;
            Game game = gamesList.Find(item => item.name.ToLower().Contains(searchText));
            int row = gamesList.IndexOf(game);
            if (row >= 0)
            {
                gamesGrid.CurrentCell = gamesGrid.Rows[row].Cells[2];
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Enter key pressed
            if (e.KeyChar == (char)13)
            {
                searchForItem();
            }
        }

        private void addNonSteamGame_Click(object sender, EventArgs e)
        {
            string gameName = Prompt.ShowDialog("Name of the game to be added:", "Add non-Steam Game");
            if (gameName != null && gameName != "")
            {
                List<Game> games = (List<Game>) gamesGrid.DataSource;
                games.Add(new Game(gameName));
                gamesGrid.DataSource = games;
                saveData();
                refreshData();
            }
        }
    }
}
