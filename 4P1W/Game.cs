using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4P1W
{
    public partial class frmGame : Form
    {
        //global vars
        string[] word = { "accurate", "sign", "bruh", "accurate", "accurate" };
        int index = 0;
        int p = 0;
        int wordLength = 0;
        int attempts = 0;
        int score = 0;

        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            // starting the game on form load
            game();
        }

        public void game()
        {
             // Clearing and hiding the answer buttons (all of the buttons in the group box)
            foreach(Control c in pnlAns.Controls)
            {    
                c.Text = "";
                c.Hide();
            }


            //Setting the images
            pic1.Image = imageList.Images[0+p];
            pic2.Image = imageList.Images[1+p];
            pic3.Image = imageList.Images[2+p];
            pic4.Image = imageList.Images[3+p];


            // splitting the word into characters and then randomising the array
            char[] wordChar = (word[index]).ToCharArray();
            Random random = new Random();
            wordChar = wordChar.OrderBy(x => random.Next()).ToArray();
            wordLength = wordChar.Count();


            // setting the possible guess buttons to each item in the now random array
            // Showing the correct amount of answer buttons
            // Centering the answer buttons (manually - I couldn't find a way to automatically do this)
            switch (wordLength)
            {
                case 1:
                    g1.Text = (wordChar[0].ToString());
                    a1.Show();
                    a1.Left = pnlAns.Width/2 - a1.Width/2;
                    break;
                case 2:
                    g1.Text = (wordChar[0].ToString());
                    g2.Text = (wordChar[0].ToString());
                    a1.Show();
                    a2.Show();
                    a1.Left = (pnlAns.Width/2 - a1.Width/2) - 20;
                    a2.Left = (pnlAns.Width/2 - a2.Width / 2) + 20;
                    break;
                case 3:
                    g1.Text = (wordChar[0].ToString());
                    g2.Text = (wordChar[1].ToString());
                    g3.Text = (wordChar[2].ToString());
                    a1.Show();
                    a2.Show();
                    a3.Show();
                    a1.Left = (pnlAns.Width / 2 - a1.Width / 2) - 40;
                    a2.Left = (pnlAns.Width / 2 - a2.Width / 2);
                    a3.Left = (pnlAns.Width / 2 - a1.Width / 2) + 40;
                    break;
                case 4:
                    g1.Text = (wordChar[0].ToString());
                    g2.Text = (wordChar[1].ToString());
                    g3.Text = (wordChar[2].ToString());
                    g4.Text = (wordChar[3].ToString());
                    a1.Show();
                    a2.Show();
                    a3.Show();
                    a4.Show();
                    a1.Left = (pnlAns.Width / 2 - a1.Width / 2) - 60;
                    a2.Left = (pnlAns.Width / 2 - a2.Width / 2) - 20;
                    a3.Left = (pnlAns.Width / 2 - a1.Width / 2) + 20;
                    a4.Left = (pnlAns.Width / 2 - a2.Width / 2) + 60;
                    break;
                case 5:
                    g1.Text = (wordChar[0].ToString());
                    g2.Text = (wordChar[1].ToString());
                    g3.Text = (wordChar[2].ToString());
                    g4.Text = (wordChar[3].ToString());
                    g5.Text = (wordChar[4].ToString());
                    a1.Show();
                    a2.Show();
                    a3.Show();
                    a4.Show();
                    a5.Show();
                    a1.Left = (pnlAns.Width / 2 - a1.Width / 2) - 70;
                    a2.Left = (pnlAns.Width / 2 - a1.Width / 2) - 35;
                    a3.Left = (pnlAns.Width / 2 - a2.Width / 2);
                    a4.Left = (pnlAns.Width / 2 - a1.Width / 2) + 35;
                    a5.Left = (pnlAns.Width / 2 - a1.Width / 2) + 70;
                    break;
                case 6:
                    g1.Text = (wordChar[0].ToString());
                    g2.Text = (wordChar[1].ToString());
                    g3.Text = (wordChar[2].ToString());
                    g4.Text = (wordChar[3].ToString());
                    g5.Text = (wordChar[4].ToString());
                    g6.Text = (wordChar[5].ToString());
                    a1.Show();
                    a2.Show();
                    a3.Show();
                    a4.Show();
                    a5.Show();
                    a6.Show();
                    a1.Left = (pnlAns.Width / 2 - a1.Width / 2) - 100;
                    a2.Left = (pnlAns.Width / 2 - a2.Width / 2) - 60;
                    a3.Left = (pnlAns.Width / 2 - a1.Width / 2) - 20;
                    a4.Left = (pnlAns.Width / 2 - a2.Width / 2) + 20;
                    a5.Left = (pnlAns.Width / 2 - a1.Width / 2) + 60;
                    a6.Left = (pnlAns.Width / 2 - a2.Width / 2) + 100;
                    break;
                case 7:
                    g1.Text = (wordChar[0].ToString());
                    g2.Text = (wordChar[1].ToString());
                    g3.Text = (wordChar[2].ToString());
                    g4.Text = (wordChar[3].ToString());
                    g5.Text = (wordChar[4].ToString());
                    g6.Text = (wordChar[5].ToString());
                    g7.Text = (wordChar[6].ToString());
                    a1.Show();
                    a2.Show();
                    a3.Show();
                    a4.Show();
                    a5.Show();
                    a6.Show();
                    a7.Show();
                    a1.Left = (pnlAns.Width / 2 - a1.Width / 2) - 105;
                    a2.Left = (pnlAns.Width / 2 - a1.Width / 2) - 70;
                    a3.Left = (pnlAns.Width / 2 - a1.Width / 2) - 35;
                    a4.Left = (pnlAns.Width / 2 - a2.Width / 2);
                    a5.Left = (pnlAns.Width / 2 - a1.Width / 2) + 35;
                    a6.Left = (pnlAns.Width / 2 - a1.Width / 2) + 70;
                    a7.Left = (pnlAns.Width / 2 - a1.Width / 2) + 105;
                    break;
                case 8:
                    g1.Text = (wordChar[0].ToString());
                    g2.Text = (wordChar[1].ToString());
                    g3.Text = (wordChar[2].ToString());
                    g4.Text = (wordChar[3].ToString());
                    g5.Text = (wordChar[4].ToString());
                    g6.Text = (wordChar[5].ToString());
                    g7.Text = (wordChar[6].ToString());
                    g8.Text = (wordChar[7].ToString());
                    a1.Show();
                    a2.Show();
                    a3.Show();
                    a4.Show();
                    a5.Show();
                    a6.Show();
                    a7.Show();
                    a8.Show();
                    a1.Left = (pnlAns.Width / 2 - a1.Width / 2) - 140;
                    a2.Left = (pnlAns.Width / 2 - a1.Width / 2) - 100;
                    a3.Left = (pnlAns.Width / 2 - a2.Width / 2) - 60;
                    a4.Left = (pnlAns.Width / 2 - a1.Width / 2) - 20;
                    a5.Left = (pnlAns.Width / 2 - a2.Width / 2) + 20;
                    a6.Left = (pnlAns.Width / 2 - a1.Width / 2) + 60;
                    a7.Left = (pnlAns.Width / 2 - a2.Width / 2) + 100;
                    a8.Left = (pnlAns.Width / 2 - a2.Width / 2) + 140;
                    a8.Left = (pnlAns.Width / 2 - a2.Width / 2) + 140;
                    break;
                default:
                    MessageBox.Show("no word");
                    break;
            }
        }

        public void checkAns()
        {
            // Concatenate all of the answers
            string guess = (a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + a8.Text);

            // Compare the concatenated string the the word
            if (guess == word[index])
            {
                MessageBox.Show("Correct     * index = " + index.ToString());
                // incrementing the game index
                index++;
                // incrementing the score minus the attempts
                score = score + (10 - attempts);
                // incrementing the picture index
                p = p + 4;
                MessageBox.Show(score.ToString());
                attempts = 0;
                game();
            }
            // if the sting does not match
            else
            {
                attempts++;
                MessageBox.Show("Incorrect: " + (5 - attempts) + " Attempts Remaining");
                game();
                if (attempts == 5)
                {
                    MessageBox.Show("You have failed");
                    // form class
                    Form1 frmMenu = new Form1();
                    //Showing the menu window
                    frmMenu.Show();
                    //Hiding the game (this form)
                    this.Hide();
                }
            }
        }


        public void setAnsValue(Button c)
        {
            // checks for an empty answer btn, and fills from left to right when a guess is clicked

            if (a1.Text.Equals(""))
            {
                a1.Text = c.Text;
            }
            else if (a2.Text.Equals(""))
            {
                a2.Text = c.Text;
            }
            else if (a3.Text.Equals(""))
            {
                a3.Text = c.Text;
            }
            else if (a4.Text.Equals(""))
            {
                a4.Text = c.Text;
            }
            else if (a5.Text.Equals(""))
            {
                a5.Text = c.Text;
            }
            else if (a6.Text.Equals(""))
            {
                a6.Text = c.Text;
            }
            else if (a7.Text.Equals(""))
            {
                a7.Text = c.Text;
            }
            else if (a8.Text.Equals(""))
            {
                a8.Text = c.Text;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // y/n dialog box
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { 
                    //Creating a class for the help window
                    Form1 frmMenu = new Form1();
                    //Showing the menu window
                    frmMenu.Show();
                    //Hiding the game (this form)
                    this.Hide();
            } 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Resets the level    
            game();
        }

        private void g1_Click(object sender, EventArgs e)
        {
            setAnsValue(g1);
            g1.Text = "";     
        }

        private void g2_Click(object sender, EventArgs e)
        {
            setAnsValue(g2);
            g2.Text = "";
        }

        private void g3_Click(object sender, EventArgs e)
        {
            setAnsValue(g3);
            g3.Text = "";
        }

        private void g4_Click(object sender, EventArgs e)
        {
            setAnsValue(g4);
            g4.Text = "";
        }

        private void g5_Click(object sender, EventArgs e)
        {
            setAnsValue(g5);
            g5.Text = "";
        }

        private void g6_Click(object sender, EventArgs e)
        {
            setAnsValue(g6);
            g6.Text = "";
        }

        private void g7_Click(object sender, EventArgs e)
        {
            setAnsValue(g7);
            g7.Text = "";
        }

        private void g8_Click(object sender, EventArgs e)
        {
            setAnsValue(g8);
            g8.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            checkAns();
        }
    }
}
