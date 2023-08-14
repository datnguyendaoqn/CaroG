using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroG.Class
{
    [Serializable]
    public class SocketData
    {
        private Point? pos;
        private int command;
        private string? message;
        public SocketData(Point? pos, int command, string? message)
        {
            this.pos = pos;
            this.command = command;
            this.message = message;
        }

        public enum C
        {
            NewGame,
            Notify,
            SendPoint,
            Undo,
            EndGame,
            AgreeUndo,
            Connect,
            Quit

        }

        public int Command { get => command; set => command = value; }
        public string? Message { get => message; set => message = value; }
        public Point? Pos { get => pos; set => pos = value; }
    }
}
