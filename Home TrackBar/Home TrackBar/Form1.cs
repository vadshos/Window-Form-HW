using Home_TrackBar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_TrackBar
{
    public partial class Form1 : Form
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\PicturesList.json";
        int currentIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }
        BindingList<PictureModel> pictures;
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currentIndex != pictures.Count - 1)
            {
                currentIndex++;             
            }
            else
            {
                currentIndex = 0;
            }
            SetData(pictures[currentIndex]);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }
        private void SetData(PictureModel picture)
        {
            notifyIcon.Text = picture.Name;
            pbImage.Load(picture.PathToImage);
            tbLike.Value = (int)(picture.Rate);
            tbDislike.Value = (tbDislike.Maximum - tbLike.Value);
            lblInfoLike.Text = $"{tbLike.Value}/10";
            lblInfoDislike.Text = $"{tbDislike.Value}/10";
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictures = FileIOServices.FileIOService.LoadData(PATH);
            
            {
                SetData(pictures[0]);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileIOServices.FileIOService.SaveData(pictures, PATH);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if(pictures.Count > 0)
            {
                SetData(pictures[0]);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (pictures.Count > 0)
            {
                SetData(pictures[pictures.Count - 1]);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentIndex != 0)
            {
                currentIndex--;
            }
            else
            {
                currentIndex = pictures.Count -1;
            }
            SetData(pictures[currentIndex]);
        }

        private void lblLike_Click(object sender, EventArgs e)
        {
            double count = pictures[currentIndex].CountVote;
            double value = 1 / count;
            pictures[currentIndex].Rate += pictures[currentIndex].Rate * value;
            if(pictures[currentIndex].Rate > tbLike.Maximum)
            {
                pictures[currentIndex].Rate = tbLike.Maximum;
            }
            pictures[currentIndex].CountVote++;
            SetData(pictures[currentIndex]);



        }

        private void lblDislike_Click(object sender, EventArgs e)
        {
            double count = pictures[currentIndex].CountVote;
            double value = 1 / count;
            pictures[currentIndex].Rate -= pictures[currentIndex].Rate * value;
            if (pictures[currentIndex].Rate < tbDislike.Minimum)
            {
                pictures[currentIndex].Rate = tbDislike.Minimum;
            }
            pictures[currentIndex].CountVote++;
            SetData(pictures[currentIndex]);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.Size.Width > 1000 || this.Height > 700){
                notifyIcon.Visible = true;
                
                notifyIcon.ShowBalloonTip(100000000, "Maximazite size", "Resize", ToolTipIcon.Info);
            }
            else
            {
                notifyIcon.Visible = false;
            }
        }
    }
}
