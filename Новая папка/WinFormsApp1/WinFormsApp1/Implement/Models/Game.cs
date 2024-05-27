using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Implement.Models
{
    public class Game
    {
        public string GameName { get; set; }
        public string MasterName { get; set; }
        public DateTime DateGame { get; set; }
        public List<Player> Players { get; set; }
    }
}
