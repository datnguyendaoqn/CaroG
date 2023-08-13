using CaroG.Class;
using CaroG.Manager;
using System.Net.NetworkInformation;

namespace CaroG
{
    public partial class Form1 : Form
    {
        ManagerChessBoard Chessboard;
        SeverManager Socketmanager;
        public Form1()
        {
            InitializeComponent();
            Chessboard = new ManagerChessBoard(pnBoardchess, tbName, pbIcon);
            Chessboard.DrawBoardChess();
            Chessboard.Endgame += Chessboard_Endgame;
            Chessboard.Loadicon += Chessboard_Loadicon;
            pgbtime.Maximum = 1000;
            Socketmanager = new SeverManager();
            Chessboard.Getinform += Chessboard_Getinform;
        }

        private void Chessboard_Getinform(object? sender, ManagerChessBoard.btninfor e)
        {
            pnBoardchess.Enabled = false;
            Socketmanager.Send(new SocketData(e.Pos, (int)SocketData.C.SendPoint, null));
            Listen();
        }

        void Resetpgb()
        {
            CD.Stop();
            pgbtime.Value = 0
;
        }
        private void Chessboard_Loadicon(object? sender, EventArgs e)
        {
            pgbtime.Value = 0;
            CD.Start();

        }

        private void Chessboard_Endgame(object? sender, EventArgs e)
        {
            CD.Stop();
            MessageBox.Show("END!!!");
            pnBoardchess.Enabled = false;

        }

        private void CD_Tick(object sender, EventArgs e)
        {
            pgbtime.PerformStep();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chessboard.Newgame();
            Resetpgb();
            pnBoardchess.Enabled = false;
            Socketmanager.Send(new SocketData(null, (int)SocketData.C.NewGame, null));
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CD.Stop();
            Socketmanager.Send(new SocketData(null, (int)SocketData.C.Undo, "Player want undo, are u agree?"));
            Listen();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (DialogResult.OK != (MessageBox.Show("Are you sure to quit ? ", "Warning", MessageBoxButtons.OKCancel)))
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    Socketmanager.Send(new SocketData(null, (int)SocketData.C.Quit, "Player  Quitted!!!"));
                }
                catch { }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            tbIPAddress.Text = Socketmanager.GetIPAddress(NetworkInterfaceType.Ethernet);
            if (string.IsNullOrEmpty(tbIPAddress.Text)) { tbIPAddress.Text = Socketmanager.GetIPAddress(NetworkInterfaceType.Wireless80211); }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Socketmanager.IP = tbIPAddress.Text;
            if (!Socketmanager.Connectsever())
            {
                Socketmanager.Createsever();
                pnBoardchess.Enabled = true;
            }
            else
            {
                pnBoardchess.Enabled = false;
                Socketmanager.IsSever = false;
                Listen();
            }

        }
        void Listen()
        {
            Thread clientlistten = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)Socketmanager.Receive();
                    ProcessData(data);
                }
                catch { }
            });

            clientlistten.IsBackground = true;
            clientlistten.Start();
        }
        void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketData.C.SendPoint:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        undoToolStripMenuItem.Enabled = true;
                        pnBoardchess.Enabled = true;
                        Chessboard.FillButton(data.Pos);
                        Listen();
                    }));
                    break;
                case (int)SocketData.C.Quit:
                    MessageBox.Show(data.Message);
                    pnBoardchess.Enabled = false;
                    break;
                case (int)SocketData.C.NewGame:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        undoToolStripMenuItem.Enabled = true;
                        Resetpgb();
                        Chessboard.Newgame();
                        Listen();
                    }));
                    break;
                case (int)SocketData.C.Undo:
                    CD.Stop();
                    if (DialogResult.OK == MessageBox.Show(data.Message, "Notify", MessageBoxButtons.OKCancel))
                    {
                        Chessboard.Undo();
                        this.Invoke((MethodInvoker)(() =>
                        {
                            Resetpgb();
                            CD.Start();
                        }));
                        pnBoardchess.Enabled = false;
                        Socketmanager.Send(new SocketData(null, (int)SocketData.C.AgreeUndo, null));
                        Listen();
                    }
                    else
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            CD.Start();
                        }));
                        Socketmanager.Send(new SocketData(null, (int)SocketData.C.Notify, "Player disagree"));
                        Listen();
                    }
                    break;
                case (int)SocketData.C.AgreeUndo:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        undoToolStripMenuItem.Enabled = false;
                        Chessboard.Undo();
                        Resetpgb();
                        CD.Start();
                    }));
                    break;
                case (int)SocketData.C.Notify:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        CD.Start();
                    }));
                    MessageBox.Show(data.Message);
                    Listen();
                    break;


                default: break;
            }
        }
    }
}