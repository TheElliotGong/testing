using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reworked_Matching_Game
{
    public partial class MatchingGame : Form
    {
        //This random object helps choose random objects for the squares
        Random rng = new Random();

        //These letters are interesting icons in our desired font.
        List<String> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };
        public MatchingGame()
        {
            InitializeComponent();
        }

        private void MatchingGame_Load(object sender, EventArgs e)
        {

        }
    }
}
