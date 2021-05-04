using CityViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_events
{
    public partial class Form1 : Form
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\EventsList.json";
        BindingList<Event> events;
        bool modeEdit = false; 
        public Form1()
        {

            InitializeComponent();
            events = FileIOService.LoadData(PATH);
            listBox1.DataSource = events;
            tbPriority.AutoCompleteCustomSource.AddRange(Enum.GetNames(typeof(PriorityEvent)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string name = tbNameEvent.Text;
            string location = tbLocationEvent.Text;
            DateTime dateTime = dtEvent.Value;
            PriorityEvent priority = (PriorityEvent)Enum.Parse(typeof(PriorityEvent), tbPriority.Text);
            Event @event = new Event {NameEvent=name,LocationEvent=location,DateEvent =dateTime,Priority_event=priority};
            if (modeEdit)
            {
                events[listBox1.SelectedIndex] = @event;
                btAdd.Text = "Add";
                modeEdit = false;
                return;
            }

           
            events.Add(@event);
            listBox1.DataSource = events;
        }

        private void btDeleteSelected_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void btClearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            events.Clear();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           if(textBox1.Text == null)
            {
                return;
            }
            int index = 0;
            foreach (var item in events)
            {

                if (item.NameEvent.ToLower().Contains(textBox1.Text.ToLower()))
                {
                    index = listBox1.Items.IndexOf(item);
                }
            }
   
            if(index != -1)
            listBox1.SetSelected(index, true);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileIOService.SaveData(events, PATH);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btAdd.Text = "Save Change";
            var selectedEvent = (listBox1.SelectedItem as Event);
            tbNameEvent.Text = selectedEvent.NameEvent;
            tbLocationEvent.Text = selectedEvent.LocationEvent;
            dtEvent.Value = selectedEvent.DateEvent;
            tbPriority.Text = selectedEvent.Priority_event.ToString();
            modeEdit = true;
        }
    }
}
