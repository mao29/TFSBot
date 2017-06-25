namespace TFSBot.TFSIntegration.Events
{
    public class WorkItemEvent : Event
    {
        public WorkItemResource Resource { get; set; }

        public string Url { get; set; }
    }
}
