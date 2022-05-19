using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class PlayerControl : UserControl
    {
        private Player _player;
        private Color _trailColor;

        private Bitmap _upImage;
        private Bitmap _downImage;
        private Bitmap _leftImage;
        private Bitmap _rightImage;

        public PlayerControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public PlayerControl(Player player, Color trailColor) : this()
        {
            _player = player;
            _trailColor = trailColor;
            BackColor = trailColor;
            Margin = new Padding(0, 0, 0, 0);
            player.PlayerTurn += Player_Turn;

            if(player.Name.Equals("Piros"))
            {
                _upImage = Properties.Resources.MotorcycleRedUp;
                _downImage = Properties.Resources.MotorcycleRedDown;
                _leftImage = Properties.Resources.MotorcycleRedLeft;
                _rightImage = Properties.Resources.MotorcycleRedRight;
            }
            else
            {
                _upImage = Properties.Resources.MotorcycleRedUp;
                _downImage = Properties.Resources.MotorcycleRedDown;
                _leftImage = Properties.Resources.MotorcycleRedLeft;
                _rightImage = Properties.Resources.MotorcycleRedRight;
            }

            BackgroundImage = getCorrectBgImage();
            BackgroundImageLayout = ImageLayout.Zoom;

        }

        public Panel generateNewTrailPanel()
        {
            return new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = _trailColor,
                Margin = new Padding(0, 0, 0, 0)
            };
        }

        private Bitmap getCorrectBgImage()
        {
            return _player.Direction switch
            {
                Direction.Up => _upImage,
                Direction.Down => _downImage,
                Direction.Left => _leftImage,
                _ => _rightImage
            };
        }


        private void Player_Turn(object sender, EventArgs e)
        {
            BackgroundImage = getCorrectBgImage();
        }
    }
}
