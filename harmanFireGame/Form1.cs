using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harmanFireGame
{
    public partial class Form1 : Form
    {
        String yUrl = "";

        public Form1()
        {

            InitializeComponent();
        }
        // this is the getter method of the class that pass the string method to the user and pass the string to the main method
        public String video {
            get {
                // this is used to check the url is coorect or incorrect 
                var yMatch = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)").Match(yUrl);
                return yMatch.Success ? yMatch.Groups[1].Value : String.Empty;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //after getting the complete url of the video then pass to the main method
            yUrl = "https://www.youtube.com/watch?v=tTe-TcJRZ2U";
            //pass the url to the web browser to provide the link to play on you tube how to play the game 
            webBrowser1.Navigate($"http://youtube.com/v/{video}?version=3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RussianRoulette obj = new RussianRoulette();
            obj.Visible = true;

        }
    }
}
