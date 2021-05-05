using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAchion_Click(object sender, EventArgs e)
        {
            Form gameForm = new Game(this) { };
            this.Visible = false;
            gameForm.ShowDialog();
            
        }
    }
}
