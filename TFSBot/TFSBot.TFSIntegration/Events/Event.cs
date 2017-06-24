using System;

namespace TFSBot.TFSIntegration.Events
{
    public class Event
    {
        public string Id { get; set; }

        public string EventType { get; set; }

        public string PublisherId { get; set; }

        public string Scope { get; set; }

        public Message Message { get; set; }

        public Message DetailedMessage { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string ResourceVersion { get; set; }

        public ResourceContainer ResourceContainers { get; set; }
    }

    public class ResourceContainer
    {
        public Collection Collection { get; set; }

        public Account Account { get; set; }

        public Project Project { get; set; }
    }

    public class Collection
    {
        public string Id { get; set; }
    }

    public class Account
    {
        public string Id { get; set; }
    }

    public class Project
    {
        public string Id { get; set; }
    }
}
