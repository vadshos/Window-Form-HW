using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_WF.Model
{
    class ElemModel
    {
        public PictureBox label { get; set; } 
        public int WidthPanel { get; set; }
        public int HeigthPanel { get; set; }
        
        public void Move()
        {
            int direction = new Random().Next(3);
             if (direction == 0)
            {

                if (label.Location.Y + 45 < HeigthPanel)
                    label.Location = new System.Drawing.Point(label.Location.X, label.Location.Y + 45);
                else
                {
                    throw new Exception();
                }
           
            }else if(direction == 1)
            {
               
                if ((label.Location.X - 45) > 0)
                    label.Location = new System.Drawing.Point(label.Location.X-45, label.Location.Y);
            }
            else if(direction == 2)
            {
               
                if((label.Location.X + 45) < WidthPanel)
                    label.Location = new System.Drawing.Point(label.Location.X +45 , label.Location.Y);
            }
        }
        

    }
}
