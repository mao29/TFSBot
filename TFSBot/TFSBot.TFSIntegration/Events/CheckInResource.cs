using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFSBot.TFSIntegration.Events
{
    public class CheckInResource
    {
        public int ChangesetId { get; set; }

        public string Url { get; set; }

        public User Author { get; set; }

        public User CheckedInBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string Comment { get; set; }
    }
}
