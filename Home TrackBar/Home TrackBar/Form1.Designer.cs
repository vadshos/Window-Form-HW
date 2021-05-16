
namespace Home_TrackBar
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
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tbLike = new System.Windows.Forms.TrackBar();
            this.tbDislike = new System.Windows.Forms.TrackBar();
            this.lblLike = new System.Windows.Forms.Label();
            this.lblDislike = new System.Windows.Forms.Label();
            this.lblInfoLike = new System.Windows.Forms.Label();
            this.lblInfoDislike = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDislike)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFirst.Location = new System.Drawing.Point(538, 37);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(132, 43);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLast.Location = new System.Drawing.Point(538, 116);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(132, 43);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(538, 191);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(132, 43);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.Location = new System.Drawing.Point(538, 271);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(132, 43);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(70, 37);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(446, 277);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // tbLike
            // 
            this.tbLike.Enabled = false;
            this.tbLike.Location = new System.Drawing.Point(70, 341);
            this.tbLike.Name = "tbLike";
            this.tbLike.Size = new System.Drawing.Size(365, 56);
            this.tbLike.TabIndex = 6;
            this.tbLike.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbDislike
            // 
            this.tbDislike.Enabled = false;
            this.tbDislike.Location = new System.Drawing.Point(70, 420);
            this.tbDislike.Name = "tbDislike";
            this.tbDislike.Size = new System.Drawing.Size(365, 56);
            this.tbDislike.TabIndex = 7;
            this.tbDislike.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbDislike.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // lblLike
            // 
            this.lblLike.Image = ((System.Drawing.Image)(resources.GetObject("lblLike.Image")));
            this.lblLike.Location = new System.Drawing.Point(441, 317);
            this.lblLike.Name = "lblLike";
            this.lblLike.Size = new System.Drawing.Size(75, 67);
            this.lblLike.TabIndex = 8;
            this.lblLike.Click += new System.EventHandler(this.lblLike_Click);
            // 
            // lblDislike
            // 
            this.lblDislike.Image = ((System.Drawing.Image)(resources.GetObject("lblDislike.Image")));
            this.lblDislike.Location = new System.Drawing.Point(441, 409);
            this.lblDislike.Name = "lblDislike";
            this.lblDislike.Size = new System.Drawing.Size(75, 67);
            this.lblDislike.TabIndex = 9;
            this.lblDislike.Click += new System.EventHandler(this.lblDislike_Click);
            // 
            // lblInfoLike
            // 
            this.lblInfoLike.AutoSize = true;
            this.lblInfoLike.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoLike.Location = new System.Drawing.Point(522, 341);
            this.lblInfoLike.Name = "lblInfoLike";
            this.lblInfoLike.Size = new System.Drawing.Size(42, 28);
            this.lblInfoLike.TabIndex = 10;
            this.lblInfoLike.Text = "0/5";
            // 
            // lblInfoDislike
            // 
            this.lblInfoDislike.AutoSize = true;
            this.lblInfoDislike.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoDislike.Location = new System.Drawing.Point(522, 420);
            this.lblInfoDislike.Name = "lblInfoDislike";
            this.lblInfoDislike.Size = new System.Drawing.Size(42, 28);
            this.lblInfoDislike.TabIndex = 11;
            this.lblInfoDislike.Text = "0/5";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 502);
            this.Controls.Add(this.lblInfoDislike);
            this.Controls.Add(this.lblInfoLike);
            this.Controls.Add(this.lblDislike);
            this.Controls.Add(this.lblLike);
            this.Controls.Add(this.tbDislike);
            this.Controls.Add(this.tbLike);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.pbImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDislike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TrackBar tbLike;
        private System.Windows.Forms.TrackBar tbDislike;
        private System.Windows.Forms.Label lblLike;
        private System.Windows.Forms.Label lblDislike;
        private System.Windows.Forms.Label lblInfoLike;
        private System.Windows.Forms.Label lblInfoDislike;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

