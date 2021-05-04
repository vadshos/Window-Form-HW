using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_events
{
    public enum PriorityEvent {Low,Middle,Height}
    class Event
    {
        public string NameEvent { get; set; }
        public string LocationEvent { get; set; }
        public DateTime  DateEvent { get; set; }
        public PriorityEvent Priority_event { get; set; }
        public override string ToString()
        {
            return $"{NameEvent} {LocationEvent} {DateEvent.ToShortDateString()} {Priority_event}";
        }

    }
}
