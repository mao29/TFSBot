using System;
using System.Runtime.Serialization;

namespace TFSBot.TFSIntegration.Events
{
    [DataContract()]
    public class WorkItemResource
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int Rev { get; set; }

        [DataMember]
        public int? WorkItemId { get; set; }

        [DataMember]
        public string Url { get; set; }

        [DataMember]
        public DateTime? RevisedDate { get; set; }

        [DataMember(Name = "fields")]
        public dynamic Fields { get; set; }

        [DataMember(Name = "_links")]
        public WorkItemLinks Links { get; set; }

        [DataMember]
        public WorkItemResource Revision { get; set; }
    }


    public class WorkItemLinks
    {
        public WorkItemLink Self { get; set; }

        public WorkItemLink WorkItemUpdates { get; set; }

        public WorkItemLink WorkItemRevisions { get; set; }

        public WorkItemLink WorkItemType { get; set; }

        public WorkItemLink Fields { get; set; }

        public WorkItemLink Html { get; set; }

        public WorkItemLink WorkItemHistory { get; set; }
    }

    public class WorkItemLink
    {
        public string Href { get; set; }
    }
}