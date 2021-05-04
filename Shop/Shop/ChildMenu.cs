using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class ChildMenu : Form
    {
       string pathErrorImage = "../../../Resources/download.png";
        public enum ModeWork {Edit,Add}
        ProductModel product;
        string path;
        public Form1 Parent { get; set; }
        ModeWork Mode { get; set; }
        public ChildMenu()
        {
            InitializeComponent();
        }
        public ChildMenu(Form1 parent, ProductModel product,ModeWork mode)
        {
            
            InitializeComponent();
            var result = typeof(ProductModel.TypeProduct).GetEnumValues();
            Mode = mode;
            foreach (var item in result)
            {
                cbType.Items.Add(item);
            }
            btnCancel.Text = "Cancel";
            Parent = parent;
            if (mode == ModeWork.Add)
            {
                SetModeAdd(product);
            }else if( mode == ModeWork.Edit)
            {
                SetModeEdit(product);
            }
            
        }
        private void ChildMenu_Load(object sender, EventArgs e)
        {
          
        }

        void SetModeAdd(ProductModel product)
        {
            pbImage.Load(pathErrorImage);
            product = new ProductModel();
            this.product = product;
            btnOk.Text = "Add";
        }
        
        void SetModeEdit(ProductModel product)
        {
            try
            {
                pbImage.Load(product.PathToIMG);
            }
            catch (Exception)
            {
                pbImage.Load(pathErrorImage);



            }
           
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            this.product = product;
            cbType.SelectedIndex = (int)product.Type;
            tbName.Text = product.Name;
            nudAmount.Value = product.Amount;
            nudPrice.Value = product.Price;
            btnOk.Text = "Save";
            textBox1.Text = product.Description;
            
        }
        
        bool CheckData()
        {
            if (cbType.SelectedItem == null)
            {
                MessageBox.Show("Bad type product");
                return false;
            }
            else if (String.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Bad name product");
                return false;
            }
            else if (String.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Bad image product");
                return false;
            }
            return true;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                
                product.Amount = (ushort)nudAmount.Value;
                product.Name = tbName.Text;
                product.Type = (ProductModel.TypeProduct)cbType.SelectedIndex;
                product.Price = (ushort)nudPrice.Value;
                product.PathToIMG = path;
                product.Description = textBox1.Text;
                if (Mode == ModeWork.Add)
                {
                    Parent.products.Add(product);
                }
                Parent.RefreshDataSourse();
            }
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            
            if(openImageDialog.ShowDialog() == DialogResult.OK)
            {
                path = openImageDialog.FileName;
                pbImage.Load(path);
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }
    }
}
