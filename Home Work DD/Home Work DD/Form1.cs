using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Work_DD
{
    public partial class Form1 : Form
    {
        Button[,] buttons ;
        Button buttonEmpty;
        int countRowAndCol;
        int curI, curJ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int countBtn = this.Controls.Count-1;
            countRowAndCol = (int)Math.Sqrt(countBtn);
            buttons = new Button[countRowAndCol, countRowAndCol];
            curI = countRowAndCol -1;
            curJ = countRowAndCol-1;

            int j = 0;
            int i = 0;
            List<Button> btns = new List<Button>();
            foreach (Button item in this.Controls)
            {
                if (item.Text != "New Game")               
                    btns.Add(item);
            }
            btns.Sort((e, e2) => int.Parse(e.Text).CompareTo(int.Parse(e2.Text)));
               foreach (Button item in btns)
               {
                  
                    buttons[i, j] = item;
                    ++j;
                    if(j == countRowAndCol)
                    {
                        j = 0;
                        ++i;
                    }
                  }

            SetCanDrag();
            FillButton();
            buttonEmpty = buttons[curI,curJ];
           



        }
        private void FillButton()
        {
            int[] arr = new int[buttons.Length];
            int i = 0;
            foreach (var item in buttons)
            {
                while (true)
                {
                    var number = new Random().Next(1,buttons.Length);
                    var elem = (from num in arr where num == number select num).ToList();
                    if(item.Visible == false)
                    {
                        break;
                    }
                    if (elem?.Count == 0)
                    {
                        item.Text = number.ToString();
                        arr[i] = number;
                        i++;
                        break;
                    }
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if((sender as Button).Tag != null)
            {
                buttonEmpty.Visible = true;
                string text = buttonEmpty.Text;
                buttonEmpty.Text = (sender as Button).Text;
                   
                
                Tuple<int,int> arr = (Tuple<int,int>)(sender as Button).Tag ;
                curI = arr.Item1;
                curJ = arr.Item2;
                buttons[curI, curJ].Visible = false;
                buttonEmpty = buttons[curI, curJ];
                buttonEmpty.Text = text;
                SetCanDrag();
                if (CheckIsWin())
                {
                    MessageBox.Show("You WIN!!!");
                }
            }
           
        }

        bool CheckIsWin()
        {
            int num = 0;
            foreach (var item in buttons)
            {
                if(item.Text != (num + 1).ToString())
                {
                     return false;
                }
                ++num;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SetCanDrag()
        {
            foreach (var item in buttons)
            {
                item.Tag = null;
            }
            if(curJ != 0 && curI != 0 && curJ != countRowAndCol-1&&curI != countRowAndCol - 1)
            {
                int leftJ = curJ - 1;
                int rigthJ = curJ + 1;
                int upI = curI - 1;
                int downI = curI + 1;
              
                buttons[upI, curJ].Tag = new Tuple<int,int>( upI, curJ );
               
                buttons[curI, leftJ].Tag = new Tuple<int,int>( curI, leftJ );
                buttons[curI, rigthJ].Tag = new Tuple<int,int>( curI, rigthJ );
               
                buttons[downI, curJ].Tag = new Tuple<int,int>( downI, curJ );
               
            }
            else if((curI == 0 && curJ == 0)|| (curI == countRowAndCol-1 && curJ == countRowAndCol - 1))
            {
                int cof = -1;
                if(curI == 0)
                {
                    cof = 1;
                }
                buttons[curI, (curJ + cof)].Tag = new Tuple<int,int>( curI, (curJ + cof) );
                buttons[(curI + cof), curJ].Tag = new Tuple<int,int>( curI + cof, curJ  ) ;
                
            }else if ((curI == 0 && curJ == countRowAndCol - 1) || (curI == countRowAndCol - 1 && curJ == 0))
            {
                int cofFirst = -1;
                int cofSecond = 1;
                if (curJ == countRowAndCol - 1)
                {
                 cofFirst = 1;
                 cofSecond = -1;
                    
                }
                buttons[ curI + cofFirst, curJ].Tag = new Tuple<int,int>( (curI + cofFirst), curJ );
                
                buttons[curI, (curJ + cofSecond)].Tag = new Tuple<int,int>( curI, (curJ + cofSecond) );
            }
            else
            {
                if(curI == 0)
                {
                    int leftJ = curJ - 1;
                    int rigthJ = curJ + 1;                   
                    int downI = curI + 1;                 
                    buttons[curI, leftJ].Tag = new Tuple<int, int>(curI, leftJ);
                    buttons[curI, rigthJ].Tag = new Tuple<int, int>(curI, rigthJ);
                 
                    buttons[downI, curJ].Tag = new Tuple<int, int>(downI, curJ);
                   
                }
                else if(curI == countRowAndCol -1)
                {
                    int leftJ = curJ - 1;
                    int rigthJ = curJ + 1;
                    int upI = curI - 1;
                   
                    buttons[upI, curJ].Tag = new Tuple<int, int>(upI, curJ);
                  
                    buttons[curI, leftJ].Tag = new Tuple<int, int>(curI, leftJ);
                    buttons[curI, rigthJ].Tag = new Tuple<int, int>(curI, rigthJ);
                }else if(curJ == 0)
                {
                    int rigthJ = curJ + 1;
                    int upI = curI - 1;
                    int downI = curI + 1;
                    
                    buttons[upI, curJ].Tag = new Tuple<int, int>(upI, curJ);
                   
                    
                    buttons[curI, rigthJ].Tag = new Tuple<int, int>(curI, rigthJ);
                    
                    buttons[downI, curJ].Tag = new Tuple<int, int>(downI, curJ);
                  
                }else if(curJ == countRowAndCol - 1)
                {
                    int leftJ = curJ - 1;
            
                    int upI = curI - 1;
                    int downI = curI + 1;
                  
                    buttons[upI, curJ].Tag = new Tuple<int, int>(upI, curJ);
                
                    buttons[curI, leftJ].Tag = new Tuple<int, int>(curI, leftJ);
                
                  
                    buttons[downI, curJ].Tag = new Tuple<int, int>(downI, curJ);
                    
                }
            }
            
        }
    }
}
