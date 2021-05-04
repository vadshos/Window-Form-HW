using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register_form
{
    public partial class Form1 : Form
    {
        bool isValidName;
        bool isValidSurname;
        bool isValidEmail;
        bool isValidPhoneNumber;
        bool isValidDateBirth;
        public Form1()
        {
            InitializeComponent();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar)&&e.KeyChar!='\b')
            {
                e.Handled = true;
            }
            
        }

        private void tbSurName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbSurName.Focus();
                if (!String.IsNullOrWhiteSpace(tbName.Text))
                {
                    if(isValidName == false)
                    {
                        isValidName = true;
                        pbProgress.Value++;
                    }

                }
                else
                {
                    if (isValidName)
                    {
                        pbProgress.Value--;
                        isValidName = false;
                    }
                }
            }
            
        }

        private void tbSurName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpDateBirth.Focus();
                if (!String.IsNullOrWhiteSpace(tbSurName.Text))
                {
                    if (!isValidSurname)
                    {
                        isValidSurname = true;
                        pbProgress.Value++;
                    }
                }
                else
                {
                    if (isValidSurname)
                    {
                        isValidSurname = false;
                        pbProgress.Value--;
                    }
                }
            }
        }

        private void dtpDateBirth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                mtbPhobeNumber.Focus();
                
            }
        }

        private void dtpDateBirth_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = dtpDateBirth.Value;


            if ((DateTime.Now - dateTime).TotalDays / 365 >= 12)
            {
                if (isValidDateBirth == false)
                {
                    pbProgress.Value++;
                    isValidDateBirth = true;
                }

            }
            else
            {
                if (isValidDateBirth)
                {
                    pbProgress.Value--;
                    isValidDateBirth = false;
                }
            }
        }

        private void mtbPhobeNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(mtbPhobeNumber.Text.Length == 14)
                {
                    tbEmail.Focus();
                    if(!isValidPhoneNumber)
                    {
                        isValidPhoneNumber = true;
                        pbProgress.Value++;
                    }
                }
                else
                {
                    if (isValidPhoneNumber)
                    {
                        isValidPhoneNumber = false;
                        pbProgress.Value--;
                    }
                }
            }
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btRegister.Focus();
                if (tbEmail.Text.Length > 5&& tbEmail.Text.Contains("@")&& tbEmail.Text.Contains("."))
                {
                    if (!isValidEmail)
                    {
                        isValidSurname = true;
                        pbProgress.Value++;
                    }
                }
                else
                {
                    if (isValidEmail)
                    {
                        isValidSurname = false;
                        pbProgress.Value--;
                    }
                }
            }
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if(pbProgress.Value == 5)
            {
                errorProvider.SetError(btRegister, "Ok");
            }
            else
            {
                errorProvider1.SetError(btRegister, "Bad data");
            }
        }
    }
}
