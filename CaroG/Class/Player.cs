using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroG.Class
{
    public class Player
    {
        private string name;
        public string Name { get => name; set => name = value; }
        public Image Icon { get => icon; set => icon = value; }

        private Image icon;
    }
}
