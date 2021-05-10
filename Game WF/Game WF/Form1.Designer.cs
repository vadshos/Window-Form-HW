
namespace Game_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelElem = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.heartFirst = new System.Windows.Forms.Label();
            this.heartSecond = new System.Windows.Forms.Label();
            this.heardThird = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.countCoint = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.countFruit = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerEndGame = new System.Windows.Forms.Timer(this.components);
            this.timerForTimerForm = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelElem
            // 
            this.panelElem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelElem.Location = new System.Drawing.Point(12, 12);
            this.panelElem.Name = "panelElem";
            this.panelElem.Size = new System.Drawing.Size(775, 434);
            this.panelElem.TabIndex = 3;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(803, 22);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(100, 56);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "1:00";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(793, 335);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 59);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // heartFirst
            // 
            this.heartFirst.Image = ((System.Drawing.Image)(resources.GetObject("heartFirst.Image")));
            this.heartFirst.Location = new System.Drawing.Point(793, 143);
            this.heartFirst.Name = "heartFirst";
            this.heartFirst.Size = new System.Drawing.Size(35, 25);
            this.heartFirst.TabIndex = 7;
            // 
            // heartSecond
            // 
            this.heartSecond.Image = ((System.Drawing.Image)(resources.GetObject("heartSecond.Image")));
            this.heartSecond.Location = new System.Drawing.Point(841, 143);
            this.heartSecond.Name = "heartSecond";
            this.heartSecond.Size = new System.Drawing.Size(30, 25);
            this.heartSecond.TabIndex = 8;
            // 
            // heardThird
            // 
            this.heardThird.Image = ((System.Drawing.Image)(resources.GetObject("heardThird.Image")));
            this.heardThird.Location = new System.Drawing.Point(877, 143);
            this.heardThird.Name = "heardThird";
            this.heardThird.Size = new System.Drawing.Size(38, 25);
            this.heardThird.TabIndex = 9;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // countCoint
            // 
            this.countCoint.AutoSize = true;
            this.countCoint.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countCoint.Location = new System.Drawing.Point(841, 192);
            this.countCoint.Name = "countCoint";
            this.countCoint.Size = new System.Drawing.Size(25, 30);
            this.countCoint.TabIndex = 10;
            this.countCoint.Text = "0";
            this.countCoint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(793, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // countFruit
            // 
            this.countFruit.AutoSize = true;
            this.countFruit.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countFruit.Location = new System.Drawing.Point(841, 253);
            this.countFruit.Name = "countFruit";
            this.countFruit.Size = new System.Drawing.Size(25, 30);
            this.countFruit.TabIndex = 13;
            this.countFruit.Text = "0";
            this.countFruit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(793, 247);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // timerEndGame
            // 
            this.timerEndGame.Interval = 60000;
            this.timerEndGame.Tick += new System.EventHandler(this.timerEndGame_Tick);
            // 
            // timerForTimerForm
            // 
            this.timerForTimerForm.Interval = 1000;
            this.timerForTimerForm.Tick += new System.EventHandler(this.timerForTimerForm_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.countFruit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.countCoint);
            this.Controls.Add(this.heardThird);
            this.Controls.Add(this.heartSecond);
            this.Controls.Add(this.heartFirst);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.panelElem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelElem;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label heartFirst;
        private System.Windows.Forms.Label heartSecond;
        private System.Windows.Forms.Label heardThird;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label countCoint;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label countFruit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerEndGame;
        private System.Windows.Forms.Timer timerForTimerForm;
    }
}

