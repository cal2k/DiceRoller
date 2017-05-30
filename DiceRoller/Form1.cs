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

        int d4;
        int d6;
        int d8;
        int d10;
        int d12;
        int d20;
        int d100;
        int d4Mod;
        int d4Total;
        int d6Mod;
        int d6Total;
        int d8Mod;
        int d8Total;
        int d10Mod;
        int d10Total;
        int d12Mod;
        int d12Total;
        int d20Mod;
        int d20Total;
        int d100Mod;
        int d100Total;

        Boolean valid = true;


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //D4
        private void btnRollD4_Click(object sender, EventArgs e)
        {
            rollingD4(d4Mod);
        }
            private void rollingD4(int d4)
                {
                    string Rolls = "Rolled: ";
                    int total = 0;

                    if (Int32.TryParse(tbD4Modifer.Text, out d4Mod))
                    {
                        Random rnd = new Random();
                        while (valid == true)
                        {
                            for (int x = 0; x < d4Mod; x++)
                            {
                                //generats a random number.
                                int dice4 = rnd.Next(1, 5);

                                //adding the running total
                                total = total + dice4;

                                //displays the result of the roll
                                lblRollsD4.Text = Rolls + dice4;

                                //adds the current roll on to the end of the rolls string
                                Rolls = Rolls + dice4 + " ";

                                //converts the total in to string and displays the total
                                lblTotalsD4.Text = total.ToString();
                            }

                            break;
                        }

                    }
                    else
                    {
                        invalidmod();

                    }
                }

        //D6
        private void btnRollD6_Click(object sender, EventArgs e)
        {
            rollingD6(d6Mod);
        }
            private void rollingD6(int d6)
                {
                    string Rolls = "Rolled: ";
                    int total = 0;

                    if (Int32.TryParse(tbD6Modifer.Text, out d6Mod))
                    {
                        Random rnd = new Random();
                        while (valid == true)
                        {
                            for (int x = 0; x < d6Mod; x++)
                            {
                                //generats a random number.
                                int dice6 = rnd.Next(1, 7;

                                //adding the running total
                                total = total + dice6;

                                //displays the result of the roll
                                lblRollsD6.Text = Rolls + dice6;

                                //adds the current roll on to the end of the rolls string
                                Rolls = Rolls + dice6 + " ";

                                //converts the total in to string and displays the total
                                lblTotalsD6.Text = total.ToString();
                            }

                            break;
                        }

                    }
                    else
                    {
                        invalidmod();

                    }
                }

        //D8
        private void btnRollD8_Click(object sender, EventArgs e)
        {
            rollingD8(d8Mod);
        }
            private void rollingD8(int d8)
            {
                string Rolls = "Rolled: ";
                int total = 0;

                if (Int32.TryParse(tbD8Modifer.Text, out d8Mod))
                {
                    Random rnd = new Random();
                    while (valid == true)
                    {
                        for (int x = 0; x < d8Mod; x++)
                        {
                            //generats a random number.
                            int dice8 = rnd.Next(1, 9);

                            //adding the running total
                            total = total + dice8;

                            //displays the result of the roll
                            lblRollsD8.Text = Rolls + dice8;

                            //adds the current roll on to the end of the rolls string
                            Rolls = Rolls + dice8 + " ";

                            //converts the total in to string and displays the total
                            lblTotalsD8.Text = total.ToString();
                        }

                        break;
                    }

                }
                else
                {
                    invalidmod();

                }
            }

        //D10
        private void btnRollD10_Click(object sender, EventArgs e)
        {
            rollingD10(d10Mod);
        }
            private void rollingD10(int d10)
            {
                string Rolls = "Rolled: ";
                int total = 0;

                if (Int32.TryParse(tbD10Modifer.Text, out d10Mod))
                {
                    Random rnd = new Random();
                    while (valid == true)
                    {
                        for (int x = 0; x < d10Mod; x++)
                        {
                            //generats a random number.
                            int dice10 = rnd.Next(1, 11);

                            //adding the running total
                            total = total + dice10;

                            //displays the result of the roll
                            lblRollsD10.Text = Rolls + dice10;

                            //adds the current roll on to the end of the rolls string
                            Rolls = Rolls + dice10 + " ";

                            //converts the total in to string and displays the total
                            lblTotalsD10.Text = total.ToString();
                        }

                        break;
                    }

                }
                else
                {
                    invalidmod();

                }
                }

        //D12
        private void btnRollD12_Click(object sender, EventArgs e)
        {
            rollingD12(d12Mod);
        }
            private void rollingD12(int d12)
            {
                string Rolls = "Rolled: ";
                int total = 0;

                if (Int32.TryParse(tbD12Modifer.Text, out d12Mod))
                {
                    Random rnd = new Random();
                    while (valid == true)
                    {
                        for (int x = 0; x < d12Mod; x++)
                        {
                            //generats a random number.
                            int dice12 = rnd.Next(1, 13);

                            //adding the running total
                            total = total + dice12;

                            //displays the result of the roll
                            lblRollsD12.Text = Rolls + dice12;

                            //adds the current roll on to the end of the rolls string
                            Rolls = Rolls + dice12 + " ";

                            //converts the total in to string and displays the total
                            lblTotalsD12.Text = total.ToString();
                        }

                        break;
                    }

                }
                else
                {
                    invalidmod();

                }
            }

        //D20
        private void btnRollD20_Click(object sender, EventArgs e)
        {
            rollingD20(d20Mod);
        }
            private void rollingD20(int d20)
            {
                string Rolls = "Rolled: ";
                int total = 0;

                if (Int32.TryParse(tbD20Modifer.Text, out d20Mod))
                {
                    Random rnd = new Random();
                    while (valid == true)
                    {
                        for (int x = 0; x < d20Mod; x++)
                        {
                            //generats a random number.
                            int dice20 = rnd.Next(1, 21);

                            //adding the running total
                            total = total + dice20;

                            //displays the result of the roll
                            lblRollsD20.Text = Rolls + dice20;

                            //adds the current roll on to the end of the rolls string
                            Rolls = Rolls + dice20 + " ";

                            //converts the total in to string and displays the total
                            lblTotalsD20.Text = total.ToString();
                        }

                        break;
                    }

                }
                else
                {
                    invalidmod();

                }
            }

        //D100
        private void btnRollD100_Click(object sender, EventArgs e)
        {
            rollingD100(d100Mod);
        }
            private void rollingD100(int d100)
            {
                string Rolls = "Rolled: ";
                int total = 0;

                if (Int32.TryParse(tbD100Modifer.Text, out d100Mod))
                {
                    Random rnd = new Random();
                    while (valid == true)
                    {
                        for (int x = 0; x < d100Mod; x++)
                        {
                            //generats a random number.
                            int dice100 = rnd.Next(1, 101);

                            //adding the running total
                            total = total + dice100;

                            //displays the result of the roll
                            lblRollsD100.Text = Rolls + dice100;

                            //adds the current roll on to the end of the rolls string
                            Rolls = Rolls + dice100 + " ";

                            //converts the total in to string and displays the total
                            lblTotalsD100.Text = total.ToString();
                        }

                        break;
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
    }
}
