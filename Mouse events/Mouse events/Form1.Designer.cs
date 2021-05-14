
namespace Mouse_events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColorBlack = new System.Windows.Forms.Label();
            this.ColorBlue = new System.Windows.Forms.Label();
            this.ColorYellow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rectangle = new System.Windows.Forms.Label();
            this.pen = new System.Windows.Forms.Label();
            this.btmClear = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(182, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 426);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // ColorBlack
            // 
            this.ColorBlack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColorBlack.Location = new System.Drawing.Point(98, 12);
            this.ColorBlack.Name = "ColorBlack";
            this.ColorBlack.Size = new System.Drawing.Size(50, 50);
            this.ColorBlack.TabIndex = 1;
            this.ColorBlack.Click += new System.EventHandler(this.ColorBlack_Click);
            // 
            // ColorBlue
            // 
            this.ColorBlue.BackColor = System.Drawing.Color.Blue;
            this.ColorBlue.Location = new System.Drawing.Point(23, 12);
            this.ColorBlue.Name = "ColorBlue";
            this.ColorBlue.Size = new System.Drawing.Size(50, 50);
            this.ColorBlue.TabIndex = 2;
            this.ColorBlue.Click += new System.EventHandler(this.ColorBlue_Click);
            // 
            // ColorYellow
            // 
            this.ColorYellow.AutoEllipsis = true;
            this.ColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.ColorYellow.Location = new System.Drawing.Point(98, 83);
            this.ColorYellow.Name = "ColorYellow";
            this.ColorYellow.Size = new System.Drawing.Size(50, 50);
            this.ColorYellow.TabIndex = 3;
            this.ColorYellow.Click += new System.EventHandler(this.ColorYellow_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 50);
            this.label2.TabIndex = 4;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.Color.White;
            this.rectangle.Image = ((System.Drawing.Image)(resources.GetObject("rectangle.Image")));
            this.rectangle.Location = new System.Drawing.Point(23, 314);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(131, 113);
            this.rectangle.TabIndex = 5;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // pen
            // 
            this.pen.Image = ((System.Drawing.Image)(resources.GetObject("pen.Image")));
            this.pen.Location = new System.Drawing.Point(23, 152);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(125, 134);
            this.pen.TabIndex = 6;
            this.pen.Click += new System.EventHandler(this.pen_Click);
            // 
            // btmClear
            // 
            this.btmClear.Location = new System.Drawing.Point(23, 448);
            this.btmClear.Name = "btmClear";
            this.btmClear.Size = new System.Drawing.Size(131, 38);
            this.btmClear.TabIndex = 7;
            this.btmClear.Text = "Clear";
            this.btmClear.UseVisualStyleBackColor = true;
            this.btmClear.Click += new System.EventHandler(this.btmClear_Click);
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(791, 13);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(79, 27);
            this.size.TabIndex = 8;
            this.size.Text = "10";
            this.size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.size.TextChanged += new System.EventHandler(this.size_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(791, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 71);
            this.label1.TabIndex = 9;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(903, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.size);
            this.Controls.Add(this.btmClear);
            this.Controls.Add(this.pen);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ColorYellow);
            this.Controls.Add(this.ColorBlue);
            this.Controls.Add(this.ColorBlack);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ColorBlack;
        private System.Windows.Forms.Label ColorBlue;
        private System.Windows.Forms.Label ColorYellow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rectangle;
        private System.Windows.Forms.Label pen;
        private System.Windows.Forms.Button btmClear;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.Label label1;
    }
}

