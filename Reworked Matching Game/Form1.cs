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
        /// <summary>
        /// This method assigns random icons to each of the table boxes.
        /// </summary>
        private void AssignIconsToSquares()
        {
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = rng.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    // iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        public MatchingGame()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void MatchingGame_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// When a label is clicked, we handle the events this way.
        /// </summary>
        /// <param name="sender">This is the lable that was clicked</param>
        /// <param name="e"></param>
        private void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            
            //If the clicked label is already black, then we know it's already been revealed.
            //Thus, we ignore future clicks of the same label afterward.
            if(clickedLabel != null)
            {
                if(clickedLabel.ForeColor == Color.Black)
                {
                    return;
                }
                clickedLabel.ForeColor = Color.Black;
            }
        }
    }
}
