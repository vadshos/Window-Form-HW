using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class FormAddEditcs : Form
    {
        enum Mode { Edit,Add}
        Product product;
        public FormAddEditcs(Product product)
        {
            InitializeComponent();
            this.product = product;
            if (product.Name == "")
            {
                btnAdd.Text = "Add";
            }
            else
            {
                var categories = (Category[])Enum.GetValues(typeof(Category));
                foreach (var item in categories)
                {
                    comboBox.Items.Add(new ListViewGroup(item.ToString()));
                }
                btnAdd.Text = "Save";
                tbName.Text = product.Name;
                nudPrice.Value = product.Price;
                nudQuentity.Value = product.Quentity;
                comboBox.SelectedIndex = (int)product.CategoryProduct;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            product.Name = tbName.Text;
            product.Price = (int)nudPrice.Value;
            product.Quentity = (int)nudQuentity.Value;
            product.CategoryProduct = (Category)comboBox.SelectedIndex;
        }

       
    }
}
