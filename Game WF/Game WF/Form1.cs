using Game_WF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddElems(new Random().Next(1,10));
            hearts.Add(heartFirst);
            hearts.Add(heartSecond);
            hearts.Add(heardThird);
           
           
           
        }



        BindingList<Label> hearts = new BindingList<Label>();
        BindingList<ElemModel> elems = new BindingList<ElemModel>();
        int valueTimer = 60;
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        void AddElems(int countElem)
        {
            for (int i = 0; i < countElem; i++)
            {


                int rand = new Random().Next(5);
                int Width = new Random().Next(panelElem.Width-100);
                PictureBox label = new PictureBox() { Width = panelElem.Width, Height = panelElem.Height };
                label.Location = new Point(Width,0);
                label.Size = new Size { Height = 75, Width = 75 };
                switch (rand)
                {
                    case 0:
                        
                        label.Image = Image.FromFile("..\\..\\..\\bee.png");
                        label.Tag = "insect";
                        break;
                    case 1:
                        label.Image = Image.FromFile("..\\..\\..\\apple.png");
                        label.Tag = "fruct";
                        break;
                    case 2:
                        label.Image = Image.FromFile("..\\..\\..\\coin.png");
                        label.Tag = "coin";
                        break;
                    case 3:
                        label.Image = Image.FromFile("..\\..\\..\\pineapple.png");
                        label.Tag = "fruct";

                        break;
                    case 4:
                        label.Image = Image.FromFile("..\\..\\..\\bug.png");
                        label.Tag = "insect";
                        break;
                    default:
                        break;
                }
                label.SizeMode = PictureBoxSizeMode.StretchImage;
                label.MouseClick += PictureBox_Click;
                elems.Add(new ElemModel { label = label, HeigthPanel = panelElem.Height, WidthPanel = panelElem.Width });
                panelElem.Controls.Add(label);
            }
        }
         void PictureBox_Click(object elem,EventArgs e)
        {
            AddElems(new Random().Next(1, 2));
            if((elem as PictureBox).Tag == "coin")
            {
                countCoint.Text = $"{ int.Parse(countCoint.Text) + 1}";
            }
            panelElem.Controls.Remove(elem as PictureBox);
        }
        private void pbBasketFruits_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            foreach (var item in elems)
            {
                try
                {
                    item.Move();
                }
                catch (Exception)
                {
                    if ((item.label.Tag as String) == "insect")
                    {                                                
                            hearts[hearts.Count - 1].Visible = false;
                            hearts.RemoveAt(hearts.Count - 1);
                            
                            if (hearts.Count == 1)
                            {
                                timer.Enabled = false;
                                MessageBox.Show("You lose");
                             MessageBox.Show($"Fruits : {countFruit.Text}\nCoints : {countCoint.Text}");
                        }                     
                    }else if((item.label.Tag as String) == "fruct")
                    {
                        countFruit.Text = $"{ int.Parse(countFruit.Text) + 1}"; 
                    }
                        panelElem.Controls.Remove(item.label);
                }
            }

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timerEndGame.Enabled = true;
            timerForTimerForm.Enabled = true;
        }

        private void timerEndGame_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timerEndGame.Enabled = false;
            timerForTimerForm.Enabled = false;
            MessageBox.Show($"Fruits : {countFruit.Text}\nCoints : {countCoint.Text}");

        }

        private void timerForTimerForm_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = $"0:{valueTimer--}";
        }
    }
}
