using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmanFireGame
{
    public class Russian
    {
        Random rd = new Random();
        // this method is used to generate the no to fire 
        public int fire() {
            return rd.Next(1, 6);
        }
        //this method id used to find  the winner of the game 
        public int soundTrigger() {
            return rd.Next(1, 6);
        }
    }
}
