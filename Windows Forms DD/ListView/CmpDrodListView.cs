using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    class CmpDrodListView : IComparer
    {
        int column;
        SortOrder sortOrder;
        public CmpDrodListView(int column = 0,SortOrder sortOrder = SortOrder.Ascending)
        {
            this.column = column;

            this.sortOrder = sortOrder;
        }
        public int Compare(object x, object y)
        {
            ListViewItem li1 = x as ListViewItem;
            ListViewItem li2 = y as ListViewItem;
            int result = 1;
            if(column == 0)
            {
                string prod1 = li1.Text;
                string prod2 = li2.Text;
                if(sortOrder == SortOrder.Ascending)
                result = prod1.CompareTo(prod2);
                else
                    result = -prod1.CompareTo(prod2);

            }
            else
            {
                decimal val1 = decimal.Parse(li1.SubItems[column].Text);
                decimal val2 = decimal.Parse(li2.SubItems[column].Text);
                if (sortOrder == SortOrder.Ascending)
                    result = val1.CompareTo(val2);
                else
                    result = -val1.CompareTo(val2);
            }
            return result;
        }
    }
}
