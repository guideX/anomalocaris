using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xilium.CefGlue;
namespace Xilium.CefGlue.Scrape {

    
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        Scraper s;
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.Shutdown();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            s = new Scraper();
            s.Scrape("http://www.team-nexgen.org/");
        }





    }
}
