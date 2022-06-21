using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern1.PrototypeDesignPattern
{
    class DailyMeeting : Meeting
    {
        public override Meeting Clone()
        {
            return (Meeting)this.MemberwiseClone();
        }
    }
}
