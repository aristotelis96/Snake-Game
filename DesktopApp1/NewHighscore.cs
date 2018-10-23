using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class NewHighscore : Form
    {
        private Form1 parent;
        public NewHighscore(Form1 form)
        {
            parent = form;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void NewHighscore_Load(object sender, EventArgs e)
        {

        }

        public String getNickname()
        {
            return (nickname.Text.ToString());
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            parent.ReStartAfterHighscores();
        }
    }
}
