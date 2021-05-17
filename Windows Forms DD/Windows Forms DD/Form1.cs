using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_DD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Enum.GetValues(typeof(Product)))
            pictureBox2.AllowDrop = true;
            listBox1.AllowDrop = true;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Move);
        }
        private void textBox_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.DoDragDrop(textBox1.Text, DragDropEffects.Move);
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
              
            pictureBox2.Image = e.Data.GetData(DataFormats.Bitmap) as Image;   
            }
            else if ( e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                pictureBox2.ImageLocation = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];
            }
        }
        private void listBox_DragDrop(object sender ,DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                listBox1.Items.Add(e.Data.GetData(DataFormats.Text));
            }
        }
        private void listBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
        }
        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
        }
    }
}
