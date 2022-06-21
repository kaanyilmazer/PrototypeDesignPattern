using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern1.PrototypeDesignPattern
{
    abstract class Meeting
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Location { get; set; }

        public List<String> Participants { get; set; }

        public List<String> Materials { get; set; }

        public Object OrderSummary { get; set; }

        public abstract Meeting Clone();


    }
}
