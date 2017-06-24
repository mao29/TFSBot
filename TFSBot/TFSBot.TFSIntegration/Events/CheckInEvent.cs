using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFSBot.TFSIntegration.Events
{
    public class CheckInEvent : Event
    {
        public CheckInResource Resource { get; set; }
    }
}
