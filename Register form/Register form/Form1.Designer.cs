
namespace Register_form
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurName = new System.Windows.Forms.TextBox();
            this.dtpDateBirth = new System.Windows.Forms.DateTimePicker();
            this.mtbPhobeNumber = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.AcceptsTab = true;
            this.tbName.Location = new System.Drawing.Point(264, 61);
            this.tbName.Name = "tbName";
            this.tbName.PlaceholderText = "Name";
            this.tbName.Size = new System.Drawing.Size(215, 27);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbSurName
            // 
            this.tbSurName.Location = new System.Drawing.Point(264, 112);
            this.tbSurName.Name = "tbSurName";
            this.tbSurName.PlaceholderText = "Surname";
            this.tbSurName.Size = new System.Drawing.Size(215, 27);
            this.tbSurName.TabIndex = 1;
            this.tbSurName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSurName_KeyDown);
            this.tbSurName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSurName_KeyPress);
            // 
            // dtpDateBirth
            // 
            this.dtpDateBirth.Location = new System.Drawing.Point(264, 158);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.Size = new System.Drawing.Size(215, 27);
            this.dtpDateBirth.TabIndex = 2;
            this.dtpDateBirth.ValueChanged += new System.EventHandler(this.dtpDateBirth_ValueChanged);
            this.dtpDateBirth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDateBirth_KeyDown);
            // 
            // mtbPhobeNumber
            // 
            this.mtbPhobeNumber.Location = new System.Drawing.Point(264, 206);
            this.mtbPhobeNumber.Mask = "(999) 000-0000";
            this.mtbPhobeNumber.Name = "mtbPhobeNumber";
            this.mtbPhobeNumber.Size = new System.Drawing.Size(215, 27);
            this.mtbPhobeNumber.TabIndex = 3;
            this.mtbPhobeNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbPhobeNumber_KeyDown);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(264, 253);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(215, 27);
            this.tbEmail.TabIndex = 4;
            this.tbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEmail_KeyDown);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(299, 351);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(145, 48);
            this.btRegister.TabIndex = 5;
            this.btRegister.Text = "Sing up";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // pbProgress
            // 
            this.pbProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pbProgress.Location = new System.Drawing.Point(264, 306);
            this.pbProgress.Maximum = 5;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(215, 30);
            this.pbProgress.TabIndex = 6;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.mtbPhobeNumber);
            this.Controls.Add(this.dtpDateBirth);
            this.Controls.Add(this.tbSurName);
            this.Controls.Add(this.tbName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurName;
        private System.Windows.Forms.DateTimePicker dtpDateBirth;
        private System.Windows.Forms.MaskedTextBox mtbPhobeNumber;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

