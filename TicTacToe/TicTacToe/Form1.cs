using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;//when true =x,false=Y turns
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By sasank", "sasanks game about");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            checkforwinner();
        }

        private void checkforwinner()
        {
            bool there_is_a_winner = false;
            //Horizontal Validations
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&&(!A1.Enabled))
                there_is_a_winner = true;
           else if ((B1.Text == B2.Text) && (B2.Text == B3.Text)&&(!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text)&&(!C1.Enabled))
                there_is_a_winner = true;
            //Vertical validations
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;
            //Oblique Checking 
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                disablebuttons();
                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner +"wins!", "Gold");
                
            }
            else
            {
                if (turn_count == 9)
               
                    MessageBox.Show("Draw!", "Bummer");
            }
        }//end of check for winner

        private void disablebuttons()
        {
            try
            {
                foreach (Control c in Controls)//controls are generic objects
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch
            {

            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
