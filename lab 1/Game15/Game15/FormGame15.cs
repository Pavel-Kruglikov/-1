using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Game15
{
    public partial class FormGame15 : Form
    {
        Game game;// variable to start the game
        int steps;
        public FormGame15()
        {
            InitializeComponent();
            game = new Game(4);// creating a variable
        }
        private void button15_Click(object sender, EventArgs e)// Find out which button was pressed
        {
            int position = Convert.ToInt16(((Button)sender).Tag);// The button object that was pressed
            game.shift(position);// displacement of positions
            steps = Convert.ToInt32(label_Steps.Text);
            steps += 1;
            label_Steps.Text = Convert.ToString(steps);
            refresh();
            if (game.check_numbers())// the end of the game
            {
                MessageBox.Show("Вы победили!", "Поздравление");
                start_game();
            }
        }
        private Button button (int position)// a function that returns the button that we need
        {
            switch(position)// the button at which position we need to get
            {
                case 0: return button0;
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                case 10: return button10;
                case 11: return button11;
                case 12: return button12;
                case 13: return button13;
                case 14: return button14;
                case 15: return button15;
                default: return null;
            }
        }
        private void menu_start_Click(object sender, EventArgs e)
        {
            start_game();// game challenge  
        }
        private void start_game ()// start of the game
        {
            game.start();
            for (int j = 0; j < 50; j++)
                game.shift_random();
            refresh();
        }
        private void refresh()// updating button content
        {
            for (int position = 0; position < 16; position++)
            {
                int nr = game.get_number(position);
                button(position).Text = nr.ToString();
                button(position).Visible = (nr > 0);
            }
        }
        private void FormGame15_Load(object sender, EventArgs e)// launching the program
        {
            start_game();
        }
    }
}
