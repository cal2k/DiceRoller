using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //D4
        private void btnRollD4_Click(object sender, EventArgs e)
        {
            rollDice(4, tbD4Modifer, lblRollsD4, lblTotalsD4);
        }

        //D6
        private void btnRollD6_Click(object sender, EventArgs e)
        {
            rollDice(6, tbD6Modifer, lblRollsD6, lblTotalsD6);
        }

        //D8
        private void btnRollD8_Click(object sender, EventArgs e)
        {
            rollDice(8, tbD8Modifer, lblRollsD8, lblTotalsD8);
        }

        //D10
        private void btnRollD10_Click(object sender, EventArgs e)
        {
            rollDice(10, tbD10Modifer, lblRollsD10, lblTotalsD10);
        }

        //D12
        private void btnRollD12_Click(object sender, EventArgs e)
        {
            rollDice(12, tbD12Modifer, lblRollsD12, lblTotalsD12);
        }

        //D20
        private void btnRollD20_Click(object sender, EventArgs e)
        {
            rollDice(20, tbD20Modifer, lblRollsD20, lblTotalsD20);
        }

        //D100
        private void btnRollD100_Click(object sender, EventArgs e)
        {
            rollDice(100, tbD100Modifer, lblRollsD100, lblTotalsD100);
        }

        private void rollDice(int die, TextBox numberOfDice, Label rolls, Label total)
        {
            string Rolls = "Rolled: ";
            int runningTotal = 0;
            int myNewLocalMod;
            if (Int32.TryParse(numberOfDice.Text, out myNewLocalMod))
            {
                Random rnd = new Random();

                for (int x = 0; x < myNewLocalMod; x++)
                {
                    //generats a random number.
                    int randomVal = rnd.Next(1, die + 1);

                    //adding the running total
                    runningTotal += randomVal;

                    //displays the result of the roll
                    rolls.Text = Rolls + randomVal;

                    //adds the current roll on to the end of the rolls string
                    Rolls = Rolls + randomVal + ", ";

                    //converts the total in to string and displays the total
                    total.Text = runningTotal.ToString();
                }
            }
            else
            {
                invalidmod();

            }
        }

        private void invalidmod()
        {
            MessageBox.Show("Invalid Modifier");
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            tbD4Modifer.Text = "1";
            tbD6Modifer.Text = "1";
            tbD8Modifer.Text = "1";
            tbD10Modifer.Text = "1";
            tbD12Modifer.Text = "1";
            tbD20Modifer.Text = "1";
            tbD100Modifer.Text = "1";
        }
    }
}
