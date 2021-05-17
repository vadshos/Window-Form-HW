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
    public partial class Form1 : Form
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\ProductsDataList.json";
        public Form1()
        {
            InitializeComponent();
        }
        bool isAscending;
        

       

        private void Form1_Load(object sender, EventArgs e)
        {
            Category[] categories = (Category [])Enum.GetValues(typeof(Category));
            
            foreach (var item in (View[])Enum.GetValues(typeof(View)))
            {
                var elem = new ToolStripMenuItem(item.ToString());
                elem.Click += contextMenuStrip1_Click;
                contextMenuStrip1.Items.Add(elem);
            }
            (contextMenuStrip1.Items[(int)listView1.View] as ToolStripMenuItem).Checked = true;
            foreach (var item in categories)
            {
                listView1.Groups.Add(new ListViewGroup(item.ToString()));
            }
           var items =  FileIOService.FileIOService.LoadData(PATH);
            if(items == null)
            {
                return;
            }
            foreach (var item in items)
            {
                var elem = new ListViewItem();
                elem.Text = item.Name;
                elem.SubItems.Add(item.Price.ToString());
                elem.SubItems.Add(item.Quentity.ToString());
                elem.ImageIndex = (int)item.CategoryProduct;
                listView1.Groups[(int)item.CategoryProduct].Items.Add(elem);
                listView1.Items.Add(elem);
            }
                
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (isAscending == false)
            {
                isAscending = true;
                listView1.ListViewItemSorter = new CmpDrodListView(e.Column);
            }
            else
            {
                isAscending = false;
                listView1.ListViewItemSorter = new CmpDrodListView(e.Column,SortOrder.Descending);
            }
       }

      

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
           if( e.KeyCode == Keys.Delete)
            {
               if( listView1.SelectedItems != null)
                {
                    var elems = listView1.SelectedItems;
                    foreach (var item in elems)
                    {
                       listView1.Items.Remove(item as ListViewItem);
                    }
                }
            }
        }     

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {          
            var mode =   (sender as ToolStripMenuItem);
            foreach (var item in contextMenuStrip1.Items)
            {
                (item as ToolStripMenuItem).Checked = false;
            }
            (sender as ToolStripMenuItem).Checked = true;
            listView1.View = (View)Enum.Parse(typeof(View), mode.Text);
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                return;
            }
            var selectItem = listView1.SelectedItems[0];
            var product = new Product() { CategoryProduct = (Category)selectItem.ImageIndex, Name = selectItem.Text, Quentity = int.Parse(selectItem.SubItems[1].Text), Price = int.Parse(selectItem.SubItems[2].Text) };
            var form = new FormAddEditcs(product); 
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                listView1.Items.Remove(selectItem);
                var elem = new ListViewItem();
                elem.Text = product.Name;
                elem.SubItems.Add(product.Price.ToString());
                elem.SubItems.Add(product.Quentity.ToString());
                elem.ImageIndex = (int)product.CategoryProduct;
                listView1.Items.Add(elem);
                listView1.Groups[(int)product.CategoryProduct].Items.Add(elem);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var item = new Product();
            var form = new FormAddEditcs(item);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                var elem = new ListViewItem();
                elem.Text = item.Name;
                elem.SubItems.Add(item.Price.ToString());
                elem.SubItems.Add(item.Quentity.ToString());
                elem.ImageIndex = (int)item.CategoryProduct;
                listView1.Items.Add(elem);
                listView1.Groups[(int)item.CategoryProduct].Items.Add(elem);
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            BindingList<Product> products = new BindingList<Product>();
            foreach (ListViewItem item in listView1.Items)
            {
                products.Add(new Product() { CategoryProduct = (Category)item.ImageIndex, Name = item.Text, Quentity = int.Parse(item.SubItems[1].Text), Price = int.Parse(item.SubItems[2].Text) });
            }
            FileIOService.FileIOService.SaveData(products, PATH);
        }
    }
}
