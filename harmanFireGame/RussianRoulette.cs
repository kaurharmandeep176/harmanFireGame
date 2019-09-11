using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harmanFireGame
{
    public partial class RussianRoulette : Form
    {
        int shootchance1 = 0, shootchance2 = 0;

        int count = 0,winner=0,chance=0,shootaway=0;
        Russian obj_Russian = new Russian();

        System.Media.SoundPlayer player = null;
        
        public RussianRoulette()
        {
            InitializeComponent();
            // pass the value to the global variable to generate the sound of fire 
            shootchance1 = obj_Russian.fire();
            shootchance2 = obj_Russian.fire();
            winner = obj_Russian.soundTrigger();
            Shoot.Enabled = false;
            Shotaway.Enabled = false;
            tryAgain.Enabled = false;

        }

        private void start_Click(object sender, EventArgs e)
        {
            // this code is used to pass  the value to the picture box from the debug location  by using the class of the bitmap image
            Trigger.Image = new Bitmap("pics/r2.jpg");
        }

        private void tryAgain_Click(object sender, EventArgs e)
        {
            Trigger.Image = new Bitmap("");
            shootchance1 = 0; shootchance2 = 0;

             count = 0; winner = 0; chance = 0; shootaway = 0;
            shootchance1 = obj_Russian.fire();
            shootchance2 = obj_Russian.fire();
            winner = obj_Russian.soundTrigger();
            Shoot.Enabled = false;
            Shotaway.Enabled = false;
            tryAgain.Enabled = false;
        }

        private void Shotaway_Click(object sender, EventArgs e)
        {
            shootaway++;
            Trigger.Image = new Bitmap("pics/r5.jpg");
            // this block is used to fire the bullet in this panel you have only 2 times fire so thus u can fire only two times 
            // switch block is used to check the fire will play or not 
            switch (shootaway)
            {
                case 1:
                    MessageBox.Show("this is last chance to play");
                    if (count == obj_Russian.soundTrigger())
                    {
                        MessageBox.Show("Congrats you are the winner of this game ");
                        shootaway = 3;
                    }
                    break;
                case 2:
                    MessageBox.Show("Game is over ");
                    if (count == obj_Russian.soundTrigger())
                    {
                        MessageBox.Show("Congrats you are the winner of this game ");
                        shootaway = 3;
                    }
                    else
                    {
                        MessageBox.Show("Sorry you are not the winner of the game  ");
                    }
                    tryAgain.Enabled = true;
                    Shotaway.Enabled = false;
                    break;
            }


        }

        private void Load_Click(object sender, EventArgs e)
        {
            // this code is used to pass  the value to the picture box from the debug location  by using the class of the bitmap image
            Trigger.Image = new Bitmap("pics/r3.jpg");
        }

        private void Spin_Click(object sender, EventArgs e)
        {
            // this code is used to pass  the value to the picture box from the debug location  by using the class of the bitmap image
            Trigger.Image = new Bitmap("pics/r4.jpg");
            Shotaway.Enabled = true;
            Shoot.Enabled = true;

        }

        private void Shoot_Click(object sender, EventArgs e)
        {
            count++;
            Trigger.Image = new Bitmap("pics/r5.jpg");
            if (count == shootchance1) {
                player = new System.Media.SoundPlayer("sound/sound.wav");
                player.Play();
                chance++;
                switch (chance)
                {
                    case 1:
                        MessageBox.Show("this is last chance to play");
                        if (count == obj_Russian.soundTrigger())
                        {
                            MessageBox.Show("Congrats you are the winner of this game ");
                            chance = 3;
                        }
                        break;
                    case 2:
                        MessageBox.Show("Game is over ");
                        if (count == obj_Russian.soundTrigger())
                        {
                            MessageBox.Show("Congrats you are the winner of this game ");
                            chance = 3;
                            
                        }
                        else {
                            MessageBox.Show("Sorry you are not the winner of the game  ");
                        }
                        Shoot.Enabled = false;
                        tryAgain.Enabled = true;
                        break;
                }
                count = 0;
            }
  

        }
    }
}
