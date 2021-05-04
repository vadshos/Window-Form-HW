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
    public partial class Form1 : Form
    {
        protected internal BindingList<ProductModel> products;
        private readonly string PATH = $"{Environment.CurrentDirectory}\\ProductDataList.json";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbProducts.SelectedItem != null)
            {
                var product = lbProducts.SelectedItem as ProductModel;
                try
                {

                pbImageProduct.Load(product.PathToIMG);
                }
                catch (Exception)
                {
                    pbImageProduct.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbImageProduct.Load("../../../Resources/download.png");
                }
                lblPriceUAH.Text = "Price : " + product.Price;
                lblNameProduct.Text = product.Name;
                lblDescription.Text = product.Description;
                lblAmount.Text = "Amount : " + product.Amount;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            products = FileIOServices.FileIOService.LoadData(PATH); 
          
            lbProducts.DataSource = products;
        }
        internal void AddProduct(ProductModel product)
        {
            if (product != null)
                products.Add(product);
        }
        protected internal void RefreshDataSourse()
        {
            lbProducts.DataSource = null;
            lbProducts.DataSource = products;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex != -1)
            {
                products.Remove((ProductModel)lbProducts.SelectedItem);
                RefreshDataSourse();
                FileIOServices.FileIOService.SaveData(products, PATH);
            }

        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            if(lbProducts.SelectedIndex != -1)
            {
                ChildMenu child = new ChildMenu(this,(ProductModel)lbProducts.SelectedItem,ChildMenu.ModeWork.Edit);
                var result  = child.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FileIOServices.FileIOService.SaveData(products, PATH);
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ChildMenu child = new ChildMenu(this, null, ChildMenu.ModeWork.Add);
            var result  = child.ShowDialog();
            if(result == DialogResult.OK)
            {
                FileIOServices.FileIOService.SaveData(products, PATH);
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
