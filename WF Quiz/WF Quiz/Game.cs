using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Quiz.Models;

namespace WF_Quiz
{
    public partial class Game : Form
    {
        Form parrent;
        QuizModel quizModel;
        bool lastQuestion;
        public Game(Form parrent)
        {
            InitializeComponent();
            this.parrent = parrent;
            quizModel = new QuizModel(this);
            quizModel.GameOver += Last;
            quizModel.AddQuestion(new QuestionModel { Question = "Yes", Answer = true });
            quizModel.AddQuestion(new QuestionModel { Question = "No", Answer = false });
            quizModel.AddQuestion(new QuestionModel { Question = "Yes", Answer = true });
            Play();

        }
        void Last(object sender,EventArgs args)
        {
            lastQuestion = true;
        }
        void Play()
        {
            quizModel?.Run();
            
        }
        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if(btnYes.Tag == null)
            {
                return;
            }
            if((bool)btnYes.Tag == true)
            {
                quizModel.TrueAnswer++;
                btnYes.BackColor = Color.ForestGreen;
               

            }
            else
            {
                btnYes.BackColor = Color.IndianRed;
            }
            if (lastQuestion == true)
            {
                MessageBox.Show($"{quizModel.TrueAnswer} / {quizModel.Questions.Count}");
                this.Close();
                return;
            }
            btnNo.BackColor = Color.WhiteSmoke;
            this.progressBar1.Value++;
            Play();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (btnYes.Tag == null)
            {
                return;
            }
            if ((bool)btnNo.Tag == true)
            {
                quizModel.TrueAnswer++;

                btnNo.BackColor = Color.ForestGreen;
            }
            else
            {
                btnNo.BackColor = Color.IndianRed;
            }
            
            btnYes.BackColor = Color.WhiteSmoke;
            if(lastQuestion == true)
            {
                MessageBox.Show($"{quizModel.TrueAnswer} / {quizModel.Questions.Count}");
                this.Close();
                return;

            }
            this.progressBar1.Value++;
            Play();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            parrent.Visible = true;
        }
    }
}
