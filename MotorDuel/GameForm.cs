using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace View
{
    public partial class GameForm : Form
    {
        private MotorDuelModel _model;

        private Dictionary<Player, PlayerControl> _playerControls;

        public GameForm()
        {
            InitializeComponent();
            var dataAccess = new FileDataAccess();
            _model = new MotorDuelModel(dataAccess);
            _model.Load += Model_Load;
            _model.GameIsRunningChange += Model_GameIsRunningChange;
            _model.GameOver += Model_GameOver;
            _playerControls = new Dictionary<Player, PlayerControl>();
            _model.NewGame();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!_model.IsGameOver)
            {
                if (_model.GameIsRunning)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.A: _model.PlayerA.TurnLeft(); break;
                        case Keys.D: _model.PlayerA.TurnRight(); break;
                        case Keys.J: _model.PlayerB.TurnLeft(); break;
                        case Keys.L: _model.PlayerB.TurnRight(); break;
                    }
                }

                if(e.KeyCode == Keys.Enter)
                {
                    _model.ToggleGameIsRunning();
                    menuStrip.Focus();
                }
            }
            
        }

        private void Model_Load(object sender, EventArgs e)
        {
            saveMenuItem.Enabled = true;
            int n = ((int)_model.FieldSize);
            SuspendLayout();
            field.Controls.Clear();
            field.ColumnStyles.Clear();
            field.RowStyles.Clear();

            for (int i = 0; i < n; i++)
            {
                this.field.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, field.Width / (float)n));
                this.field.RowStyles.Add(new RowStyle(SizeType.Percent, field.Height / (float)n));
            }

            this.field.ColumnCount = n;
            this.field.RowCount = n;

            ResumeLayout();

            SetupPlayer(_model.PlayerA, Color.IndianRed);
            SetupPlayer(_model.PlayerB, Color.LightBlue);

            helpStatusLabel.Text = "Nyomj Entert az indításhoz";
            timeStatusLabel.Text = "";
        }

        private void Model_GameIsRunningChange(object sender, EventArgs e)
        {
            if(_model.GameIsRunning)
            {
                timer.Start();
                menuStrip.Enabled = false;
                helpStatusLabel.Text = "Nyomj Entert a megállításhoz";
            }
            else
            {
                timer.Stop();
                menuStrip.Enabled = true;
                helpStatusLabel.Text = "Nyomj Entert az indításhoz";
            }
        }

        private void Model_GameOver(object sender, GameOverEventArgs e)
        {
            saveMenuItem.Enabled = false;
            MessageBox.Show($"A {e.Winner.Name} játékos nyert.", "Vége a játéknak", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeStatusLabel.Text = _model.Time.Seconds.ToString();
            _model.GameAdvanced();
        }

        private void Player_Move(object sender, EventArgs e)
        {
            var player = sender as Player;
            var x = player.Location.X;
            var y = player.Location.Y;


            var controlAtLocation = field.GetControlFromPosition(x, y);
            if (controlAtLocation != null)
            {
                field.Controls.Remove(controlAtLocation);
            }

            field.Controls.Add(_playerControls[player], x, y);

            //Add a new Panel as trail
            var trailPanel = _playerControls[player].generateNewTrailPanel();
            var lastTrailPoint = player.Trail.Last();
            field.Controls.Add(trailPanel, lastTrailPoint.X, lastTrailPoint.Y);

        }

        private async void OpenMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await _model.OpenFileAsync(openFileDialog.FileName);

                }
                catch (Exception)
                {
                    MessageBox.Show("Nem sikeült megnyitni a fájlt.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private async void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await _model.SaveAsync(saveFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nem sikeült elmenteni a fájlt.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void FieldSizeMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var fieldSize = FieldSize.Size12x12;
            if (e.ClickedItem.Equals(size24MenuItem))
            {
                fieldSize = FieldSize.Size24x24;
            }
            else if (e.ClickedItem.Equals(size36MenuItem))
            {
                fieldSize = FieldSize.Size36x36;
            }
            _model.NewGame(fieldSize);
        }

        private void SetupPlayer(Player player, Color color)
        {
            var playerControl = new PlayerControl(player, color);
            _playerControls.Add(player, playerControl);

            var x = player.Location.X;
            var y = player.Location.Y;
            field.Controls.Add(playerControl, x, y);


            player.PlayerMove += Player_Move;

            foreach (var trail in player.Trail)
            {
                field.Controls.Add(playerControl.generateNewTrailPanel(), trail.X, trail.Y);
            }
        }
    }
}
