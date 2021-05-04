
namespace HM_events
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
            this.tbNameEvent = new System.Windows.Forms.TextBox();
            this.tbLocationEvent = new System.Windows.Forms.TextBox();
            this.dtEvent = new System.Windows.Forms.DateTimePicker();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbPriority = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btDeleteSelected = new System.Windows.Forms.Button();
            this.btClearList = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNameEvent
            // 
            this.tbNameEvent.Location = new System.Drawing.Point(572, 13);
            this.tbNameEvent.Name = "tbNameEvent";
            this.tbNameEvent.PlaceholderText = "Name event";
            this.tbNameEvent.Size = new System.Drawing.Size(199, 27);
            this.tbNameEvent.TabIndex = 0;
            // 
            // tbLocationEvent
            // 
            this.tbLocationEvent.Location = new System.Drawing.Point(572, 58);
            this.tbLocationEvent.Name = "tbLocationEvent";
            this.tbLocationEvent.PlaceholderText = "Location";
            this.tbLocationEvent.Size = new System.Drawing.Size(199, 27);
            this.tbLocationEvent.TabIndex = 1;
            // 
            // dtEvent
            // 
            this.dtEvent.Location = new System.Drawing.Point(572, 104);
            this.dtEvent.Name = "dtEvent";
            this.dtEvent.Size = new System.Drawing.Size(199, 27);
            this.dtEvent.TabIndex = 2;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(572, 206);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(98, 42);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPriority
            // 
            this.tbPriority.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbPriority.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbPriority.Location = new System.Drawing.Point(572, 154);
            this.tbPriority.Name = "tbPriority";
            this.tbPriority.PlaceholderText = "Priority";
            this.tbPriority.Size = new System.Drawing.Size(199, 27);
            this.tbPriority.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 425);
            this.panel1.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(83, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(553, 384);
            this.listBox1.TabIndex = 0;
            // 
            // btDeleteSelected
            // 
            this.btDeleteSelected.Location = new System.Drawing.Point(572, 409);
            this.btDeleteSelected.Name = "btDeleteSelected";
            this.btDeleteSelected.Size = new System.Drawing.Size(94, 29);
            this.btDeleteSelected.TabIndex = 6;
            this.btDeleteSelected.Text = "Delete selected";
            this.btDeleteSelected.UseVisualStyleBackColor = true;
            this.btDeleteSelected.Click += new System.EventHandler(this.btDeleteSelected_Click);
            // 
            // btClearList
            // 
            this.btClearList.Location = new System.Drawing.Point(677, 409);
            this.btClearList.Name = "btClearList";
            this.btClearList.Size = new System.Drawing.Size(94, 29);
            this.btClearList.TabIndex = 7;
            this.btClearList.Text = "Clear list";
            this.btClearList.UseVisualStyleBackColor = true;
            this.btClearList.Click += new System.EventHandler(this.btClearList_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(572, 271);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Find";
            this.textBox1.Size = new System.Drawing.Size(199, 27);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(301, 390);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(167, 29);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(673, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 42);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btClearList);
            this.Controls.Add(this.btDeleteSelected);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbPriority);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dtEvent);
            this.Controls.Add(this.tbLocationEvent);
            this.Controls.Add(this.tbNameEvent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNameEvent;
        private System.Windows.Forms.TextBox tbLocationEvent;
        private System.Windows.Forms.DateTimePicker dtEvent;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbPriority;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btDeleteSelected;
        private System.Windows.Forms.Button btClearList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
    }
}

