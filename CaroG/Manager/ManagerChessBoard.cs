using CaroG.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroG.Manager
{
    public class ManagerChessBoard
    {
        #region Properties
        Stack<Button> TimelineMove = new Stack<Button>();
        List<List<Button>> Matrix = new List<List<Button>>();

        List<Player> playerList = new List<Player>()
        {
            new Player() {Name = "player1" , Icon = Image.FromFile("../../../Resources/iconO.png") },
            new Player() {Name = "player2" , Icon = Image.FromFile("../../../Resources/iconX.png") }
        };
        int Currentplayer = 0;
        private TextBox nameplayer;
        private PictureBox iconplayer;
        private Panel chessboard;
        public Panel Chessboard { get => chessboard; set => chessboard = value; }
        public TextBox Nameplayer { get => nameplayer; set => nameplayer = value; }
        public PictureBox Iconplayer { get => iconplayer; set => iconplayer = value; }
        private event EventHandler<EventArgs> endgame;
        public event EventHandler<EventArgs> Endgame
        {
            add => endgame += value;
            remove => endgame -= value;
        }
        private event EventHandler<EventArgs> loadicon;
        public event EventHandler<EventArgs> Loadicon
        {
            add { loadicon += value; }
            remove => loadicon -= value;
        }

        #endregion
        #region Initialize
        public ManagerChessBoard(Panel chessboard, TextBox tbName, PictureBox pbIcon)
        {
            this.chessboard = chessboard;
            nameplayer = tbName;
            iconplayer = pbIcon;
        }
        #endregion
        #region Method
        public void DrawBoardChess()
        {
            Button temp = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Constant.limit; i++)
            {
                Button temp2 = new Button() { Width = 0, Location = new Point(0, i * Constant.Heightchess) };
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Constant.limit; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Constant.Widthchess,
                        Height = Constant.Heightchess,
                        Location = new Point(temp2.Location.X + temp2.Width, temp2.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    btn.Click += Btn_Click;
                    chessboard.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    temp2 = btn;
                }
            }
            LoadPlayer();
        }

        public void FillButton(Point? pos)
        {
            if (pos.HasValue)
            {
                int x = pos.Value.X;
                int y = pos.Value.Y;
                if (Matrix[y][x].BackgroundImage != null) return;
                Matrix[y][x].BackgroundImage = playerList[Currentplayer].Icon;

                TimelineMove.Push(Matrix[y][x]);
                if (IsEndGame(Matrix[y][x]))
                {
                    TimelineMove = new Stack<Button>();
                    if (endgame != null)
                    {
                        endgame(this, new EventArgs());
                    }
                    return;
                }
                Currentplayer = Currentplayer == 1 ? 0 : 1;
                LoadPlayer();
                if (loadicon != null) { loadicon(this, new EventArgs()); }
                return;
            }
        }
        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (getinform != null)
            { getinform(this, new btninfor(getposision(btn))); }
            FillButton(getposision(btn));

        }
        public class btninfor : EventArgs
        {
            private Point pos;

            public Point Pos { get => pos; set => pos = value; }

            public btninfor(Point position)
            {
                this.pos = position;
            }

        }
        private event EventHandler<btninfor> getinform;
        public event EventHandler<btninfor> Getinform
        {
            add { getinform += value; }
            remove { getinform -= value; }
        }
        void LoadPlayer()
        {
            iconplayer.BackgroundImage = playerList[Currentplayer].Icon;
            nameplayer.Text = playerList[Currentplayer].Name;
        }

        Point getposision(Button btn)
        {
            int y = int.Parse(btn.Tag.ToString());
            int x = Matrix[y].IndexOf(btn);
            Point rs = new Point(x, y);
            return rs;
        }
        private bool IsEndGame(Button btn)
        {
            return IsVertical(btn) || IsHorizontal(btn) || IsMainDiagonal(btn) || IsSubDiagonal(btn);

        }
        private bool IsVertical(Button btn)
        {
            Point pos = getposision(btn);
            int count = 1;
            for (int i = 1; i < Constant.limit; i++)
            {
                if (pos.Y - i < 0)
                {
                    break;
                }
                if (Matrix[pos.Y - i][pos.X].BackgroundImage == btn.BackgroundImage)
                { count++; }
                else
                { break; }
            }
            for (int i = 1; i < Constant.limit; i++)
            {
                if (pos.Y + i >= Constant.limit)
                {
                    break;
                }
                if (Matrix[pos.Y + i][pos.X].BackgroundImage == btn.BackgroundImage) { count++; }
                else
                {
                    break;
                }
            }
            return count == 5;
        }
        private bool IsHorizontal(Button btn)
        {
            Point pos = getposision(btn);
            int count = 1;
            for (int i = 1; i < Constant.limit; i++)
            {
                if (pos.X - i < 0) { break; }
                if (Matrix[pos.Y][pos.X - i].BackgroundImage == btn.BackgroundImage) count++;
                else
                    break;
            }
            for (int i = 1; i < Constant.limit; i++)
            {
                if (pos.X + i >= Constant.limit) { break; }
                if (Matrix[pos.Y][pos.X + i].BackgroundImage == btn.BackgroundImage) count++;
                else
                    break;
            }
            return count == 5;
        }
        private bool IsMainDiagonal(Button btn)
        {
            Point pos = getposision(btn);
            int count = 1;
            for (int i = 1; i < Constant.limit; i++)
            {
                if (pos.X - i < 0 || pos.Y - i < 0) { break; }
                if (Matrix[pos.Y - i][pos.X - i].BackgroundImage == btn.BackgroundImage) { count++; }
                else
                    break;
            }
            for (int i = 1; i < Constant.limit; i++)
            {
                if (pos.X + i >= Constant.limit || pos.Y + i >= Constant.limit) { break; }
                else
                {
                    if (Matrix[pos.Y + 1][pos.X + 1].BackgroundImage == btn.BackgroundImage) { count++; }
                    else
                        break;
                }

            }
            return count == 5;
        }
        private bool IsSubDiagonal(Button btn)
        {
            Point pos = getposision(btn);
            int count = 1;
            for (int i = 1; i < Constant.limit; i++)
            {
                if (pos.X - i < 0 || pos.Y + i >= Constant.limit) { break; }
                if (Matrix[pos.Y + i][pos.X - i].BackgroundImage == btn.BackgroundImage) { count++; }
                else
                    break;
            }
            for (int i = 1; i < Constant.limit; i++)
            {
                if (pos.X + i >= Constant.limit || pos.Y - i < 0) { break; }
                if (Matrix[pos.Y - i][pos.X + i].BackgroundImage == btn.BackgroundImage) { count++; }
                else
                    break;
            }
            return count == 5;
        }
        public void Newgame()
        {
            TimelineMove = new Stack<Button>();
            chessboard.Controls.Clear();
            chessboard.Enabled = true;
            DrawBoardChess();
            Currentplayer = Currentplayer == 1 ? 0 : 1;
            LoadPlayer();
        }
        public void Undo()
        {
            if (TimelineMove.Count > 0)
            {
                chessboard.Enabled = true;
                Button temp = TimelineMove.Pop();
                temp.BackgroundImage = null;
                Currentplayer = Currentplayer == 1 ? 0 : 1;
                LoadPlayer();
            }
        }
        #endregion
    }
}
