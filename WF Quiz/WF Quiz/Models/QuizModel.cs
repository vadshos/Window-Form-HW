using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Quiz.Models
{
    class QuizModel
    {
        public event EventHandler GameOver;
        protected ushort CurrentQuestion { get; set; } = 0;
        protected internal ushort TrueAnswer { get; set; }

        protected Game Form { get; set; }
        public QuizModel(Game gameForm)
        {
            Form = gameForm;
            Form.progressBar1.Maximum = Questions.Count;
        }
        public BindingList<QuestionModel> Questions { get; protected set; } = new BindingList<QuestionModel>();
        public void AddQuestion(QuestionModel question)
        {
            if(question != null)
            {
                Form.progressBar1.Value = 0;
                Questions.Add(question);
                Form.progressBar1.Maximum = Questions.Count;
            }
        }
        public void Run()
        {
            
            var curQ = Questions[CurrentQuestion];
            Form.lblQuestion.Text = curQ.Question;
            if (curQ.Answer)
            {
                Form.btnYes.Tag = true;
                Form.btnNo.Tag = false;
            }
            else
            {
                Form.btnNo.Tag = true;
                Form.btnYes.Tag = false;
            }
            CurrentQuestion++;
            if(CurrentQuestion == Questions.Count)
            {
                GameOver?.Invoke(this,EventArgs.Empty);
            }
           
        }
    }
}
